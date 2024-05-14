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
    public partial class UcDuyetSvDangKi : UserControl
    {
        public TheDangKiLuanVan selectedTDK { get; set; }
        public List<DangKy> Theses { get; set; }
        public UcDuyetSvDangKi()
        {
            InitializeComponent();
        }
        public void LoadThesesDuyet()
        {
            if (Theses != null && Theses.Count > 0)
            {
                // Clear  TheLuanVan da ton tai trong UserControls
                FLPLuanVanChoDuyet.Controls.Clear();

                // tao va them TheLuanVan UserControls cho moi LuanVan trong Theses
                foreach (DangKy thesis in Theses)
                {
                    TheDangKiLuanVan theDKLuanVan = new TheDangKiLuanVan();
                    theDKLuanVan.Tenluanvan = thesis.Tenluanvan;
                    theDKLuanVan.Maluanvan = thesis.Maluanvan;
                    theDKLuanVan.MaNhom = thesis.Manhom;
                    theDKLuanVan.Xetduyet = thesis.Xetduyet;
                    theDKLuanVan.Click += TheDKLuanVan_Click;
                    FLPLuanVanChoDuyet.Controls.Add(theDKLuanVan);
                }
            }
        }
        private void TheDKLuanVan_Click(object sender, EventArgs e)
        {
            // Lưu trữ thông tin luận văn được chọn
            TheDangKiLuanVan selectedThesis = sender as TheDangKiLuanVan;


            if (selectedThesis != null)
            {
                selectedTDK = selectedThesis;
            }
        }
        private void UcDuyetSvDangKi_Load(object sender, EventArgs e)
        {

        }

        
    }
}
