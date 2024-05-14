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
    public partial class FrmCapNhatDS : Form
    {
        LuanVanDAO lvDao = new LuanVanDAO();
        public FrmCapNhatDS()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //LuanVan lv = new LuanVan(txtMaLuanVan.Text, txtTenLuanVan.Text, int.Parse(txtSoLuongDangKy.Text), txtMoTa.Text, txtYeuCau.Text, txtCongnghe.Text);
            //lvDao.Sua(lv);
            
        }
    }
}
