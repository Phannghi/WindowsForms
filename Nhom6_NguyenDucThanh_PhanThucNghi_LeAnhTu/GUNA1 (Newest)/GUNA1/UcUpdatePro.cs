using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNA1
{
    public partial class UcUpdatePro : UserControl
    {
        public List<ChatBox> TheDGia { get; set; }
        DangKyDAO dkDao = new DangKyDAO();
        public UcUpdatePro()
        {
            InitializeComponent();
            
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
            // Lấy danh sách tin nhắn của nhóm có groupId
            List<ChatBox> messages = GetChatMessagesByGroupId(Convert.ToInt32(groupId));

            if (messages != null && messages.Count > 0)
            {
                // Clear TheLuanVan da ton tai trong UserControls
                FLPDanhGia.Controls.Clear();

                // tao va them TheLuanVan UserControls cho moi LuanVan trong Theses
                foreach (ChatBox dg in messages)
                {
                    string tenNguoiNhan = "";

                    // Lấy tên người  nhắn
                     if (dg.Masinhvien != null)
                    {
                        tenNguoiNhan = GetTenSinhVien(dg.Masinhvien);
                    }
                    if (dg.Magiangvien != null)
                    {
                        tenNguoiNhan = GetTenGiangVien(dg.Magiangvien);
                    }

                    // Tạo đối tượng TheDanhGia
                    TheDanhGia theDanhGia = new TheDanhGia();
                    theDanhGia.DanhGia = dg.Noidungchat;
                    theDanhGia.Ten = tenNguoiNhan;

                    FLPDanhGia.Controls.Add(theDanhGia);
                }
            }
        }

        private void UcUpdatePro_Load(object sender, EventArgs e)
        {

        }
    }
}
