namespace PBL3.Views.RenterForm
{
    partial class RenterHomeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_UserFullname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.changePwdBtn = new FontAwesome.Sharp.IconButton();
            this.userChangeBtn = new FontAwesome.Sharp.IconButton();
            this.userBtn = new FontAwesome.Sharp.IconButton();
            this.idBtn = new FontAwesome.Sharp.IconButton();
            this.signOutBtn = new FontAwesome.Sharp.IconButton();
            this.panelUserSubmenu = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelUserSubmenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
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
            // label_UserFullname
            // 
            this.label_UserFullname.BackColor = System.Drawing.Color.Gainsboro;
            this.label_UserFullname.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_UserFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_UserFullname.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserFullname.ForeColor = System.Drawing.Color.Black;
            this.label_UserFullname.Location = new System.Drawing.Point(0, 44);
            this.label_UserFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UserFullname.Name = "label_UserFullname";
            this.label_UserFullname.Size = new System.Drawing.Size(242, 34);
            this.label_UserFullname.TabIndex = 3;
            this.label_UserFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_UserFullname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 79);
            this.panel2.TabIndex = 4;
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
            this.label1.TabIndex = 2;
            this.label1.Text = "Người cho thuê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.House;
            this.homeBtn.IconColor = System.Drawing.Color.DimGray;
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeBtn.IconSize = 45;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 179);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.homeBtn.Size = new System.Drawing.Size(244, 65);
            this.homeBtn.TabIndex = 5;
            this.homeBtn.Text = "Trang chủ";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = false;
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
            // changePwdBtn
            // 
            this.changePwdBtn.BackColor = System.Drawing.Color.LightBlue;
            this.changePwdBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.changePwdBtn.FlatAppearance.BorderSize = 0;
            this.changePwdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePwdBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.changePwdBtn.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.changePwdBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changePwdBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.changePwdBtn.IconSize = 35;
            this.changePwdBtn.Location = new System.Drawing.Point(0, 108);
            this.changePwdBtn.Margin = new System.Windows.Forms.Padding(2);
            this.changePwdBtn.Name = "changePwdBtn";
            this.changePwdBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.changePwdBtn.Size = new System.Drawing.Size(244, 54);
            this.changePwdBtn.TabIndex = 4;
            this.changePwdBtn.Text = "Đổi mật khẩu";
            this.changePwdBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changePwdBtn.UseVisualStyleBackColor = false;
            // 
            // userChangeBtn
            // 
            this.userChangeBtn.BackColor = System.Drawing.Color.LightBlue;
            this.userChangeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userChangeBtn.FlatAppearance.BorderSize = 0;
            this.userChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userChangeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.userChangeBtn.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.userChangeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userChangeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.userChangeBtn.IconSize = 35;
            this.userChangeBtn.Location = new System.Drawing.Point(0, 54);
            this.userChangeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.userChangeBtn.Name = "userChangeBtn";
            this.userChangeBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.userChangeBtn.Size = new System.Drawing.Size(244, 54);
            this.userChangeBtn.TabIndex = 3;
            this.userChangeBtn.Text = "Đổi thông tin cá nhân";
            this.userChangeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userChangeBtn.UseVisualStyleBackColor = false;
            // 
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userBtn.FlatAppearance.BorderSize = 0;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.userBtn.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.userBtn.IconColor = System.Drawing.Color.DimGray;
            this.userBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userBtn.IconSize = 45;
            this.userBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.Location = new System.Drawing.Point(0, 244);
            this.userBtn.Margin = new System.Windows.Forms.Padding(2);
            this.userBtn.Name = "userBtn";
            this.userBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.userBtn.Size = new System.Drawing.Size(244, 65);
            this.userBtn.TabIndex = 7;
            this.userBtn.Text = "Cá nhân";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userBtn.UseVisualStyleBackColor = false;
            // 
            // idBtn
            // 
            this.idBtn.BackColor = System.Drawing.Color.LightBlue;
            this.idBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.idBtn.FlatAppearance.BorderSize = 0;
            this.idBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.idBtn.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.idBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.idBtn.IconSize = 35;
            this.idBtn.Location = new System.Drawing.Point(0, 0);
            this.idBtn.Margin = new System.Windows.Forms.Padding(2);
            this.idBtn.Name = "idBtn";
            this.idBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.idBtn.Size = new System.Drawing.Size(244, 54);
            this.idBtn.TabIndex = 0;
            this.idBtn.Text = "Thông tin cá nhân";
            this.idBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.idBtn.UseVisualStyleBackColor = false;
            // 
            // signOutBtn
            // 
            this.signOutBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.signOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.signOutBtn.FlatAppearance.BorderSize = 0;
            this.signOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.signOutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.signOutBtn.IconColor = System.Drawing.Color.DimGray;
            this.signOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.signOutBtn.IconSize = 45;
            this.signOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOutBtn.Location = new System.Drawing.Point(0, 474);
            this.signOutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.signOutBtn.Size = new System.Drawing.Size(244, 65);
            this.signOutBtn.TabIndex = 10;
            this.signOutBtn.Text = "Đăng xuất";
            this.signOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.signOutBtn.UseVisualStyleBackColor = false;
            // 
            // panelUserSubmenu
            // 
            this.panelUserSubmenu.Controls.Add(this.changePwdBtn);
            this.panelUserSubmenu.Controls.Add(this.userChangeBtn);
            this.panelUserSubmenu.Controls.Add(this.idBtn);
            this.panelUserSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserSubmenu.Location = new System.Drawing.Point(0, 309);
            this.panelUserSubmenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelUserSubmenu.Name = "panelUserSubmenu";
            this.panelUserSubmenu.Size = new System.Drawing.Size(244, 165);
            this.panelUserSubmenu.TabIndex = 9;
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
            this.panelChildForm.TabIndex = 8;
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
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMenu.Controls.Add(this.signOutBtn);
            this.panelMenu.Controls.Add(this.panelUserSubmenu);
            this.panelMenu.Controls.Add(this.userBtn);
            this.panelMenu.Controls.Add(this.homeBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(244, 675);
            this.panelMenu.TabIndex = 7;
            // 
            // RenterHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1285, 683);
            this.Name = "RenterHomeForm";
            this.Text = "RenterHomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelUserSubmenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_UserFullname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton homeBtn;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton changePwdBtn;
        private FontAwesome.Sharp.IconButton userChangeBtn;
        private FontAwesome.Sharp.IconButton userBtn;
        private FontAwesome.Sharp.IconButton idBtn;
        private FontAwesome.Sharp.IconButton signOutBtn;
        private System.Windows.Forms.Panel panelUserSubmenu;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelMenu;
    }
}