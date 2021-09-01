using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public class NumericTextBox:TextBox
    {
        bool minussign;
        public NumericTextBox()
        {
            minussign = false;
            this.KeyPress += NumericTextBox_KeyPress;
        }
        public bool AllowMinusSign
        {
            get
            {
                return minussign;
            }
            set
            {
                if(value)
                {
                    minussign = value;
                }
                else
                {
                    minussign = value;
                }
            }
        }
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if(((TextBox)(sender)).Text.Count() == 0 && minussign)     
                if (e.KeyChar == '-' && !this.Text.Contains('-'))
                    e.Handled = false;
        }
    }
}
