using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.Properties;

namespace ThuVien
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private MessageForm.enmAction action;
        private int x, y;
        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                MessageForm frm = (MessageForm)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }


            this.lblMsg.Text = msg;

            try
            {
                this.Show();
                this.action = enmAction.start;
                this.timer1.Interval = 1;
                this.timer1.Start();
            }
            catch
            {
                //Không làm gì cả
                //Coi như bỏ qua
                //Vì đã có rồi
            }
            
        }
        
        public void Alert(string msg, MessageForm.enmType type)
        {
            MessageForm frm = new MessageForm();
            frm.showAlert(msg, type);
        }
        

        private void pnlSuccess_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            this.Opacity -= 0.1;

            this.Left -= 3;
            if (base.Opacity == 0.0)
            {
                base.Close();
            }
        }

        private void MessageForm_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            timer1.Interval = 1;
            this.Opacity -= 0.1;

            this.Left -= 3;
            if (base.Opacity == 0.0)
            {
                base.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 3000;
                    action = enmAction.close;
                    break;
                case MessageForm.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = MessageForm.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        


    }
}
