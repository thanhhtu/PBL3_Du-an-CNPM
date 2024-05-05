namespace PBL3.Views.CommonForm
{
    partial class UserForm
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
            this.label_Fullname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 35;
            this.customPanel1.Controls.Add(this.label_Email);
            this.customPanel1.Controls.Add(this.label_Address);
            this.customPanel1.Controls.Add(this.label_Phone);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.label_Fullname);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.customPanel1.Location = new System.Drawing.Point(78, 50);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(748, 381);
            this.customPanel1.TabIndex = 1;
            // 
            // label_Fullname
            // 
            this.label_Fullname.AutoSize = true;
            this.label_Fullname.BackColor = System.Drawing.Color.Transparent;
            this.label_Fullname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_Fullname.ForeColor = System.Drawing.Color.Black;
            this.label_Fullname.Location = new System.Drawing.Point(119, 121);
            this.label_Fullname.Name = "label_Fullname";
            this.label_Fullname.Size = new System.Drawing.Size(106, 28);
            this.label_Fullname.TabIndex = 2;
            this.label_Fullname.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 83);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.BackColor = System.Drawing.Color.Transparent;
            this.label_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_Phone.ForeColor = System.Drawing.Color.Black;
            this.label_Phone.Location = new System.Drawing.Point(119, 223);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(138, 28);
            this.label_Phone.TabIndex = 7;
            this.label_Phone.Text = "Số điện thoại:";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.BackColor = System.Drawing.Color.Transparent;
            this.label_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_Email.ForeColor = System.Drawing.Color.Black;
            this.label_Email.Location = new System.Drawing.Point(119, 172);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(65, 28);
            this.label_Email.TabIndex = 9;
            this.label_Email.Text = "Email:";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.BackColor = System.Drawing.Color.Transparent;
            this.label_Address.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_Address.ForeColor = System.Drawing.Color.Black;
            this.label_Address.Location = new System.Drawing.Point(119, 277);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(78, 28);
            this.label_Address.TabIndex = 8;
            this.label_Address.Text = "Địa chỉ:";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PBL3.Properties.Resources.bgr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 492);
            this.Controls.Add(this.customPanel1);
            this.DoubleBuffered = true;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponent.CustomPanel customPanel1;
        private System.Windows.Forms.Label label_Fullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Phone;
    }
}