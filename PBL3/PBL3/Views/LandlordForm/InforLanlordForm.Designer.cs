namespace PBL3.Views.LandlordForm
{
    partial class InforLanlordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InforLanlordForm));
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customInforComponent2 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.customInforComponent1 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.BackColor = System.Drawing.Color.Transparent;
            this.labelFullname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelFullname.ForeColor = System.Drawing.Color.Black;
            this.labelFullname.Location = new System.Drawing.Point(11, 13);
            this.labelFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(84, 21);
            this.labelFullname.TabIndex = 10;
            this.labelFullname.Text = "Họ và tên:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelPhone.ForeColor = System.Drawing.Color.Black;
            this.labelPhone.Location = new System.Drawing.Point(11, 96);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(110, 21);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "Số điện thoại:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelAddress.ForeColor = System.Drawing.Color.Black;
            this.labelAddress.Location = new System.Drawing.Point(11, 140);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(62, 21);
            this.labelAddress.TabIndex = 12;
            this.labelAddress.Text = "Địa chỉ:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(11, 55);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 21);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.labelEmail);
            this.panel2.Controls.Add(this.labelAddress);
            this.panel2.Controls.Add(this.labelPhone);
            this.panel2.Controls.Add(this.labelFullname);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 397);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(866, 57);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.customInforComponent2);
            this.panel1.Controls.Add(this.customInforComponent1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(230, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 363);
            this.panel1.TabIndex = 10;
            // 
            // customInforComponent2
            // 
            this.customInforComponent2.AddressLabel = "Địa chỉ:";
            this.customInforComponent2.AreaLabel = "Diện tích: ";
            this.customInforComponent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInforComponent2.DescLabel = "Mô tả:";
            this.customInforComponent2.HomeLink = "Tên nhà";
            this.customInforComponent2.Location = new System.Drawing.Point(-2, 228);
            this.customInforComponent2.Margin = new System.Windows.Forms.Padding(2);
            this.customInforComponent2.MoneyLabel = "Số tiền: ";
            this.customInforComponent2.Name = "customInforComponent2";
            this.customInforComponent2.PictureBox = ((System.Drawing.Image)(resources.GetObject("customInforComponent2.PictureBox")));
            this.customInforComponent2.PostID = "postID";
            this.customInforComponent2.Size = new System.Drawing.Size(619, 222);
            this.customInforComponent2.TabIndex = 1;
            // 
            // customInforComponent1
            // 
            this.customInforComponent1.AddressLabel = "Địa chỉ:";
            this.customInforComponent1.AreaLabel = "Diện tích: ";
            this.customInforComponent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInforComponent1.DescLabel = "Mô tả:";
            this.customInforComponent1.HomeLink = "Tên nhà";
            this.customInforComponent1.Location = new System.Drawing.Point(0, 2);
            this.customInforComponent1.Margin = new System.Windows.Forms.Padding(2);
            this.customInforComponent1.MoneyLabel = "Số tiền: ";
            this.customInforComponent1.Name = "customInforComponent1";
            this.customInforComponent1.PictureBox = ((System.Drawing.Image)(resources.GetObject("customInforComponent1.PictureBox")));
            this.customInforComponent1.PostID = "postID";
            this.customInforComponent1.Size = new System.Drawing.Size(619, 222);
            this.customInforComponent1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(230, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(636, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Các trọ đang cho thuê";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InforLanlordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(883, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "InforLanlordForm";
            this.Text = "InforLanlordForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private CustomComponent.CustomInforComponent customInforComponent2;
        private CustomComponent.CustomInforComponent customInforComponent1;
    }
}