using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNA1
{
    public partial class UcCheckPro : UserControl
    {
        public List<DangKy> TheDky { get; set; }
        DangKyDAO dkDao = new DangKyDAO();
        public TheTienDoCuaSV selectedTTD { get; set; }
        private GiangVien giangvien;
        public UcCheckPro()
        {
            InitializeComponent();
        }
        public void LoadProcess()
        {
            if (TheDky != null && TheDky.Count > 0)
            {
                // Clear  TheLuanVan da ton tai trong UserControls
                FLPLoadTienDo.Controls.Clear();

                // tao va them TheLuanVan UserControls cho moi LuanVan trong Theses
                foreach (DangKy thesis in TheDky)
                {
                    TheTienDoCuaSV theTienDo = new TheTienDoCuaSV();
                    theTienDo.Tenluanvan = thesis.Tenluanvan; 
                    theTienDo.Maluanvan = thesis.Maluanvan;
                    theTienDo.Manhom=thesis.Manhom;
                    theTienDo.Sotask = thesis.Sotask;
                    theTienDo.Sohoanthanh=thesis.Sohoanthanh;
                    theTienDo.Click += TheTienDoCuaSV_Click;
                    FLPLoadTienDo.Controls.Add(theTienDo);
                }
            }

        }
        private void UcCheckPro_Load(object sender, EventArgs e)
        {


        }

        private void TheTienDoCuaSV_Click(object sender, EventArgs e)
        {
            // Lưu trữ thông tin luận văn được chọn
            TheTienDoCuaSV selectedTD = sender as TheTienDoCuaSV;

            if (selectedTD != null)
            {
                selectedTTD = selectedTD;
                MessageBox.Show("Bạn đã chọn nhóm: " + selectedTTD.Manhom.ToString());
                
            }
        }
        private void btnSearchId_Click(object sender, EventArgs e)
        {
            string ThesisId = txtNhapId.Text.Trim();

            if (!string.IsNullOrEmpty(ThesisId))
            {
                DataTable result = dkDao.FilterByThesisId(ThesisId);
                List<DangKy> theDkyList = new List<DangKy>();

                foreach (DataRow row in result.Rows)
                {
                    DangKy dk = new DangKy
                    {
                        Maluanvan = row["maluanvan"].ToString(),
                        Manhom = Convert.ToInt32(row["manhom"]),
                        Sohoanthanh = Convert.ToInt32(row["sohoanthanh"]),
                        Sotask = Convert.ToInt32(row["sotask"])
                    };
                    theDkyList.Add(dk);
                }

                TheDky = theDkyList;
                LoadProcess();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để tìm kiếm.");
            }
        }
    }
}
