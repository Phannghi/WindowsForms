using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUNA1 
{
    internal class DBConnection
    {
        private static string strConnection = @"Data Source=DESKTOP-O9AVOH5\SQLEXPRESS;Initial Catalog = DoAnGUNA; Integrated Security= True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strConnection);
        }

        private SqlConnection conn;
        private string connString;

        public DBConnection()
        {
            connString = strConnection;
            try
            {
                conn = new SqlConnection(connString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("connected failed: " + ex.Message);
            }
        }

        public DataTable Load(string sqlStr)
        {
            DataTable dtSinhVien = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtSinhVien);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtSinhVien;
        }
        public object ExecuteScalar(string sqlStr, params SqlParameter[] parameters)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public void ThucThi(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thay đổi Thành Công ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thay đổi thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void ThucHienDky(string sqlStr)
        {
            
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                conn.Close();
            
        }
    }
}
