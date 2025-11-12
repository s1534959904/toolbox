namespace WinFormsCloudTest
{
    partial class Cloud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUpload = new Sunny.UI.UIButton();
            this.txtName = new Sunny.UI.UITextBox();
            this.txtValue = new Sunny.UI.UITextBox();
            this.lblName = new Sunny.UI.UILabel();
            this.lblValue = new Sunny.UI.UILabel();
            this.txtDebug = new Sunny.UI.UITextBox();
            this.dgvRecords = new Sunny.UI.UIDataGridView();
            this.btnRefresh = new Sunny.UI.UIButton();
            this.btnUploadFile = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpload.Location = new System.Drawing.Point(301, 443);
            this.btnUpload.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(73, 35);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "OK";
            this.btnUpload.TipsFont = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtName.Location = new System.Drawing.Point(264, 350);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.ShowText = false;
            this.txtName.Size = new System.Drawing.Size(150, 29);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "";
            // 
            // txtValue
            // 
            this.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValue.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtValue.Location = new System.Drawing.Point(264, 389);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValue.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtValue.Name = "txtValue";
            this.txtValue.Padding = new System.Windows.Forms.Padding(5);
            this.txtValue.ShowText = false;
            this.txtValue.Size = new System.Drawing.Size(150, 29);
            this.txtValue.TabIndex = 2;
            this.txtValue.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtValue.Watermark = "";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblName.Location = new System.Drawing.Point(199, 356);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "名称";
            this.lblName.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblValue
            // 
            this.lblValue.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblValue.Location = new System.Drawing.Point(199, 395);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(49, 23);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "数字";
            // 
            // txtDebug
            // 
            this.txtDebug.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDebug.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDebug.Location = new System.Drawing.Point(924, 23);
            this.txtDebug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDebug.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Padding = new System.Windows.Forms.Padding(5);
            this.txtDebug.ShowText = false;
            this.txtDebug.Size = new System.Drawing.Size(74, 41);
            this.txtDebug.TabIndex = 5;
            this.txtDebug.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDebug.Watermark = "";
            // 
            // dgvRecords
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecords.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecords.EnableHeadersVisualStyles = false;
            this.dgvRecords.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dgvRecords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvRecords.Location = new System.Drawing.Point(31, 86);
            this.dgvRecords.Name = "dgvRecords";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dgvRecords.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecords.RowTemplate.Height = 21;
            this.dgvRecords.SelectedIndex = -1;
            this.dgvRecords.Size = new System.Drawing.Size(525, 206);
            this.dgvRecords.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvRecords.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 35);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "更新";
            this.btnRefresh.TipsFont = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUploadFile.Location = new System.Drawing.Point(91, 12);
            this.btnUploadFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(173, 35);
            this.btnUploadFile.TabIndex = 8;
            this.btnUploadFile.Text = "ファイルをアップロード";
            this.btnUploadFile.TipsFont = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUploadFile.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 531);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpload);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btnUpload;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UITextBox txtValue;
        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UILabel lblValue;
        private Sunny.UI.UITextBox txtDebug;
        private Sunny.UI.UIDataGridView dgvRecords;
        private Sunny.UI.UIButton btnRefresh;
        private Sunny.UI.UIButton btnUploadFile;
    }
}