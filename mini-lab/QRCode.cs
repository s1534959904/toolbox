using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QRCode : Form
    {
        private Bitmap qrImage;

        public QRCode(Bitmap qrImage)
        {
            InitializeComponent();
            this.qrImage = qrImage;

            this.StartPosition = FormStartPosition.CenterScreen;
        }



        //  オプション: ユーザーがダブルクリックしてウィンドウを閉じることを許可する
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQRCode_Load_1(object sender, EventArgs e)
        {
           
            pictureBoxQR.SizeMode = PictureBoxSizeMode.Zoom;

            // 下のボタンのためのスペースを確保するために PictureBox のサイズを設定します。
            pictureBoxQR.Location = new Point(10, 10);
            pictureBoxQR.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 60);

            // ウィンドウのサイズが変更されたときに PictureBox のサイズが適応するようにします。
            pictureBoxQR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            pictureBoxQR.Image = qrImage;
        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            if (qrImage == null)
            {
                MessageBox.Show("QR コードが存在しないため保存できません。");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "QRコードを保存";
                sfd.Filter = "PNG图片|*.png|JPEG图片|*.jpg|Bitmap图片|*.bmp";
                sfd.FileName = "QRCode.png"; // 默认文件名

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 選択した拡張子に基づいて保存します
                        string ext = System.IO.Path.GetExtension(sfd.FileName).ToLower();
                        switch (ext)
                        {
                            case ".jpg":
                                qrImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                            case ".bmp":
                                qrImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                            default:
                                qrImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                                break;
                        }

                        MessageBox.Show("QRコードが保存されました！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("保存に失敗しました: " + ex.Message);
                    }
                }
            }
        }
    }

}
