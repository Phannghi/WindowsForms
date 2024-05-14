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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUNA1
{
    public partial class ucThongKe : UserControl
    {
        public ucThongKe()
        {
            InitializeComponent();
        }
        private void LoadPieChart()
        {
            string sql = "SELECT chamdiem, COUNT(*) AS count FROM DangKy GROUP BY chamdiem";

            // Tạo kết nối và command
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Xóa dữ liệu cũ
                        chart1.Series[0].Points.Clear();

                        // Thêm dữ liệu vào biểu đồ
                        while (reader.Read())
                        {
                            string chamdiem = reader["chamdiem"] != DBNull.Value ? reader["chamdiem"].ToString() : "Chưa chấm điểm";
                            int count = Convert.ToInt32(reader["count"]);

                            chart1.Series[0].Points.AddXY(chamdiem, count);
                        }
                    }
                }
            }

            // Cấu hình biểu đồ Pie
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LabelFormat = "#.##";

            // Đặt tên cho trục Y
            chart1.ChartAreas[0].AxisY.Title = "Số lượng";

            // Đặt tiêu đề cho biểu đồ
            chart1.Titles.Clear();
            

        }
        private void PieChart2()
        {
            string sql = "SELECT chamdiem FROM DangKy WHERE chamdiem IS NOT NULL";

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    int quaMonCount = 0;
                    int rotMonCount = 0;

                    while (reader.Read())
                    {
                        float diem = Convert.ToSingle(reader["chamdiem"]);
                        if (diem >= 5)
                        {
                            quaMonCount++;
                        }
                        else
                        {
                            rotMonCount++;
                        }
                    }

                    // Add data to chart
                    chart2.Series["Series1"].Points.AddXY("Qua môn", quaMonCount);
                    chart2.Series["Series1"].Points.AddXY("Rớt môn", rotMonCount);

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }


        }
        private void ucThongKe_Load(object sender, EventArgs e)
        {
            LoadPieChart();
            PieChart2();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
