using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNA1
{
    public class LuanVanDAO
    {
        public LuanVanDAO() { }
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT * FROM LuanVan WHERE LuanVan.xetduyet = 'A' "); 
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public DataTable LoadLvNY()
        {
            string sqlStr = string.Format("SELECT * FROM LuanVan WHERE LuanVan.xetduyet = 'NY' ");
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public void thucThi(string sqlStr)
        {
            DBConnection db = new DBConnection();
            db.ThucThi(sqlStr);
        }
        public void Them(LuanVan lv)
        {
            string sqlStr = string.Format("INSERT INTO LuanVan(maluanvan , tenluanvan, soluongdangky, mota, yeucau,congnghe, tengiangvien,task, xetduyet) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}' , '{5}', '{6}', '{7}', '{8}')", lv.Maluanvan, lv.Tenluanvan, lv.Soluong, lv.Mota, lv.Yeucau, lv.Congnghe, lv.Tengiangvien, lv.Task, lv.Xetduyet);
            thucThi(sqlStr);
        }
        public void Xoa(LuanVan lv)
        {
            string sqlStr = string.Format("DELETE FROM LuanVan WHERE maluanvan = '{0}'", lv.Maluanvan);
            thucThi(sqlStr);
        }
        public void Sua(LuanVan lv)
        {
            string sqlStr = string.Format("UPDATE LuanVan SET maluanvan = '{0}', tenluanvan ='{1}', soluongdangky = '{2}', Mota = '{3}' , yeucau = '{4}', congnghe = '{5}' WHERE maluanvan = {0}", lv.Maluanvan, lv.Tenluanvan, lv.Soluong, lv.Mota, lv.Yeucau, lv.Congnghe);
            thucThi(sqlStr);
        }
        public void DuyetLv(string maLuanVan, string xetDuyet)
        {
            string sqlStr = "UPDATE LuanVan SET xetduyet = @xetduyet WHERE maluanvan = @maluanvan";
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@xetduyet", xetDuyet);
                    cmd.Parameters.AddWithValue("@maluanvan", maLuanVan);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<string> GetLecturerNames()
        {
            string sql = "SELECT DISTINCT tengiangvien FROM LuanVan";
            List<string> lecturers = new List<string>();

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lecturers.Add(reader["tengiangvien"].ToString());
                    }
                    reader.Close();
                }
            }

            return lecturers;
        }
        public DataTable FilterThesisByLecturer(string lecturerName)
        {
            try
            {
                if (string.IsNullOrEmpty(lecturerName))
                {
                    MessageBox.Show("Vui lòng chọn tên giảng viên");
                    return null;
                }

                string sql = "SELECT * FROM LuanVan WHERE tengiangvien = @tengiangvien";
                using (SqlConnection connection = DBConnection.GetSqlConnection()) // Một kết nối duy nhất
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@tengiangvien", lecturerName);

                    DataTable dtThesis = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtThesis);

                    return dtThesis;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc luận văn: " + ex.Message);
                return null;
            }
        }
        public DataTable FilterThesisByThesisId(string lecturerName)
        {
            try
            {
                if (string.IsNullOrEmpty(lecturerName))
                {
                    MessageBox.Show("Vui lòng chọn tên giảng viên");
                    return null;
                }

                string sql = "SELECT * FROM LuanVan WHERE maluanvan = @maluanvan";
                using (SqlConnection connection = DBConnection.GetSqlConnection()) // Một kết nối duy nhất
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@maluanvan", lecturerName);

                    DataTable dtThesis = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtThesis);

                    return dtThesis;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc luận văn: " + ex.Message);
                return null;
            }
        }
        public int GetRegisteredThesisCount(string studentId)
        {
            string sql = "SELECT COUNT(*) FROM DangKy WHERE masinhvien = @masinhvien";

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@masinhvien", studentId);

                return (int)command.ExecuteScalar();
            }
        }
        // TRA VE SO LUONG HOC SINH DA DANG KI LUAN VAN
        public int GetRegisteredStudentCount(string thesisId)
        {
            string sql = "SELECT COUNT(*) FROM DangKy WHERE maluanvan = @maluanvan";

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@maluanvan", thesisId);

                return (int)command.ExecuteScalar();
            }
        }
        public int GetMaxCountRegister(string thesisId)
        {
            int studentCount = -1;
            string sql = "select * from LuanVan where maluanvan = @maluanvan";
            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@maluanvan", thesisId);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    studentCount = (int)reader["soluongdangky"];
                }
            }
            return studentCount;
        }
        public int CheckDuplicateRegistration(string thesisId, string studentId)
        {
            string sql = "SELECT COUNT(*) FROM DangKy WHERE maluanvan = @maluanvan AND masinhvien = @masinhvien";

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@maluanvan", thesisId);
                command.Parameters.AddWithValue("@masinhvien", studentId);

                return (int)command.ExecuteScalar();
            }
        }
        //hàm lấy mã luận văn
        public string GetThesisId(string studentId)
        {
            string thesisId = "";
            string sql = "SELECT LuanVan.maluanvan FROM LuanVan INNER JOIN DangKy ON LuanVan.maluanvan = DangKy.maluanvan WHERE DangKy.masinhvien = @masinhvien";
            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@masinhvien", studentId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        thesisId = reader["maluanvan"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting thesis Id: " + ex.Message);
            }
            return thesisId;
        }
        public string GetThesisTaskByStudentId(string studentId)
        {
            string task = "";

            string sql = "SELECT LuanVan.task FROM LuanVan INNER JOIN DangKy ON LuanVan.maluanvan = DangKy.maluanvan WHERE DangKy.masinhvien = @masinhvien";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@masinhvien", studentId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        task = reader["task"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting thesis task: " + ex.Message);
            }

            return task;
        }
        public string GetThesisNameByStudentId(string studentId)
        {
            string task = "";

            string sql = "SELECT LuanVan.tenluanvan FROM LuanVan INNER JOIN DangKy ON LuanVan.maluanvan = DangKy.maluanvan WHERE DangKy.masinhvien = @masinhvien";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@masinhvien", studentId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        task = reader["tenluanvan"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting thesis task: " + ex.Message);
            }

            return task;
        }
        public string GetThesisNameByMaNhom(string groupId)
        {
            string tlv = " ";
            
            string sql = "SELECT LuanVan.tenluanvan FROM LuanVan INNER JOIN DangKy ON LuanVan.maluanvan=DangKy.maluanvan WHERE DangKy.manhom= @manhom";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@manhom", groupId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        tlv = reader["tenluanvan"].ToString();
                        
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting thesis task: " + ex.Message);
            }
            return tlv;
        }
        public string GetTechnoByNaNhom(string groupId)
        {
            string cn = " ";

            string sql = "SELECT  LuanVan.congnghe FROM LuanVan INNER JOIN DangKy ON LuanVan.maluanvan=DangKy.maluanvan WHERE DangKy.manhom= @manhom";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@manhom", groupId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        cn = reader["congnghe"].ToString();

                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting thesis task: " + ex.Message);
            }
            return cn;
        }
        public List<string> GetStudentNamesByGroupId(string groupId)
        {
            List<string> studentNames = new List<string>();

            string sql = @"
        SELECT SinhVien.ten
        FROM SinhVien
        WHERE SinhVien.masinhvien IN (
            SELECT DangKy.masinhvien
            FROM DangKy
            WHERE DangKy.manhom = @manhom
        )";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@manhom", groupId);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        studentNames.Add(reader["ten"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting student names: " + ex.Message);
            }
            return studentNames;
        }
        public List<string> GetStudentTaskByGroupId(string groupId)
        {
            List<string> studentNames = new List<string>();

            string sql = @" SELECT DangKy.tasktulam FROM DangKy WHERE DangKy.manhom = @manhom";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@manhom", groupId);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        studentNames.Add(reader["tasktulam"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting task: " + ex.Message);
            }
            return studentNames;
        }
        public string GetThesisTaskByGroupId(string groupId)
        {
            string task = "";

            string sql = "SELECT LuanVan.task FROM LuanVan INNER JOIN DangKy ON LuanVan.maluanvan = DangKy.maluanvan WHERE DangKy.manhom = @manhom";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@manhom", groupId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        task = reader["task"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting thesis task: " + ex.Message);
            }
            return task; 
        } 
        
        public string GetThesisProgress(string studentId, string thesisId)
        {
            string sql = "SELECT tiendo FROM DangKy WHERE maluanvan = @maluanvan";
            string progress = "";

            SqlConnection connection = DBConnection.GetSqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@masinhvien", studentId);
            command.Parameters.AddWithValue("@maluanvan", thesisId);
            object result = command.ExecuteScalar();
            if (result != null)
            {
                progress = result.ToString();
            }
            connection.Close();
            return progress;
        }

        public string GetThesisProgressByGroupId(string groupId)
        {
            string sql = "SELECT tiendo FROM DangKy WHERE manhom = @manhom";
            string progress = "";

            SqlConnection connection = DBConnection.GetSqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@manhom", groupId);
            object result = command.ExecuteScalar();
            if (result != null)
            {
                progress = result.ToString();
            }
            connection.Close();
            return progress;
        }

        public bool UpdateXetDuyet(string duyet, int manhom)
        {
            string sqlStr = "UPDATE DangKy SET xetduyet=@duyet WHERE manhom=@manhom";
            SqlConnection conn = DBConnection.GetSqlConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@duyet", duyet);
                cmd.Parameters.AddWithValue("@manhom", manhom);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật xét duyệt thất bại " + ex);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public void UpdateXetDuyetTableLuanVan(string duyet, string maluanvan)
        {
            string sqlStr = "UPDATE LuanVan SET xetduyet=@duyet WHERE maluanvan=@maluanvan";
            SqlConnection conn = DBConnection.GetSqlConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@duyet", duyet);
                cmd.Parameters.AddWithValue("@maluanvan", maluanvan);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật xét duyệt thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public bool UpdateThesisProgress(string studentId, string thesisId, string progress)
        {
            SqlConnection connection = DBConnection.GetSqlConnection();
            connection.Open();
            try
            {
                string sql = "UPDATE DangKy SET tiendo=@tiendo WHERE  maluanvan=@maluanvan";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@tiendo", progress);
                command.Parameters.AddWithValue("@masinhvien", studentId);
                command.Parameters.AddWithValue("@maluanvan", thesisId);
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public string GetXetDuyet(string masinhvien)
        {
            string sql = "SELECT xetduyet FROM DangKy WHERE masinhvien = @masinhvien";
            string xetduyet = "";

            SqlConnection connection = DBConnection.GetSqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@masinhvien", masinhvien);
            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                xetduyet = result.ToString();
            }
            connection.Close();
            return xetduyet;
        }
        public string GetTasksForThesis(string LuanVanId)
        {
            string tasks = "";
            string sql = "SELECT task FROM LuanVan WHERE maluanvan = @LuanVanId";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@LuanVanId", LuanVanId);
                    tasks = command.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return tasks;
        }

        public void UpdateTasksForThesis(string LuanVanId, string updatedTasks)
        {
            string sql = "UPDATE LuanVan SET task = @tasks WHERE maluanvan = @LuanVanId";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@tasks", updatedTasks);
                    command.Parameters.AddWithValue("@LuanVanId", LuanVanId);
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
