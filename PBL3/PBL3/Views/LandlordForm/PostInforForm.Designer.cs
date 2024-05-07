namespace PBL3.Views.LandlordForm
{
    partial class PostInforForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUploadImg = new PBL3.Views.CustomComponent.CustomButton();
            this.diaChiGroupBox = new System.Windows.Forms.GroupBox();
            this.txtDetailAddress = new PBL3.Views.CustomComponent.CustomTextBox();
            this.cbbWard = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbbDistrict = new PBL3.Views.CustomComponents.CustomComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUploadInfor = new PBL3.Views.CustomComponent.CustomButton();
            this.btnCancel = new PBL3.Views.CustomComponent.CustomButton();
            this.radioBtnNotLiveWithOwner = new PBL3.Views.CustomComponent.CustomRadioButton();
            this.radioBtnLiveWithOwner = new PBL3.Views.CustomComponent.CustomRadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.customTextBox1 = new PBL3.Views.CustomComponent.CustomTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrice = new PBL3.Views.CustomComponent.CustomTextBox();
            this.txtArea = new PBL3.Views.CustomComponent.CustomTextBox();
            this.txtDescribe = new PBL3.Views.CustomComponent.CustomTextBox();
            this.txtTitle = new PBL3.Views.CustomComponent.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.diaChiGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(46, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ cụ thể:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quận/Huyện:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mô tả:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUploadImg);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(178, 276);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 224);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUploadImg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUploadImg.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnUploadImg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUploadImg.BorderRadius = 25;
            this.btnUploadImg.BorderSize = 0;
            this.btnUploadImg.FlatAppearance.BorderSize = 0;
            this.btnUploadImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImg.ForeColor = System.Drawing.Color.Black;
            this.btnUploadImg.Location = new System.Drawing.Point(236, 165);
            this.btnUploadImg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(154, 41);
            this.btnUploadImg.TabIndex = 11;
            this.btnUploadImg.Text = "Thêm ảnh";
            this.btnUploadImg.TextColor = System.Drawing.Color.Black;
            this.btnUploadImg.UseVisualStyleBackColor = false;
            this.btnUploadImg.Click += new System.EventHandler(this.btnUploadImg_Click);
            // 
            // diaChiGroupBox
            // 
            this.diaChiGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.diaChiGroupBox.Controls.Add(this.txtDetailAddress);
            this.diaChiGroupBox.Controls.Add(this.cbbWard);
            this.diaChiGroupBox.Controls.Add(this.cbbDistrict);
            this.diaChiGroupBox.Controls.Add(this.label5);
            this.diaChiGroupBox.Controls.Add(this.label4);
            this.diaChiGroupBox.Controls.Add(this.label2);
            this.diaChiGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.diaChiGroupBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.diaChiGroupBox.Location = new System.Drawing.Point(0, 59);
            this.diaChiGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.diaChiGroupBox.Name = "diaChiGroupBox";
            this.diaChiGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.diaChiGroupBox.Size = new System.Drawing.Size(859, 173);
            this.diaChiGroupBox.TabIndex = 14;
            this.diaChiGroupBox.TabStop = false;
            this.diaChiGroupBox.Text = "Địa chỉ";
            this.diaChiGroupBox.Enter += new System.EventHandler(this.diaChiGroupBox_Enter);
            // 
            // txtDetailAddress
            // 
            this.txtDetailAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtDetailAddress.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtDetailAddress.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.txtDetailAddress.BorderRadius = 6;
            this.txtDetailAddress.BorderSize = 2;
            this.txtDetailAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDetailAddress.Location = new System.Drawing.Point(178, 90);
            this.txtDetailAddress.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDetailAddress.Multiline = true;
            this.txtDetailAddress.Name = "txtDetailAddress";
            this.txtDetailAddress.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDetailAddress.PasswordChar = false;
            this.txtDetailAddress.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDetailAddress.PlaceholderText = "";
            this.txtDetailAddress.Size = new System.Drawing.Size(628, 56);
            this.txtDetailAddress.TabIndex = 8;
            this.txtDetailAddress.Texts = "";
            this.txtDetailAddress.UnderlinedStyle = false;
            this.txtDetailAddress._TextChanged += new System.EventHandler(this.txtDetailAddress__TextChanged);
            // 
            // cbbWard
            // 
            this.cbbWard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbWard.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbWard.BorderSize = 2;
            this.cbbWard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbWard.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbWard.ForeColor = System.Drawing.Color.DimGray;
            this.cbbWard.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbWard.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbWard.ListTextColor = System.Drawing.Color.Black;
            this.cbbWard.Location = new System.Drawing.Point(572, 41);
            this.cbbWard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbWard.MinimumSize = new System.Drawing.Size(150, 32);
            this.cbbWard.Name = "cbbWard";
            this.cbbWard.Padding = new System.Windows.Forms.Padding(2);
            this.cbbWard.Size = new System.Drawing.Size(235, 32);
            this.cbbWard.TabIndex = 7;
            this.cbbWard.Texts = "";
            this.cbbWard.OnSelectedIndexChanged += new System.EventHandler(this.cbbWard_OnSelectedIndexChanged);
            // 
            // cbbDistrict
            // 
            this.cbbDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbDistrict.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbDistrict.BorderSize = 2;
            this.cbbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDistrict.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbDistrict.ForeColor = System.Drawing.Color.DimGray;
            this.cbbDistrict.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbDistrict.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbDistrict.ListTextColor = System.Drawing.Color.Black;
            this.cbbDistrict.Location = new System.Drawing.Point(178, 41);
            this.cbbDistrict.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDistrict.MinimumSize = new System.Drawing.Size(150, 32);
            this.cbbDistrict.Name = "cbbDistrict";
            this.cbbDistrict.Padding = new System.Windows.Forms.Padding(2);
            this.cbbDistrict.Size = new System.Drawing.Size(235, 32);
            this.cbbDistrict.TabIndex = 6;
            this.cbbDistrict.Texts = "";
            this.cbbDistrict.OnSelectedIndexChanged += new System.EventHandler(this.cbbDistrict_OnSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(474, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phường/Xã: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(46, 276);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Hình ảnh trọ: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(46, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Diện tích: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(46, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giá cho thuê: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(46, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tiêu đề: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnUploadInfor);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.radioBtnNotLiveWithOwner);
            this.groupBox1.Controls.Add(this.radioBtnLiveWithOwner);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.customTextBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.txtDescribe);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(859, 564);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mô tả";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUploadInfor
            // 
            this.btnUploadInfor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUploadInfor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUploadInfor.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnUploadInfor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUploadInfor.BorderRadius = 30;
            this.btnUploadInfor.BorderSize = 0;
            this.btnUploadInfor.FlatAppearance.BorderSize = 0;
            this.btnUploadInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadInfor.ForeColor = System.Drawing.Color.White;
            this.btnUploadInfor.Location = new System.Drawing.Point(262, 512);
            this.btnUploadInfor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUploadInfor.Name = "btnUploadInfor";
            this.btnUploadInfor.Size = new System.Drawing.Size(150, 41);
            this.btnUploadInfor.TabIndex = 23;
            this.btnUploadInfor.Text = "Đăng";
            this.btnUploadInfor.TextColor = System.Drawing.Color.White;
            this.btnUploadInfor.UseVisualStyleBackColor = false;
            this.btnUploadInfor.Click += new System.EventHandler(this.btnUploadInfor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 30;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(525, 512);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 41);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radioBtnNotLiveWithOwner
            // 
            this.radioBtnNotLiveWithOwner.AutoSize = true;
            this.radioBtnNotLiveWithOwner.CheckedColor = System.Drawing.Color.PaleVioletRed;
            this.radioBtnNotLiveWithOwner.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radioBtnNotLiveWithOwner.ForeColor = System.Drawing.Color.Black;
            this.radioBtnNotLiveWithOwner.Location = new System.Drawing.Point(706, 130);
            this.radioBtnNotLiveWithOwner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnNotLiveWithOwner.MinimumSize = new System.Drawing.Size(0, 17);
            this.radioBtnNotLiveWithOwner.Name = "radioBtnNotLiveWithOwner";
            this.radioBtnNotLiveWithOwner.Size = new System.Drawing.Size(88, 25);
            this.radioBtnNotLiveWithOwner.TabIndex = 21;
            this.radioBtnNotLiveWithOwner.TabStop = true;
            this.radioBtnNotLiveWithOwner.Text = "Không";
            this.radioBtnNotLiveWithOwner.UncheckedColor = System.Drawing.Color.Gray;
            this.radioBtnNotLiveWithOwner.UseVisualStyleBackColor = true;
            this.radioBtnNotLiveWithOwner.CheckedChanged += new System.EventHandler(this.radioBtnNotLiveWithOwner_CheckedChanged);
            // 
            // radioBtnLiveWithOwner
            // 
            this.radioBtnLiveWithOwner.AutoSize = true;
            this.radioBtnLiveWithOwner.CheckedColor = System.Drawing.Color.PaleVioletRed;
            this.radioBtnLiveWithOwner.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radioBtnLiveWithOwner.ForeColor = System.Drawing.Color.Black;
            this.radioBtnLiveWithOwner.Location = new System.Drawing.Point(626, 130);
            this.radioBtnLiveWithOwner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnLiveWithOwner.MinimumSize = new System.Drawing.Size(0, 17);
            this.radioBtnLiveWithOwner.Name = "radioBtnLiveWithOwner";
            this.radioBtnLiveWithOwner.Size = new System.Drawing.Size(60, 25);
            this.radioBtnLiveWithOwner.TabIndex = 20;
            this.radioBtnLiveWithOwner.TabStop = true;
            this.radioBtnLiveWithOwner.Text = "Có";
            this.radioBtnLiveWithOwner.UncheckedColor = System.Drawing.Color.Gray;
            this.radioBtnLiveWithOwner.UseVisualStyleBackColor = true;
            this.radioBtnLiveWithOwner.CheckedChanged += new System.EventHandler(this.radioBtnLiveWithOwner_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(474, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Trọ chung chủ: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.customTextBox1.BorderColor = System.Drawing.Color.SteelBlue;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.customTextBox1.BorderRadius = 6;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.customTextBox1.Location = new System.Drawing.Point(572, 85);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(235, 31);
            this.customTextBox1.TabIndex = 18;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            this.customTextBox1._TextChanged += new System.EventHandler(this.customTextBox1__TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(474, 85);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "Tiền cọc:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtPrice.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPrice.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.txtPrice.BorderRadius = 6;
            this.txtPrice.BorderSize = 2;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPrice.Location = new System.Drawing.Point(178, 80);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.Size = new System.Drawing.Size(235, 31);
            this.txtPrice.TabIndex = 16;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = false;
            this.txtPrice._TextChanged += new System.EventHandler(this.txtPrice__TextChanged);
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtArea.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtArea.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.txtArea.BorderRadius = 6;
            this.txtArea.BorderSize = 2;
            this.txtArea.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtArea.Location = new System.Drawing.Point(178, 130);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtArea.Multiline = false;
            this.txtArea.Name = "txtArea";
            this.txtArea.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArea.PasswordChar = false;
            this.txtArea.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtArea.PlaceholderText = "";
            this.txtArea.Size = new System.Drawing.Size(235, 31);
            this.txtArea.TabIndex = 15;
            this.txtArea.Texts = "";
            this.txtArea.UnderlinedStyle = false;
            this.txtArea._TextChanged += new System.EventHandler(this.txtArea__TextChanged);
            // 
            // txtDescribe
            // 
            this.txtDescribe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtDescribe.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtDescribe.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.txtDescribe.BorderRadius = 6;
            this.txtDescribe.BorderSize = 2;
            this.txtDescribe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescribe.Location = new System.Drawing.Point(178, 175);
            this.txtDescribe.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescribe.PasswordChar = false;
            this.txtDescribe.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDescribe.PlaceholderText = "";
            this.txtDescribe.Size = new System.Drawing.Size(628, 87);
            this.txtDescribe.TabIndex = 14;
            this.txtDescribe.Texts = "";
            this.txtDescribe.UnderlinedStyle = false;
            this.txtDescribe._TextChanged += new System.EventHandler(this.txtDescribe__TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtTitle.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTitle.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.txtTitle.BorderRadius = 6;
            this.txtTitle.BorderSize = 2;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTitle.Location = new System.Drawing.Point(178, 41);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtTitle.Multiline = false;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.PasswordChar = false;
            this.txtTitle.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.Size = new System.Drawing.Size(628, 31);
            this.txtTitle.TabIndex = 9;
            this.txtTitle.Texts = "";
            this.txtTitle.UnderlinedStyle = false;
            this.txtTitle._TextChanged += new System.EventHandler(this.txtTitle__TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(860, 57);
            this.label3.TabIndex = 16;
            this.label3.Text = "ĐĂNG THÔNG TIN TRỌ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::PBL3.Properties.Resources.image;
            this.pictureBox3.Location = new System.Drawing.Point(447, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::PBL3.Properties.Resources.image;
            this.pictureBox2.Location = new System.Drawing.Point(236, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PBL3.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(26, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PostInforForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 716);
            this.Controls.Add(this.diaChiGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(876, 698);
            this.Name = "PostInforForm";
            this.Text = "InforPostingForm";
            this.panel1.ResumeLayout(false);
            this.diaChiGroupBox.ResumeLayout(false);
            this.diaChiGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox diaChiGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private CustomComponents.CustomComboBox cbbWard;
        private CustomComponents.CustomComboBox cbbDistrict;
        private CustomComponent.CustomTextBox txtDetailAddress;
        private CustomComponent.CustomTextBox txtPrice;
        private CustomComponent.CustomTextBox txtArea;
        private CustomComponent.CustomTextBox txtDescribe;
        private CustomComponent.CustomTextBox txtTitle;
        private CustomComponent.CustomTextBox customTextBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private CustomComponent.CustomRadioButton radioBtnLiveWithOwner;
        private CustomComponent.CustomRadioButton radioBtnNotLiveWithOwner;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomComponent.CustomButton btnUploadImg;
        private CustomComponent.CustomButton btnUploadInfor;
        private CustomComponent.CustomButton btnCancel;
    }
}