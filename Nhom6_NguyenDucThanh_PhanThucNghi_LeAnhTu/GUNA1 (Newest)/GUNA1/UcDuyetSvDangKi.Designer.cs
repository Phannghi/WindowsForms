namespace GUNA1
{
    partial class UcDuyetSvDangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDuyetSvDangKi));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.FLPLuanVanChoDuyet = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Lavender;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.FLPLuanVanChoDuyet);
            this.guna2Panel1.Controls.Add(this.btnKDuyet);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(58, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(969, 527);
            this.guna2Panel1.TabIndex = 3;
            // 
            // FLPLuanVanChoDuyet
            // 
            this.FLPLuanVanChoDuyet.AutoScroll = true;
            this.FLPLuanVanChoDuyet.BackColor = System.Drawing.Color.White;
            this.FLPLuanVanChoDuyet.Location = new System.Drawing.Point(50, 92);
            this.FLPLuanVanChoDuyet.Name = "FLPLuanVanChoDuyet";
            this.FLPLuanVanChoDuyet.Size = new System.Drawing.Size(685, 402);
            this.FLPLuanVanChoDuyet.TabIndex = 49;
            // 
            // btnKDuyet
            // 
            this.btnKDuyet.Animated = true;
            this.btnKDuyet.AutoRoundedCorners = true;
            this.btnKDuyet.BorderRadius = 27;
            this.btnKDuyet.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKDuyet.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKDuyet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKDuyet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKDuyet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKDuyet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKDuyet.FillColor = System.Drawing.Color.Crimson;
            this.btnKDuyet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKDuyet.ForeColor = System.Drawing.Color.White;
            this.btnKDuyet.Image = ((System.Drawing.Image)(resources.GetObject("btnKDuyet.Image")));
            this.btnKDuyet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKDuyet.Location = new System.Drawing.Point(762, 295);
            this.btnKDuyet.Name = "btnKDuyet";
            this.btnKDuyet.Size = new System.Drawing.Size(160, 57);
            this.btnKDuyet.TabIndex = 3;
            this.btnKDuyet.Text = "   Từ Chối";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(40, 19);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(792, 47);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Danh Sách Luận Văn Các Nhóm Đăng Kí Chờ Duyệt";
            // 
            // UcDuyetSvDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UcDuyetSvDangKi";
            this.Size = new System.Drawing.Size(1070, 646);
            this.Load += new System.EventHandler(this.UcDuyetSvDangKi_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel FLPLuanVanChoDuyet;
        private Guna.UI2.WinForms.Guna2Button btnKDuyet;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
