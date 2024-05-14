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
    public partial class TheTienDoCuaSV : UserControl
    {
        public string Maluanvan { get; set; }
        public string Tenluanvan { get; set; }
        public int Sotask { get; set; }
        public int Sohoanthanh { get; set; }

        public int Manhom { get; set; }
     

        public TheTienDoCuaSV()
        {
            InitializeComponent();
        }

        

        private void TheTienDoCuaSV_Load(object sender, EventArgs e)
        {
            lblTenLuanvan.Text = Tenluanvan;
            lblMaLuanVan.Text = Maluanvan;
            lblMaNhom.Text = Manhom.ToString();
            lblSotask.Text = Sotask.ToString();
            lblSoHT.Text = Sohoanthanh.ToString();  
           
        }

       
    }
}
