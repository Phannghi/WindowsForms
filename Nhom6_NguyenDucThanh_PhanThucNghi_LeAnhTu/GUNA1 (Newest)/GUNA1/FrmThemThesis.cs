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
    public partial class FrmThemThesis : Form
    {
        LuanVanDAO lvDao = new LuanVanDAO();
        private GiangVien giangvien;
        private LuanVan maluanvan;
        public FrmThemThesis(GiangVien giangVien)
        {
            InitializeComponent();

            this.giangvien = giangVien;
        }
        
        private void FrmThemThesis_Load(object sender, EventArgs e)
        {
            
            DisplayGVName();
        }
        private void DisplayGVName()
        {
            
                txtHienTenGV.Text = giangvien.Ten;
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            
            LuanVan lv = new LuanVan(txtMaLuanVan.Text, txtTenLuanVan.Text, int.Parse(txtSoLuongDangKy.Text), txtMoTa.Text, txtYeuCau.Text,  txtCongnghe.Text, txtHienTenGV.Text,txtTask.Text, txtDuyet.Text="A");
            lvDao.Them(lv);
            FrmThemThesis_Load(sender, e);
        }

       
    }
}
