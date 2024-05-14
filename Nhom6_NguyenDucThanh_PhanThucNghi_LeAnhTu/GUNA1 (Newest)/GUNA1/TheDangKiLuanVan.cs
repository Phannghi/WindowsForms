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
    public partial class TheDangKiLuanVan : UserControl
    {
        public string Tenluanvan { get; set; }
        public string Maluanvan { get; set; }
        public string Xetduyet { get; set; }
        public int MaNhom { get; set; }
        public TheDangKiLuanVan()
        {
            InitializeComponent();
        }

        private void TheDangKiLuanVan_Load(object sender, EventArgs e)
        {
            lblMaLuanVan.Text=Maluanvan;
            lblTenLuan.Text=Tenluanvan;
            lblMaNhom.Text=MaNhom.ToString();
            lblXetDuyet.Text=Xetduyet;
            if (lblXetDuyet.Text == "NY")
            {
                btnChoDuyet.Visible = true;
                btnDaDuyet.Visible = false;
            }
            if (lblXetDuyet.Text == "Y")
            {
                btnDaDuyet.Visible = true;
                btnChoDuyet.Visible = false;
            }
        }
    }
}
