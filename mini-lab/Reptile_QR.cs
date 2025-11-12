using QRCoder;
using Sunny.UI;
using System;
using System.Drawing; // 如果用 ContentAlignment
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;


namespace WindowsFormsApp1
{
    public partial class Reptile_QR : Form
    {

        private Random rnd = new Random(); // クラスレベルの変数、ランダム性を維持

        public Reptile_QR()
        {
            InitializeComponent();

            txtResult.Multiline = true;            
            //txtResult.ScrollBar = true;          
            txtResult.ReadOnly = true;             
                                                   


            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
           
        }
        private async void uiButton1_Click(object sender, EventArgs e)
        {
            txtResult.Clear();


            // DataGridView を反復処理する
            foreach (DataGridViewRow row in uiDataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                // 列 1 のチェックボックスが選択されているかどうかを確認します
                var isCheckedObj = row.Cells[0].Value;
                bool isChecked = isCheckedObj != null && (bool)isCheckedObj;
                if (!isChecked) continue;

                // 列2からURLを読み取る
                var urlObj = row.Cells[1].Value;
                if (urlObj == null) continue;

                string url = urlObj.ToString().Trim();
                if (string.IsNullOrEmpty(url)) continue;

                //txtResult.AppendText($"{url}\r\n");
                //txtResult.AppendText($"{url}\r\n");


                var result = await GetBilibiliVideoInfo(url);

                if (result != null)
                {
                    txtResult.AppendText(
                        $"動画タイトル: {result.Title}\r\n" +
                        $"作者: {result.Owner}\r\n" +
                        $"公開日: {result.PublishDate}\r\n" +
                        $"再生回数: {result.Views}\r\n" +
                        $"動画URL: {result.VideoUrl}\r\n" +
                        $"サムネイル: {result.Cover}\r\n" +
                        "----------------------------\r\n"
                    );



                }
                else
                {
                    //txtResult.AppendText("取得失敗\r\n----------------------------\r\n");
                }
            }

        
        }


        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            string text = txtResult.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("コンテンツが空なので、QR コードを生成できません。");
                return;
            }

            var urls = System.Text.RegularExpressions.Regex.Matches(text, @"https?://[^\s]+")
                .Cast<System.Text.RegularExpressions.Match>()
                .Select(m => m.Value)
                .Where(u => u.Contains("bilibili.com/video/")) // ビデオリンクのみ保存
                .ToList();

            if (urls.Count == 0)
            {
                MessageBox.Show("ビデオリンクが見つかりません!");
                return;
            }

            foreach (var url in urls)
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
                QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                QRCode preview = new QRCode(qrCodeImage)
                {
                    Text = $"QRコードプレビュー - ビデオ"
                };

                // 画面の中央からのランダムな位置オフセット
                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

                int x = screenWidth / 2 - preview.Width / 2 + rnd.Next(-100, 100);
                int y = screenHeight / 2 - preview.Height / 2 + rnd.Next(-100, 100);
                preview.StartPosition = FormStartPosition.Manual;
                preview.Location = new Point(x, y);

                preview.Show(); // 非モーダル表示
            }
        }



        private async Task<BiliVideoInfo> GetBilibiliVideoInfo(string videoUrl)
        {
            try
            {
                string bv = ExtractBV(videoUrl);
                if (string.IsNullOrEmpty(bv)) return null;

                string apiUrl = $"https://api.bilibili.com/x/web-interface/view?bvid={bv}";

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

                    var response = await client.GetAsync(apiUrl);
                    if (!response.IsSuccessStatusCode) return null;

                    string json = await response.Content.ReadAsStringAsync();

                    using (JsonDocument doc = JsonDocument.Parse(json))
                    {
                        var data = doc.RootElement.GetProperty("data");

                        string title = data.GetProperty("title").GetString();
                        string owner = data.GetProperty("owner").GetProperty("name").GetString();
                        string publishDate = DateTimeOffset
                            .FromUnixTimeSeconds(data.GetProperty("pubdate").GetInt64())
                            .ToLocalTime().ToString("yyyy-MM-dd");
                        string views = data.GetProperty("stat").GetProperty("view").GetInt64().ToString();
                        string cover = data.GetProperty("pic").GetString();

                        return new BiliVideoInfo
                        {
                            Title = title,
                            Owner = owner,
                            PublishDate = publishDate,
                            Views = views,
                            Cover = cover,
                            VideoUrl = videoUrl
                        };
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        private string ExtractBV(string url)
        {
            try
            {
                var uri = new Uri(url);
                string[] parts = uri.AbsolutePath.Split('/');
                foreach (var part in parts)
                {
                    if (part.StartsWith("BV"))
                        return part;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }


    }

    public class BiliVideoInfo
    {
        public string Title { get; set; }
        public string Owner { get; set; }
        public string PublishDate { get; set; }
        public string Views { get; set; }
        public string Cover { get; set; }
        public string VideoUrl { get; set; }
    }
}
