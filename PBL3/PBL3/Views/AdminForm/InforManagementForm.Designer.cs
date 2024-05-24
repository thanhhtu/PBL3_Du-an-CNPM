namespace PBL3.Views.AdminForm
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
            this.btnSearch = new PBL3.Views.CustomComponent.CustomButton();
            this.btnReverse = new PBL3.Views.CustomComponent.CustomButton();
            this.cbbSort = new PBL3.Views.CustomComponents.CustomComboBox();
            this.cbbPostedFilter = new PBL3.Views.CustomComponents.CustomComboBox();
            this.txtSearch = new PBL3.Views.CustomComponent.CustomTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteInfor = new PBL3.Views.CustomComponent.CustomButton();
            this.btnReadInfor = new PBL3.Views.CustomComponent.CustomButton();
            this.btnViewUser = new PBL3.Views.CustomComponent.CustomButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelMenu.Controls.Add(this.btnSearch);
            this.panelMenu.Controls.Add(this.btnReverse);
            this.panelMenu.Controls.Add(this.cbbSort);
            this.panelMenu.Controls.Add(this.cbbPostedFilter);
            this.panelMenu.Controls.Add(this.txtSearch);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1411, 80);
            this.panelMenu.TabIndex = 20;
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
            this.btnSearch.Location = new System.Drawing.Point(1212, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 48);
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
            this.btnReverse.Location = new System.Drawing.Point(1127, 14);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(56, 48);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.TextColor = System.Drawing.Color.White;
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // cbbSort
            // 
            this.cbbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.cbbSort.Location = new System.Drawing.Point(870, 20);
            this.cbbSort.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Padding = new System.Windows.Forms.Padding(2);
            this.cbbSort.Size = new System.Drawing.Size(251, 40);
            this.cbbSort.TabIndex = 3;
            this.cbbSort.Texts = "Sắp xếp theo";
            this.cbbSort.OnSelectionChangedCommited += new System.EventHandler(this.cbbSort_OnSelectionChangedCommited);
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
            this.cbbPostedFilter.Location = new System.Drawing.Point(546, 20);
            this.cbbPostedFilter.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbPostedFilter.Name = "cbbPostedFilter";
            this.cbbPostedFilter.Padding = new System.Windows.Forms.Padding(2);
            this.cbbPostedFilter.Size = new System.Drawing.Size(306, 40);
            this.cbbPostedFilter.TabIndex = 2;
            this.cbbPostedFilter.Texts = "Chọn bộ lọc";
            this.cbbPostedFilter.OnSelectionChangedCommited += new System.EventHandler(this.cbbPostedFilter_OnSelectionChangedCommited);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoSize = true;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.txtSearch.BorderRadius = 6;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(36, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Nhập nội dung cần tìm";
            this.txtSearch.Size = new System.Drawing.Size(480, 36);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDeleteInfor);
            this.panel1.Controls.Add(this.btnReadInfor);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 90);
            this.panel1.TabIndex = 21;
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
            this.btnDeleteInfor.Location = new System.Drawing.Point(981, 11);
            this.btnDeleteInfor.Name = "btnDeleteInfor";
            this.btnDeleteInfor.Size = new System.Drawing.Size(228, 56);
            this.btnDeleteInfor.TabIndex = 8;
            this.btnDeleteInfor.Text = "Xóa thông tin trọ";
            this.btnDeleteInfor.TextColor = System.Drawing.Color.White;
            this.btnDeleteInfor.UseVisualStyleBackColor = false;
            this.btnDeleteInfor.Click += new System.EventHandler(this.btnDeleteInfor_Click);
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
            this.btnReadInfor.Location = new System.Drawing.Point(574, 11);
            this.btnReadInfor.Name = "btnReadInfor";
            this.btnReadInfor.Size = new System.Drawing.Size(228, 56);
            this.btnReadInfor.TabIndex = 7;
            this.btnReadInfor.Text = "Thông tin trọ";
            this.btnReadInfor.TextColor = System.Drawing.Color.White;
            this.btnReadInfor.UseVisualStyleBackColor = false;
            this.btnReadInfor.Click += new System.EventHandler(this.btnReadInfor_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnViewUser.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnViewUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnViewUser.BorderRadius = 30;
            this.btnViewUser.BorderSize = 0;
            this.btnViewUser.FlatAppearance.BorderSize = 0;
            this.btnViewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Location = new System.Drawing.Point(164, 11);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(228, 56);
            this.btnViewUser.TabIndex = 6;
            this.btnViewUser.Text = "Thông tin chủ trọ";
            this.btnViewUser.TextColor = System.Drawing.Color.White;
            this.btnViewUser.UseVisualStyleBackColor = false;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1411, 493);
            this.dgv.TabIndex = 22;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 63;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1411, 493);
            this.panel2.TabIndex = 28;
            // 
            // InforManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Panel panel1;
        private CustomComponent.CustomButton btnDeleteInfor;
        private CustomComponent.CustomButton btnReadInfor;
        private CustomComponent.CustomButton btnViewUser;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel2;
        private CustomComponent.CustomButton btnSearch;
        private CustomComponent.CustomButton btnReverse;
        private CustomComponents.CustomComboBox cbbSort;
        private CustomComponents.CustomComboBox cbbPostedFilter;
        private CustomComponent.CustomTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
    }
}
