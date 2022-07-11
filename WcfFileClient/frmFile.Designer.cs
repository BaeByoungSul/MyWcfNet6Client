namespace WcfFileClient
{
    partial class frmFile
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_t1_download = new System.Windows.Forms.Button();
            this.txt_t1_download = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_t1_upload = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_t2_upload2 = new System.Windows.Forms.Button();
            this.btn_t2_download2 = new System.Windows.Forms.Button();
            this.btn_t2_download = new System.Windows.Forms.Button();
            this.txt_t2_download = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btn_t2_upload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txrElapsedTime = new System.Windows.Forms.TextBox();
            this.txtUploadFile = new System.Windows.Forms.TextBox();
            this.btn_file_select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 386);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_t1_download);
            this.tabPage1.Controls.Add(this.txt_t1_download);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.btn_t1_upload);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(928, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File Sync";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_t1_download
            // 
            this.btn_t1_download.Location = new System.Drawing.Point(741, 19);
            this.btn_t1_download.Name = "btn_t1_download";
            this.btn_t1_download.Size = new System.Drawing.Size(145, 55);
            this.btn_t1_download.TabIndex = 3;
            this.btn_t1_download.Text = "Download";
            this.btn_t1_download.UseVisualStyleBackColor = true;
            this.btn_t1_download.Click += new System.EventHandler(this.btn_t1_download_Click);
            // 
            // txt_t1_download
            // 
            this.txt_t1_download.Location = new System.Drawing.Point(498, 47);
            this.txt_t1_download.Name = "txt_t1_download";
            this.txt_t1_download.Size = new System.Drawing.Size(217, 27);
            this.txt_t1_download.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 89);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(836, 29);
            this.progressBar1.TabIndex = 1;
            // 
            // btn_t1_upload
            // 
            this.btn_t1_upload.Location = new System.Drawing.Point(50, 19);
            this.btn_t1_upload.Name = "btn_t1_upload";
            this.btn_t1_upload.Size = new System.Drawing.Size(145, 55);
            this.btn_t1_upload.TabIndex = 0;
            this.btn_t1_upload.Text = "Upload";
            this.btn_t1_upload.UseVisualStyleBackColor = true;
            this.btn_t1_upload.Click += new System.EventHandler(this.btn_t1_upload_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_t2_upload2);
            this.tabPage2.Controls.Add(this.btn_t2_download2);
            this.tabPage2.Controls.Add(this.btn_t2_download);
            this.tabPage2.Controls.Add(this.txt_t2_download);
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.btn_t2_upload);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(928, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Async";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_t2_upload2
            // 
            this.btn_t2_upload2.Location = new System.Drawing.Point(45, 143);
            this.btn_t2_upload2.Name = "btn_t2_upload2";
            this.btn_t2_upload2.Size = new System.Drawing.Size(145, 55);
            this.btn_t2_upload2.TabIndex = 9;
            this.btn_t2_upload2.Text = "Upload Async";
            this.btn_t2_upload2.UseVisualStyleBackColor = true;
            this.btn_t2_upload2.Click += new System.EventHandler(this.btn_t2_upload2_Click);
            // 
            // btn_t2_download2
            // 
            this.btn_t2_download2.Location = new System.Drawing.Point(735, 143);
            this.btn_t2_download2.Name = "btn_t2_download2";
            this.btn_t2_download2.Size = new System.Drawing.Size(145, 55);
            this.btn_t2_download2.TabIndex = 8;
            this.btn_t2_download2.Text = "Download Async";
            this.btn_t2_download2.UseVisualStyleBackColor = true;
            // 
            // btn_t2_download
            // 
            this.btn_t2_download.Location = new System.Drawing.Point(735, 27);
            this.btn_t2_download.Name = "btn_t2_download";
            this.btn_t2_download.Size = new System.Drawing.Size(145, 55);
            this.btn_t2_download.TabIndex = 7;
            this.btn_t2_download.Text = "Download Async";
            this.btn_t2_download.UseVisualStyleBackColor = true;
            this.btn_t2_download.Click += new System.EventHandler(this.btn_t2_download_Click);
            // 
            // txt_t2_download
            // 
            this.txt_t2_download.Location = new System.Drawing.Point(492, 55);
            this.txt_t2_download.Name = "txt_t2_download";
            this.txt_t2_download.Size = new System.Drawing.Size(217, 27);
            this.txt_t2_download.TabIndex = 6;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(45, 97);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(836, 29);
            this.progressBar2.TabIndex = 5;
            // 
            // btn_t2_upload
            // 
            this.btn_t2_upload.Location = new System.Drawing.Point(45, 27);
            this.btn_t2_upload.Name = "btn_t2_upload";
            this.btn_t2_upload.Size = new System.Drawing.Size(145, 55);
            this.btn_t2_upload.TabIndex = 4;
            this.btn_t2_upload.Text = "Upload Async";
            this.btn_t2_upload.UseVisualStyleBackColor = true;
            this.btn_t2_upload.Click += new System.EventHandler(this.btn_t2_upload_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txrElapsedTime);
            this.panel1.Controls.Add(this.txtUploadFile);
            this.panel1.Controls.Add(this.btn_file_select);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 81);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(729, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "시간(초)";
            // 
            // txrElapsedTime
            // 
            this.txrElapsedTime.Location = new System.Drawing.Point(798, 48);
            this.txrElapsedTime.Name = "txrElapsedTime";
            this.txrElapsedTime.ReadOnly = true;
            this.txrElapsedTime.Size = new System.Drawing.Size(125, 27);
            this.txrElapsedTime.TabIndex = 13;
            // 
            // txtUploadFile
            // 
            this.txtUploadFile.Location = new System.Drawing.Point(454, 17);
            this.txtUploadFile.Name = "txtUploadFile";
            this.txtUploadFile.ReadOnly = true;
            this.txtUploadFile.Size = new System.Drawing.Size(469, 27);
            this.txtUploadFile.TabIndex = 12;
            // 
            // btn_file_select
            // 
            this.btn_file_select.Location = new System.Drawing.Point(312, 9);
            this.btn_file_select.Name = "btn_file_select";
            this.btn_file_select.Size = new System.Drawing.Size(129, 53);
            this.btn_file_select.TabIndex = 11;
            this.btn_file_select.Text = "Upload File 선택";
            this.btn_file_select.UseVisualStyleBackColor = true;
            this.btn_file_select.Click += new System.EventHandler(this.btn_file_select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bindings";
            // 
            // cbo1
            // 
            this.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Items.AddRange(new object[] {
            "Http",
            "NetTcp"});
            this.cbo1.Location = new System.Drawing.Point(125, 9);
            this.cbo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(154, 28);
            this.cbo1.TabIndex = 9;
            // 
            // frmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmFile";
            this.Text = "Wcf File Client";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Label label1;
        private ComboBox cbo1;
        private TextBox txtUploadFile;
        private Button btn_file_select;
        private Label label2;
        private TextBox txrElapsedTime;
        private Button btn_t1_download;
        private TextBox txt_t1_download;
        private ProgressBar progressBar1;
        private Button btn_t1_upload;
        private Button btn_t2_download;
        private TextBox txt_t2_download;
        private ProgressBar progressBar2;
        private Button btn_t2_upload;
        private Button btn_t2_download2;
        private Button btn_t2_upload2;
    }
}