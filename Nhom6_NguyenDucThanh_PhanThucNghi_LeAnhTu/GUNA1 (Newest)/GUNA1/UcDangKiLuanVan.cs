using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNA1
{
    public partial class UcDangKiLuanVan : UserControl
    {
        public List<LuanVan> Theses { get; set; }
        public TheLuanVan selectedTLV { get; set; }
        LuanVanDAO lvDao = new LuanVanDAO();
        public UcDangKiLuanVan()
        {
            InitializeComponent();
        }
        public void LoadTheses()
        {
            if (Theses != null && Theses.Count > 0)
            {
                // Clear  TheLuanVan da ton tai trong UserControls
                FLPLuanVan.Controls.Clear();

                // tao va them TheLuanVan UserControls cho moi LuanVan trong Theses
                foreach (LuanVan thesis in Theses)
                {
                    TheLuanVan theLuanVan = new TheLuanVan();
                    theLuanVan.Tenluanvan = thesis.Tenluanvan;
                    theLuanVan.Maluanvan = thesis.Maluanvan;
                    theLuanVan.Tengiangvien = thesis.Tengiangvien;
                    theLuanVan.Congnghe = thesis.Congnghe;
                    theLuanVan.Soluong = thesis.Soluong;
                    theLuanVan.Click += TheLuanVan_Click;
                    FLPLuanVan.Controls.Add(theLuanVan);
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

        private void UcDangKiLuanVan_Load(object sender, EventArgs e)
        {
            lblExist.Visible = false;
        }

        private void LoadData()
        {
            LuanVanDAO luanVanDAO = new LuanVanDAO();
            dgvManageThesis.DataSource = luanVanDAO.Load();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

