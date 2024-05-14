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
    public partial class TheLuanVan : UserControl
    {
        public string Tenluanvan { get; set; }
        public string Maluanvan { get; set; }
        public string Tengiangvien { get; set; }
        public string Congnghe { get; set; }
        public int Soluong { get; set; }

        public string Xetduyet { get; set; }
        public TheLuanVan()
        {
            InitializeComponent();
        }

        private void TheLuanVan_Load(object sender, EventArgs e)
        {
            lblTenLuanVan.Text = Tenluanvan;
            lblMaLuanVan.Text = Maluanvan;
            lblTenGiangVien.Text = Tengiangvien;
            lblCongNghe.Text = Congnghe;
            lblSoluong.Text = Soluong.ToString();
            lblXetDuyet.Text = Xetduyet;
            if (lblXetDuyet.Text == "NY")
            {
                btnChoDuyet.Visible = true;
                btnDaDuyet.Visible = false;
            }
            if (lblXetDuyet.Text == "A")
            {
                btnDaDuyet.Visible=true;
                btnChoDuyet.Visible = false;
            }
        }

        
    }
}
