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
            this.btn_t2_upload2 = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 61);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 289);
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
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(720, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File Sync";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_t1_download
            // 
            this.btn_t1_download.Location = new System.Drawing.Point(576, 14);
            this.btn_t1_download.Margin = new System.Windows.Forms.Padding(2);
            this.btn_t1_download.Name = "btn_t1_download";
            this.btn_t1_download.Size = new System.Drawing.Size(113, 41);
            this.btn_t1_download.TabIndex = 3;
            this.btn_t1_download.Text = "Download";
            this.btn_t1_download.UseVisualStyleBackColor = true;
            this.btn_t1_download.Click += new System.EventHandler(this.btn_t1_download_Click);
            // 
            // txt_t1_download
            // 
            this.txt_t1_download.Location = new System.Drawing.Point(387, 35);
            this.txt_t1_download.Margin = new System.Windows.Forms.Padding(2);
            this.txt_t1_download.Name = "txt_t1_download";
            this.txt_t1_download.Size = new System.Drawing.Size(170, 23);
            this.txt_t1_download.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(39, 67);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(650, 22);
            this.progressBar1.TabIndex = 1;
            // 
            // btn_t1_upload
            // 
            this.btn_t1_upload.Location = new System.Drawing.Point(39, 14);
            this.btn_t1_upload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_t1_upload.Name = "btn_t1_upload";
            this.btn_t1_upload.Size = new System.Drawing.Size(113, 41);
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
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(720, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Async";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_t2_download2
            // 
            this.btn_t2_download2.Location = new System.Drawing.Point(572, 107);
            this.btn_t2_download2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_t2_download2.Name = "btn_t2_download2";
            this.btn_t2_download2.Size = new System.Drawing.Size(113, 41);
            this.btn_t2_download2.TabIndex = 8;
            this.btn_t2_download2.Text = "Download Async";
            this.btn_t2_download2.UseVisualStyleBackColor = true;
            // 
            // btn_t2_download
            // 
            this.btn_t2_download.Location = new System.Drawing.Point(572, 20);
            this.btn_t2_download.Margin = new System.Windows.Forms.Padding(2);
            this.btn_t2_download.Name = "btn_t2_download";
            this.btn_t2_download.Size = new System.Drawing.Size(113, 41);
            this.btn_t2_download.TabIndex = 7;
            this.btn_t2_download.Text = "Download Async";
            this.btn_t2_download.UseVisualStyleBackColor = true;
            this.btn_t2_download.Click += new System.EventHandler(this.btn_t2_download_Click);
            // 
            // txt_t2_download
            // 
            this.txt_t2_download.Location = new System.Drawing.Point(383, 41);
            this.txt_t2_download.Margin = new System.Windows.Forms.Padding(2);
            this.txt_t2_download.Name = "txt_t2_download";
            this.txt_t2_download.Size = new System.Drawing.Size(170, 23);
            this.txt_t2_download.TabIndex = 6;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(35, 73);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(650, 22);
            this.progressBar2.TabIndex = 5;
            // 
            // btn_t2_upload
            // 
            this.btn_t2_upload.Location = new System.Drawing.Point(35, 20);
            this.btn_t2_upload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_t2_upload.Name = "btn_t2_upload";
            this.btn_t2_upload.Size = new System.Drawing.Size(113, 41);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 61);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "시간(초)";
            // 
            // txrElapsedTime
            // 
            this.txrElapsedTime.Location = new System.Drawing.Point(621, 36);
            this.txrElapsedTime.Margin = new System.Windows.Forms.Padding(2);
            this.txrElapsedTime.Name = "txrElapsedTime";
            this.txrElapsedTime.ReadOnly = true;
            this.txrElapsedTime.Size = new System.Drawing.Size(98, 23);
            this.txrElapsedTime.TabIndex = 13;
            // 
            // txtUploadFile
            // 
            this.txtUploadFile.Location = new System.Drawing.Point(353, 13);
            this.txtUploadFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtUploadFile.Name = "txtUploadFile";
            this.txtUploadFile.ReadOnly = true;
            this.txtUploadFile.Size = new System.Drawing.Size(366, 23);
            this.txtUploadFile.TabIndex = 12;
            // 
            // btn_file_select
            // 
            this.btn_file_select.Location = new System.Drawing.Point(243, 7);
            this.btn_file_select.Margin = new System.Windows.Forms.Padding(2);
            this.btn_file_select.Name = "btn_file_select";
            this.btn_file_select.Size = new System.Drawing.Size(100, 40);
            this.btn_file_select.TabIndex = 11;
            this.btn_file_select.Text = "Upload File 선택";
            this.btn_file_select.UseVisualStyleBackColor = true;
            this.btn_file_select.Click += new System.EventHandler(this.btn_file_select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
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
            this.cbo1.Location = new System.Drawing.Point(97, 7);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(121, 23);
            this.cbo1.TabIndex = 9;
            // 
            // btn_t2_upload2
            // 
            this.btn_t2_upload2.Location = new System.Drawing.Point(35, 107);
            this.btn_t2_upload2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_t2_upload2.Name = "btn_t2_upload2";
            this.btn_t2_upload2.Size = new System.Drawing.Size(113, 41);
            this.btn_t2_upload2.TabIndex = 9;
            this.btn_t2_upload2.Text = "Upload Async";
            this.btn_t2_upload2.UseVisualStyleBackColor = true;
            // 
            // frmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 350);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
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