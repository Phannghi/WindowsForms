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
    internal class GiangVienDAO
    {

        public GiangVienDAO()
        {

        }
        static SqlCommand sqlCommand; // dung de truy van cau lenh insert, delete,...
        static SqlDataReader dataReader; // dung de doc du lieu trong bang

        public static List<GiangVien> TaiKhoanGiangViens(string query)
        {
            List<GiangVien> giangViens = new List<GiangVien>();
            using (SqlConnection sqlConnection = DBConnection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    giangViens.Add(new GiangVien(dataReader.GetString(0)));
                }
                sqlConnection.Close();
            }
            return giangViens;
        }

        public static GiangVien GetGiangVien(string tenTK, string matKhau)
        {
            GiangVien giangvien = new GiangVien();
            string query = "SELECT * FROM GiangVien WHERE magiangvien = '" + tenTK + "' and matkhau = '" + matKhau + "'";


            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    giangvien.Id = reader.GetString(0);
                    giangvien.Ten = reader.GetString(1);
                    giangvien.Diachi = reader.GetString(2);
                    giangvien.Ngaysinh = reader.GetDateTime(3);
                    giangvien.Email = reader.GetString(4);
                    giangvien.Sdt = reader.GetString(5);
                    giangvien.Gioitinh = reader.GetString(6);
                    giangvien.Nganh = reader.GetString(7);

                }
                reader.Close();
                conn.Close();
            }
            return giangvien;
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
        public void Them(LuanVan lv)
        {
            string sqlStr = string.Format("INSERT INTO LuanVan(maluanvan , tenluanvan, soluongdangky, mota, yeucau,congnghe) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}' , '{5}')", lv.Tenluanvan, lv.Maluanvan, lv.Soluong, lv.Mota, lv.Yeucau, lv.Congnghe);
            thucThi(sqlStr);
        }
        public void Xoa(LuanVan lv)
        {
            string sqlStr = string.Format("DELETE FROM LuanVan WHERE maluanvan = ('{0}')", lv.Maluanvan);
            thucThi(sqlStr);
        }
        //public void Sua(GiangVien gv)
        //{
        //    string sqlStr = string.Format("UPDATE LuanVan SET Ten = '{0}', DiaChi ='{1}', Cmnd = '{2}', NgaySinh = '{3}' , Email = '{4}', Sdt = '{5}',Id = '{6}',  GioiTinh = '{7}'WHERE Cmnd = {2}", gv.Ten, gv.DiaChi, gv.Id, gv.NgaySinh, gv.Email, gv.Sdt, gv.Id, gv.GioiTinh);
        //    thucThi(sqlStr);
        //}
    }
}
