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
    public partial class UserControlAddThesis : UserControl
    {
        public List<LuanVan> Theses { get; set; }
        LuanVanDAO lvDao = new LuanVanDAO();
        private GiangVien giangvien;
        public UserControlAddThesis()
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
                    theLuanVan.Xetduyet = thesis.Xetduyet;
                    FLPLuanVan.Controls.Add(theLuanVan);
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FrmThemThesis frmThemThesis = new FrmThemThesis(giangvien);
            frmThemThesis.ShowDialog();
            LoadData();

        }

        private void UserControlAddThesis_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FrmCapNhat frmcapnhat = new FrmCapNhat();
            frmcapnhat.ShowDialog();
            LoadData();
        }

       


        private void UserControlAddThesis_Load_1(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLuanVan = txtTimkiem.Text;
            LuanVanDAO luanVanDAO = new LuanVanDAO();
            LuanVan luanVan = new LuanVan();
            luanVan.Maluanvan = maLuanVan;
            luanVanDAO.Xoa(luanVan);
            DataTable dt = lvDao.Load();
            dgvManageThesis.DataSource = dt;
            // Load lại dữ liệu sau khi xóa
            

        }
        private void LoadData()
        {
            LuanVanDAO luanVanDAO = new LuanVanDAO();
            dgvManageThesis.DataSource = luanVanDAO.Load();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadTheses();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ThesisId = txtTimkiem.Text.Trim();

            if (!string.IsNullOrEmpty(ThesisId))
            {
                DataTable dt = lvDao.FilterThesisByThesisId(ThesisId);
                List<LuanVan> theses = dt.AsEnumerable()
               .Select(row => new LuanVan()
               {
                   Maluanvan = row["maluanvan"].ToString(),
                   Tenluanvan = row["tenluanvan"].ToString(),
                   Congnghe = row["congnghe"].ToString(),
                   Tengiangvien = row["tengiangvien"].ToString(),
                   Soluong = Convert.ToInt32(row["soluongdangky"]),
                   Xetduyet = row["xetduyet"].ToString()
               })
               .ToList();

                Theses = theses;
                LoadTheses();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để tìm kiếm.");
            }
        }
    }
}
