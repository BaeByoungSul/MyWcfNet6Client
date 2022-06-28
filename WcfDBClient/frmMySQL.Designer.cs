namespace WcfDBClient
{
    partial class frmMySQL
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn_ins2 = new System.Windows.Forms.Button();
            this.btn_ins1 = new System.Windows.Forms.Button();
            this.btn_sel_2 = new System.Windows.Forms.Button();
            this.btn_sel_1 = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bindings";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(438, 101);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 61);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_ins2
            // 
            this.btn_ins2.Location = new System.Drawing.Point(846, 101);
            this.btn_ins2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ins2.Name = "btn_ins2";
            this.btn_ins2.Size = new System.Drawing.Size(138, 61);
            this.btn_ins2.TabIndex = 15;
            this.btn_ins2.Text = "등록(DataSet)";
            this.btn_ins2.UseVisualStyleBackColor = true;
            // 
            // btn_ins1
            // 
            this.btn_ins1.Location = new System.Drawing.Point(692, 101);
            this.btn_ins1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ins1.Name = "btn_ins1";
            this.btn_ins1.Size = new System.Drawing.Size(147, 61);
            this.btn_ins1.TabIndex = 14;
            this.btn_ins1.Text = "등록(List)";
            this.btn_ins1.UseVisualStyleBackColor = true;
            this.btn_ins1.Click += new System.EventHandler(this.btn_ins1_Click);
            // 
            // btn_sel_2
            // 
            this.btn_sel_2.Location = new System.Drawing.Point(201, 101);
            this.btn_sel_2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sel_2.Name = "btn_sel_2";
            this.btn_sel_2.Size = new System.Drawing.Size(138, 61);
            this.btn_sel_2.TabIndex = 13;
            this.btn_sel_2.Text = "조회(DataSet)";
            this.btn_sel_2.UseVisualStyleBackColor = true;
            this.btn_sel_2.Click += new System.EventHandler(this.btn_sel_2_Click);
            // 
            // btn_sel_1
            // 
            this.btn_sel_1.Location = new System.Drawing.Point(46, 101);
            this.btn_sel_1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sel_1.Name = "btn_sel_1";
            this.btn_sel_1.Size = new System.Drawing.Size(147, 61);
            this.btn_sel_1.TabIndex = 12;
            this.btn_sel_1.Text = "조회(List)";
            this.btn_sel_1.UseVisualStyleBackColor = true;
            this.btn_sel_1.Click += new System.EventHandler(this.btn_sel_1_Click);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(545, 180);
            this.dgv2.Margin = new System.Windows.Forms.Padding(4);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 25;
            this.dgv2.Size = new System.Drawing.Size(438, 380);
            this.dgv2.TabIndex = 11;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(46, 180);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(438, 380);
            this.dgv1.TabIndex = 10;
            // 
            // cbo1
            // 
            this.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Items.AddRange(new object[] {
            "Http",
            "NetTcp"});
            this.cbo1.Location = new System.Drawing.Point(46, 63);
            this.cbo1.Margin = new System.Windows.Forms.Padding(4);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(154, 28);
            this.cbo1.TabIndex = 9;
            // 
            // frmMySQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn_ins2);
            this.Controls.Add(this.btn_ins1);
            this.Controls.Add(this.btn_sel_2);
            this.Controls.Add(this.btn_sel_1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.cbo1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMySQL";
            this.Text = "frmMySQL";
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnClear;
        private Button btn_ins2;
        private Button btn_ins1;
        private Button btn_sel_2;
        private Button btn_sel_1;
        private DataGridView dgv2;
        private DataGridView dgv1;
        private ComboBox cbo1;
    }
}