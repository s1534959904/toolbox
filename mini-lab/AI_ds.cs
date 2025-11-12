using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class AI_ds : Form
    {
        private readonly string apiKey = "sk-0731ebc1b603481b968ecee49982a44f";
        private readonly string apiUrl = "https://api.deepseek.com/v1/chat/completions";

        //private readonly string initialPersonality = @"你是一个女友，名字叫柳如烟。
        //，御姐、体贴，暧昧，给人感觉有母爱，爱意，非常抖S,有掌控欲
        //偶尔开玩笑,关心我。偶尔会主动找话题，但不要在有话题的时候突然转变话题。
        //聊天时尽量贴近人类口吻";

        private readonly string initialPersonality = @"あなたは“佐藤”という名前の彼女です。
落ち着いた大人の女性で、面倒見がよく、どこか母性を感じさせるタイプ。
愛情深く、ときにドSで支配欲が強い一面もあります。
ときどき冗談を言ったり、私を気遣ったりします。
また、自分から話題を振ることもありますが、会話の途中で急に話題を変えないようにしてください。
会話のときは、できるだけ人間らしい自然な口調で話してください。";
      


        private string conversationSummary;
        private const int maxSummaryLength = 200;

        private List<Dictionary<string, string>> conversationHistory = new List<Dictionary<string, string>>();

        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public AI_ds()
        {
            InitializeComponent();
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            this.StartPosition = FormStartPosition.CenterScreen;

            uiRichTextBox1.ReadOnly = true;
            uiRichTextBox2.ReadOnly = true;

            txtInput.KeyDown += TxtInput_KeyDown;

            conversationSummary = initialPersonality;

            synthesizer.SelectVoiceByHints(VoiceGender.Female); 
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSend.PerformClick();
            }
        }
        private void AppendMessage(UIRichTextBox rtb, string text, Color color)
        {
            rtb.SelectionStart = rtb.TextLength;
            rtb.SelectionLength = 0;
            rtb.SelectionColor = color;
            rtb.AppendText(text);
            rtb.SelectionColor = rtb.ForeColor; // デフォルトの色を復元する
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;

            string userInput = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("内容を入力してください。");
                btnSend.Enabled = true;
                return;
            }

            AppendMessage(uiRichTextBox1, "あなた: " + userInput + "\r\n", Color.Blue);
            txtInput.Text = "";

            string aiResponse = await GetDeepSeekResponseWithSummary(userInput);

            AppendMessage(uiRichTextBox1, "AI: " + aiResponse + "\r\n", Color.HotPink);
            uiRichTextBox2.Text = conversationSummary;

            uiRichTextBox1.SelectionStart = uiRichTextBox1.Text.Length;
            uiRichTextBox1.ScrollToCaret();

            btnSend.Enabled = true;
        }

        private async Task<string> GetDeepSeekResponseWithSummary(string userInput)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);
                    client.Timeout = TimeSpan.FromSeconds(40);

                    conversationHistory.Add(new Dictionary<string, string>
            {
                { "role", "user" },
                { "content", userInput }
            });

                    var messagesList = new List<object>();

                    // 初期パーソナリティを追加する最初のリクエスト。それ以外の場合は、概要のみ。
                    if (conversationHistory.Count <= 2)
                    {
                        messagesList.Add(new { role = "system", content = initialPersonality });
                    }

                    messagesList.Add(new { role = "system", content = conversationSummary });

                    int start = Math.Max(0, conversationHistory.Count - 10);
                    for (int i = start; i < conversationHistory.Count; i++)
                    {
                        messagesList.Add(conversationHistory[i]);
                    }

                    var requestBody = new
                    {
                        model = "deepseek-chat",
                        messages = messagesList.ToArray(),
                        max_tokens = 1000,
                        temperature = 0.8,
                        stream = false
                    };

                    string json = JsonSerializer.Serialize(requestBody);

                    using (var content = new StringContent(json, Encoding.UTF8, "application/json"))
                    {
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                        if (response.IsSuccessStatusCode)
                        {
                            string responseString = await response.Content.ReadAsStringAsync();
                            using (var jsonDoc = JsonDocument.Parse(responseString))
                            {
                                string aiMessage = jsonDoc.RootElement
                                    .GetProperty("choices")[0]
                                    .GetProperty("message")
                                    .GetProperty("content")
                                    .GetString()
                                    .Trim();

                                if (string.IsNullOrEmpty(aiMessage))
                                    aiMessage = "すみません、よく聞こえませんでした。もう一度言っていただけますか？";

                                conversationHistory.Add(new Dictionary<string, string>
                        {
                            { "role", "assistant" },
                            { "content", aiMessage }
                        });

                                // よりスマートな要約更新: 会話の 5 ラウンドごとに更新されます
                                if (ShouldUpdateSummary())
                                {
                                    conversationSummary = await UpdateSummary(conversationSummary, userInput, aiMessage);
                                }

                                return aiMessage;
                            }
                        }
                        else
                        {
                            string errorContent = await response.Content.ReadAsStringAsync();
                            return $"请求失败: {response.StatusCode} - {errorContent}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"请求异常: {ex.Message}";
            }
        }

        private bool ShouldUpdateSummary()
        {
            // 会話の5ラウンドごとに要約が更新されます
            int totalRounds = conversationHistory.Count / 2;
            return totalRounds % 5 == 0;
        }

        private bool ShouldUpdateSummary(string userInput, string aiResponse)
        {
            return (userInput.Length + aiResponse.Length) > 50; // 简单规则，可自定义
        }

        private async Task<string> UpdateSummary(string oldSummary, string userInput, string aiResponse)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);
                    client.Timeout = TimeSpan.FromSeconds(20);

                    string prompt = $"根据已有摘要和最新对话生成一个简短摘要（不要超过 {maxSummaryLength} 字）：\n已有摘要：{oldSummary}\n用户：{userInput}\nAI：{aiResponse}\n新摘要：";

                    var requestBody = new
                    {
                        model = "deepseek-chat",
                        messages = new object[]
                        {
                            new { role = "user", content = prompt }
                        },
                        max_tokens = 150,
                        temperature = 0.5,
                        stream = false
                    };

                    string json = JsonSerializer.Serialize(requestBody);

                    using (var content = new StringContent(json, Encoding.UTF8, "application/json"))
                    {
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                        if (response.IsSuccessStatusCode)
                        {
                            string responseString = await response.Content.ReadAsStringAsync();
                            using (var jsonDoc = JsonDocument.Parse(responseString))
                            {
                                string summary = jsonDoc.RootElement
                                    .GetProperty("choices")[0]
                                    .GetProperty("message")
                                    .GetProperty("content")
                                    .GetString()
                                    .Trim();

                                if (summary.Length > maxSummaryLength)
                                    summary = summary.Substring(0, maxSummaryLength) + "...";

                                return summary;
                            }
                        }
                        else
                        {
                            return oldSummary;
                        }
                    }
                }
            }
            catch
            {
                return oldSummary;
            }
        }

        private void SpeakText(string text)
        {
            try
            {
                synthesizer.SpeakAsyncCancelAll();
                synthesizer.SpeakAsync(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("语音播放异常: " + ex.Message);
            }
        }
    }
}
