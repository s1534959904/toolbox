namespace WindowsFormsApp1
{
    partial class AI_ds
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
            this.btnSend = new Sunny.UI.UIButton();
            this.txtInput = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            this.uiRichTextBox2 = new Sunny.UI.UIRichTextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSend.Location = new System.Drawing.Point(825, 554);
            this.btnSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 60);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "発送";
            this.btnSend.TipsFont = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtInput
            // 
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtInput.Location = new System.Drawing.Point(28, 554);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtInput.Name = "txtInput";
            this.txtInput.Padding = new System.Windows.Forms.Padding(5);
            this.txtInput.ShowText = false;
            this.txtInput.Size = new System.Drawing.Size(784, 60);
            this.txtInput.TabIndex = 4;
            this.txtInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtInput.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.SystemColors.Info;
            this.uiLabel1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(12, 18);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(80, 25);
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "DeepSeek";
            // 
            // uiRichTextBox1
            // 
            this.uiRichTextBox1.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uiRichTextBox1.Location = new System.Drawing.Point(28, 62);
            this.uiRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox1.Name = "uiRichTextBox1";
            this.uiRichTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox1.ShowText = false;
            this.uiRichTextBox1.Size = new System.Drawing.Size(897, 458);
            this.uiRichTextBox1.TabIndex = 6;
            this.uiRichTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiRichTextBox2
            // 
            this.uiRichTextBox2.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uiRichTextBox2.Location = new System.Drawing.Point(973, 82);
            this.uiRichTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox2.Name = "uiRichTextBox2";
            this.uiRichTextBox2.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox2.ShowText = false;
            this.uiRichTextBox2.Size = new System.Drawing.Size(173, 490);
            this.uiRichTextBox2.TabIndex = 7;
            this.uiRichTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uiLabel2.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(1004, 54);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "AIの設定";
            // 
            // FormAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 644);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiRichTextBox2);
            this.Controls.Add(this.uiRichTextBox1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSend);
            this.Name = "FormAI";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton btnSend;
        private Sunny.UI.UITextBox txtInput;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UIRichTextBox uiRichTextBox2;
        private Sunny.UI.UILabel uiLabel2;
    }
}