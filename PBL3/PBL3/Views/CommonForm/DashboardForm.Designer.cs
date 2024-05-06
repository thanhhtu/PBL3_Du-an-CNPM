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
            this.resetBtn = new PBL3.Views.CustomComponent.CustomButton();
            this.searchBtn = new PBL3.Views.CustomComponent.CustomButton();
            this.cbb_PageNumber = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbb_Sort = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbb_Area = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbb_Price = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbb_Ward = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbb_District = new PBL3.Views.CustomComponents.CustomComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customInforComponent4 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.customInforComponent3 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.customInforComponent2 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.customInforComponent1 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.customInforComponent5 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nextPageBtn = new PBL3.Views.CustomComponent.CustomButton();
            this.prevPageBtn = new PBL3.Views.CustomComponent.CustomButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.cbb_PageNumber);
            this.panel1.Controls.Add(this.cbb_Sort);
            this.panel1.Controls.Add(this.cbb_Area);
            this.panel1.Controls.Add(this.cbb_Price);
            this.panel1.Controls.Add(this.cbb_Ward);
            this.panel1.Controls.Add(this.cbb_District);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1764, 130);
            this.panel1.TabIndex = 11;
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.resetBtn.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.resetBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.resetBtn.BorderRadius = 25;
            this.resetBtn.BorderSize = 0;
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.Black;
            this.resetBtn.Location = new System.Drawing.Point(1522, 66);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(180, 50);
            this.resetBtn.TabIndex = 38;
            this.resetBtn.Text = "Đặt lại";
            this.resetBtn.TextColor = System.Drawing.Color.Black;
            this.resetBtn.UseVisualStyleBackColor = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.searchBtn.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 25;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Location = new System.Drawing.Point(1309, 66);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(180, 50);
            this.searchBtn.TabIndex = 37;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.TextColor = System.Drawing.Color.Black;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // cbb_PageNumber
            // 
            this.cbb_PageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_PageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbb_PageNumber.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbb_PageNumber.BorderSize = 3;
            this.cbb_PageNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_PageNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbb_PageNumber.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_PageNumber.IconColor = System.Drawing.Color.SteelBlue;
            this.cbb_PageNumber.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_PageNumber.ListTextColor = System.Drawing.Color.Black;
            this.cbb_PageNumber.Location = new System.Drawing.Point(62, 19);
            this.cbb_PageNumber.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbb_PageNumber.Name = "cbb_PageNumber";
            this.cbb_PageNumber.Padding = new System.Windows.Forms.Padding(3);
            this.cbb_PageNumber.Size = new System.Drawing.Size(255, 40);
            this.cbb_PageNumber.TabIndex = 36;
            this.cbb_PageNumber.Texts = "Trang";
            // 
            // cbb_Sort
            // 
            this.cbb_Sort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbb_Sort.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbb_Sort.BorderSize = 3;
            this.cbb_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Sort.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbb_Sort.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_Sort.IconColor = System.Drawing.Color.SteelBlue;
            this.cbb_Sort.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_Sort.ListTextColor = System.Drawing.Color.Black;
            this.cbb_Sort.Location = new System.Drawing.Point(362, 19);
            this.cbb_Sort.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbb_Sort.Name = "cbb_Sort";
            this.cbb_Sort.Padding = new System.Windows.Forms.Padding(3);
            this.cbb_Sort.Size = new System.Drawing.Size(255, 40);
            this.cbb_Sort.TabIndex = 35;
            this.cbb_Sort.Texts = "Sắp xếp theo";
            // 
            // cbb_Area
            // 
            this.cbb_Area.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbb_Area.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbb_Area.BorderSize = 3;
            this.cbb_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Area.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbb_Area.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_Area.IconColor = System.Drawing.Color.SteelBlue;
            this.cbb_Area.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_Area.ListTextColor = System.Drawing.Color.Black;
            this.cbb_Area.Location = new System.Drawing.Point(962, 74);
            this.cbb_Area.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbb_Area.Name = "cbb_Area";
            this.cbb_Area.Padding = new System.Windows.Forms.Padding(3);
            this.cbb_Area.Size = new System.Drawing.Size(255, 40);
            this.cbb_Area.TabIndex = 34;
            this.cbb_Area.Texts = "Chọn diện tích";
            // 
            // cbb_Price
            // 
            this.cbb_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbb_Price.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbb_Price.BorderSize = 3;
            this.cbb_Price.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Price.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbb_Price.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_Price.IconColor = System.Drawing.Color.SteelBlue;
            this.cbb_Price.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_Price.ListTextColor = System.Drawing.Color.Black;
            this.cbb_Price.Location = new System.Drawing.Point(662, 74);
            this.cbb_Price.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbb_Price.Name = "cbb_Price";
            this.cbb_Price.Padding = new System.Windows.Forms.Padding(3);
            this.cbb_Price.Size = new System.Drawing.Size(255, 40);
            this.cbb_Price.TabIndex = 33;
            this.cbb_Price.Texts = "Chọn giá";
            // 
            // cbb_Ward
            // 
            this.cbb_Ward.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Ward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbb_Ward.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbb_Ward.BorderSize = 3;
            this.cbb_Ward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Ward.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbb_Ward.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_Ward.IconColor = System.Drawing.Color.SteelBlue;
            this.cbb_Ward.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_Ward.ListTextColor = System.Drawing.Color.Black;
            this.cbb_Ward.Location = new System.Drawing.Point(362, 74);
            this.cbb_Ward.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbb_Ward.Name = "cbb_Ward";
            this.cbb_Ward.Padding = new System.Windows.Forms.Padding(3);
            this.cbb_Ward.Size = new System.Drawing.Size(255, 40);
            this.cbb_Ward.TabIndex = 32;
            this.cbb_Ward.Texts = "Chọn phường";
            // 
            // cbb_District
            // 
            this.cbb_District.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_District.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbb_District.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbb_District.BorderSize = 3;
            this.cbb_District.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_District.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbb_District.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_District.IconColor = System.Drawing.Color.SteelBlue;
            this.cbb_District.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_District.ListTextColor = System.Drawing.Color.Black;
            this.cbb_District.Location = new System.Drawing.Point(62, 74);
            this.cbb_District.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbb_District.Name = "cbb_District";
            this.cbb_District.Padding = new System.Windows.Forms.Padding(3);
            this.cbb_District.Size = new System.Drawing.Size(255, 40);
            this.cbb_District.TabIndex = 31;
            this.cbb_District.Texts = "Chọn quận";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.customInforComponent4);
            this.panel2.Controls.Add(this.customInforComponent3);
            this.panel2.Controls.Add(this.customInforComponent2);
            this.panel2.Controls.Add(this.customInforComponent1);
            this.panel2.Controls.Add(this.customInforComponent5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1764, 467);
            this.panel2.TabIndex = 13;
            // 
            // customInforComponent4
            // 
            this.customInforComponent4.AddressLabel = "Địa chỉ:";
            this.customInforComponent4.AreaLabel = "Diện tích: ";
            this.customInforComponent4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInforComponent4.DescLabel = "Mô tả:";
            this.customInforComponent4.Dock = System.Windows.Forms.DockStyle.Top;
            this.customInforComponent4.HomeLink = "Tên nhà";
            this.customInforComponent4.Location = new System.Drawing.Point(0, 1256);
            this.customInforComponent4.Margin = new System.Windows.Forms.Padding(2);
            this.customInforComponent4.MoneyLabel = "Số tiền: ";
            this.customInforComponent4.Name = "customInforComponent4";
            this.customInforComponent4.PictureBox = ((System.Drawing.Image)(resources.GetObject("customInforComponent4.PictureBox")));
            this.customInforComponent4.PostID = "postID";
            this.customInforComponent4.Size = new System.Drawing.Size(1743, 314);
            this.customInforComponent4.TabIndex = 22;
            // 
            // customInforComponent3
            // 
            this.customInforComponent3.AddressLabel = "Địa chỉ:";
            this.customInforComponent3.AreaLabel = "Diện tích: ";
            this.customInforComponent3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInforComponent3.DescLabel = "Mô tả:";
            this.customInforComponent3.Dock = System.Windows.Forms.DockStyle.Top;
            this.customInforComponent3.HomeLink = "Tên nhà";
            this.customInforComponent3.Location = new System.Drawing.Point(0, 942);
            this.customInforComponent3.Margin = new System.Windows.Forms.Padding(2);
            this.customInforComponent3.MoneyLabel = "Số tiền: ";
            this.customInforComponent3.Name = "customInforComponent3";
            this.customInforComponent3.PictureBox = ((System.Drawing.Image)(resources.GetObject("customInforComponent3.PictureBox")));
            this.customInforComponent3.PostID = "postID";
            this.customInforComponent3.Size = new System.Drawing.Size(1743, 314);
            this.customInforComponent3.TabIndex = 21;
            // 
            // customInforComponent2
            // 
            this.customInforComponent2.AddressLabel = "Địa chỉ:";
            this.customInforComponent2.AreaLabel = "Diện tích: ";
            this.customInforComponent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInforComponent2.DescLabel = "Mô tả:";
            this.customInforComponent2.Dock = System.Windows.Forms.DockStyle.Top;
            this.customInforComponent2.HomeLink = "Tên nhà";
            this.customInforComponent2.Location = new System.Drawing.Point(0, 628);
            this.customInforComponent2.Margin = new System.Windows.Forms.Padding(2);
            this.customInforComponent2.MoneyLabel = "Số tiền: ";
            this.customInforComponent2.Name = "customInforComponent2";
            this.customInforComponent2.PictureBox = ((System.Drawing.Image)(resources.GetObject("customInforComponent2.PictureBox")));
            this.customInforComponent2.PostID = "postID";
            this.customInforComponent2.Size = new System.Drawing.Size(1743, 314);
            this.customInforComponent2.TabIndex = 20;
            // 
            // customInforComponent1
            // 
            this.customInforComponent1.AddressLabel = "Địa chỉ:";
            this.customInforComponent1.AreaLabel = "Diện tích: ";
            this.customInforComponent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInforComponent1.DescLabel = "Mô tả:";
            this.customInforComponent1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customInforComponent1.HomeLink = "Tên nhà";
            this.customInforComponent1.Location = new System.Drawing.Point(0, 314);
            this.customInforComponent1.Margin = new System.Windows.Forms.Padding(2);
            this.customInforComponent1.MoneyLabel = "Số tiền: ";
            this.customInforComponent1.Name = "customInforComponent1";
            this.customInforComponent1.PictureBox = ((System.Drawing.Image)(resources.GetObject("customInforComponent1.PictureBox")));
            this.customInforComponent1.PostID = "postID";
            this.customInforComponent1.Size = new System.Drawing.Size(1743, 314);
            this.customInforComponent1.TabIndex = 19;
            // 
            // customInforComponent5
            // 
            this.customInforComponent5.AddressLabel = "Địa chỉ:";
            this.customInforComponent5.AreaLabel = "Diện tích: ";
            this.customInforComponent5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInforComponent5.DescLabel = "Mô tả:";
            this.customInforComponent5.Dock = System.Windows.Forms.DockStyle.Top;
            this.customInforComponent5.HomeLink = "Tên nhà";
            this.customInforComponent5.Location = new System.Drawing.Point(0, 0);
            this.customInforComponent5.Margin = new System.Windows.Forms.Padding(2);
            this.customInforComponent5.MoneyLabel = "Số tiền: ";
            this.customInforComponent5.Name = "customInforComponent5";
            this.customInforComponent5.PictureBox = ((System.Drawing.Image)(resources.GetObject("customInforComponent5.PictureBox")));
            this.customInforComponent5.PostID = "postID";
            this.customInforComponent5.Size = new System.Drawing.Size(1743, 314);
            this.customInforComponent5.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.nextPageBtn);
            this.panel3.Controls.Add(this.prevPageBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 1570);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1743, 80);
            this.panel3.TabIndex = 12;
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextPageBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.nextPageBtn.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.nextPageBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nextPageBtn.BorderRadius = 30;
            this.nextPageBtn.BorderSize = 0;
            this.nextPageBtn.FlatAppearance.BorderSize = 0;
            this.nextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPageBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPageBtn.ForeColor = System.Drawing.Color.White;
            this.nextPageBtn.Location = new System.Drawing.Point(1201, 14);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(200, 50);
            this.nextPageBtn.TabIndex = 32;
            this.nextPageBtn.Text = "Trang sau";
            this.nextPageBtn.TextColor = System.Drawing.Color.White;
            this.nextPageBtn.UseVisualStyleBackColor = false;
            // 
            // prevPageBtn
            // 
            this.prevPageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevPageBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.prevPageBtn.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.prevPageBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.prevPageBtn.BorderRadius = 30;
            this.prevPageBtn.BorderSize = 0;
            this.prevPageBtn.FlatAppearance.BorderSize = 0;
            this.prevPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevPageBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevPageBtn.ForeColor = System.Drawing.Color.White;
            this.prevPageBtn.Location = new System.Drawing.Point(299, 14);
            this.prevPageBtn.Name = "prevPageBtn";
            this.prevPageBtn.Size = new System.Drawing.Size(200, 50);
            this.prevPageBtn.TabIndex = 31;
            this.prevPageBtn.Text = "Trang trước";
            this.prevPageBtn.TextColor = System.Drawing.Color.White;
            this.prevPageBtn.UseVisualStyleBackColor = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1034, 626);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomComponent.CustomButton resetBtn;
        private CustomComponent.CustomButton searchBtn;
        private CustomComponents.CustomComboBox cbb_PageNumber;
        private CustomComponents.CustomComboBox cbb_Sort;
        private CustomComponents.CustomComboBox cbb_Area;
        private CustomComponents.CustomComboBox cbb_Price;
        private CustomComponents.CustomComboBox cbb_Ward;
        private CustomComponents.CustomComboBox cbb_District;
        private System.Windows.Forms.Panel panel3;
        private CustomComponent.CustomButton nextPageBtn;
        private CustomComponent.CustomButton prevPageBtn;
        private CustomComponent.CustomInforComponent customInforComponent5;
        private CustomComponent.CustomInforComponent customInforComponent1;
        private CustomComponent.CustomInforComponent customInforComponent4;
        private CustomComponent.CustomInforComponent customInforComponent3;
        private CustomComponent.CustomInforComponent customInforComponent2;
    }
}