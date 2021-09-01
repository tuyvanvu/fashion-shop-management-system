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
    public partial class frmKetNoiDatabase : Form
    {

        XuLy xl1 = new XuLy();
        XuLyGUI xl = new XuLyGUI();
        public frmKetNoiDatabase()
        {
            InitializeComponent();
        }
        private void cboServerName_DropDown(object sender, EventArgs e)
        {
            cboServerName.DataSource = xl.getServerName();
            cboServerName.DisplayMember = "ServerName";
            cboServerName.SelectedIndexChanged += CboServerName_SelectedIndexChanged;
        }

        private bool CheckFill()
        {
            if (cboServerName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
                return true;
            return false;
        }
        private void CboServerName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (CheckFill())
                cboDatabase.Enabled = true;
            else
                cboDatabase.Enabled = false;
        }
        private void cboDatabase_DropDown(object sender, System.EventArgs e)
        {
            cboDatabase.DataSource = xl.getDatabaseName(cboServerName.Text, txtUserName.Text, txtPassword.Text);
            cboDatabase.DisplayMember = "Name";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckFill() && cboDatabase.Text != "")
            {
                xl1.SaveConfig(cboServerName.Text, txtUserName.Text, txtPassword.Text, cboDatabase.Text);
                this.Close();
                Program.frm_Login.Show();
            }
        }
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (CheckFill())
                cboDatabase.Enabled = true;
            else
                cboDatabase.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
