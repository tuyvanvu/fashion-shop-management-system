namespace frmMain
{
    partial class frmDuDoan
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
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.cboNSX = new System.Windows.Forms.ComboBox();
            this.cboChatLieu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDuDoan = new System.Windows.Forms.Button();
            this.btnHoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboNCC
            // 
            this.cboNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(258, 200);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(291, 21);
            this.cboNCC.TabIndex = 3;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(258, 80);
            this.cboLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(291, 21);
            this.cboLoaiSP.TabIndex = 0;
            // 
            // cboNSX
            // 
            this.cboNSX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboNSX.FormattingEnabled = true;
            this.cboNSX.Location = new System.Drawing.Point(258, 160);
            this.cboNSX.Margin = new System.Windows.Forms.Padding(4);
            this.cboNSX.Name = "cboNSX";
            this.cboNSX.Size = new System.Drawing.Size(291, 21);
            this.cboNSX.TabIndex = 2;
            // 
            // cboChatLieu
            // 
            this.cboChatLieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboChatLieu.FormattingEnabled = true;
            this.cboChatLieu.Location = new System.Drawing.Point(258, 120);
            this.cboChatLieu.Margin = new System.Windows.Forms.Padding(4);
            this.cboChatLieu.Name = "cboChatLieu";
            this.cboChatLieu.Size = new System.Drawing.Size(291, 21);
            this.cboChatLieu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Loại sản phẩm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Chất liệu";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nhà sản xuất";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nhà cung cấp";
            // 
            // btnDuDoan
            // 
            this.btnDuDoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDuDoan.Enabled = false;
            this.btnDuDoan.Location = new System.Drawing.Point(363, 286);
            this.btnDuDoan.Name = "btnDuDoan";
            this.btnDuDoan.Size = new System.Drawing.Size(86, 45);
            this.btnDuDoan.TabIndex = 5;
            this.btnDuDoan.Text = "Dự đoán";
            this.btnDuDoan.UseVisualStyleBackColor = true;
            this.btnDuDoan.Click += new System.EventHandler(this.btnDuDoan_Click);
            // 
            // btnHoc
            // 
            this.btnHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHoc.Location = new System.Drawing.Point(271, 286);
            this.btnHoc.Name = "btnHoc";
            this.btnHoc.Size = new System.Drawing.Size(86, 45);
            this.btnHoc.TabIndex = 4;
            this.btnHoc.Text = "Học";
            this.btnHoc.UseVisualStyleBackColor = true;
            this.btnHoc.Click += new System.EventHandler(this.btnHoc_Click);
            // 
            // frmDuDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHoc);
            this.Controls.Add(this.btnDuDoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.cboNSX);
            this.Controls.Add(this.cboChatLieu);
            this.Name = "frmDuDoan";
            this.Text = "frmDuDoan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDuDoan_FormClosing);
            this.Load += new System.EventHandler(this.frmDuDoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.ComboBox cboNSX;
        private System.Windows.Forms.ComboBox cboChatLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDuDoan;
        private System.Windows.Forms.Button btnHoc;
    }
}