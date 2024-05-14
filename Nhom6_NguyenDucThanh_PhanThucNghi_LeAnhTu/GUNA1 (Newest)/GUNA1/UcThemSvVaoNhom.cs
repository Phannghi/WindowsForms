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
    public partial class UcThemSvVaoNhom : UserControl
    {
        public List<SinhVien> SVs { get; set; }
        SinhVienDAO svDao = new SinhVienDAO();
        public UcThemSvVaoNhom()
        {
            InitializeComponent();
        }
        public void LoadSVs()
        {
            if (SVs != null && SVs.Count > 0)
            {
                FLPTheSV.Controls.Clear();

                foreach (SinhVien sv in SVs)
                {
                    TheThongTinSV theThongTinSV = new TheThongTinSV();
                    theThongTinSV.Ten = sv.Ten;
                    theThongTinSV.MaSV = sv.Id;
                    theThongTinSV.Email = sv.Email;

                    FLPTheSV.Controls.Add(theThongTinSV);

                    
                }
            }
        }
        private void UcThemSvVaoNhom_Load(object sender, EventArgs e)
        {

        }
    }
}
