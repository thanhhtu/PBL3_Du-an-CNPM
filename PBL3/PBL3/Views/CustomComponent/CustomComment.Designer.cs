
namespace PBL3.Views.CustomComponents
{
    partial class CustomComment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deleteLinkLabel = new PBL3.Views.CustomComponents.CustomLinkLabel();
            this.editLinkLabel = new PBL3.Views.CustomComponents.CustomLinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.utilityPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.utilityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteLinkLabel
            // 
            this.deleteLinkLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteLinkLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.deleteLinkLabel.ID = -1;
            this.deleteLinkLabel.LinkColor = System.Drawing.Color.Red;
            this.deleteLinkLabel.LinkText = "Xóa";
            this.deleteLinkLabel.Location = new System.Drawing.Point(0, 26);
            this.deleteLinkLabel.Margin = new System.Windows.Forms.Padding(2);
            this.deleteLinkLabel.Name = "deleteLinkLabel";
            this.deleteLinkLabel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.deleteLinkLabel.Size = new System.Drawing.Size(71, 26);
            this.deleteLinkLabel.TabIndex = 1;
            // 
            // editLinkLabel
            // 
            this.editLinkLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editLinkLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLinkLabel.ID = -1;
            this.editLinkLabel.LinkColor = System.Drawing.Color.SteelBlue;
            this.editLinkLabel.LinkText = "Chỉnh sửa";
            this.editLinkLabel.Location = new System.Drawing.Point(0, 0);
            this.editLinkLabel.Margin = new System.Windows.Forms.Padding(2);
            this.editLinkLabel.Name = "editLinkLabel";
            this.editLinkLabel.Size = new System.Drawing.Size(71, 26);
            this.editLinkLabel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(191, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 52);
            this.textBox1.TabIndex = 8;
            // 
            // utilityPanel
            // 
            this.utilityPanel.Controls.Add(this.deleteLinkLabel);
            this.utilityPanel.Controls.Add(this.editLinkLabel);
            this.utilityPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.utilityPanel.Location = new System.Drawing.Point(647, 0);
            this.utilityPanel.Margin = new System.Windows.Forms.Padding(2);
            this.utilityPanel.Name = "utilityPanel";
            this.utilityPanel.Size = new System.Drawing.Size(71, 52);
            this.utilityPanel.TabIndex = 7;
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.White;
            this.usernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLabel.Location = new System.Drawing.Point(0, 0);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.usernameLabel.Size = new System.Drawing.Size(191, 52);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Tên người dùng";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.utilityPanel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "CustomComment";
            this.Size = new System.Drawing.Size(718, 52);
            this.utilityPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomLinkLabel deleteLinkLabel;
        private CustomLinkLabel editLinkLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel utilityPanel;
        private System.Windows.Forms.Label usernameLabel;
    }
}
