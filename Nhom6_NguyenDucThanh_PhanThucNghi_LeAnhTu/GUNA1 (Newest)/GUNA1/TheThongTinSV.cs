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
    public partial class TheThongTinSV : UserControl
    {
        public string Ten { get; set; }
        public string MaSV { get; set; }
        public string Email { get; set; }
        public TheThongTinSV()
        {
            InitializeComponent();
        }
        private void TheThongTinSV_Load(object sender, EventArgs e)
        {
            lblHoVaTen.Text = Ten;
            lblMaSV.Text = MaSV;
            lblEmail.Text = Email;
        }
    }
}
