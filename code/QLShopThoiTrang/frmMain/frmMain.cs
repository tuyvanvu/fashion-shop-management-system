using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace frmMain
{
    public partial class frmMain : Form
    {
        Main xl_Main = new Main();
        string TenDN;

        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string TenDN)
        {
            InitializeComponent();
            this.TenDN = TenDN;
        }


        Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlFill.Controls.Add(childForm);
            pnlFill.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frm_BanHang = new frmBanHang();
            openChildForm(Program.frm_BanHang);
        }
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frm_QuanLyNhanVien = new frmQuanLyNhanVien();
            openChildForm(Program.frm_QuanLyNhanVien);
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void quảnLýĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frm_QuanLyDonHang = new frmQuanLyDonHang();
            openChildForm(Program.frm_QuanLyDonHang);
        }
        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frm_QuanLyHangHoa = new frmQuanLyHangHoa();
            openChildForm(Program.frm_QuanLyHangHoa);
        }
        private void quảnLýNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frm_QuanLyNhapHang = new frmQuanLyNhapHang();
            openChildForm(Program.frm_QuanLyNhapHang);
        }
        private void quảnLýHàngHóaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            quảnLýHàngHóaToolStripMenuItem.ShowDropDown();
        }
        private void doanhSốBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frm_ThongKeDoanhThu = new frmThongKeDoanhThu();
            openChildForm(Program.frm_ThongKeDoanhThu);
        }
        private void thốngKêToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            thốngKêToolStripMenuItem.ShowDropDown();
        }
        private void cáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm_DoiMK = new frmDoiMatKhau(TenDN);
            frm_DoiMK.Show();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frm_Main.Hide();
            Program.frm_Login.Show();
        }
        private void quảnLýĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frm_QlDDH = new frmQLDonDatHang();
            openChildForm(Program.frm_QlDDH);
        }
        private void quảnLýĐơnHàngToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            quảnLýĐơnHàngToolStripMenuItem.ShowDropDown();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            if(!xl_Main.CoQuyenHayKhong(xl_Main.GetMaNhomNguoiDung(TenDN).First(), bánHàngToolStripMenuItem.Tag.ToString()))
                bánHàngToolStripMenuItem.PerformClick();
            List<string> NhomNguoiDung = xl_Main.GetMaNhomNguoiDung(TenDN);
            foreach(string item in NhomNguoiDung)
            {
                DataTable dsQuyen = xl_Main.GetMaManHinh(item);
                foreach(DataRow row in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(this.mnsMain.Items, row[1].ToString(), Convert.ToBoolean(row[0].ToString()));
                }
            }
        }
        private void FindMenuPhanQuyen(ToolStripItemCollection mnuItems, string pScreenName, bool pEnable)
        {
            foreach(ToolStripItem menu in mnuItems)
            {
                if(menu is ToolStripMenuItem && ((ToolStripMenuItem)(menu)).DropDownItems.Count > 0)
                {
                    FindMenuPhanQuyen(((ToolStripMenuItem)(menu)).DropDownItems,
                        pScreenName, pEnable);
                    menu.Enabled = CheckAllMenuChildVisible(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                }
                else if(string.Equals(pScreenName, menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }
        private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach(ToolStripItem menuItem in mnuItems)
            {
                if (menuItem is ToolStripMenuItem && menuItem.Enabled)
                    return true;
                else if (menuItem is ToolStripSeparator)
                    continue;
            }
            return false;
        }
        
        
    }

    

}
