namespace frmMain
{
    partial class frmScan
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
            this.cboCam = new System.Windows.Forms.ComboBox();
            this.pbCam = new System.Windows.Forms.PictureBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCam
            // 
            this.cboCam.FormattingEnabled = true;
            this.cboCam.Location = new System.Drawing.Point(12, 12);
            this.cboCam.Name = "cboCam";
            this.cboCam.Size = new System.Drawing.Size(327, 21);
            this.cboCam.TabIndex = 0;
            // 
            // pbCam
            // 
            this.pbCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCam.Location = new System.Drawing.Point(12, 39);
            this.pbCam.Name = "pbCam";
            this.pbCam.Size = new System.Drawing.Size(327, 151);
            this.pbCam.TabIndex = 1;
            this.pbCam.TabStop = false;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(12, 196);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(325, 20);
            this.txtCode.TabIndex = 2;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(130, 222);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 59);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // frmScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 284);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.pbCam);
            this.Controls.Add(this.cboCam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmScan";
            this.Text = "Scan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScan_FormClosing);
            this.Load += new System.EventHandler(this.frmScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCam;
        private System.Windows.Forms.PictureBox pbCam;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnConnect;
    }
}