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
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bindings";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(341, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 46);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btn_ins2
            // 
            this.btn_ins2.Location = new System.Drawing.Point(658, 76);
            this.btn_ins2.Name = "btn_ins2";
            this.btn_ins2.Size = new System.Drawing.Size(107, 46);
            this.btn_ins2.TabIndex = 15;
            this.btn_ins2.Text = "등록(DataSet)";
            this.btn_ins2.UseVisualStyleBackColor = true;
            // 
            // btn_ins1
            // 
            this.btn_ins1.Location = new System.Drawing.Point(538, 76);
            this.btn_ins1.Name = "btn_ins1";
            this.btn_ins1.Size = new System.Drawing.Size(114, 46);
            this.btn_ins1.TabIndex = 14;
            this.btn_ins1.Text = "등록(List)";
            this.btn_ins1.UseVisualStyleBackColor = true;
            // 
            // btn_sel_2
            // 
            this.btn_sel_2.Location = new System.Drawing.Point(156, 76);
            this.btn_sel_2.Name = "btn_sel_2";
            this.btn_sel_2.Size = new System.Drawing.Size(107, 46);
            this.btn_sel_2.TabIndex = 13;
            this.btn_sel_2.Text = "조회(DataSet)";
            this.btn_sel_2.UseVisualStyleBackColor = true;
            // 
            // btn_sel_1
            // 
            this.btn_sel_1.Location = new System.Drawing.Point(36, 76);
            this.btn_sel_1.Name = "btn_sel_1";
            this.btn_sel_1.Size = new System.Drawing.Size(114, 46);
            this.btn_sel_1.TabIndex = 12;
            this.btn_sel_1.Text = "조회(List)";
            this.btn_sel_1.UseVisualStyleBackColor = true;
            this.btn_sel_1.Click += new System.EventHandler(this.btn_sel_1_Click);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(424, 135);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 25;
            this.dgv2.Size = new System.Drawing.Size(341, 285);
            this.dgv2.TabIndex = 11;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(36, 135);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(341, 285);
            this.dgv1.TabIndex = 10;
            // 
            // cbo1
            // 
            this.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Items.AddRange(new object[] {
            "Http",
            "NetTcp"});
            this.cbo1.Location = new System.Drawing.Point(36, 47);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(121, 23);
            this.cbo1.TabIndex = 9;
            // 
            // frmMySQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn_ins2);
            this.Controls.Add(this.btn_ins1);
            this.Controls.Add(this.btn_sel_2);
            this.Controls.Add(this.btn_sel_1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.cbo1);
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