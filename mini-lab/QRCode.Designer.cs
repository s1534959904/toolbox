namespace WindowsFormsApp1
{
    partial class QRCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.btnSaveQR = new Sunny.UI.UIButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxQR.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(907, 514);
            this.pictureBoxQR.TabIndex = 0;
            this.pictureBoxQR.TabStop = false;
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveQR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveQR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSaveQR.Location = new System.Drawing.Point(0, 479);
            this.btnSaveQR.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(907, 35);
            this.btnSaveQR.TabIndex = 1;
            this.btnSaveQR.Text = "QRコード保存";
            this.btnSaveQR.TipsFont = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSaveQR.Click += new System.EventHandler(this.btnSaveQR_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.pictureBoxQR);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(907, 514);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 514);
            this.Controls.Add(this.btnSaveQR);
            this.Controls.Add(this.uiPanel1);
            this.Name = "FormQRCode";
            this.Text = "FormQR";
            this.Load += new System.EventHandler(this.FormQRCode_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxQR;
        private Sunny.UI.UIButton btnSaveQR;
        private Sunny.UI.UIPanel uiPanel1;
    }
}