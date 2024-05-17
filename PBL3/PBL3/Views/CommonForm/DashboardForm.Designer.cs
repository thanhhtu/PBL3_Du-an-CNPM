namespace PBL3.Views.CommonForm
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSort = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbbPageNumber = new PBL3.Views.CustomComponents.CustomComboBox();
            this.btnReset = new PBL3.Views.CustomComponent.CustomButton();
            this.btnSearch = new PBL3.Views.CustomComponent.CustomButton();
            this.cbbArea = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbbPrice = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbbWard = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbbDistrict = new PBL3.Views.CustomComponents.CustomComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.houseInfoComponent5 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.houseInfoComponent4 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.houseInfoComponent3 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.houseInfoComponent2 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.houseInfoComponent1 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNextPage = new PBL3.Views.CustomComponent.CustomButton();
            this.btnPrevPage = new PBL3.Views.CustomComponent.CustomButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbSort);
            this.panel1.Controls.Add(this.cbbPageNumber);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cbbArea);
            this.panel1.Controls.Add(this.cbbPrice);
            this.panel1.Controls.Add(this.cbbWard);
            this.panel1.Controls.Add(this.cbbDistrict);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 106);
            this.panel1.TabIndex = 20;
            // 
            // cbbSort
            // 
            this.cbbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbSort.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbSort.BorderSize = 2;
            this.cbbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSort.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbSort.ForeColor = System.Drawing.Color.DimGray;
            this.cbbSort.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbSort.Items.AddRange(new object[] {
            "Mới nhất",
            "Cũ nhất",
            "Giá từ thấp đến cao",
            "Giá từ cao đến thấp",
            "Diện tích từ nhỏ đến lớn",
            "Diện tích từ lớn đến nhỏ"});
            this.cbbSort.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbSort.ListTextColor = System.Drawing.Color.Black;
            this.cbbSort.Location = new System.Drawing.Point(46, 12);
            this.cbbSort.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSort.MinimumSize = new System.Drawing.Size(150, 24);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Padding = new System.Windows.Forms.Padding(2);
            this.cbbSort.Size = new System.Drawing.Size(191, 32);
            this.cbbSort.TabIndex = 1;
            this.cbbSort.Texts = "Sắp xếp theo";
            this.cbbSort.OnSelectionChangedCommited += new System.EventHandler(this.cbbSort_OnSelectionChangedCommited);
            // 
            // cbbPageNumber
            // 
            this.cbbPageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbPageNumber.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbPageNumber.BorderSize = 2;
            this.cbbPageNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPageNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbPageNumber.ForeColor = System.Drawing.Color.DimGray;
            this.cbbPageNumber.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbPageNumber.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbPageNumber.ListTextColor = System.Drawing.Color.Black;
            this.cbbPageNumber.Location = new System.Drawing.Point(272, 12);
            this.cbbPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.cbbPageNumber.MinimumSize = new System.Drawing.Size(150, 24);
            this.cbbPageNumber.Name = "cbbPageNumber";
            this.cbbPageNumber.Padding = new System.Windows.Forms.Padding(2);
            this.cbbPageNumber.Size = new System.Drawing.Size(191, 32);
            this.cbbPageNumber.TabIndex = 2;
            this.cbbPageNumber.Texts = "Trang";
            this.cbbPageNumber.OnSelectionChangedCommited += new System.EventHandler(this.cbbPageNumber_OnSelectionChangedCommited);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReset.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 25;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(1081, 54);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 41);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.TextColor = System.Drawing.Color.Black;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 25;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(921, 54);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 41);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbArea
            // 
            this.cbbArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbArea.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbArea.BorderSize = 2;
            this.cbbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbArea.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbArea.ForeColor = System.Drawing.Color.DimGray;
            this.cbbArea.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbArea.Items.AddRange(new object[] {
            "Tất cả diện tích",
            "Dưới 20m2",
            "Từ 20 - 25m2",
            "Từ 25 - 30m2",
            "Trên 30m2"});
            this.cbbArea.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbArea.ListTextColor = System.Drawing.Color.Black;
            this.cbbArea.Location = new System.Drawing.Point(722, 60);
            this.cbbArea.Margin = new System.Windows.Forms.Padding(2);
            this.cbbArea.MinimumSize = new System.Drawing.Size(150, 32);
            this.cbbArea.Name = "cbbArea";
            this.cbbArea.Padding = new System.Windows.Forms.Padding(2);
            this.cbbArea.Size = new System.Drawing.Size(191, 32);
            this.cbbArea.TabIndex = 6;
            this.cbbArea.Texts = "Chọn diện tích";
            // 
            // cbbPrice
            // 
            this.cbbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbPrice.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbPrice.BorderSize = 2;
            this.cbbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbPrice.ForeColor = System.Drawing.Color.DimGray;
            this.cbbPrice.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbPrice.Items.AddRange(new object[] {
            "Tất cả khoảng giá",
            "Dưới 1 triệu",
            "Từ 1 triệu - 1,5 triệu",
            "Từ 1,5 triệu - 2 triệu",
            "Trên 2 triệu"});
            this.cbbPrice.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbPrice.ListTextColor = System.Drawing.Color.Black;
            this.cbbPrice.Location = new System.Drawing.Point(496, 60);
            this.cbbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.cbbPrice.MinimumSize = new System.Drawing.Size(150, 32);
            this.cbbPrice.Name = "cbbPrice";
            this.cbbPrice.Padding = new System.Windows.Forms.Padding(2);
            this.cbbPrice.Size = new System.Drawing.Size(191, 32);
            this.cbbPrice.TabIndex = 5;
            this.cbbPrice.Texts = "Chọn giá";
            this.cbbPrice.OnSelectedIndexChanged += new System.EventHandler(this.cbbPrice_OnSelectedIndexChanged);
            // 
            // cbbWard
            // 
            this.cbbWard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbWard.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbWard.BorderSize = 2;
            this.cbbWard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWard.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbWard.ForeColor = System.Drawing.Color.DimGray;
            this.cbbWard.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbWard.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbWard.ListTextColor = System.Drawing.Color.Black;
            this.cbbWard.Location = new System.Drawing.Point(272, 60);
            this.cbbWard.Margin = new System.Windows.Forms.Padding(2);
            this.cbbWard.MinimumSize = new System.Drawing.Size(150, 32);
            this.cbbWard.Name = "cbbWard";
            this.cbbWard.Padding = new System.Windows.Forms.Padding(2);
            this.cbbWard.Size = new System.Drawing.Size(191, 32);
            this.cbbWard.TabIndex = 4;
            this.cbbWard.Texts = "Chọn phường";
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
            this.cbbDistrict.Location = new System.Drawing.Point(46, 60);
            this.cbbDistrict.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDistrict.MinimumSize = new System.Drawing.Size(150, 32);
            this.cbbDistrict.Name = "cbbDistrict";
            this.cbbDistrict.Padding = new System.Windows.Forms.Padding(2);
            this.cbbDistrict.Size = new System.Drawing.Size(191, 32);
            this.cbbDistrict.TabIndex = 3;
            this.cbbDistrict.Texts = "Chọn quận";
            this.cbbDistrict.OnSelectionChangedCommited += new System.EventHandler(this.cbbDistrict_OnSelectionChangedCommited);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.houseInfoComponent5);
            this.panel2.Controls.Add(this.houseInfoComponent4);
            this.panel2.Controls.Add(this.houseInfoComponent3);
            this.panel2.Controls.Add(this.houseInfoComponent2);
            this.panel2.Controls.Add(this.houseInfoComponent1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1203, 314);
            this.panel2.TabIndex = 13;
            // 
            // houseInfoComponent5
            // 
            this.houseInfoComponent5.AddressLabel = "Địa chỉ:";
            this.houseInfoComponent5.AreaLabel = "Diện tích: ";
            this.houseInfoComponent5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseInfoComponent5.DescLabel = "Mô tả:";
            this.houseInfoComponent5.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent5.HomeLink = "Tên nhà";
            this.houseInfoComponent5.Location = new System.Drawing.Point(0, 1020);
            this.houseInfoComponent5.Margin = new System.Windows.Forms.Padding(2);
            this.houseInfoComponent5.MoneyLabel = "Số tiền: ";
            this.houseInfoComponent5.Name = "houseInfoComponent5";
            this.houseInfoComponent5.PictureBox = ((System.Drawing.Image)(resources.GetObject("houseInfoComponent5.PictureBox")));
            this.houseInfoComponent5.PostID = "postID";
            this.houseInfoComponent5.Size = new System.Drawing.Size(1186, 256);
            this.houseInfoComponent5.TabIndex = 24;
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
            this.houseInfoComponent4.Location = new System.Drawing.Point(0, 764);
            this.houseInfoComponent4.Margin = new System.Windows.Forms.Padding(2);
            this.houseInfoComponent4.MoneyLabel = "Số tiền: ";
            this.houseInfoComponent4.Name = "houseInfoComponent4";
            this.houseInfoComponent4.PictureBox = ((System.Drawing.Image)(resources.GetObject("houseInfoComponent4.PictureBox")));
            this.houseInfoComponent4.PostID = "postID";
            this.houseInfoComponent4.Size = new System.Drawing.Size(1186, 256);
            this.houseInfoComponent4.TabIndex = 16;
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
            this.houseInfoComponent3.Location = new System.Drawing.Point(0, 508);
            this.houseInfoComponent3.Margin = new System.Windows.Forms.Padding(2);
            this.houseInfoComponent3.MoneyLabel = "Số tiền: ";
            this.houseInfoComponent3.Name = "houseInfoComponent3";
            this.houseInfoComponent3.PictureBox = ((System.Drawing.Image)(resources.GetObject("houseInfoComponent3.PictureBox")));
            this.houseInfoComponent3.PostID = "postID";
            this.houseInfoComponent3.Size = new System.Drawing.Size(1186, 256);
            this.houseInfoComponent3.TabIndex = 16;
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
            this.houseInfoComponent2.Location = new System.Drawing.Point(0, 252);
            this.houseInfoComponent2.Margin = new System.Windows.Forms.Padding(2);
            this.houseInfoComponent2.MoneyLabel = "Số tiền: ";
            this.houseInfoComponent2.Name = "houseInfoComponent2";
            this.houseInfoComponent2.PictureBox = ((System.Drawing.Image)(resources.GetObject("houseInfoComponent2.PictureBox")));
            this.houseInfoComponent2.PostID = "postID";
            this.houseInfoComponent2.Size = new System.Drawing.Size(1186, 256);
            this.houseInfoComponent2.TabIndex = 23;
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
            this.houseInfoComponent1.Margin = new System.Windows.Forms.Padding(2);
            this.houseInfoComponent1.MoneyLabel = "Số tiền: ";
            this.houseInfoComponent1.Name = "houseInfoComponent1";
            this.houseInfoComponent1.PictureBox = ((System.Drawing.Image)(resources.GetObject("houseInfoComponent1.PictureBox")));
            this.houseInfoComponent1.PostID = "postID";
            this.houseInfoComponent1.Size = new System.Drawing.Size(1186, 252);
            this.houseInfoComponent1.TabIndex = 22;
            this.houseInfoComponent1._OnLabelClicked += new System.EventHandler(this.houseInfoComponent1__OnLabelClicked);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnNextPage);
            this.panel3.Controls.Add(this.btnPrevPage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 420);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1203, 65);
            this.panel3.TabIndex = 21;
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
            this.btnNextPage.Location = new System.Drawing.Point(849, 11);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(150, 41);
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
            this.btnPrevPage.Location = new System.Drawing.Point(172, 11);
            this.btnPrevPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(150, 41);
            this.btnPrevPage.TabIndex = 14;
            this.btnPrevPage.Text = "Trang trước";
            this.btnPrevPage.TextColor = System.Drawing.Color.White;
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1203, 314);
            this.panel4.TabIndex = 22;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 485);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(780, 516);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomComponent.CustomButton btnReset;
        private CustomComponent.CustomButton btnSearch;
        private CustomComponents.CustomComboBox cbbArea;
        private CustomComponents.CustomComboBox cbbPrice;
        private CustomComponents.CustomComboBox cbbWard;
        private CustomComponents.CustomComboBox cbbDistrict;
        private System.Windows.Forms.Panel panel3;
        private CustomComponent.CustomButton btnNextPage;
        private CustomComponent.CustomButton btnPrevPage;
        private CustomComponents.CustomComboBox cbbPageNumber;
        private CustomComponents.CustomComboBox cbbSort;
        private CustomComponent.CustomInforComponent houseInfoComponent3;
        private CustomComponent.CustomInforComponent houseInfoComponent2;
        private CustomComponent.CustomInforComponent houseInfoComponent1;
        private CustomComponent.CustomInforComponent houseInfoComponent5;
        private CustomComponent.CustomInforComponent houseInfoComponent4;
        private System.Windows.Forms.Panel panel4;
    }
}