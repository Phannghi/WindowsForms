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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUNA1
{
    public partial class FrmDangNhap : Form
    {
        GiangVienDAO gvDao;
        private GiangVien giangVienInfo;
        private SinhVien sinhVienInfo;
        public FrmDangNhap()
        {
            InitializeComponent();
        }
       


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTK = txtTaikhoan.Text;
            string matKhau = txtMatkhau.Text;
            if (tenTK.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
            }
            else if (matKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
            }
            else
            {
                string query = "";
                if (cbbLoaiTaiKhoan.SelectedItem.ToString() == "Giảng Viên")
                {
                    query = "Select * from GiangVien where magiangvien = '" + tenTK + "' and matkhau = '" + matKhau + "' ";
                    if (GiangVienDAO.TaiKhoanGiangViens(query).Count > 0)
                    {
                        giangVienInfo = GiangVienDAO.GetGiangVien(tenTK, matKhau);
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FrmMainGV home = new FrmMainGV(giangVienInfo);
                        home.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cbbLoaiTaiKhoan.SelectedItem.ToString() == "Sinh Viên")
                {
                    query = "Select * from SinhVien where masinhvien = '" + tenTK + "' and matkhau = '" + matKhau + "' ";
                    if (SinhVienDAO.TaiKhoanSinhViens(query).Count > 0)
                    {
                        sinhVienInfo = SinhVienDAO.GetSinhVien(tenTK, matKhau);
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FrmMainHS home = new FrmMainHS(sinhVienInfo);
                        home.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn vai trò đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
