namespace frmMain
{
    partial class frmMain
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
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhSốBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.quảnLýĐặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.bánHàngToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýĐơnHàngToolStripMenuItem,
            this.quảnLýHàngHóaToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.cáNhânToolStripMenuItem});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnsMain.Size = new System.Drawing.Size(980, 31);
            this.mnsMain.TabIndex = 0;
            this.mnsMain.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            this.trangChủToolStripMenuItem.Visible = false;
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.bánHàngToolStripMenuItem.Tag = "SF001";
            this.bánHàngToolStripMenuItem.Text = "Bán Hàng";
            this.bánHàngToolStripMenuItem.Click += new System.EventHandler(this.bánHàngToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(156, 25);
            this.quảnLýNhânViênToolStripMenuItem.Tag = "SF002";
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýHàngHóaToolStripMenuItem
            // 
            this.quảnLýHàngHóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhậpHàngToolStripMenuItem,
            this.toolStripMenuItem1});
            this.quảnLýHàngHóaToolStripMenuItem.Name = "quảnLýHàngHóaToolStripMenuItem";
            this.quảnLýHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.quảnLýHàngHóaToolStripMenuItem.Tag = "SF006";
            this.quảnLýHàngHóaToolStripMenuItem.Text = "Hàng Hóa";
            this.quảnLýHàngHóaToolStripMenuItem.MouseHover += new System.EventHandler(this.quảnLýHàngHóaToolStripMenuItem_MouseHover);
            // 
            // quảnLýNhậpHàngToolStripMenuItem
            // 
            this.quảnLýNhậpHàngToolStripMenuItem.Name = "quảnLýNhậpHàngToolStripMenuItem";
            this.quảnLýNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.quảnLýNhậpHàngToolStripMenuItem.Tag = "SF004";
            this.quảnLýNhậpHàngToolStripMenuItem.Text = "Quản Lý Nhập Hàng";
            this.quảnLýNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhậpHàngToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.toolStripMenuItem1.Tag = "SF005";
            this.toolStripMenuItem1.Text = "Quản Lý Hàng Hóa";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.quảnLýHàngHóaToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhSốBánHàngToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            this.thốngKêToolStripMenuItem.MouseHover += new System.EventHandler(this.thốngKêToolStripMenuItem_MouseHover);
            // 
            // doanhSốBánHàngToolStripMenuItem
            // 
            this.doanhSốBánHàngToolStripMenuItem.Name = "doanhSốBánHàngToolStripMenuItem";
            this.doanhSốBánHàngToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.doanhSốBánHàngToolStripMenuItem.Text = "Doanh Số Bán Hàng";
            this.doanhSốBánHàngToolStripMenuItem.Click += new System.EventHandler(this.doanhSốBánHàngToolStripMenuItem_Click);
            // 
            // cáNhânToolStripMenuItem
            // 
            this.cáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.cáNhânToolStripMenuItem.Name = "cáNhânToolStripMenuItem";
            this.cáNhânToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.cáNhânToolStripMenuItem.Text = "Cá Nhân";
            this.cáNhânToolStripMenuItem.Click += new System.EventHandler(this.cáNhânToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // pnlFill
            // 
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 31);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(980, 467);
            this.pnlFill.TabIndex = 1;
            // 
            // quảnLýĐặtHàngToolStripMenuItem
            // 
            this.quảnLýĐặtHàngToolStripMenuItem.Name = "quảnLýĐặtHàngToolStripMenuItem";
            this.quảnLýĐặtHàngToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.quảnLýĐặtHàngToolStripMenuItem.Text = "Quản Lý Đặt Hàng";
            this.quảnLýĐặtHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐặtHàngToolStripMenuItem_Click);
            // 
            // quảnLýĐơnHàngToolStripMenuItem
            // 
            this.quảnLýĐơnHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýĐặtHàngToolStripMenuItem,
            this.toolStripMenuItem2});
            this.quảnLýĐơnHàngToolStripMenuItem.Name = "quảnLýĐơnHàngToolStripMenuItem";
            this.quảnLýĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.quảnLýĐơnHàngToolStripMenuItem.Tag = "SF003";
            this.quảnLýĐơnHàngToolStripMenuItem.Text = "Quản Lý Thu";
            this.quảnLýĐơnHàngToolStripMenuItem.MouseHover += new System.EventHandler(this.quảnLýĐơnHàngToolStripMenuItem_MouseHover);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(212, 26);
            this.toolStripMenuItem2.Tag = "SF003";
            this.toolStripMenuItem2.Text = "Quản Lý Đơn Hàng";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.quảnLýĐơnHàngToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 498);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.mnsMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnsMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhSốBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}