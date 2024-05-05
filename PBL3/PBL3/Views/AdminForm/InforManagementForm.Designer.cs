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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new PBL3.Views.CustomComponent.CustomButton();
            this.reverseBtn = new PBL3.Views.CustomComponent.CustomButton();
            this.sortCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.postedFilterCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.txtSearch = new PBL3.Views.CustomComponent.CustomTextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.deleteBtn = new PBL3.Views.CustomComponent.CustomButton();
            this.readBtn = new PBL3.Views.CustomComponent.CustomButton();
            this.viewUserBtn = new PBL3.Views.CustomComponent.CustomButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.reverseBtn);
            this.panel1.Controls.Add(this.sortCbb);
            this.panel1.Controls.Add(this.postedFilterCbb);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 80);
            this.panel1.TabIndex = 26;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.searchBtn.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 30;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Location = new System.Drawing.Point(1212, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(159, 48);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.TextColor = System.Drawing.Color.Black;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // reverseBtn
            // 
            this.reverseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.reverseBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.reverseBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.reverseBtn.BorderRadius = 0;
            this.reverseBtn.BorderSize = 0;
            this.reverseBtn.FlatAppearance.BorderSize = 0;
            this.reverseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reverseBtn.ForeColor = System.Drawing.Color.White;
            this.reverseBtn.Image = global::PBL3.Properties.Resources.reverse;
            this.reverseBtn.Location = new System.Drawing.Point(1122, 18);
            this.reverseBtn.Name = "reverseBtn";
            this.reverseBtn.Size = new System.Drawing.Size(56, 48);
            this.reverseBtn.TabIndex = 20;
            this.reverseBtn.TextColor = System.Drawing.Color.White;
            this.reverseBtn.UseVisualStyleBackColor = false;
            // 
            // sortCbb
            // 
            this.sortCbb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortCbb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.sortCbb.BorderColor = System.Drawing.Color.SteelBlue;
            this.sortCbb.BorderSize = 3;
            this.sortCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortCbb.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sortCbb.ForeColor = System.Drawing.Color.DimGray;
            this.sortCbb.IconColor = System.Drawing.Color.SteelBlue;
            this.sortCbb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.sortCbb.ListTextColor = System.Drawing.Color.Black;
            this.sortCbb.Location = new System.Drawing.Point(870, 18);
            this.sortCbb.MinimumSize = new System.Drawing.Size(200, 30);
            this.sortCbb.Name = "sortCbb";
            this.sortCbb.Padding = new System.Windows.Forms.Padding(3);
            this.sortCbb.Size = new System.Drawing.Size(220, 40);
            this.sortCbb.TabIndex = 19;
            this.sortCbb.Texts = "Sắp xếp";
            // 
            // postedFilterCbb
            // 
            this.postedFilterCbb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postedFilterCbb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.postedFilterCbb.BorderColor = System.Drawing.Color.SteelBlue;
            this.postedFilterCbb.BorderSize = 3;
            this.postedFilterCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postedFilterCbb.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.postedFilterCbb.ForeColor = System.Drawing.Color.DimGray;
            this.postedFilterCbb.IconColor = System.Drawing.Color.SteelBlue;
            this.postedFilterCbb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.postedFilterCbb.ListTextColor = System.Drawing.Color.Black;
            this.postedFilterCbb.Location = new System.Drawing.Point(602, 18);
            this.postedFilterCbb.MinimumSize = new System.Drawing.Size(200, 30);
            this.postedFilterCbb.Name = "postedFilterCbb";
            this.postedFilterCbb.Padding = new System.Windows.Forms.Padding(3);
            this.postedFilterCbb.Size = new System.Drawing.Size(220, 40);
            this.postedFilterCbb.TabIndex = 18;
            this.postedFilterCbb.Texts = "Chọn bộ lọc";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.AutoSize = true;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 6;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(35, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 4, 7, 4);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Nhập nội dung cần tìm";
            this.txtSearch.Size = new System.Drawing.Size(509, 34);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.deleteBtn);
            this.panelMenu.Controls.Add(this.readBtn);
            this.panelMenu.Controls.Add(this.viewUserBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 563);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1411, 100);
            this.panelMenu.TabIndex = 25;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.BorderRadius = 30;
            this.deleteBtn.BorderSize = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(949, 11);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(228, 56);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Xóa thông tin trọ";
            this.deleteBtn.TextColor = System.Drawing.Color.White;
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // readBtn
            // 
            this.readBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.readBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.readBtn.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.readBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.readBtn.BorderRadius = 30;
            this.readBtn.BorderSize = 0;
            this.readBtn.FlatAppearance.BorderSize = 0;
            this.readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.ForeColor = System.Drawing.Color.White;
            this.readBtn.Location = new System.Drawing.Point(570, 11);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(228, 56);
            this.readBtn.TabIndex = 3;
            this.readBtn.Text = "Xem thông tin trọ";
            this.readBtn.TextColor = System.Drawing.Color.White;
            this.readBtn.UseVisualStyleBackColor = false;
            // 
            // viewUserBtn
            // 
            this.viewUserBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewUserBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.viewUserBtn.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.viewUserBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.viewUserBtn.BorderRadius = 30;
            this.viewUserBtn.BorderSize = 0;
            this.viewUserBtn.FlatAppearance.BorderSize = 0;
            this.viewUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUserBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUserBtn.ForeColor = System.Drawing.Color.White;
            this.viewUserBtn.Location = new System.Drawing.Point(146, 11);
            this.viewUserBtn.Name = "viewUserBtn";
            this.viewUserBtn.Size = new System.Drawing.Size(228, 56);
            this.viewUserBtn.TabIndex = 0;
            this.viewUserBtn.Text = "Thông tin chủ trọ";
            this.viewUserBtn.TextColor = System.Drawing.Color.White;
            this.viewUserBtn.UseVisualStyleBackColor = false;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1411, 663);
            this.dgv.TabIndex = 27;
            // 
            // InforManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dgv);
            this.Name = "InforManagementForm";
            this.Text = "InforManagementForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomComponent.CustomButton searchBtn;
        private CustomComponent.CustomButton reverseBtn;
        private CustomComponents.CustomComboBox sortCbb;
        private CustomComponents.CustomComboBox postedFilterCbb;
        private CustomComponent.CustomTextBox txtSearch;
        private System.Windows.Forms.Panel panelMenu;
        private CustomComponent.CustomButton deleteBtn;
        private CustomComponent.CustomButton readBtn;
        private CustomComponent.CustomButton viewUserBtn;
        private System.Windows.Forms.DataGridView dgv;
    }
}