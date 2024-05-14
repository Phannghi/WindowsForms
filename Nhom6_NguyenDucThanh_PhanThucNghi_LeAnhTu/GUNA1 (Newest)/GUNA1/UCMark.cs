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
    public partial class UCMark : UserControl
    {
        public TheChamDiem selectedTCD { get; set; }
        public List<DangKy> Theses { get; set; }
        public UCMark()
        {
            InitializeComponent();
        }

        private void UCMark_Load(object sender, EventArgs e)
        {

        }
        public void LoadThesesDuyet()
        {
            if (Theses != null && Theses.Count > 0)
            {
                // Clear  TheLuanVan da ton tai trong UserControls
                FLPChamDiem.Controls.Clear();

                // tao va them TheLuanVan UserControls cho moi LuanVan trong Theses
                foreach (DangKy thesis in Theses)
                {
                    TheChamDiem theChamDiem = new TheChamDiem();
                    theChamDiem.Tensinhvien = thesis.Tensinhvien;
                    theChamDiem.Masinhvien = thesis.Masinhvien;
                    theChamDiem.Sotask = thesis.Sotask;
                    theChamDiem.Tasktulam = thesis.Tasktulam;
                    theChamDiem.Chamdiem = thesis.Chamdiem;
                    theChamDiem.Click += TheCDLuanVan_Click;
                    FLPChamDiem.Controls.Add(theChamDiem);
                }
            }
        }
        private void TheCDLuanVan_Click(object sender, EventArgs e)
        {
            // Lưu trữ thông tin luận văn được chọn
            TheChamDiem selectedSV = sender as TheChamDiem;


            if (selectedSV != null)
            {
                selectedTCD = selectedSV;
            }
        }
    }
}
