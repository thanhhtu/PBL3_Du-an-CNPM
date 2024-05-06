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
            this.BtnReset = new PBL3.Views.CustomComponent.CustomButton();
            this.btnSearch = new PBL3.Views.CustomComponent.CustomButton();
            this.cbbArea = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbbPrice = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbbWard = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbbDistrict = new PBL3.Views.CustomComponents.CustomComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customInforComponent5 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.customInforComponent4 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.customInforComponent3 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.customInforComponent2 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.customInforComponent1 = new PBL3.Views.CustomComponent.CustomInforComponent();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnNextPage = new PBL3.Views.CustomComponent.CustomButton();
            this.BtnPrevPage = new PBL3.Views.CustomComponent.CustomButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbSort);
            this.panel1.Controls.Add(this.cbbPageNumber);
            this.panel1.Controls.Add(this.BtnReset);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cbbArea);
            this.panel1.Controls.Add(this.cbbPrice);
            this.panel1.Controls.Add(this.cbbWard);
            this.panel1.Controls.Add(this.cbbDistrict);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1764, 130);
            this.panel1.TabIndex = 20;
            // 
            // cbbSort
            // 
            this.cbbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbSort.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbSort.BorderSize = 3;
            this.cbbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSort.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbSort.ForeColor = System.Drawing.Color.DimGray;
            this.cbbSort.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbSort.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbSort.ListTextColor = System.Drawing.Color.Black;
            this.cbbSort.Location = new System.Drawing.Point(62, 11);
            this.cbbSort.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Padding = new System.Windows.Forms.Padding(3);
            this.cbbSort.Size = new System.Drawing.Size(255, 40);
            this.cbbSort.TabIndex = 1;
            this.cbbSort.Texts = "Sắp xếp theo";
            // 
            // cbbPageNumber
            // 
            this.cbbPageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbPageNumber.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbPageNumber.BorderSize = 3;
            this.cbbPageNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPageNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbPageNumber.ForeColor = System.Drawing.Color.DimGray;
            this.cbbPageNumber.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbPageNumber.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbPageNumber.ListTextColor = System.Drawing.Color.Black;
            this.cbbPageNumber.Location = new System.Drawing.Point(362, 11);
            this.cbbPageNumber.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbPageNumber.Name = "cbbPageNumber";
            this.cbbPageNumber.Padding = new System.Windows.Forms.Padding(3);
            this.cbbPageNumber.Size = new System.Drawing.Size(255, 40);
            this.cbbPageNumber.TabIndex = 2;
            this.cbbPageNumber.Texts = "Trang";
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnReset.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnReset.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.BtnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnReset.BorderRadius = 25;
            this.BtnReset.BorderSize = 0;
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.Black;
            this.BtnReset.Location = new System.Drawing.Point(1522, 66);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(180, 50);
            this.BtnReset.TabIndex = 8;
            this.BtnReset.Text = "Đặt lại";
            this.BtnReset.TextColor = System.Drawing.Color.Black;
            this.BtnReset.UseVisualStyleBackColor = false;
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
            this.btnSearch.Location = new System.Drawing.Point(1309, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 50);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cbbArea
            // 
            this.cbbArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbArea.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbArea.BorderSize = 3;
            this.cbbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbArea.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbArea.ForeColor = System.Drawing.Color.DimGray;
            this.cbbArea.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbArea.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbArea.ListTextColor = System.Drawing.Color.Black;
            this.cbbArea.Location = new System.Drawing.Point(962, 74);
            this.cbbArea.MinimumSize = new System.Drawing.Size(200, 40);
            this.cbbArea.Name = "cbbArea";
            this.cbbArea.Padding = new System.Windows.Forms.Padding(3);
            this.cbbArea.Size = new System.Drawing.Size(255, 40);
            this.cbbArea.TabIndex = 6;
            this.cbbArea.Texts = "Chọn diện tích";
            // 
            // cbbPrice
            // 
            this.cbbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbPrice.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbPrice.BorderSize = 3;
            this.cbbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbPrice.ForeColor = System.Drawing.Color.DimGray;
            this.cbbPrice.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbPrice.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbPrice.ListTextColor = System.Drawing.Color.Black;
            this.cbbPrice.Location = new System.Drawing.Point(662, 74);
            this.cbbPrice.MinimumSize = new System.Drawing.Size(200, 40);
            this.cbbPrice.Name = "cbbPrice";
            this.cbbPrice.Padding = new System.Windows.Forms.Padding(3);
            this.cbbPrice.Size = new System.Drawing.Size(255, 40);
            this.cbbPrice.TabIndex = 5;
            this.cbbPrice.Texts = "Chọn giá";
            // 
            // cbbWard
            // 
            this.cbbWard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbWard.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbWard.BorderSize = 3;
            this.cbbWard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWard.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbWard.ForeColor = System.Drawing.Color.DimGray;
            this.cbbWard.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbWard.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbWard.ListTextColor = System.Drawing.Color.Black;
            this.cbbWard.Location = new System.Drawing.Point(362, 74);
            this.cbbWard.MinimumSize = new System.Drawing.Size(200, 40);
            this.cbbWard.Name = "cbbWard";
            this.cbbWard.Padding = new System.Windows.Forms.Padding(3);
            this.cbbWard.Size = new System.Drawing.Size(255, 40);
            this.cbbWard.TabIndex = 4;
            this.cbbWard.Texts = "Chọn phường";
            // 
            // cbbDistrict
            // 
            this.cbbDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbDistrict.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbDistrict.BorderSize = 3;
            this.cbbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDistrict.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbDistrict.ForeColor = System.Drawing.Color.DimGray;
            this.cbbDistrict.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbDistrict.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbDistrict.ListTextColor = System.Drawing.Color.Black;
            this.cbbDistrict.Location = new System.Drawing.Point(62, 74);
            this.cbbDistrict.MinimumSize = new System.Drawing.Size(200, 40);
            this.cbbDistrict.Name = "cbbDistrict";
            this.cbbDistrict.Padding = new System.Windows.Forms.Padding(3);
            this.cbbDistrict.Size = new System.Drawing.Size(255, 40);
            this.cbbDistrict.TabIndex = 3;
            this.cbbDistrict.Texts = "Chọn quận";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.customInforComponent5);
            this.panel2.Controls.Add(this.customInforComponent4);
            this.panel2.Controls.Add(this.customInforComponent3);
            this.panel2.Controls.Add(this.customInforComponent2);
            this.panel2.Controls.Add(this.customInforComponent1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1764, 467);
            this.panel2.TabIndex = 13;
            // 
            // customInforComponent5
            // 
            this.customInforComponent5.AddressLabel = "Địa chỉ:";
            this.customInforComponent5.AreaLabel = "Diện tích: ";
            this.customInforComponent5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInforComponent5.DescLabel = "Mô tả:";
            this.customInforComponent5.Dock = System.Windows.Forms.DockStyle.Top;
            this.customInforComponent5.HomeLink = "Tên nhà";
            this.customInforComponent5.Location = new System.Drawing.Point(0, 1256);
            this.customInforComponent5.Margin = new System.Windows.Forms.Padding(2);
            this.customInforComponent5.MoneyLabel = "Số tiền: ";
            this.customInforComponent5.Name = "customInforComponent5";
            this.customInforComponent5.PictureBox = ((System.Drawing.Image)(resources.GetObject("customInforComponent5.PictureBox")));
            this.customInforComponent5.PostID = "postID";
            this.customInforComponent5.Size = new System.Drawing.Size(1743, 314);
            this.customInforComponent5.TabIndex = 13;
            // 
            // customInforComponent4
            // 
            this.customInforComponent4.AddressLabel = "Địa chỉ:";
            this.customInforComponent4.AreaLabel = "Diện tích: ";
            this.customInforComponent4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInforComponent4.DescLabel = "Mô tả:";
            this.customInforComponent4.Dock = System.Windows.Forms.DockStyle.Top;
            this.customInforComponent4.HomeLink = "Tên nhà";
            this.customInforComponent4.Location = new System.Drawing.Point(0, 942);
            this.customInforComponent4.Margin = new System.Windows.Forms.Padding(2);
            this.customInforComponent4.MoneyLabel = "Số tiền: ";
            this.customInforComponent4.Name = "customInforComponent4";
            this.customInforComponent4.PictureBox = ((System.Drawing.Image)(resources.GetObject("customInforComponent4.PictureBox")));
            this.customInforComponent4.PostID = "postID";
            this.customInforComponent4.Size = new System.Drawing.Size(1743, 314);
            this.customInforComponent4.TabIndex = 12;
            // 
            // customInforComponent3
            // 
            this.customInforComponent3.AddressLabel = "Địa chỉ:";
            this.customInforComponent3.AreaLabel = "Diện tích: ";
            this.customInforComponent3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInforComponent3.DescLabel = "Mô tả:";
            this.customInforComponent3.Dock = System.Windows.Forms.DockStyle.Top;
            this.customInforComponent3.HomeLink = "Tên nhà";
            this.customInforComponent3.Location = new System.Drawing.Point(0, 628);
            this.customInforComponent3.Margin = new System.Windows.Forms.Padding(2);
            this.customInforComponent3.MoneyLabel = "Số tiền: ";
            this.customInforComponent3.Name = "customInforComponent3";
            this.customInforComponent3.PictureBox = ((System.Drawing.Image)(resources.GetObject("customInforComponent3.PictureBox")));
            this.customInforComponent3.PostID = "postID";
            this.customInforComponent3.Size = new System.Drawing.Size(1743, 314);
            this.customInforComponent3.TabIndex = 11;
            // 
            // customInforComponent2
            // 
            this.customInforComponent2.AddressLabel = "Địa chỉ:";
            this.customInforComponent2.AreaLabel = "Diện tích: ";
            this.customInforComponent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInforComponent2.DescLabel = "Mô tả:";
            this.customInforComponent2.Dock = System.Windows.Forms.DockStyle.Top;
            this.customInforComponent2.HomeLink = "Tên nhà";
            this.customInforComponent2.Location = new System.Drawing.Point(0, 314);
            this.customInforComponent2.Margin = new System.Windows.Forms.Padding(2);
            this.customInforComponent2.MoneyLabel = "Số tiền: ";
            this.customInforComponent2.Name = "customInforComponent2";
            this.customInforComponent2.PictureBox = ((System.Drawing.Image)(resources.GetObject("customInforComponent2.PictureBox")));
            this.customInforComponent2.PostID = "postID";
            this.customInforComponent2.Size = new System.Drawing.Size(1743, 314);
            this.customInforComponent2.TabIndex = 10;
            // 
            // customInforComponent1
            // 
            this.customInforComponent1.AddressLabel = "Địa chỉ:";
            this.customInforComponent1.AreaLabel = "Diện tích: ";
            this.customInforComponent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customInforComponent1.DescLabel = "Mô tả:";
            this.customInforComponent1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customInforComponent1.HomeLink = "Tên nhà";
            this.customInforComponent1.Location = new System.Drawing.Point(0, 0);
            this.customInforComponent1.Margin = new System.Windows.Forms.Padding(2);
            this.customInforComponent1.MoneyLabel = "Số tiền: ";
            this.customInforComponent1.Name = "customInforComponent1";
            this.customInforComponent1.PictureBox = ((System.Drawing.Image)(resources.GetObject("customInforComponent1.PictureBox")));
            this.customInforComponent1.PostID = "postID";
            this.customInforComponent1.Size = new System.Drawing.Size(1743, 314);
            this.customInforComponent1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.BtnNextPage);
            this.panel3.Controls.Add(this.BtnPrevPage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 1570);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1743, 80);
            this.panel3.TabIndex = 21;
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNextPage.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnNextPage.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.BtnNextPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnNextPage.BorderRadius = 30;
            this.BtnNextPage.BorderSize = 0;
            this.BtnNextPage.FlatAppearance.BorderSize = 0;
            this.BtnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextPage.ForeColor = System.Drawing.Color.White;
            this.BtnNextPage.Location = new System.Drawing.Point(1201, 14);
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.Size = new System.Drawing.Size(200, 50);
            this.BtnNextPage.TabIndex = 15;
            this.BtnNextPage.Text = "Trang sau";
            this.BtnNextPage.TextColor = System.Drawing.Color.White;
            this.BtnNextPage.UseVisualStyleBackColor = false;
            // 
            // BtnPrevPage
            // 
            this.BtnPrevPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPrevPage.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnPrevPage.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.BtnPrevPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnPrevPage.BorderRadius = 30;
            this.BtnPrevPage.BorderSize = 0;
            this.BtnPrevPage.FlatAppearance.BorderSize = 0;
            this.BtnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevPage.ForeColor = System.Drawing.Color.White;
            this.BtnPrevPage.Location = new System.Drawing.Point(299, 14);
            this.BtnPrevPage.Name = "BtnPrevPage";
            this.BtnPrevPage.Size = new System.Drawing.Size(200, 50);
            this.BtnPrevPage.TabIndex = 14;
            this.BtnPrevPage.Text = "Trang trước";
            this.BtnPrevPage.TextColor = System.Drawing.Color.White;
            this.BtnPrevPage.UseVisualStyleBackColor = false;
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
        private CustomComponent.CustomButton BtnReset;
        private CustomComponent.CustomButton btnSearch;
        private CustomComponents.CustomComboBox cbbArea;
        private CustomComponents.CustomComboBox cbbPrice;
        private CustomComponents.CustomComboBox cbbWard;
        private CustomComponents.CustomComboBox cbbDistrict;
        private System.Windows.Forms.Panel panel3;
        private CustomComponent.CustomButton BtnNextPage;
        private CustomComponent.CustomButton BtnPrevPage;
        private CustomComponent.CustomInforComponent customInforComponent1;
        private CustomComponent.CustomInforComponent customInforComponent2;
        private CustomComponent.CustomInforComponent customInforComponent5;
        private CustomComponent.CustomInforComponent customInforComponent4;
        private CustomComponent.CustomInforComponent customInforComponent3;
        private CustomComponents.CustomComboBox cbbPageNumber;
        private CustomComponents.CustomComboBox cbbSort;
    }
}