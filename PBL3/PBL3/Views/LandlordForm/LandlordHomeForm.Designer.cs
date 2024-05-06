namespace PBL3.Views.LandlordForm
{
    partial class LandlordHomeForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSignOut = new FontAwesome.Sharp.IconButton();
            this.panelUserSubmenu = new System.Windows.Forms.Panel();
            this.btnChangePwd = new FontAwesome.Sharp.IconButton();
            this.btnUserChange = new FontAwesome.Sharp.IconButton();
            this.btnId = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnInforManagement = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUserFullname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelUserSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::PBL3.Properties.Resources.bgrHome;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1039, 675);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.BackColor = System.Drawing.Color.AliceBlue;
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(244, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.panelChildForm.MinimumSize = new System.Drawing.Size(800, 576);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1039, 675);
            this.panelChildForm.TabIndex = 6;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMenu.Controls.Add(this.btnSignOut);
            this.panelMenu.Controls.Add(this.panelUserSubmenu);
            this.panelMenu.Controls.Add(this.btnUser);
            this.panelMenu.Controls.Add(this.btnInforManagement);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(244, 675);
            this.panelMenu.TabIndex = 5;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSignOut.IconColor = System.Drawing.Color.DimGray;
            this.btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignOut.IconSize = 45;
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(0, 539);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSignOut.Size = new System.Drawing.Size(244, 65);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignOut.UseVisualStyleBackColor = false;
            // 
            // panelUserSubmenu
            // 
            this.panelUserSubmenu.Controls.Add(this.btnChangePwd);
            this.panelUserSubmenu.Controls.Add(this.btnUserChange);
            this.panelUserSubmenu.Controls.Add(this.btnId);
            this.panelUserSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserSubmenu.Location = new System.Drawing.Point(0, 374);
            this.panelUserSubmenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelUserSubmenu.Name = "panelUserSubmenu";
            this.panelUserSubmenu.Size = new System.Drawing.Size(244, 165);
            this.panelUserSubmenu.TabIndex = 4;
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.BackColor = System.Drawing.Color.LightBlue;
            this.btnChangePwd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePwd.FlatAppearance.BorderSize = 0;
            this.btnChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePwd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnChangePwd.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnChangePwd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangePwd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnChangePwd.IconSize = 35;
            this.btnChangePwd.Location = new System.Drawing.Point(0, 108);
            this.btnChangePwd.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnChangePwd.Size = new System.Drawing.Size(244, 54);
            this.btnChangePwd.TabIndex = 8;
            this.btnChangePwd.Text = "Đổi mật khẩu";
            this.btnChangePwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePwd.UseVisualStyleBackColor = false;
            // 
            // btnUserChange
            // 
            this.btnUserChange.BackColor = System.Drawing.Color.LightBlue;
            this.btnUserChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserChange.FlatAppearance.BorderSize = 0;
            this.btnUserChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserChange.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUserChange.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btnUserChange.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUserChange.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUserChange.IconSize = 35;
            this.btnUserChange.Location = new System.Drawing.Point(0, 54);
            this.btnUserChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserChange.Name = "btnUserChange";
            this.btnUserChange.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnUserChange.Size = new System.Drawing.Size(244, 54);
            this.btnUserChange.TabIndex = 7;
            this.btnUserChange.Text = "Đổi thông tin cá nhân";
            this.btnUserChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserChange.UseVisualStyleBackColor = false;
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.LightBlue;
            this.btnId.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnId.FlatAppearance.BorderSize = 0;
            this.btnId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnId.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.btnId.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnId.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnId.IconSize = 35;
            this.btnId.Location = new System.Drawing.Point(0, 0);
            this.btnId.Margin = new System.Windows.Forms.Padding(2);
            this.btnId.Name = "btnId";
            this.btnId.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnId.Size = new System.Drawing.Size(244, 54);
            this.btnId.TabIndex = 6;
            this.btnId.Text = "Thông tin cá nhân";
            this.btnId.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnId.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnUser.IconColor = System.Drawing.Color.DimGray;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 45;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 309);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(244, 65);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Cá nhân";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnInforManagement
            // 
            this.btnInforManagement.BackColor = System.Drawing.Color.Gainsboro;
            this.btnInforManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInforManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInforManagement.FlatAppearance.BorderSize = 0;
            this.btnInforManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnInforManagement.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnInforManagement.IconColor = System.Drawing.Color.DimGray;
            this.btnInforManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInforManagement.IconSize = 45;
            this.btnInforManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInforManagement.Location = new System.Drawing.Point(0, 244);
            this.btnInforManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnInforManagement.Name = "btnInforManagement";
            this.btnInforManagement.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInforManagement.Size = new System.Drawing.Size(244, 65);
            this.btnInforManagement.TabIndex = 2;
            this.btnInforManagement.Text = "Quản lý thông tin trọ";
            this.btnInforManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInforManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInforManagement.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.DimGray;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 45;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 179);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(244, 65);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.panel2);
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(244, 179);
            this.panelLogo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelUserFullname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 79);
            this.panel2.TabIndex = 4;
            // 
            // labelUserFullname
            // 
            this.labelUserFullname.BackColor = System.Drawing.Color.Gainsboro;
            this.labelUserFullname.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUserFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUserFullname.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserFullname.ForeColor = System.Drawing.Color.Black;
            this.labelUserFullname.Location = new System.Drawing.Point(0, 44);
            this.labelUserFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserFullname.Name = "labelUserFullname";
            this.labelUserFullname.Size = new System.Drawing.Size(242, 34);
            this.labelUserFullname.TabIndex = 9;
            this.labelUserFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người cho thuê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PBL3.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LandlordHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1285, 683);
            this.Name = "LandlordHomeForm";
            this.Text = "LandlordHomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelUserSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnInforManagement;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUserFullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnSignOut;
        private System.Windows.Forms.Panel panelUserSubmenu;
        private FontAwesome.Sharp.IconButton btnUserChange;
        private FontAwesome.Sharp.IconButton btnId;
        private FontAwesome.Sharp.IconButton btnChangePwd;
    }
}