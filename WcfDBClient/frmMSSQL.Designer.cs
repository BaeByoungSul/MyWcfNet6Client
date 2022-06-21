﻿namespace WcfDBClient
{
    partial class frmMSSQL
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
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.btn_sel_1 = new System.Windows.Forms.Button();
            this.btn_sel_2 = new System.Windows.Forms.Button();
            this.btn_ins2 = new System.Windows.Forms.Button();
            this.btn_ins1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo1
            // 
            this.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Items.AddRange(new object[] {
            "Http",
            "NetTcp"});
            this.cbo1.Location = new System.Drawing.Point(51, 27);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(121, 23);
            this.cbo1.TabIndex = 0;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(51, 115);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(341, 285);
            this.dgv1.TabIndex = 1;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(439, 115);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowTemplate.Height = 25;
            this.dgv2.Size = new System.Drawing.Size(341, 285);
            this.dgv2.TabIndex = 2;
            // 
            // btn_sel_1
            // 
            this.btn_sel_1.Location = new System.Drawing.Point(51, 56);
            this.btn_sel_1.Name = "btn_sel_1";
            this.btn_sel_1.Size = new System.Drawing.Size(114, 46);
            this.btn_sel_1.TabIndex = 3;
            this.btn_sel_1.Text = "조회(List)";
            this.btn_sel_1.UseVisualStyleBackColor = true;
            this.btn_sel_1.Click += new System.EventHandler(this.btn_sel_1_Click);
            // 
            // btn_sel_2
            // 
            this.btn_sel_2.Location = new System.Drawing.Point(171, 56);
            this.btn_sel_2.Name = "btn_sel_2";
            this.btn_sel_2.Size = new System.Drawing.Size(107, 46);
            this.btn_sel_2.TabIndex = 4;
            this.btn_sel_2.Text = "조회(DataSet)";
            this.btn_sel_2.UseVisualStyleBackColor = true;
            this.btn_sel_2.Click += new System.EventHandler(this.btn_sel_2_Click);
            // 
            // btn_ins2
            // 
            this.btn_ins2.Location = new System.Drawing.Point(673, 56);
            this.btn_ins2.Name = "btn_ins2";
            this.btn_ins2.Size = new System.Drawing.Size(107, 46);
            this.btn_ins2.TabIndex = 6;
            this.btn_ins2.Text = "등록(DataSet)";
            this.btn_ins2.UseVisualStyleBackColor = true;
            this.btn_ins2.Click += new System.EventHandler(this.btn_ins2_Click);
            // 
            // btn_ins1
            // 
            this.btn_ins1.Location = new System.Drawing.Point(553, 56);
            this.btn_ins1.Name = "btn_ins1";
            this.btn_ins1.Size = new System.Drawing.Size(114, 46);
            this.btn_ins1.TabIndex = 5;
            this.btn_ins1.Text = "등록(List)";
            this.btn_ins1.UseVisualStyleBackColor = true;
            this.btn_ins1.Click += new System.EventHandler(this.btn_ins1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(356, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 46);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMSSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn_ins2);
            this.Controls.Add(this.btn_ins1);
            this.Controls.Add(this.btn_sel_2);
            this.Controls.Add(this.btn_sel_1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.cbo1);
            this.Name = "frmMSSQL";
            this.Text = "MSSQL";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbo1;
        private DataGridView dgv1;
        private DataGridView dgv2;
        private Button btn_sel_1;
        private Button btn_sel_2;
        private Button btn_ins2;
        private Button btn_ins1;
        private Button btnClear;
    }
}