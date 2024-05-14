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
    public partial class TheDanhGia : UserControl
    {
        public string DanhGia { get; set; }
        public string Ten { get; set; }


        public TheDanhGia()
        {
            InitializeComponent();
        }

        private void TheDanhGia_Load(object sender, EventArgs e)
        {
            lblHienThiTen.Text = Ten;

            txtHienDanhGia.Text = DanhGia;
            txtHienDanhGia.ReadOnly = true;
        }
    }
}
