namespace PBL3.Views.RenterForm
{
    partial class UserInforForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInforForm));
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.houseInfoComponent5 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.houseInfoComponent4 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.houseInfoComponent3 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.houseInfoComponent2 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.houseInfoComponent1 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.cbbPageNumber = new PBL3.Views.CustomComponents.CustomComboBox();
            this.btnNextPage = new PBL3.Views.CustomComponent.CustomButton();
            this.btnPrevPage = new PBL3.Views.CustomComponent.CustomButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.BackColor = System.Drawing.Color.Transparent;
            this.labelFullname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelFullname.ForeColor = System.Drawing.Color.Black;
            this.labelFullname.Location = new System.Drawing.Point(15, 16);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(106, 28);
            this.labelFullname.TabIndex = 10;
            this.labelFullname.Text = "Họ và tên:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelPhone.ForeColor = System.Drawing.Color.Black;
            this.labelPhone.Location = new System.Drawing.Point(15, 118);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(138, 28);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "Số điện thoại:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelAddress.ForeColor = System.Drawing.Color.Black;
            this.labelAddress.Location = new System.Drawing.Point(15, 172);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(78, 28);
            this.labelAddress.TabIndex = 12;
            this.labelAddress.Text = "Địa chỉ:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(15, 68);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 28);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelEmail);
            this.panel2.Controls.Add(this.labelAddress);
            this.panel2.Controls.Add(this.labelPhone);
            this.panel2.Controls.Add(this.labelFullname);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 464);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(89, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 116);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1520, 70);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÔNG TIN TRỌ YÊU THÍCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.houseInfoComponent5);
            this.panel1.Controls.Add(this.houseInfoComponent4);
            this.panel1.Controls.Add(this.houseInfoComponent3);
            this.panel1.Controls.Add(this.houseInfoComponent2);
            this.panel1.Controls.Add(this.houseInfoComponent1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 395);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.cbbPageNumber);
            this.panel4.Controls.Add(this.btnNextPage);
            this.panel4.Controls.Add(this.btnPrevPage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1165, 66);
            this.panel4.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(355, 465);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1165, 69);
            this.panel6.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(355, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1165, 395);
            this.panel3.TabIndex = 16;
            // 
            // houseInfoComponent5
            // 
            this.houseInfoComponent5.AddressLabel = "Địa chỉ:";
            this.houseInfoComponent5.AreaLabel = "Diện tích: ";
            this.houseInfoComponent5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseInfoComponent5.DescLabel = "Mô tả:";
            this.houseInfoComponent5.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent5.HomeLink = "Tên nhà";
            this.houseInfoComponent5.Location = new System.Drawing.Point(0, 1092);
            this.houseInfoComponent5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.houseInfoComponent5.MoneyLabel = "Số tiền: ";
            this.houseInfoComponent5.Name = "houseInfoComponent5";
            this.houseInfoComponent5.PictureBox = ((System.Drawing.Image)(resources.GetObject("houseInfoComponent5.PictureBox")));
            this.houseInfoComponent5.InforID = "postID";
            this.houseInfoComponent5.Size = new System.Drawing.Size(1144, 273);
            this.houseInfoComponent5.TabIndex = 4;
            this.houseInfoComponent5._DeleteEventHandler += new System.EventHandler(this.DeleteFavorite5);
            this.houseInfoComponent5._OnLabelClicked += new System.EventHandler(this.houseInfoComponent5__OnLabelClicked);
            // 
            // houseInfoComponent4
            // 
            this.houseInfoComponent4.AddressLabel = "Địa chỉ:";
            this.houseInfoComponent4.AreaLabel = "Diện tích: ";
            this.houseInfoComponent4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseInfoComponent4.DescLabel = "Mô tả:";
            this.houseInfoComponent4.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent4.HomeLink = "Tên nhà";
            this.houseInfoComponent4.Location = new System.Drawing.Point(0, 819);
            this.houseInfoComponent4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.houseInfoComponent4.MoneyLabel = "Số tiền: ";
            this.houseInfoComponent4.Name = "houseInfoComponent4";
            this.houseInfoComponent4.PictureBox = ((System.Drawing.Image)(resources.GetObject("houseInfoComponent4.PictureBox")));
            this.houseInfoComponent4.InforID = "postID";
            this.houseInfoComponent4.Size = new System.Drawing.Size(1144, 273);
            this.houseInfoComponent4.TabIndex = 3;
            this.houseInfoComponent4._DeleteEventHandler += new System.EventHandler(this.DeleteFavorite4);
            this.houseInfoComponent4._OnLabelClicked += new System.EventHandler(this.houseInfoComponent4__OnLabelClicked);
            // 
            // houseInfoComponent3
            // 
            this.houseInfoComponent3.AddressLabel = "Địa chỉ:";
            this.houseInfoComponent3.AreaLabel = "Diện tích: ";
            this.houseInfoComponent3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseInfoComponent3.DescLabel = "Mô tả:";
            this.houseInfoComponent3.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent3.HomeLink = "Tên nhà";
            this.houseInfoComponent3.Location = new System.Drawing.Point(0, 546);
            this.houseInfoComponent3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.houseInfoComponent3.MoneyLabel = "Số tiền: ";
            this.houseInfoComponent3.Name = "houseInfoComponent3";
            this.houseInfoComponent3.PictureBox = ((System.Drawing.Image)(resources.GetObject("houseInfoComponent3.PictureBox")));
            this.houseInfoComponent3.InforID = "postID";
            this.houseInfoComponent3.Size = new System.Drawing.Size(1144, 273);
            this.houseInfoComponent3.TabIndex = 2;
            this.houseInfoComponent3._DeleteEventHandler += new System.EventHandler(this.DeleteFavorite3);
            this.houseInfoComponent3._OnLabelClicked += new System.EventHandler(this.houseInfoComponent3__OnLabelClicked);
            // 
            // houseInfoComponent2
            // 
            this.houseInfoComponent2.AddressLabel = "Địa chỉ:";
            this.houseInfoComponent2.AreaLabel = "Diện tích: ";
            this.houseInfoComponent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseInfoComponent2.DescLabel = "Mô tả:";
            this.houseInfoComponent2.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent2.HomeLink = "Tên nhà";
            this.houseInfoComponent2.Location = new System.Drawing.Point(0, 273);
            this.houseInfoComponent2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.houseInfoComponent2.MoneyLabel = "Số tiền: ";
            this.houseInfoComponent2.Name = "houseInfoComponent2";
            this.houseInfoComponent2.PictureBox = ((System.Drawing.Image)(resources.GetObject("houseInfoComponent2.PictureBox")));
            this.houseInfoComponent2.InforID = "postID";
            this.houseInfoComponent2.Size = new System.Drawing.Size(1144, 273);
            this.houseInfoComponent2.TabIndex = 1;
            this.houseInfoComponent2._DeleteEventHandler += new System.EventHandler(this.DeleteFavorite2);
            this.houseInfoComponent2._OnLabelClicked += new System.EventHandler(this.houseInfoComponent2__OnLabelClicked);
            // 
            // houseInfoComponent1
            // 
            this.houseInfoComponent1.AddressLabel = "Địa chỉ:";
            this.houseInfoComponent1.AreaLabel = "Diện tích: ";
            this.houseInfoComponent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseInfoComponent1.DescLabel = "Mô tả:";
            this.houseInfoComponent1.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent1.HomeLink = "Tên nhà";
            this.houseInfoComponent1.Location = new System.Drawing.Point(0, 0);
            this.houseInfoComponent1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.houseInfoComponent1.MoneyLabel = "Số tiền: ";
            this.houseInfoComponent1.Name = "houseInfoComponent1";
            this.houseInfoComponent1.PictureBox = ((System.Drawing.Image)(resources.GetObject("houseInfoComponent1.PictureBox")));
            this.houseInfoComponent1.InforID = "postID";
            this.houseInfoComponent1.Size = new System.Drawing.Size(1144, 273);
            this.houseInfoComponent1.TabIndex = 0;
            this.houseInfoComponent1._DeleteEventHandler += new System.EventHandler(this.DeleteFavorite1);
            this.houseInfoComponent1._OnLabelClicked += new System.EventHandler(this.houseInfoComponent1__OnLabelClicked);
            // 
            // cbbPageNumber
            // 
            this.cbbPageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbPageNumber.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbPageNumber.BorderSize = 2;
            this.cbbPageNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbbPageNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPageNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbPageNumber.ForeColor = System.Drawing.Color.DimGray;
            this.cbbPageNumber.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbPageNumber.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbPageNumber.ListTextColor = System.Drawing.Color.Black;
            this.cbbPageNumber.Location = new System.Drawing.Point(965, 0);
            this.cbbPageNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPageNumber.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbPageNumber.Name = "cbbPageNumber";
            this.cbbPageNumber.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPageNumber.Size = new System.Drawing.Size(200, 66);
            this.cbbPageNumber.TabIndex = 16;
            this.cbbPageNumber.Texts = "Trang";
            this.cbbPageNumber.OnSelectionChangedCommited += new System.EventHandler(this.cbbPageNumber_OnSelectionChangedCommited);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextPage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNextPage.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnNextPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNextPage.BorderRadius = 30;
            this.btnNextPage.BorderSize = 0;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(620, 14);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(200, 50);
            this.btnNextPage.TabIndex = 15;
            this.btnNextPage.Text = "Trang sau";
            this.btnNextPage.TextColor = System.Drawing.Color.White;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevPage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrevPage.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnPrevPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrevPage.BorderRadius = 30;
            this.btnPrevPage.BorderSize = 0;
            this.btnPrevPage.FlatAppearance.BorderSize = 0;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnPrevPage.Location = new System.Drawing.Point(132, 4);
            this.btnPrevPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(200, 50);
            this.btnPrevPage.TabIndex = 14;
            this.btnPrevPage.Text = "Trang trước";
            this.btnPrevPage.TextColor = System.Drawing.Color.White;
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // UserInforForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1520, 534);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserInforForm";
            this.Text = "InforLanlordForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private CustomComponent.CustomInforComponent houseInfoComponent2;
        private CustomComponent.CustomInforComponent houseInfoComponent1;
        private System.Windows.Forms.Panel panel4;
        private CustomComponent.CustomButton btnNextPage;
        private CustomComponent.CustomButton btnPrevPage;
        private System.Windows.Forms.Panel panel6;
        private CustomComponent.CustomInforComponent houseInfoComponent5;
        private CustomComponent.CustomInforComponent houseInfoComponent4;
        private CustomComponent.CustomInforComponent houseInfoComponent3;
        private System.Windows.Forms.Panel panel3;
        private CustomComponents.CustomComboBox cbbPageNumber;
        private System.Windows.Forms.Label label3;
    }
}