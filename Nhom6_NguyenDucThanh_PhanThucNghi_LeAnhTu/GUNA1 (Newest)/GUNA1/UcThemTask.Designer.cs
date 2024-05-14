namespace GUNA1
{
    partial class UcThemTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcThemTask));
            this.txtNhapTaskThem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemTaskVaoData = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhapTaskThem
            // 
            this.txtNhapTaskThem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapTaskThem.DefaultText = "";
            this.txtNhapTaskThem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapTaskThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapTaskThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapTaskThem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapTaskThem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapTaskThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhapTaskThem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapTaskThem.Location = new System.Drawing.Point(245, 140);
            this.txtNhapTaskThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhapTaskThem.Multiline = true;
            this.txtNhapTaskThem.Name = "txtNhapTaskThem";
            this.txtNhapTaskThem.PasswordChar = '\0';
            this.txtNhapTaskThem.PlaceholderText = "";
            this.txtNhapTaskThem.SelectedText = "";
            this.txtNhapTaskThem.Size = new System.Drawing.Size(495, 189);
            this.txtNhapTaskThem.TabIndex = 0;
            // 
            // btnThemTaskVaoData
            // 
            this.btnThemTaskVaoData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnThemTaskVaoData.BorderRadius = 14;
            this.btnThemTaskVaoData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTaskVaoData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTaskVaoData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemTaskVaoData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemTaskVaoData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemTaskVaoData.ForeColor = System.Drawing.Color.White;
            this.btnThemTaskVaoData.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTaskVaoData.Image")));
            this.btnThemTaskVaoData.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThemTaskVaoData.Location = new System.Drawing.Point(401, 357);
            this.btnThemTaskVaoData.Name = "btnThemTaskVaoData";
            this.btnThemTaskVaoData.Size = new System.Drawing.Size(180, 45);
            this.btnThemTaskVaoData.TabIndex = 81;
            this.btnThemTaskVaoData.Text = "Thêm Task";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(380, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 28);
            this.label7.TabIndex = 82;
            this.label7.Text = "NHẬP THÊM TASK ";
            // 
            // UcThemTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThemTaskVaoData);
            this.Controls.Add(this.txtNhapTaskThem);
            this.Name = "UcThemTask";
            this.Size = new System.Drawing.Size(989, 642);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnThemTaskVaoData;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2TextBox txtNhapTaskThem;
    }
}
