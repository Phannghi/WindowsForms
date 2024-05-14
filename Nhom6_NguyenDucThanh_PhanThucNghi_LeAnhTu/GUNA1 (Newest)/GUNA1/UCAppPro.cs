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
    public partial class UCAppPro : UserControl
    {
        public TheLuanVan selectedTLV { get; set; }
        public List<LuanVan> Theses { get; set; }
        LuanVanDAO lvDao = new LuanVanDAO();
        private GiangVien giangvien;
        public UCAppPro()
        {
            InitializeComponent();
        }

        private void addEs_Click(object sender, EventArgs e)
        {
            FrmLyDoKoDuyet frmKoduyet = new FrmLyDoKoDuyet();
            frmKoduyet.ShowDialog();
        }
        public void LoadTheses()
        {
            if (Theses != null && Theses.Count > 0)
            {
                // Clear  TheLuanVan da ton tai trong UserControls
                FLPLuanVanChoDuyet.Controls.Clear();

                // tao va them TheLuanVan UserControls cho moi LuanVan trong Theses
                foreach (LuanVan thesis in Theses)
                {
                    TheLuanVan theLuanVan = new TheLuanVan();
                    theLuanVan.Tenluanvan = thesis.Tenluanvan;
                    theLuanVan.Maluanvan = thesis.Maluanvan;
                    theLuanVan.Tengiangvien = thesis.Tengiangvien;
                    theLuanVan.Congnghe = thesis.Congnghe;
                    theLuanVan.Soluong = thesis.Soluong;
                    theLuanVan.Xetduyet = thesis.Xetduyet;
                    theLuanVan.Click += TheLuanVan_Click;
                    FLPLuanVanChoDuyet.Controls.Add(theLuanVan);
                }
            }
        }
        private void TheLuanVan_Click(object sender, EventArgs e)
        {
            // Lưu trữ thông tin luận văn được chọn
            TheLuanVan selectedThesis = sender as TheLuanVan;


            if (selectedThesis != null)
            {
                selectedTLV = selectedThesis;
            }
        }
        private void UCAppPro_Load(object sender, EventArgs e)
        {

        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {

        }
    }
}
