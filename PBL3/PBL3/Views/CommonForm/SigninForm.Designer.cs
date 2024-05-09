namespace PBL3.Views.CommonForm
{
    partial class SignInForm
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
            this.customPanel1 = new PBL3.Views.CustomComponent.CustomPanel();
            this.btnHidePwd = new PBL3.Views.CustomComponent.CustomButton();
            this.btnShowPwd = new PBL3.Views.CustomComponent.CustomButton();
            this.LabelSignUp = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignIn = new PBL3.Views.CustomComponent.CustomButton();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtPwd = new PBL3.Views.CustomComponent.CustomTextBox();
            this.txtUserName = new PBL3.Views.CustomComponent.CustomTextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.btnHidePwd);
            this.customPanel1.Controls.Add(this.btnShowPwd);
            this.customPanel1.Controls.Add(this.LabelSignUp);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.btnSignIn);
            this.customPanel1.Controls.Add(this.labelPass);
            this.customPanel1.Controls.Add(this.txtPwd);
            this.customPanel1.Controls.Add(this.txtUserName);
            this.customPanel1.Controls.Add(this.labelUserName);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.customPanel1.Location = new System.Drawing.Point(181, 76);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(704, 401);
            this.customPanel1.TabIndex = 8;
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // btnHidePwd
            // 
            this.btnHidePwd.BackColor = System.Drawing.Color.Transparent;
            this.btnHidePwd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHidePwd.BorderColor = System.Drawing.Color.Transparent;
            this.btnHidePwd.BorderRadius = 0;
            this.btnHidePwd.BorderSize = 0;
            this.btnHidePwd.FlatAppearance.BorderSize = 0;
            this.btnHidePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHidePwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnHidePwd.Image = global::PBL3.Properties.Resources.hidePass;
            this.btnHidePwd.Location = new System.Drawing.Point(557, 212);
            this.btnHidePwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnHidePwd.Name = "btnHidePwd";
            this.btnHidePwd.Size = new System.Drawing.Size(49, 25);
            this.btnHidePwd.TabIndex = 24;
            this.btnHidePwd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnHidePwd.UseVisualStyleBackColor = false;
            // 
            // btnShowPwd
            // 
            this.btnShowPwd.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPwd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnShowPwd.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowPwd.BorderRadius = 0;
            this.btnShowPwd.BorderSize = 0;
            this.btnShowPwd.FlatAppearance.BorderSize = 0;
            this.btnShowPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnShowPwd.Image = global::PBL3.Properties.Resources.showPass;
            this.btnShowPwd.Location = new System.Drawing.Point(615, 210);
            this.btnShowPwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPwd.Name = "btnShowPwd";
            this.btnShowPwd.Size = new System.Drawing.Size(48, 25);
            this.btnShowPwd.TabIndex = 23;
            this.btnShowPwd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnShowPwd.UseVisualStyleBackColor = false;
            // 
            // LabelSignUp
            // 
            this.LabelSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelSignUp.AutoSize = true;
            this.LabelSignUp.BackColor = System.Drawing.Color.Transparent;
            this.LabelSignUp.DisabledLinkColor = System.Drawing.Color.DodgerBlue;
            this.LabelSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.LabelSignUp.LinkColor = System.Drawing.Color.DodgerBlue;
            this.LabelSignUp.Location = new System.Drawing.Point(579, 366);
            this.LabelSignUp.Name = "LabelSignUp";
            this.LabelSignUp.Size = new System.Drawing.Size(94, 19);
            this.LabelSignUp.TabIndex = 13;
            this.LabelSignUp.TabStop = true;
            this.LabelSignUp.Text = "Đăng ký ngay";
            this.LabelSignUp.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(452, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Chưa có tài khoản?";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSignIn.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnSignIn.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnSignIn.BorderRadius = 20;
            this.btnSignIn.BorderSize = 0;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Location = new System.Drawing.Point(245, 283);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(211, 47);
            this.btnSignIn.TabIndex = 12;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.TextColor = System.Drawing.Color.Black;
            this.btnSignIn.UseVisualStyleBackColor = false;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.labelPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelPass.ForeColor = System.Drawing.Color.Black;
            this.labelPass.Location = new System.Drawing.Point(12, 201);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(103, 28);
            this.labelPass.TabIndex = 9;
            this.labelPass.Text = "Mật khẩu:";
            // 
            // txtPwd
            // 
            this.txtPwd.AutoSize = true;
            this.txtPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtPwd.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPwd.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.txtPwd.BorderRadius = 6;
            this.txtPwd.BorderSize = 2;
            this.txtPwd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.ForeColor = System.Drawing.Color.DimGray;
            this.txtPwd.Location = new System.Drawing.Point(184, 201);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtPwd.Multiline = false;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Padding = new System.Windows.Forms.Padding(11, 6, 11, 6);
            this.txtPwd.PasswordChar = false;
            this.txtPwd.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPwd.PlaceholderText = "Nhập mật khẩu";
            this.txtPwd.Size = new System.Drawing.Size(489, 45);
            this.txtPwd.TabIndex = 8;
            this.txtPwd.Texts = "";
            this.txtPwd.UnderlinedStyle = false;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtUserName.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.txtUserName.BorderRadius = 6;
            this.txtUserName.BorderSize = 2;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserName.Location = new System.Drawing.Point(184, 121);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(11, 6, 11, 6);
            this.txtUserName.PasswordChar = false;
            this.txtUserName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtUserName.PlaceholderText = "Nhập tên đăng nhập";
            this.txtUserName.Size = new System.Drawing.Size(489, 43);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Texts = "";
            this.txtUserName.UnderlinedStyle = false;
            this.txtUserName.UseWaitCursor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelUserName.ForeColor = System.Drawing.Color.Black;
            this.labelUserName.Location = new System.Drawing.Point(12, 121);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(153, 28);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 81);
            this.label1.TabIndex = 6;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.bgr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 574);
            this.Controls.Add(this.customPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignInForm";
            this.Text = "SigninForm";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponent.CustomPanel customPanel1;
        private CustomComponent.CustomButton btnSignIn;
        private System.Windows.Forms.Label labelPass;
        private CustomComponent.CustomTextBox txtPwd;
        private CustomComponent.CustomTextBox txtUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LabelSignUp;
        private System.Windows.Forms.Label label2;
        private CustomComponent.CustomButton btnHidePwd;
        private CustomComponent.CustomButton btnShowPwd;
    }
}