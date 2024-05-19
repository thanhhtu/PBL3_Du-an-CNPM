namespace PBL3.Views.LandlordForm
{
    partial class InforLandlordForm
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
            this.customPanel1 = new PBL3.Views.CustomComponent.CustomPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackCCCD = new System.Windows.Forms.PictureBox();
            this.FrontCCCD = new System.Windows.Forms.PictureBox();
            this.labelCCCD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackCCCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontCCCD)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 35;
            this.customPanel1.Controls.Add(this.panel1);
            this.customPanel1.Controls.Add(this.labelCCCD);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.labelEmail);
            this.customPanel1.Controls.Add(this.labelAddress);
            this.customPanel1.Controls.Add(this.labelPhone);
            this.customPanel1.Controls.Add(this.labelFullname);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.customPanel1.Location = new System.Drawing.Point(81, 55);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(748, 626);
            this.customPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BackCCCD);
            this.panel1.Controls.Add(this.FrontCCCD);
            this.panel1.Location = new System.Drawing.Point(133, 386);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 208);
            this.panel1.TabIndex = 30;
            // 
            // BackCCCD
            // 
            this.BackCCCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackCCCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackCCCD.Image = global::PBL3.Properties.Resources.image;
            this.BackCCCD.Location = new System.Drawing.Point(274, 30);
            this.BackCCCD.Margin = new System.Windows.Forms.Padding(2);
            this.BackCCCD.Name = "BackCCCD";
            this.BackCCCD.Size = new System.Drawing.Size(179, 148);
            this.BackCCCD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackCCCD.TabIndex = 12;
            this.BackCCCD.TabStop = false;
            // 
            // FrontCCCD
            // 
            this.FrontCCCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FrontCCCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FrontCCCD.Image = global::PBL3.Properties.Resources.image;
            this.FrontCCCD.Location = new System.Drawing.Point(36, 30);
            this.FrontCCCD.Margin = new System.Windows.Forms.Padding(2);
            this.FrontCCCD.Name = "FrontCCCD";
            this.FrontCCCD.Size = new System.Drawing.Size(182, 148);
            this.FrontCCCD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FrontCCCD.TabIndex = 8;
            this.FrontCCCD.TabStop = false;
            // 
            // labelCCCD
            // 
            this.labelCCCD.AutoSize = true;
            this.labelCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.labelCCCD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelCCCD.ForeColor = System.Drawing.Color.Black;
            this.labelCCCD.Location = new System.Drawing.Point(119, 342);
            this.labelCCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCCCD.Name = "labelCCCD";
            this.labelCCCD.Size = new System.Drawing.Size(132, 28);
            this.labelCCCD.TabIndex = 27;
            this.labelCCCD.Text = "CMND/CCCD:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(193, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 65);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 82);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(119, 172);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 28);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelAddress.ForeColor = System.Drawing.Color.Black;
            this.labelAddress.Location = new System.Drawing.Point(119, 277);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(78, 28);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Địa chỉ:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelPhone.ForeColor = System.Drawing.Color.Black;
            this.labelPhone.Location = new System.Drawing.Point(119, 223);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(138, 28);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Số điện thoại:";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.BackColor = System.Drawing.Color.Transparent;
            this.labelFullname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelFullname.ForeColor = System.Drawing.Color.Black;
            this.labelFullname.Location = new System.Drawing.Point(119, 121);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(106, 28);
            this.labelFullname.TabIndex = 2;
            this.labelFullname.Text = "Họ và tên:";
            // 
            // InforLandlordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PBL3.Properties.Resources.bgr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 735);
            this.Controls.Add(this.customPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InforLandlordForm";
            this.Text = "InforLandlordForm";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackCCCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontCCCD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponent.CustomPanel customPanel1;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCCCD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BackCCCD;
        private System.Windows.Forms.PictureBox FrontCCCD;
    }
}