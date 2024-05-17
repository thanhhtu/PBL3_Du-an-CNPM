namespace PBL3.Views.CustomComponent
{
    partial class CustomInforComponent
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelHide = new System.Windows.Forms.Panel();
            this.btnDeleteFavour = new PBL3.Views.CustomComponent.CustomButton();
            this.postID = new System.Windows.Forms.Label();
            this.tenNhaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.mieuTaLabel = new System.Windows.Forms.Label();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.dienTichLabel = new System.Windows.Forms.Label();
            this.tienLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panelHide.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panelHide);
            this.panel2.Controls.Add(this.postID);
            this.panel2.Controls.Add(this.tenNhaLinkLabel);
            this.panel2.Controls.Add(this.mieuTaLabel);
            this.panel2.Controls.Add(this.diaChiLabel);
            this.panel2.Controls.Add(this.dienTichLabel);
            this.panel2.Controls.Add(this.tienLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(237, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 255);
            this.panel2.TabIndex = 10;
            // 
            // panelHide
            // 
            this.panelHide.Controls.Add(this.btnDeleteFavour);
            this.panelHide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHide.Location = new System.Drawing.Point(0, 215);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(529, 36);
            this.panelHide.TabIndex = 37;
            // 
            // btnDeleteFavour
            // 
            this.btnDeleteFavour.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFavour.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDeleteFavour.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteFavour.BorderRadius = 0;
            this.btnDeleteFavour.BorderSize = 0;
            this.btnDeleteFavour.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteFavour.FlatAppearance.BorderSize = 0;
            this.btnDeleteFavour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFavour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFavour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnDeleteFavour.Image = global::PBL3.Properties.Resources.heart_full;
            this.btnDeleteFavour.Location = new System.Drawing.Point(475, 0);
            this.btnDeleteFavour.Name = "btnDeleteFavour";
            this.btnDeleteFavour.Size = new System.Drawing.Size(54, 36);
            this.btnDeleteFavour.TabIndex = 35;
            this.btnDeleteFavour.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnDeleteFavour.UseVisualStyleBackColor = false;
            this.btnDeleteFavour.Click += new System.EventHandler(this.btnDeleteFavour_Click);
            // 
            // postID
            // 
            this.postID.AutoSize = true;
            this.postID.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.postID.ForeColor = System.Drawing.Color.SteelBlue;
            this.postID.Location = new System.Drawing.Point(60, 15);
            this.postID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.postID.Name = "postID";
            this.postID.Size = new System.Drawing.Size(41, 13);
            this.postID.TabIndex = 12;
            this.postID.Text = "postID";
            this.postID.Visible = false;
            // 
            // tenNhaLinkLabel
            // 
            this.tenNhaLinkLabel.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.tenNhaLinkLabel.AutoSize = true;
            this.tenNhaLinkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenNhaLinkLabel.ForeColor = System.Drawing.Color.Red;
            this.tenNhaLinkLabel.LinkColor = System.Drawing.Color.Red;
            this.tenNhaLinkLabel.Location = new System.Drawing.Point(58, 38);
            this.tenNhaLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenNhaLinkLabel.Name = "tenNhaLinkLabel";
            this.tenNhaLinkLabel.Size = new System.Drawing.Size(135, 45);
            this.tenNhaLinkLabel.TabIndex = 11;
            this.tenNhaLinkLabel.TabStop = true;
            this.tenNhaLinkLabel.Text = "Tên nhà";
            this.tenNhaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tenNhaLinkLabel_LinkClicked_1);
            // 
            // mieuTaLabel
            // 
            this.mieuTaLabel.AutoSize = true;
            this.mieuTaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mieuTaLabel.ForeColor = System.Drawing.Color.Black;
            this.mieuTaLabel.Location = new System.Drawing.Point(61, 181);
            this.mieuTaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mieuTaLabel.Name = "mieuTaLabel";
            this.mieuTaLabel.Size = new System.Drawing.Size(57, 21);
            this.mieuTaLabel.TabIndex = 10;
            this.mieuTaLabel.Text = "Mô tả:";
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiLabel.ForeColor = System.Drawing.Color.Black;
            this.diaChiLabel.Location = new System.Drawing.Point(59, 135);
            this.diaChiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(62, 21);
            this.diaChiLabel.TabIndex = 9;
            this.diaChiLabel.Text = "Địa chỉ:";
            // 
            // dienTichLabel
            // 
            this.dienTichLabel.AutoSize = true;
            this.dienTichLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dienTichLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.dienTichLabel.Location = new System.Drawing.Point(300, 92);
            this.dienTichLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dienTichLabel.Name = "dienTichLabel";
            this.dienTichLabel.Size = new System.Drawing.Size(82, 21);
            this.dienTichLabel.TabIndex = 8;
            this.dienTichLabel.Text = "Diện tích: ";
            // 
            // tienLabel
            // 
            this.tienLabel.AutoSize = true;
            this.tienLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.tienLabel.Location = new System.Drawing.Point(61, 92);
            this.tienLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tienLabel.Name = "tienLabel";
            this.tienLabel.Size = new System.Drawing.Size(69, 21);
            this.tienLabel.TabIndex = 7;
            this.tienLabel.Text = "Số tiền: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 255);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PBL3.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CustomInforComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomInforComponent";
            this.Size = new System.Drawing.Size(770, 255);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelHide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label postID;
        private System.Windows.Forms.LinkLabel tenNhaLinkLabel;
        private System.Windows.Forms.Label mieuTaLabel;
        private System.Windows.Forms.Label diaChiLabel;
        private System.Windows.Forms.Label dienTichLabel;
        private System.Windows.Forms.Label tienLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton btnDeleteFavour;
        private System.Windows.Forms.Panel panelHide;
    }
}
