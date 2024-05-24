namespace PBL3.Views.LandlordForm
{
    partial class InforManagementForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPostInfor = new PBL3.Views.CustomComponent.CustomButton();
            this.btnSearch = new PBL3.Views.CustomComponent.CustomButton();
            this.btnReverse = new PBL3.Views.CustomComponent.CustomButton();
            this.cbbSort = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbbPostedFilter = new PBL3.Views.CustomComponents.CustomComboBox();
            this.txtSearch = new PBL3.Views.CustomComponent.CustomTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModifiedHistory = new PBL3.Views.CustomComponent.CustomButton();
            this.btnDeleteInfor = new PBL3.Views.CustomComponent.CustomButton();
            this.btnUpdateInfor = new PBL3.Views.CustomComponent.CustomButton();
            this.btnReadInfor = new PBL3.Views.CustomComponent.CustomButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnPostInfor);
            this.panelMenu.Controls.Add(this.btnSearch);
            this.panelMenu.Controls.Add(this.btnReverse);
            this.panelMenu.Controls.Add(this.cbbSort);
            this.panelMenu.Controls.Add(this.cbbPostedFilter);
            this.panelMenu.Controls.Add(this.txtSearch);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1141, 65);
            this.panelMenu.TabIndex = 29;
            // 
            // btnPostInfor
            // 
            this.btnPostInfor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPostInfor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPostInfor.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnPostInfor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPostInfor.BorderRadius = 30;
            this.btnPostInfor.BorderSize = 0;
            this.btnPostInfor.FlatAppearance.BorderSize = 0;
            this.btnPostInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostInfor.ForeColor = System.Drawing.Color.White;
            this.btnPostInfor.Location = new System.Drawing.Point(985, 15);
            this.btnPostInfor.Margin = new System.Windows.Forms.Padding(2);
            this.btnPostInfor.Name = "btnPostInfor";
            this.btnPostInfor.Size = new System.Drawing.Size(139, 39);
            this.btnPostInfor.TabIndex = 21;
            this.btnPostInfor.Text = "Đăng thông tin";
            this.btnPostInfor.TextColor = System.Drawing.Color.White;
            this.btnPostInfor.UseVisualStyleBackColor = false;
            this.btnPostInfor.Click += new System.EventHandler(this.btnPostInfor_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 30;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(847, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 39);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnReverse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnReverse.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReverse.BorderRadius = 0;
            this.btnReverse.BorderSize = 0;
            this.btnReverse.FlatAppearance.BorderSize = 0;
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReverse.ForeColor = System.Drawing.Color.White;
            this.btnReverse.Image = global::PBL3.Properties.Resources.reverse;
            this.btnReverse.Location = new System.Drawing.Point(818, 9);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(2);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(42, 39);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.TextColor = System.Drawing.Color.White;
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
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
            "Thời gian tạo",
            "Thời gian chỉnh sửa",
            "Số bình luận"});
            this.cbbSort.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbSort.ListTextColor = System.Drawing.Color.Black;
            this.cbbSort.Location = new System.Drawing.Point(631, 15);
            this.cbbSort.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSort.MinimumSize = new System.Drawing.Size(150, 24);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Padding = new System.Windows.Forms.Padding(2);
            this.cbbSort.Size = new System.Drawing.Size(182, 32);
            this.cbbSort.TabIndex = 3;
            this.cbbSort.Texts = "Sắp xếp theo";
            this.cbbSort.OnSelectedIndexChanged += new System.EventHandler(this.cbbSort_OnSelectedIndexChanged);
            // 
            // cbbPostedFilter
            // 
            this.cbbPostedFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbPostedFilter.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbPostedFilter.BorderSize = 2;
            this.cbbPostedFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPostedFilter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbPostedFilter.ForeColor = System.Drawing.Color.DimGray;
            this.cbbPostedFilter.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbPostedFilter.Items.AddRange(new object[] {
            "Tất cả thông tin trọ",
            "Trọ chưa được cho thuê",
            "Trọ đã cho thuê",
            "Thông tin trọ đã có chỉnh sửa"});
            this.cbbPostedFilter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbPostedFilter.ListTextColor = System.Drawing.Color.Black;
            this.cbbPostedFilter.Location = new System.Drawing.Point(357, 15);
            this.cbbPostedFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbbPostedFilter.MinimumSize = new System.Drawing.Size(150, 24);
            this.cbbPostedFilter.Name = "cbbPostedFilter";
            this.cbbPostedFilter.Padding = new System.Windows.Forms.Padding(2);
            this.cbbPostedFilter.Size = new System.Drawing.Size(242, 32);
            this.cbbPostedFilter.TabIndex = 2;
            this.cbbPostedFilter.Texts = "Chọn bộ lọc";
            this.cbbPostedFilter.OnSelectedIndexChanged += new System.EventHandler(this.cbbPostedFilter_OnSelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.AutoSize = true;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.txtSearch.BorderRadius = 6;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(22, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Nhập nội dung cần tìm";
            this.txtSearch.Size = new System.Drawing.Size(291, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnModifiedHistory);
            this.panel1.Controls.Add(this.btnDeleteInfor);
            this.panel1.Controls.Add(this.btnUpdateInfor);
            this.panel1.Controls.Add(this.btnReadInfor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 74);
            this.panel1.TabIndex = 28;
            // 
            // btnModifiedHistory
            // 
            this.btnModifiedHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifiedHistory.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModifiedHistory.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnModifiedHistory.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModifiedHistory.BorderRadius = 30;
            this.btnModifiedHistory.BorderSize = 0;
            this.btnModifiedHistory.FlatAppearance.BorderSize = 0;
            this.btnModifiedHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifiedHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifiedHistory.ForeColor = System.Drawing.Color.White;
            this.btnModifiedHistory.Location = new System.Drawing.Point(514, 9);
            this.btnModifiedHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifiedHistory.Name = "btnModifiedHistory";
            this.btnModifiedHistory.Size = new System.Drawing.Size(194, 46);
            this.btnModifiedHistory.TabIndex = 9;
            this.btnModifiedHistory.Text = "Xem lịch sử cho thuê";
            this.btnModifiedHistory.TextColor = System.Drawing.Color.White;
            this.btnModifiedHistory.UseVisualStyleBackColor = false;
            this.btnModifiedHistory.Click += new System.EventHandler(this.btnModifiedHistory_Click);
            // 
            // btnDeleteInfor
            // 
            this.btnDeleteInfor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteInfor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteInfor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteInfor.BorderRadius = 30;
            this.btnDeleteInfor.BorderSize = 0;
            this.btnDeleteInfor.FlatAppearance.BorderSize = 0;
            this.btnDeleteInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInfor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInfor.Location = new System.Drawing.Point(762, 9);
            this.btnDeleteInfor.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteInfor.Name = "btnDeleteInfor";
            this.btnDeleteInfor.Size = new System.Drawing.Size(171, 46);
            this.btnDeleteInfor.TabIndex = 8;
            this.btnDeleteInfor.Text = "Xóa thông tin trọ";
            this.btnDeleteInfor.TextColor = System.Drawing.Color.White;
            this.btnDeleteInfor.UseVisualStyleBackColor = false;
            this.btnDeleteInfor.Click += new System.EventHandler(this.btnDeleteInfor_Click);
            // 
            // btnUpdateInfor
            // 
            this.btnUpdateInfor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateInfor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateInfor.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateInfor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdateInfor.BorderRadius = 30;
            this.btnUpdateInfor.BorderSize = 0;
            this.btnUpdateInfor.FlatAppearance.BorderSize = 0;
            this.btnUpdateInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfor.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInfor.Location = new System.Drawing.Point(256, 9);
            this.btnUpdateInfor.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateInfor.Name = "btnUpdateInfor";
            this.btnUpdateInfor.Size = new System.Drawing.Size(194, 46);
            this.btnUpdateInfor.TabIndex = 7;
            this.btnUpdateInfor.Text = "Cập nhật thông tin trọ";
            this.btnUpdateInfor.TextColor = System.Drawing.Color.White;
            this.btnUpdateInfor.UseVisualStyleBackColor = false;
            this.btnUpdateInfor.Click += new System.EventHandler(this.btnUpdateInfor_Click);
            // 
            // btnReadInfor
            // 
            this.btnReadInfor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReadInfor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReadInfor.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnReadInfor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReadInfor.BorderRadius = 30;
            this.btnReadInfor.BorderSize = 0;
            this.btnReadInfor.FlatAppearance.BorderSize = 0;
            this.btnReadInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadInfor.ForeColor = System.Drawing.Color.White;
            this.btnReadInfor.Location = new System.Drawing.Point(21, 9);
            this.btnReadInfor.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadInfor.Name = "btnReadInfor";
            this.btnReadInfor.Size = new System.Drawing.Size(171, 46);
            this.btnReadInfor.TabIndex = 6;
            this.btnReadInfor.Text = "Xem thông tin trọ";
            this.btnReadInfor.TextColor = System.Drawing.Color.White;
            this.btnReadInfor.UseVisualStyleBackColor = false;
            this.btnReadInfor.Click += new System.EventHandler(this.btnReadInfor_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1141, 361);
            this.dgv.TabIndex = 30;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 53;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 361);
            this.panel2.TabIndex = 31;
            // 
            // InforManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InforManagementForm";
            this.Text = "InforManagementForm";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private CustomComponent.CustomButton btnSearch;
        private CustomComponent.CustomButton btnReverse;
        private CustomComponents.CustomComboBox cbbSort;
        private CustomComponents.CustomComboBox cbbPostedFilter;
        private CustomComponent.CustomTextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private CustomComponent.CustomButton btnDeleteInfor;
        private CustomComponent.CustomButton btnUpdateInfor;
        private CustomComponent.CustomButton btnReadInfor;
        private System.Windows.Forms.DataGridView dgv;
        private CustomComponent.CustomButton btnPostInfor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private CustomComponent.CustomButton btnModifiedHistory;
    }
}