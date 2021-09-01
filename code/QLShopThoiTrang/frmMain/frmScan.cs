using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace frmMain
{
    public partial class frmScan : Form
    {
        public frmScan()
        {
            InitializeComponent();
        }

        private void frmScan_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo fi in filterInfoCollection)
                cboCam.Items.Add(fi.Name);

            cboCam.SelectedIndex = 0;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCam.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if(result != null)
            {
                txtCode.Invoke(new MethodInvoker(delegate ()
                {
                    txtCode.Text = result.ToString();
                }));
            }
            pbCam.Image = bitmap;
            pbCam.BackgroundImageLayout = ImageLayout.Zoom;
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void frmScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }
        public string GetCode()
        {
            if (txtCode.Text != "")
                return txtCode.Text;
            return string.Empty;
        }
        public void TurnOffPictureBoxClick()
        {
            pbCam.Click -= PbCam_Click;   
        }
        public void TurnOnPictureBoxClick()
        {
            pbCam.Click += PbCam_Click;
        }


        private void PbCam_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pbCam.Image = new Bitmap(open.FileName);
                pbCam.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)pbCam.Image);
            if (result != null)
                txtCode.Text = result.ToString();
        }
        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
