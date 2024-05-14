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
    public partial class UcPhanTramTienDo : UserControl
    {
        public UcPhanTramTienDo()
        {
            InitializeComponent();
        }

        private void tbPhanTram_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void UcPhanTramTienDo_Load(object sender, EventArgs e)
        {

        }
        public string GetTenGiangVien(string magiangvien)
        {
            string tenGiangVien = "";
            string sql = "SELECT ten FROM GiangVien WHERE magiangvien = @magiangvien";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@magiangvien", magiangvien);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        tenGiangVien = reader["ten"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return tenGiangVien;
        }

        public string GetTenSinhVien(string masinhvien)
        {
            string tenSinhVien = "";
            string sql = "SELECT ten FROM SinhVien WHERE masinhvien = @masinhvien";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@masinhvien", masinhvien);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        tenSinhVien = reader["ten"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return tenSinhVien;
        }
        public List<ChatBox> GetChatMessagesByGroupId(int groupId)
        {
            List<ChatBox> messages = new List<ChatBox>();
            string sql = "SELECT * FROM boxchat WHERE manhom = @groupId ORDER BY thoigian";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@groupId", groupId);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ChatBox message = new ChatBox
                        {
                            Magiangvien = reader["magiangvien"].ToString(),
                            Masinhvien = reader["masinhvien"].ToString(),
                            Ten = reader["ten"].ToString(),
                            Manhom = Convert.ToInt32(reader["manhom"]),
                            Noidungchat = reader["noidungchat"].ToString(),
                            Thoigian = Convert.ToDateTime(reader["thoigian"])
                        };
                        messages.Add(message);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return messages;
        }

        public void LoadComments(string groupId)
        {
            // Clear TheLuanVan đã tồn tại trong UserControls
            FLPDanhGia.Controls.Clear();

            // Lấy danh sách đánh giá cho nhóm
            List<ChatBox> danhGiaList = GetChatMessagesByGroupId(Convert.ToInt32(groupId));

            // Tạo và thêm các UserControls TheDanhGia cho mỗi đánh giá vào FlowLayoutPanel
            foreach (ChatBox dg in danhGiaList)
            {
                string tenNguoiNhan = "";

                // Lấy tên người nhận tin nhắn
                if (dg.Magiangvien != null)
                {
                    tenNguoiNhan = GetTenGiangVien(dg.Magiangvien);
                }
                else if (dg.Masinhvien != null)
                {
                    tenNguoiNhan = GetTenSinhVien(dg.Masinhvien);
                }

                // Tạo đối tượng TheDanhGia
                TheDanhGia theDanhGia = new TheDanhGia();
                theDanhGia.DanhGia = dg.Noidungchat;
                theDanhGia.Ten = tenNguoiNhan;

                FLPDanhGia.Controls.Add(theDanhGia);
            }
        }

    }
}
