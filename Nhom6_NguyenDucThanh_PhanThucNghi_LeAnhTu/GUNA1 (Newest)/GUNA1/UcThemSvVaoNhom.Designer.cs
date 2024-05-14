namespace GUNA1
{
    partial class UcThemSvVaoNhom
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
            this.FLPTheSV = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FLPTheSV
            // 
            this.FLPTheSV.AutoScroll = true;
            this.FLPTheSV.BackColor = System.Drawing.Color.White;
            this.FLPTheSV.Location = new System.Drawing.Point(58, 134);
            this.FLPTheSV.Name = "FLPTheSV";
            this.FLPTheSV.Size = new System.Drawing.Size(723, 548);
            this.FLPTheSV.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(53, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 28);
            this.label7.TabIndex = 50;
            this.label7.Text = "DANH SÁCH SINH VIÊN :";
            // 
            // UcThemSvVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FLPTheSV);
            this.Name = "UcThemSvVaoNhom";
            this.Size = new System.Drawing.Size(1090, 886);
            this.Load += new System.EventHandler(this.UcThemSvVaoNhom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel FLPTheSV;
        private System.Windows.Forms.Label label7;
    }
}
