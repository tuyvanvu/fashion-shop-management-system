using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public partial class HintTextBox : UserControl
    {
        string _AllText;
        bool isLabelVisible;
        public HintTextBox()
        {
            InitializeComponent();
            isLabelVisible = true;
            _AllText = "Label";
            
        }

        //Properties
        public string AllText
        {
            get { return _AllText; }
            set
            {
                SetAllText(value);
            }
        }
        public string LabelText
        {
            get { return lblTopLabel.Text; }
            set
            {
                lblTopLabel.Text = value;
            }
        }
        public override string Text
        {
            get { return txtTextBox.Text; }
            set
            {
                _AllText = value;
                txtTextBox.Text = value;
            }
        }
        public bool LabelVisible
        {
            get
            {
                return isLabelVisible;
            }
            set
            {
                if(value)
                {
                    lblTopLabel.Visible = true;
                    SetTrueTextBox();
                    txtTextBox.Enter -= HtxtTextBox_Enter;
                    txtTextBox.Leave -= HtxtTextBox_Leave;
                }
                else
                {
                    isLabelVisible = false;
                    lblTopLabel.Visible = false;
                    txtTextBox.Enter += HtxtTextBox_Enter;
                    txtTextBox.Leave += HtxtTextBox_Leave;
                }
                
            }
        }

        public void SetText(string Text)
        {
            if (txtTextBox.Tag.Equals("Yes"))
            {
                txtTextBox.Text = Text;
                txtTextBox.ForeColor = Color.Black;
                lblTopLabel.Visible = true;
                txtTextBox.Tag = "";
            }
        }

        private void HtxtTextBox_Leave(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Text == "")
            {
                ((TextBox)(sender)).Text = " " + _AllText;
                ((TextBox)(sender)).ForeColor = Color.Gray;
                lblTopLabel.Visible = false;
                ((TextBox)(sender)).Tag = "Yes";
            }
        }
        private void HtxtTextBox_Enter(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Tag.Equals("Yes"))
            {
                ((TextBox)(sender)).Text = "";
                ((TextBox)(sender)).ForeColor = Color.Black;
                lblTopLabel.Visible = true;
                ((TextBox)(sender)).Tag = "";
            }
        }


        void SetAllText(string Text)
        {
            _AllText = Text;
            lblTopLabel.Text = Text;
            txtTextBox.Text = Text;
        }
        void SetTrueTextBox()
        {
            txtTextBox.ForeColor = Color.Black;
        }
        void SetFalseTextBox()
        {
            txtTextBox.ForeColor = Color.Gray;
        }
        
    }
}
