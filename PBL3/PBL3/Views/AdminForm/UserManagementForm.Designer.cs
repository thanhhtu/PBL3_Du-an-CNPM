namespace PBL3.Views.AdminForm
{
    partial class UserManagementForm
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
            this.cbbUserRole = new PBL3.Views.CustomComponents.CustomComboBox();
            this.txtSearch = new PBL3.Views.CustomComponent.CustomTextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.CLstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActiveUser = new PBL3.Views.CustomComponent.CustomButton();
            this.AcceptLandlord = new PBL3.Views.CustomComponent.CustomButton();
            this.btnPauseUser = new PBL3.Views.CustomComponent.CustomButton();
            this.btnViewUser = new PBL3.Views.CustomComponent.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnSearch);
            this.panelMenu.Controls.Add(this.btnReverse);
            this.panelMenu.Controls.Add(this.cbbSort);
            this.panelMenu.Controls.Add(this.cbbUserRole);
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
            this.btnSearch.Location = new System.Drawing.Point(1240, 14);
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
            this.btnReverse.Location = new System.Drawing.Point(1183, 12);
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
            this.cbbSort.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbSort.BorderSize = 2;
            this.cbbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSort.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbSort.ForeColor = System.Drawing.Color.DimGray;
            this.cbbSort.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbSort.Items.AddRange(new object[] {
            "Thời gian tham gia",
            "Thời gian được duyệt",
            "Số comment",
            "Số phòng trọ"});
            this.cbbSort.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbSort.ListTextColor = System.Drawing.Color.Black;
            this.cbbSort.Location = new System.Drawing.Point(926, 18);
            this.cbbSort.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Padding = new System.Windows.Forms.Padding(2);
            this.cbbSort.Size = new System.Drawing.Size(251, 40);
            this.cbbSort.TabIndex = 3;
            this.cbbSort.Texts = "Sắp xếp theo";
            this.cbbSort.OnSelectionChangedCommited += new System.EventHandler(this.cbbSort_OnSelectionChangedCommited);
            // 
            // cbbUserRole
            // 
            this.cbbUserRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cbbUserRole.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbbUserRole.BorderSize = 2;
            this.cbbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbUserRole.ForeColor = System.Drawing.Color.DimGray;
            this.cbbUserRole.IconColor = System.Drawing.Color.SteelBlue;
            this.cbbUserRole.Items.AddRange(new object[] {
            "Tất cả",
            "Người cho thuê (Đã được duyệt)",
            "Người cho thuê (Chưa được duyệt)",
            "Người đi thuê",
            "Tài khoản bị ngừng hoạt động"});
            this.cbbUserRole.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbUserRole.ListTextColor = System.Drawing.Color.Black;
            this.cbbUserRole.Location = new System.Drawing.Point(539, 18);
            this.cbbUserRole.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbUserRole.Name = "cbbUserRole";
            this.cbbUserRole.Padding = new System.Windows.Forms.Padding(2);
            this.cbbUserRole.Size = new System.Drawing.Size(361, 40);
            this.cbbUserRole.TabIndex = 2;
            this.cbbUserRole.Texts = "Chọn loại tài khoản";
            this.cbbUserRole.OnSelectedIndexChanged += new System.EventHandler(this.cbbUserRole_OnSelectedIndexChanged);
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
            this.txtSearch.Location = new System.Drawing.Point(34, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Nhập nội dung cần tìm";
            this.txtSearch.Size = new System.Drawing.Size(480, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
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
            this.CLstt});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1411, 493);
            this.dgv.TabIndex = 10;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            // 
            // CLstt
            // 
            this.CLstt.HeaderText = "STT";
            this.CLstt.MinimumWidth = 6;
            this.CLstt.Name = "CLstt";
            this.CLstt.ReadOnly = true;
            this.CLstt.Width = 63;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnActiveUser);
            this.panel1.Controls.Add(this.AcceptLandlord);
            this.panel1.Controls.Add(this.btnPauseUser);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 90);
            this.panel1.TabIndex = 21;
            // 
            // btnActiveUser
            // 
            this.btnActiveUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActiveUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnActiveUser.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnActiveUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActiveUser.BorderRadius = 30;
            this.btnActiveUser.BorderSize = 0;
            this.btnActiveUser.FlatAppearance.BorderSize = 0;
            this.btnActiveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiveUser.ForeColor = System.Drawing.Color.Black;
            this.btnActiveUser.Location = new System.Drawing.Point(1057, 11);
            this.btnActiveUser.Name = "btnActiveUser";
            this.btnActiveUser.Size = new System.Drawing.Size(234, 56);
            this.btnActiveUser.TabIndex = 9;
            this.btnActiveUser.Text = "Cho phép hoạt động";
            this.btnActiveUser.TextColor = System.Drawing.Color.Black;
            this.btnActiveUser.UseVisualStyleBackColor = false;
            this.btnActiveUser.Click += new System.EventHandler(this.btnActiveUser_Click);
            // 
            // AcceptLandlord
            // 
            this.AcceptLandlord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AcceptLandlord.BackColor = System.Drawing.Color.SteelBlue;
            this.AcceptLandlord.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.AcceptLandlord.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AcceptLandlord.BorderRadius = 30;
            this.AcceptLandlord.BorderSize = 0;
            this.AcceptLandlord.FlatAppearance.BorderSize = 0;
            this.AcceptLandlord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptLandlord.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptLandlord.ForeColor = System.Drawing.Color.White;
            this.AcceptLandlord.Location = new System.Drawing.Point(438, 11);
            this.AcceptLandlord.Name = "AcceptLandlord";
            this.AcceptLandlord.Size = new System.Drawing.Size(234, 56);
            this.AcceptLandlord.TabIndex = 8;
            this.AcceptLandlord.Text = "Duyệt Chủ Trọ";
            this.AcceptLandlord.TextColor = System.Drawing.Color.White;
            this.AcceptLandlord.UseVisualStyleBackColor = false;
            this.AcceptLandlord.Click += new System.EventHandler(this.AcceptLandlord_Click);
            // 
            // btnPauseUser
            // 
            this.btnPauseUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPauseUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPauseUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPauseUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPauseUser.BorderRadius = 30;
            this.btnPauseUser.BorderSize = 0;
            this.btnPauseUser.FlatAppearance.BorderSize = 0;
            this.btnPauseUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauseUser.ForeColor = System.Drawing.Color.White;
            this.btnPauseUser.Location = new System.Drawing.Point(746, 11);
            this.btnPauseUser.Name = "btnPauseUser";
            this.btnPauseUser.Size = new System.Drawing.Size(243, 56);
            this.btnPauseUser.TabIndex = 7;
            this.btnPauseUser.Text = "Tạm ngưng hoạt động";
            this.btnPauseUser.TextColor = System.Drawing.Color.White;
            this.btnPauseUser.UseVisualStyleBackColor = false;
            this.btnPauseUser.Click += new System.EventHandler(this.btnPauseUser_Click);
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
            this.btnViewUser.Location = new System.Drawing.Point(113, 11);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(270, 56);
            this.btnViewUser.TabIndex = 6;
            this.btnViewUser.Text = "Thông tin người dùng";
            this.btnViewUser.TextColor = System.Drawing.Color.White;
            this.btnViewUser.UseVisualStyleBackColor = false;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1411, 493);
            this.panel2.TabIndex = 31;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UserManagementForm";
            this.Text = "UserManagementForm";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private CustomComponent.CustomButton btnSearch;
        private CustomComponent.CustomButton btnReverse;
        private CustomComponents.CustomComboBox cbbSort;
        private CustomComponents.CustomComboBox cbbUserRole;
        private CustomComponent.CustomTextBox txtSearch;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private CustomComponent.CustomButton btnPauseUser;
        private CustomComponent.CustomButton btnViewUser;
        private System.Windows.Forms.Panel panel2;
        private CustomComponent.CustomButton AcceptLandlord;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLstt;
        private CustomComponent.CustomButton btnActiveUser;
    }
}