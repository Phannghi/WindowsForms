using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNA1
{
    internal class SinhVienDAO
    {
        public DataTable LoadSv()
        {
            string sqlStr = string.Format("SELECT * FROM SinhVien ");
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public SinhVienDAO()
        {

        }
        static SqlCommand sqlCommand; // dung de truy van cau lenh insert, delete,...
        static SqlDataReader dataReader; // dung de doc du lieu trong bang

        public static List<SinhVien> TaiKhoanSinhViens(string query)
        {
            List<SinhVien> sinhViens = new List<SinhVien>();
            using (SqlConnection sqlConnection = DBConnection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    sinhViens.Add(new SinhVien(dataReader.GetString(0)));
                }
                sqlConnection.Close();
            }
            return sinhViens;
        }
        public DataTable FilterBySVId(string SvID)
        {
            string sqlStr = $"SELECT * FROM SinhVien WHERE SinhVien.masinhvien = '{SvID}'";
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public static SinhVien GetSinhVien(string tenTK, string matKhau)
        {
            SinhVien sinhvien = new SinhVien();
            string query = "SELECT * FROM SinhVien WHERE masinhvien = '" + tenTK + "' and matkhau = '" + matKhau + "'";


            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    sinhvien.Id = reader.GetString(0);
                    sinhvien.Ten = reader.GetString(1);
                    sinhvien.Diachi = reader.GetString(2);
                    sinhvien.Ngaysinh = reader.GetDateTime(3);
                    sinhvien.Email = reader.GetString(4);
                    sinhvien.Sdt = reader.GetString(5);
                    sinhvien.Gioitinh = reader.GetString(6);
                    sinhvien.Nganh = reader.GetString(7);

                }
                reader.Close();
                conn.Close();
            }
            return sinhvien;
        }
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM LuanVan");
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public void thucThi(string sqlStr)
        {
            DBConnection db = new DBConnection();
            db.ThucThi(sqlStr);
        }
    }
}
