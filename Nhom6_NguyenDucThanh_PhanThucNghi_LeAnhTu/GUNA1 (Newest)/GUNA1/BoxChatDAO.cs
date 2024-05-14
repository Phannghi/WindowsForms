using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GUNA1
{
    public class BoxChatDAO
    {
        public BoxChatDAO() { }
        
        public void AddChatMessage(string magiangvien, string masinhvien, int manhom, string ten, string noidungchat)
        {
            string sql = "INSERT INTO boxchat (magiangvien, masinhvien, manhom, ten, noidungchat, thoigian) VALUES (@magiangvien, @masinhvien, @manhom, @ten, @noidungchat, GETDATE())";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@magiangvien", magiangvien);
                    command.Parameters.AddWithValue("@masinhvien", masinhvien);
                    command.Parameters.AddWithValue("@manhom", manhom);
                    command.Parameters.AddWithValue("@ten", ten);
                    command.Parameters.AddWithValue("@noidungchat", noidungchat);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
