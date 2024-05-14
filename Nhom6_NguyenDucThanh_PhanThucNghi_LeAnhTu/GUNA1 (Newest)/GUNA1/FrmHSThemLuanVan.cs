using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNA1
{
    public partial class FrmHSThemLuanVan : Form
    {
        LuanVanDAO lvDao = new LuanVanDAO();
        private SinhVien sinhvien;
        public FrmHSThemLuanVan(SinhVien sinhvien)
        {
            InitializeComponent();
            this.sinhvien = sinhvien;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void FrmHSThemLuanVan_Load(object sender, EventArgs e)
        {

        }

        
            private void btnDeNghi_Click(object sender, EventArgs e)
            {
                string soLuongText = string.IsNullOrEmpty(txtSoLuongDangKy.Text) ? null : txtSoLuongDangKy.Text;
                string hienTenGVText = string.IsNullOrEmpty(txtHienTenGV.Text) ? null : txtHienTenGV.Text;
                string taskText = string.IsNullOrEmpty(txtTask.Text) ? null : txtTask.Text;

                LuanVan lv = new LuanVan(txtMaLuanVan.Text, txtTenLuanVan.Text, string.IsNullOrEmpty(soLuongText) ? 0 : int.Parse(soLuongText), txtMoTa.Text, txtYeuCau.Text, txtCongnghe.Text, hienTenGVText, taskText, "NY");
                lvDao.Them(lv);
            }
        
    }
}
