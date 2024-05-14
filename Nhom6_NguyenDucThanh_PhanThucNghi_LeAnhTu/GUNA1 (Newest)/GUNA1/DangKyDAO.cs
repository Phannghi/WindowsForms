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
    public class DangKyDAO
    {
        public DangKyDAO() { }

        public DataTable Load()
        {
            string sqlStr = "WITH RankedDangKy AS (\r\n    SELECT \r\n        DangKy.*,\r\n        LuanVan.Tenluanvan,\r\n        ROW_NUMBER() OVER (PARTITION BY DangKy.Maluanvan ORDER BY DangKy.Masinhvien) AS RowNum\r\n    FROM \r\n        DangKy\r\n    INNER JOIN \r\n        LuanVan ON DangKy.Maluanvan = LuanVan.Maluanvan\r\n)\r\nSELECT \r\n    Maluanvan, \r\n    Masinhvien, \r\n    Manhom, \r\n    Tiendo, \r\n    Chamdiem, \r\n    Danhgia, \r\n    Sotask, \r\n    Sohoanthanh,\r\n    Tenluanvan\r\nFROM \r\n    RankedDangKy\r\nWHERE \r\n    RowNum = 1;\r\n";
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public DataTable LoadDanhGia(string groupId)
        {
            string sqlStr = $"SELECT * FROM DangKy WHERE DangKy.manhom  = '{groupId}'";
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public DataTable LoadAllInDangKy()
        {
            string sqlStr = "SELECT DangKy.*, SinhVien.ten FROM DangKy INNER JOIN SinhVien ON DangKy.masinhvien = SinhVien.masinhvien";
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public void thucThi(string sqlStr)
        {
            DBConnection db = new DBConnection();
            db.ThucThi(sqlStr);
        }
        public DataTable LoadLvSvDangKiChoDuyet()
        {
            string sqlStr = "WITH RankedDangKy AS (\r\n    SELECT\r\n        DangKy.*,\r\n        ROW_NUMBER() OVER (PARTITION BY DangKy.Manhom ORDER BY DangKy.Masinhvien) AS RowNum\r\n    FROM\r\n        DangKy\r\n    WHERE\r\n        DangKy.xetduyet = 'NY'\r\n)\r\nSELECT\r\n    RankedDangKy.Maluanvan,\r\n    RankedDangKy.Masinhvien,\r\n    RankedDangKy.Manhom,\r\n    RankedDangKy.Tiendo,\r\n    RankedDangKy.Chamdiem,\r\n    RankedDangKy.Danhgia,\r\n    RankedDangKy.Sotask,\r\n    RankedDangKy.xetduyet,\r\n    LuanVan.Tenluanvan\r\nFROM\r\n    RankedDangKy\r\nINNER JOIN\r\n    LuanVan ON RankedDangKy.Maluanvan = LuanVan.Maluanvan\r\nWHERE\r\n    RankedDangKy.RowNum = 1;\r\n";

            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public DataTable FilterByThesisId(string thesisID)
        {
            string sqlStr = $"SELECT DangKy.*, SinhVien.ten FROM DangKy INNER JOIN SinhVien ON DangKy.masinhvien = SinhVien.masinhvien WHERE DangKy.manhom = '{thesisID}'";
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public void UpdateSotask()
        {
            string sqlStr = @"
        UPDATE DangKy
        SET sotask = 
            CASE 
                WHEN ISNULL(task, '') = '' THEN 0
                ELSE LEN(task) - LEN(REPLACE(task, ',', '')) + 1
            END
        FROM DangKy dk
        INNER JOIN LuanVan lv ON dk.Maluanvan = lv.Maluanvan;";

            SqlConnection conn = DBConnection.GetSqlConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật task thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateSohoanthanh()
        {
            string sqlStr = @"
        UPDATE DangKy
        SET sohoanthanh = 
            CASE 
                WHEN tiendo IS NULL THEN 0
                WHEN tiendo = '' THEN 0
                ELSE LEN(tiendo) - LEN(REPLACE(tiendo, ',', '')) + 1
            END;";

            SqlConnection conn = DBConnection.GetSqlConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật tiến độ thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public bool SaveComment(string groupId, string comment)
        {
            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                connection.Open();
                try
                {
                   
                    string taskString = "/" + comment;
                    string sql = "UPDATE DangKy SET danhgia = CONCAT(ISNULL(danhgia, ''), @danhgia) WHERE manhom = @manhom";

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@danhgia", taskString);
                    command.Parameters.AddWithValue("@manhom", groupId);
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving comment: " + ex.Message);
                    return false;
                }
            }
        }
        public void ChamDiem(string masinhvien, float diem)
        {
            string sqlStr = "UPDATE DangKy SET chamdiem = @chamdiem WHERE masinhvien = @masinhvien";
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@chamdiem", diem);
                    cmd.Parameters.AddWithValue("@masinhvien", masinhvien);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable GetStudentsFromGroupId(string groupId)
        {
            DataTable dt = new DataTable();

            string sql = "SELECT DangKy.masinhvien,DangKy.sotask, DangKy.tasktulam, DangKy.chamdiem, SinhVien.ten FROM DangKy INNER JOIN SinhVien ON DangKy.masinhvien = SinhVien.masinhvien WHERE DangKy.manhom = @manhom";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@manhom", groupId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return dt;
        }
        public DataTable GetStudentsFromId(string Id)
        {
            DataTable dt = new DataTable();

            string sql = "SELECT DangKy.masinhvien,DangKy.sotask, DangKy.tasktulam, DangKy.chamdiem, SinhVien.ten FROM DangKy INNER JOIN SinhVien ON DangKy.masinhvien = SinhVien.masinhvien WHERE DangKy.masinhvien = @masinhvien";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@masinhvien", Id);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return dt;
        }
        public List<int> GetGroupIdsByStudentId(string studentId)
        {
            List<int> groupIds = new List<int>();

            string sql = "SELECT manhom FROM DangKy WHERE masinhvien = @masinhvien";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@masinhvien", studentId);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int groupId = Convert.ToInt32(reader["manhom"]);
                        groupIds.Add(groupId);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return groupIds;
        }

        public string GetCommentByStudentId(string studentId)
        {
            string comments = "";

            string sql = "SELECT DangKy.danhgia FROM DangKy WHERE DangKy.masinhvien = @masinhvien";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@masinhvien", studentId);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Split comments by "/" and remove empty entries
                        string[] commentParts = reader["danhgia"].ToString().Split('/').Where(c => !string.IsNullOrEmpty(c)).ToArray();
                        comments = string.Join("/", commentParts);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return comments;
        }
        public int GetTaskTulam(string studentId)
        {
            int taskTulam = 0;
            string sqlStr = "SELECT tasktulam FROM DangKy WHERE masinhvien = @studentId";

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        taskTulam = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy số lượng task tự làm: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return taskTulam;
        }

        public void UpdateTaskTuLam(int soluong, string studentId)
        {
            string sqlStr = "UPDATE DangKy SET tasktulam = @soluong WHERE masinhvien = @masinhvien";
            SqlConnection conn = DBConnection.GetSqlConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@soluong", soluong);
                cmd.Parameters.AddWithValue("@masinhvien", studentId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật tasktulam thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public bool UpdatePhanTramTienDo(string taskName, int phanTram, string studentId, string thesisId)
        {
            string sqlStr = "UPDATE PhanTramTask SET phantram = @phantram WHERE maluanvan = @maluanvan AND taskrieng = @taskrieng";
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@phantram", phanTram);
                    cmd.Parameters.AddWithValue("@maluanvan", thesisId);
                    cmd.Parameters.AddWithValue("@taskrieng", taskName);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public int GetTaskPercentage(string thesisId, string taskName)
        {
            string sqlStr = "SELECT phantram FROM PhanTramTask WHERE maluanvan = @maluanvan AND taskrieng = @taskrieng";
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@maluanvan", thesisId);
                    cmd.Parameters.AddWithValue("@taskrieng", taskName);

                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
        }

        LuanVanDAO lvDao = new LuanVanDAO();
        public void AddTaskToPhanTramTask(string studentId, string task)
        {
            string thesisId = lvDao.GetThesisId(studentId); // Lấy mã luận văn
            string sqlStr = "INSERT INTO PhanTramTask (maluanvan, taskrieng) VALUES (@maluanvan, @taskrieng)";
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@maluanvan", thesisId);
                    cmd.Parameters.AddWithValue("@taskrieng", task);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}

