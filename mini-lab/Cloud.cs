using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCloudTest
{
    public partial class Cloud : Form
    {
        private LeanCloudUploader uploader;

        public Cloud()
        {
            // TLS 1.2 を強制する
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            InitializeComponent();

            uploader = new LeanCloudUploader();

            // DataGridView の列を設定する
            dgvRecords.Columns.Clear();
            dgvRecords.Columns.Add("objectId", "ObjectId");
            dgvRecords.Columns.Add("Name", "Name");
            dgvRecords.Columns.Add("Value", "Value");
            dgvRecords.Columns.Add("createdAt", "CreatedAt");
        }

       
        private async void btnUpload_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string valueText = txtValue.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(valueText))
            {
                MessageBox.Show("名前と値を入力してください。");
                return;
            }

            if (!int.TryParse(valueText, out int value))
            {
                MessageBox.Show("値は数値でなければなりません。");
                return;
            }

            string result = await uploader.UploadAsync(name, value);
            txtDebug.Text = result;

            if (result.Contains("objectId"))
            {
                MessageBox.Show("✅アップロード成功しました!");
                // アップロードが成功した後、DataGridView に表示されます
                var record = JsonDocument.Parse(result).RootElement;
                string objectId = record.GetProperty("objectId").GetString();
                string createdAt = record.GetProperty("createdAt").GetString();
                dgvRecords.Rows.Add(objectId, name, value, createdAt);
                await LoadCloudDataAsync(); // アップロードが成功したらテーブルを更新します
            }
            else
            {
                MessageBox.Show("❌ アップロードに失敗しました。デバッグ情報を確認してください。");
            }
        }



       



        private async Task LoadCloudDataAsync()
        {
            dgvRecords.Rows.Clear();
            var records = await uploader.GetAllRecordsAsync();
            foreach (var rec in records)
            {
                dgvRecords.Rows.Add(rec.objectId, rec.Name, rec.Value, rec.createdAt);
            }


        }


        private async void Form4_Load(object sender, EventArgs e)
        {
            await LoadCloudDataAsync();
        }

        private　async void btnRefresh_Click_1(object sender, EventArgs e)
        {
            dgvRecords.Rows.Clear();
            var records = await uploader.GetAllRecordsAsync();
            foreach (var rec in records)
            {
                dgvRecords.Rows.Add(rec.objectId, rec.Name, rec.Value, rec.createdAt);
            }
        }

        private async　void uiButton1_Click(object sender, EventArgs e)
        {
            btnUploadFile.Enabled = false; // 重複クリックを防ぐ

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                btnUploadFile.Enabled = true;
                return;
            }

            string filePath = ofd.FileName;
            string result = await uploader.UploadFileAsync(filePath);
            txtDebug.Text = result;

            if (result.Contains("url"))
                MessageBox.Show("✅ アップロード成功！");
            else
                MessageBox.Show("❌ アップロード失敗！");

            btnUploadFile.Enabled = true;
        }



    }

    public class LeanCloudUploader
    {
        private readonly string appId = "ts1HbQFmg7FEqlWIbw9xRZZK-MdYXbMMI";
        private readonly string appKey = "PBB1GYi9qmLEGg6hw3Jt8Uc4";
        private readonly string serverUrl = "https://ts1hbqfm.api.lncldglobal.com";
        private readonly string className = "ASDE123";

        private readonly HttpClient client;

        public LeanCloudUploader()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-LC-Id", appId);
            client.DefaultRequestHeaders.Add("X-LC-Key", appKey);
            client.DefaultRequestHeaders.Add("User-Agent", "WinFormsLeanCloudTest");
        }


        // 単一のデータエントリをアップロードする
        public async Task<string> UploadAsync(string name, int value)
        {
            string url = $"{serverUrl}/1.1/classes/{className}";
            string json = $"{{\"Name\":\"{name}\", \"Value\":{value}}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                return result; // objectIdとcreatedAtを簡単に解析できるようにJSONを返します
            }
            catch (Exception ex)
            {
                return $"❌ 请求异常:\r\n{ex.Message}";
            }
        }

        // すべてのレコードを取得する
        public async Task<Record[]> GetAllRecordsAsync()
        {
            string url = $"{serverUrl}/1.1/classes/{className}";
            try
            {
                var response = await client.GetAsync(url);
                string result = await response.Content.ReadAsStringAsync();
                var doc = JsonDocument.Parse(result).RootElement;
                if (doc.TryGetProperty("results", out var results))
                {
                    Record[] records = new Record[results.GetArrayLength()];
                    int i = 0;
                    foreach (var item in results.EnumerateArray())
                    {
                        records[i++] = new Record
                        {
                            objectId = item.GetProperty("objectId").GetString(),
                            Name = item.GetProperty("Name").GetString(),
                            Value = item.GetProperty("Value").GetInt32(),
                            createdAt = item.GetProperty("createdAt").GetString()
                        };
                    }
                    return records;
                }
                return new Record[0];
            }
            catch
            {
                return new Record[0];
            }
        }


        public async Task<string> UploadFileAsync(string filePath)
        {
            try
            {
                string fileName = Path.GetFileName(filePath);
                using (FileStream fs = File.OpenRead(filePath))
                using (StreamContent content = new StreamContent(fs))
                {
                    content.Headers.ContentType =
                        new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                    string url = $"{serverUrl}/1.1/files/{fileName}";
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    string result = await response.Content.ReadAsStringAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                return $"❌ アップロードエラー: {ex.Message}";
            }
        }

    }

    public class Record
    {
        public string objectId { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string createdAt { get; set; }
    }
}
