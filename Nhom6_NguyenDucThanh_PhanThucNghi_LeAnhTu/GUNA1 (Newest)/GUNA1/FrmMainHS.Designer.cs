namespace GUNA1
{
    partial class FrmMainHS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainHS));
            this.btnTKGV = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.appPro = new Guna.UI2.WinForms.Guna2Button();
            this.checkPro = new Guna.UI2.WinForms.Guna2Button();
            this.update = new Guna.UI2.WinForms.Guna2Button();
            this.addEs = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemSinhVien = new Guna.UI2.WinForms.Guna2Button();
            this.txtNhapMSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTinNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuiTinNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnReLoad = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimSV = new Guna.UI2.WinForms.Guna2Button();
            this.btnMoUcThemSV = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnHSDeNghi = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.ucPhanTramTienDo1 = new GUNA1.UcPhanTramTienDo();
            this.ucXemDiem1 = new GUNA1.UcXemDiem();
            this.ucThemSvVaoNhom1 = new GUNA1.UcThemSvVaoNhom();
            this.ucDangKiLuanVan1 = new GUNA1.UcDangKiLuanVan();
            this.ucUpdatePro1 = new GUNA1.UcUpdatePro();
            this.ucInfo1 = new GUNA1.UCInfo();
            this.btnChatRieng = new Guna.UI2.WinForms.Guna2Button();
            this.btnTKGV.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTKGV
            // 
            this.btnTKGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnTKGV.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnTKGV.Controls.Add(this.btnDangXuat);
            this.btnTKGV.Controls.Add(this.appPro);
            this.btnTKGV.Controls.Add(this.checkPro);
            this.btnTKGV.Controls.Add(this.update);
            this.btnTKGV.Controls.Add(this.addEs);
            this.btnTKGV.Controls.Add(this.guna2CircleButton1);
            this.btnTKGV.Controls.Add(this.guna2Button2);
            this.btnTKGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTKGV.Location = new System.Drawing.Point(6, 6);
            this.btnTKGV.Name = "btnTKGV";
            this.btnTKGV.Size = new System.Drawing.Size(231, 802);
            this.btnTKGV.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Animated = true;
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.Location = new System.Drawing.Point(1, 655);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(228, 51);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // appPro
            // 
            this.appPro.Animated = true;
            this.appPro.AutoRoundedCorners = true;
            this.appPro.BorderRadius = 24;
            this.appPro.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.appPro.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.appPro.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.appPro.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.appPro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.appPro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.appPro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.appPro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.appPro.FillColor = System.Drawing.Color.Transparent;
            this.appPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appPro.ForeColor = System.Drawing.Color.White;
            this.appPro.Location = new System.Drawing.Point(-6, 279);
            this.appPro.Name = "appPro";
            this.appPro.Size = new System.Drawing.Size(234, 51);
            this.appPro.TabIndex = 6;
            this.appPro.Text = " Feedback";
            // 
            // checkPro
            // 
            this.checkPro.Animated = true;
            this.checkPro.AutoRoundedCorners = true;
            this.checkPro.BorderRadius = 24;
            this.checkPro.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.checkPro.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.checkPro.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.checkPro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkPro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkPro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkPro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkPro.FillColor = System.Drawing.Color.Transparent;
            this.checkPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPro.ForeColor = System.Drawing.Color.White;
            this.checkPro.Image = ((System.Drawing.Image)(resources.GetObject("checkPro.Image")));
            this.checkPro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.checkPro.ImageSize = new System.Drawing.Size(35, 35);
            this.checkPro.Location = new System.Drawing.Point(-6, 222);
            this.checkPro.Name = "checkPro";
            this.checkPro.Size = new System.Drawing.Size(234, 51);
            this.checkPro.TabIndex = 5;
            this.checkPro.Text = "   View Grades";
            this.checkPro.Click += new System.EventHandler(this.checkPro_Click);
            // 
            // update
            // 
            this.update.Animated = true;
            this.update.AutoRoundedCorners = true;
            this.update.BorderRadius = 24;
            this.update.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.update.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.update.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update.FillColor = System.Drawing.Color.Transparent;
            this.update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.update.ImageSize = new System.Drawing.Size(32, 32);
            this.update.Location = new System.Drawing.Point(-6, 165);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(234, 51);
            this.update.TabIndex = 4;
            this.update.Text = "       Update Process";
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // addEs
            // 
            this.addEs.Animated = true;
            this.addEs.AutoRoundedCorners = true;
            this.addEs.BorderRadius = 24;
            this.addEs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addEs.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.addEs.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addEs.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.addEs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addEs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addEs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addEs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addEs.FillColor = System.Drawing.Color.Transparent;
            this.addEs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEs.ForeColor = System.Drawing.Color.White;
            this.addEs.Location = new System.Drawing.Point(0, 108);
            this.addEs.Name = "addEs";
            this.addEs.Size = new System.Drawing.Size(228, 51);
            this.addEs.TabIndex = 2;
            this.addEs.Text = "Register ";
            this.addEs.Click += new System.EventHandler(this.addEs_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.Aqua;
            this.guna2CircleButton1.BorderThickness = 1;
            this.guna2CircleButton1.CustomImages.ImageSize = new System.Drawing.Size(18, 18);
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.guna2CircleButton1.Location = new System.Drawing.Point(13, 25);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(70, 67);
            this.guna2CircleButton1.TabIndex = 1;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 27;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(45, 45);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 36);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "INFO";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnThemSinhVien.BorderColor = System.Drawing.Color.White;
            this.btnThemSinhVien.BorderRadius = 14;
            this.btnThemSinhVien.BorderThickness = 1;
            this.btnThemSinhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSinhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemSinhVien.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnThemSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSinhVien.Image")));
            this.btnThemSinhVien.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThemSinhVien.Location = new System.Drawing.Point(845, 373);
            this.btnThemSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(184, 72);
            this.btnThemSinhVien.TabIndex = 50;
            this.btnThemSinhVien.Text = "Thêm Vào Nhóm";
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // txtNhapMSV
            // 
            this.txtNhapMSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapMSV.DefaultText = "";
            this.txtNhapMSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapMSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapMSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapMSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapMSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapMSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhapMSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapMSV.Location = new System.Drawing.Point(818, 231);
            this.txtNhapMSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhapMSV.Name = "txtNhapMSV";
            this.txtNhapMSV.PasswordChar = '\0';
            this.txtNhapMSV.PlaceholderText = "";
            this.txtNhapMSV.SelectedText = "";
            this.txtNhapMSV.Size = new System.Drawing.Size(229, 48);
            this.txtNhapMSV.TabIndex = 49;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.OrangeRed;
            this.guna2Panel1.Controls.Add(this.btnChatRieng);
            this.guna2Panel1.Controls.Add(this.ucPhanTramTienDo1);
            this.guna2Panel1.Controls.Add(this.ucXemDiem1);
            this.guna2Panel1.Controls.Add(this.btnTinNhan);
            this.guna2Panel1.Controls.Add(this.btnGuiTinNhan);
            this.guna2Panel1.Controls.Add(this.btnBack);
            this.guna2Panel1.Controls.Add(this.btnReLoad);
            this.guna2Panel1.Controls.Add(this.txtNhapMSV);
            this.guna2Panel1.Controls.Add(this.btnThemSinhVien);
            this.guna2Panel1.Controls.Add(this.btnTimSV);
            this.guna2Panel1.Controls.Add(this.ucThemSvVaoNhom1);
            this.guna2Panel1.Controls.Add(this.btnMoUcThemSV);
            this.guna2Panel1.Controls.Add(this.btnLuu);
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Controls.Add(this.btnHSDeNghi);
            this.guna2Panel1.Controls.Add(this.btnDangKy);
            this.guna2Panel1.Controls.Add(this.btnTimKiem);
            this.guna2Panel1.Controls.Add(this.ucDangKiLuanVan1);
            this.guna2Panel1.Controls.Add(this.ucUpdatePro1);
            this.guna2Panel1.Controls.Add(this.ucInfo1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(237, 6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1090, 802);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnTinNhan
            // 
            this.btnTinNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnTinNhan.BorderRadius = 20;
            this.btnTinNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTinNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTinNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTinNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTinNhan.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTinNhan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTinNhan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTinNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnTinNhan.Image")));
            this.btnTinNhan.Location = new System.Drawing.Point(907, 518);
            this.btnTinNhan.Name = "btnTinNhan";
            this.btnTinNhan.Size = new System.Drawing.Size(160, 45);
            this.btnTinNhan.TabIndex = 77;
            this.btnTinNhan.Text = "Tin nhắn";
            this.btnTinNhan.Click += new System.EventHandler(this.btnTinNhan_Click);
            // 
            // btnGuiTinNhan
            // 
            this.btnGuiTinNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuiTinNhan.BorderColor = System.Drawing.Color.White;
            this.btnGuiTinNhan.BorderThickness = 1;
            this.btnGuiTinNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuiTinNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuiTinNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuiTinNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuiTinNhan.FillColor = System.Drawing.Color.AliceBlue;
            this.btnGuiTinNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiTinNhan.ForeColor = System.Drawing.Color.White;
            this.btnGuiTinNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnGuiTinNhan.Image")));
            this.btnGuiTinNhan.ImageSize = new System.Drawing.Size(50, 50);
            this.btnGuiTinNhan.Location = new System.Drawing.Point(892, 557);
            this.btnGuiTinNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuiTinNhan.Name = "btnGuiTinNhan";
            this.btnGuiTinNhan.Size = new System.Drawing.Size(83, 52);
            this.btnGuiTinNhan.TabIndex = 56;
            this.btnGuiTinNhan.Click += new System.EventHandler(this.btnGuiTinNhan_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnBack.BorderColor = System.Drawing.Color.White;
            this.btnBack.BorderRadius = 14;
            this.btnBack.BorderThickness = 1;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(3, -2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 52);
            this.btnBack.TabIndex = 55;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnReLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReLoad.FillColor = System.Drawing.Color.Transparent;
            this.btnReLoad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.ForeColor = System.Drawing.Color.White;
            this.btnReLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnReLoad.Image")));
            this.btnReLoad.ImageSize = new System.Drawing.Size(35, 35);
            this.btnReLoad.Location = new System.Drawing.Point(1028, 0);
            this.btnReLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(62, 50);
            this.btnReLoad.TabIndex = 54;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnTimSV
            // 
            this.btnTimSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnTimSV.BorderColor = System.Drawing.Color.White;
            this.btnTimSV.BorderRadius = 14;
            this.btnTimSV.BorderThickness = 1;
            this.btnTimSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimSV.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTimSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSV.ForeColor = System.Drawing.Color.White;
            this.btnTimSV.Image = ((System.Drawing.Image)(resources.GetObject("btnTimSV.Image")));
            this.btnTimSV.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimSV.Location = new System.Drawing.Point(845, 302);
            this.btnTimSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimSV.Name = "btnTimSV";
            this.btnTimSV.Size = new System.Drawing.Size(184, 48);
            this.btnTimSV.TabIndex = 53;
            this.btnTimSV.Text = "Tìm kiếm SV";
            this.btnTimSV.Click += new System.EventHandler(this.btnTimSV_Click);
            // 
            // btnMoUcThemSV
            // 
            this.btnMoUcThemSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnMoUcThemSV.BorderColor = System.Drawing.Color.White;
            this.btnMoUcThemSV.BorderRadius = 14;
            this.btnMoUcThemSV.BorderThickness = 1;
            this.btnMoUcThemSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoUcThemSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoUcThemSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoUcThemSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoUcThemSV.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMoUcThemSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoUcThemSV.ForeColor = System.Drawing.Color.White;
            this.btnMoUcThemSV.Image = ((System.Drawing.Image)(resources.GetObject("btnMoUcThemSV.Image")));
            this.btnMoUcThemSV.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMoUcThemSV.Location = new System.Drawing.Point(771, 94);
            this.btnMoUcThemSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoUcThemSV.Name = "btnMoUcThemSV";
            this.btnMoUcThemSV.Size = new System.Drawing.Size(218, 45);
            this.btnMoUcThemSV.TabIndex = 51;
            this.btnMoUcThemSV.Text = "Thêm SV Vào Nhóm";
            this.btnMoUcThemSV.Click += new System.EventHandler(this.btnMoUcThemSV_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnLuu.BorderColor = System.Drawing.Color.White;
            this.btnLuu.BorderRadius = 14;
            this.btnLuu.BorderThickness = 1;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLuu.Location = new System.Drawing.Point(892, 449);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(184, 45);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu Tiến Độ ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.Location = new System.Drawing.Point(1014, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 50);
            this.btnClose.TabIndex = 48;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHSDeNghi
            // 
            this.btnHSDeNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnHSDeNghi.BorderColor = System.Drawing.Color.White;
            this.btnHSDeNghi.BorderRadius = 14;
            this.btnHSDeNghi.BorderThickness = 1;
            this.btnHSDeNghi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHSDeNghi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHSDeNghi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHSDeNghi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHSDeNghi.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnHSDeNghi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHSDeNghi.ForeColor = System.Drawing.Color.White;
            this.btnHSDeNghi.Image = ((System.Drawing.Image)(resources.GetObject("btnHSDeNghi.Image")));
            this.btnHSDeNghi.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHSDeNghi.Location = new System.Drawing.Point(936, 285);
            this.btnHSDeNghi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHSDeNghi.Name = "btnHSDeNghi";
            this.btnHSDeNghi.Size = new System.Drawing.Size(140, 45);
            this.btnHSDeNghi.TabIndex = 26;
            this.btnHSDeNghi.Text = "Thêm";
            this.btnHSDeNghi.Click += new System.EventHandler(this.btnHSDeNghi_Click_1);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnDangKy.BorderColor = System.Drawing.Color.White;
            this.btnDangKy.BorderRadius = 14;
            this.btnDangKy.BorderThickness = 1;
            this.btnDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKy.FillColor = System.Drawing.Color.Tomato;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.Wheat;
            this.btnDangKy.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKy.Image")));
            this.btnDangKy.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDangKy.Location = new System.Drawing.Point(936, 222);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(140, 51);
            this.btnDangKy.TabIndex = 22;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.White;
            this.btnTimKiem.BorderRadius = 14;
            this.btnTimKiem.BorderThickness = 1;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimKiem.Location = new System.Drawing.Point(609, 91);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(140, 48);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // ucPhanTramTienDo1
            // 
            this.ucPhanTramTienDo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(185)))), ((int)(((byte)(205)))));
            this.ucPhanTramTienDo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPhanTramTienDo1.Location = new System.Drawing.Point(0, 0);
            this.ucPhanTramTienDo1.Name = "ucPhanTramTienDo1";
            this.ucPhanTramTienDo1.Size = new System.Drawing.Size(1090, 802);
            this.ucPhanTramTienDo1.TabIndex = 79;
            // 
            // ucXemDiem1
            // 
            this.ucXemDiem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ucXemDiem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucXemDiem1.Location = new System.Drawing.Point(0, 0);
            this.ucXemDiem1.Name = "ucXemDiem1";
            this.ucXemDiem1.selectedTCD = null;
            this.ucXemDiem1.Size = new System.Drawing.Size(1090, 802);
            this.ucXemDiem1.TabIndex = 78;
            this.ucXemDiem1.Theses = null;
            this.ucXemDiem1.Load += new System.EventHandler(this.ucXemDiem1_Load);
            // 
            // ucThemSvVaoNhom1
            // 
            this.ucThemSvVaoNhom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ucThemSvVaoNhom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucThemSvVaoNhom1.Location = new System.Drawing.Point(0, 0);
            this.ucThemSvVaoNhom1.Name = "ucThemSvVaoNhom1";
            this.ucThemSvVaoNhom1.Size = new System.Drawing.Size(1090, 802);
            this.ucThemSvVaoNhom1.SVs = null;
            this.ucThemSvVaoNhom1.TabIndex = 52;
            // 
            // ucDangKiLuanVan1
            // 
            this.ucDangKiLuanVan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ucDangKiLuanVan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDangKiLuanVan1.Location = new System.Drawing.Point(0, 0);
            this.ucDangKiLuanVan1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucDangKiLuanVan1.Name = "ucDangKiLuanVan1";
            this.ucDangKiLuanVan1.selectedTLV = null;
            this.ucDangKiLuanVan1.Size = new System.Drawing.Size(1090, 802);
            this.ucDangKiLuanVan1.TabIndex = 3;
            this.ucDangKiLuanVan1.Theses = null;
            // 
            // ucUpdatePro1
            // 
            this.ucUpdatePro1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ucUpdatePro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUpdatePro1.ForeColor = System.Drawing.Color.Pink;
            this.ucUpdatePro1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdatePro1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucUpdatePro1.Name = "ucUpdatePro1";
            this.ucUpdatePro1.Size = new System.Drawing.Size(1090, 802);
            this.ucUpdatePro1.TabIndex = 2;
            this.ucUpdatePro1.TheDGia = null;
            // 
            // ucInfo1
            // 
            this.ucInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ucInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucInfo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucInfo1.Name = "ucInfo1";
            this.ucInfo1.Size = new System.Drawing.Size(1090, 802);
            this.ucInfo1.TabIndex = 0;
            // 
            // btnChatRieng
            // 
            this.btnChatRieng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChatRieng.BorderColor = System.Drawing.Color.White;
            this.btnChatRieng.BorderThickness = 1;
            this.btnChatRieng.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChatRieng.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChatRieng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChatRieng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChatRieng.FillColor = System.Drawing.Color.AliceBlue;
            this.btnChatRieng.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChatRieng.ForeColor = System.Drawing.Color.White;
            this.btnChatRieng.Image = ((System.Drawing.Image)(resources.GetObject("btnChatRieng.Image")));
            this.btnChatRieng.ImageSize = new System.Drawing.Size(50, 50);
            this.btnChatRieng.Location = new System.Drawing.Point(907, 635);
            this.btnChatRieng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChatRieng.Name = "btnChatRieng";
            this.btnChatRieng.Size = new System.Drawing.Size(83, 52);
            this.btnChatRieng.TabIndex = 80;
            this.btnChatRieng.Click += new System.EventHandler(this.btnChatRieng_Click);
            // 
            // FrmMainHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 814);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnTKGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMainHS";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "FrmMainHS";
            this.Load += new System.EventHandler(this.FrmMainHS_Load);
            this.btnTKGV.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel btnTKGV;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button addEs;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button checkPro;
        private Guna.UI2.WinForms.Guna2Button update;
        private Guna.UI2.WinForms.Guna2Button appPro;
        private UCInfo ucInfo1;
        private UcUpdatePro ucUpdatePro1;
        private UcDangKiLuanVan ucDangKiLuanVan1;
        public Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnDangKy;
        private Guna.UI2.WinForms.Guna2Button btnHSDeNghi;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnThemSinhVien;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapMSV;
        private Guna.UI2.WinForms.Guna2Button btnMoUcThemSV;
        public UcThemSvVaoNhom ucThemSvVaoNhom1;
        public Guna.UI2.WinForms.Guna2Button btnTimSV;
        private Guna.UI2.WinForms.Guna2Button btnReLoad;
        public Guna.UI2.WinForms.Guna2Button btnBack;
        public Guna.UI2.WinForms.Guna2Button btnGuiTinNhan;
        private Guna.UI2.WinForms.Guna2Button btnTinNhan;
        private UcXemDiem ucXemDiem1;
        private UcPhanTramTienDo ucPhanTramTienDo1;
        public Guna.UI2.WinForms.Guna2Button btnChatRieng;
    }
}

