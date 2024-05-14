namespace GUNA1
{
    partial class UcPhanTramTienDo
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
            this.tbPhanTram = new Guna.UI2.WinForms.Guna2TrackBar();
            this.FLPDanhGia = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGuiTinNhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // tbPhanTram
            // 
            this.tbPhanTram.Location = new System.Drawing.Point(599, 82);
            this.tbPhanTram.Name = "tbPhanTram";
            this.tbPhanTram.Size = new System.Drawing.Size(300, 23);
            this.tbPhanTram.TabIndex = 0;
            this.tbPhanTram.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbPhanTram.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbPhanTram_Scroll);
            // 
            // FLPDanhGia
            // 
            this.FLPDanhGia.AllowDrop = true;
            this.FLPDanhGia.AutoScroll = true;
            this.FLPDanhGia.BackColor = System.Drawing.Color.Gainsboro;
            this.FLPDanhGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FLPDanhGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FLPDanhGia.ForeColor = System.Drawing.Color.Teal;
            this.FLPDanhGia.Location = new System.Drawing.Point(49, 181);
            this.FLPDanhGia.Name = "FLPDanhGia";
            this.FLPDanhGia.Size = new System.Drawing.Size(934, 454);
            this.FLPDanhGia.TabIndex = 26;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(49, 64);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(500, 52);
            this.guna2HtmlLabel1.TabIndex = 27;
            this.guna2HtmlLabel1.Text = "Phần Trăm Tiến Độ Của Task";
            // 
            // txtGuiTinNhan
            // 
            this.txtGuiTinNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuiTinNhan.DefaultText = "";
            this.txtGuiTinNhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGuiTinNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGuiTinNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGuiTinNhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGuiTinNhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGuiTinNhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGuiTinNhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGuiTinNhan.Location = new System.Drawing.Point(49, 633);
            this.txtGuiTinNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuiTinNhan.Multiline = true;
            this.txtGuiTinNhan.Name = "txtGuiTinNhan";
            this.txtGuiTinNhan.PasswordChar = '\0';
            this.txtGuiTinNhan.PlaceholderText = "";
            this.txtGuiTinNhan.SelectedText = "";
            this.txtGuiTinNhan.Size = new System.Drawing.Size(878, 54);
            this.txtGuiTinNhan.TabIndex = 71;
            // 
            // UcPhanTramTienDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(185)))), ((int)(((byte)(205)))));
            this.Controls.Add(this.txtGuiTinNhan);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.FLPDanhGia);
            this.Controls.Add(this.tbPhanTram);
            this.Name = "UcPhanTramTienDo";
            this.Size = new System.Drawing.Size(1066, 738);
            this.Load += new System.EventHandler(this.UcPhanTramTienDo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TrackBar tbPhanTram;
        public System.Windows.Forms.FlowLayoutPanel FLPDanhGia;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2TextBox txtGuiTinNhan;
    }
}
