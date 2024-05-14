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
    public partial class TheChamDiem : UserControl
    {
        public string Masinhvien { get; set; }
        public string Tensinhvien { get; set; }
        public float Chamdiem { get; set; }
        
        public int Tasktulam{ get; set; }
        public int Sotask{ get; set; }
        public TheChamDiem()
        {
            InitializeComponent();
        }

        private void TheChamDiem_Load(object sender, EventArgs e)
        {
            lblMaSV.Text = Masinhvien;
            lblHoVaTen.Text = Tensinhvien;
            lblSotask.Text = Sotask.ToString();
            lblSoTaskTuLam.Text = Tasktulam.ToString();
            lblDiem.Text = Chamdiem.ToString();
        }
    }
}
