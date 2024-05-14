namespace GUNA1
{
    partial class TheDanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheDanhGia));
            this.txtHienDanhGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHienThiTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // txtHienDanhGia
            // 
            this.txtHienDanhGia.BackColor = System.Drawing.Color.Transparent;
            this.txtHienDanhGia.BorderColor = System.Drawing.Color.Transparent;
            this.txtHienDanhGia.BorderRadius = 15;
            this.txtHienDanhGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHienDanhGia.DefaultText = "";
            this.txtHienDanhGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHienDanhGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHienDanhGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHienDanhGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHienDanhGia.FillColor = System.Drawing.Color.LightSkyBlue;
            this.txtHienDanhGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHienDanhGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHienDanhGia.ForeColor = System.Drawing.Color.Black;
            this.txtHienDanhGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHienDanhGia.Location = new System.Drawing.Point(70, 51);
            this.txtHienDanhGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHienDanhGia.Multiline = true;
            this.txtHienDanhGia.Name = "txtHienDanhGia";
            this.txtHienDanhGia.PasswordChar = '\0';
            this.txtHienDanhGia.PlaceholderText = "";
            this.txtHienDanhGia.ReadOnly = true;
            this.txtHienDanhGia.SelectedText = "";
            this.txtHienDanhGia.Size = new System.Drawing.Size(672, 133);
            this.txtHienDanhGia.TabIndex = 0;
            // 
            // lblHienThiTen
            // 
            this.lblHienThiTen.AutoSize = false;
            this.lblHienThiTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHienThiTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHienThiTen.Location = new System.Drawing.Point(70, 14);
            this.lblHienThiTen.Name = "lblHienThiTen";
            this.lblHienThiTen.Size = new System.Drawing.Size(196, 30);
            this.lblHienThiTen.TabIndex = 1;
            this.lblHienThiTen.Text = "Ho Va Ten ";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleButton1.Location = new System.Drawing.Point(14, 14);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(50, 54);
            this.guna2CircleButton1.TabIndex = 2;
            // 
            // TheDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.lblHienThiTen);
            this.Controls.Add(this.txtHienDanhGia);
            this.Name = "TheDanhGia";
            this.Size = new System.Drawing.Size(761, 203);
            this.Load += new System.EventHandler(this.TheDanhGia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtHienDanhGia;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblHienThiTen;
    }
}
