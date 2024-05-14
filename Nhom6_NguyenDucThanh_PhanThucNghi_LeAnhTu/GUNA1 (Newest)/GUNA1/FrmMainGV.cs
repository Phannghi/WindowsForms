using DevExpress.Office.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNA1
{
    public partial class FrmMainGV : Form
    {
        GiangVienDAO gvDao = new GiangVienDAO();
        LuanVanDAO lvDao = new LuanVanDAO();
        DangKyDAO dkDao = new DangKyDAO();
        BoxChatDAO chatDao = new BoxChatDAO();
        private GiangVien giangvien;
  
        public FrmMainGV(GiangVien giangVien)
        {
            InitializeComponent();
            this.giangvien = giangVien;
            
            HideAllUserControls();
            LoadTheses();
            LoadTheDangKy();
            LoadThesesNY();
            LoadThesesSvDky();
            LoadTheDanhGia();
            LoadDsChamDiem();


        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            FrmMainGV_Load(sender, e);
        }

        private void guna2CircleButton1_MouseEnter(object sender, EventArgs e)
        {
            guna2CircleButton1.Size = new Size(guna2CircleButton1.Width + 10, guna2CircleButton1.Height + 10);
            
        }
        public void LoadTheses()
        {
            DataTable dt = lvDao.Load();
            List<LuanVan> theses = dt.AsEnumerable()
               .Select(row => new LuanVan()
               {
                   Maluanvan = row["maluanvan"].ToString(),
                   Tenluanvan = row["tenluanvan"].ToString(),
                   Congnghe = row["congnghe"].ToString(),
                   Tengiangvien = row["tengiangvien"].ToString(),
                   Soluong = Convert.ToInt32(row["soluongdangky"]),
                   Xetduyet = row["xetduyet"].ToString()
               })
               .ToList();

            userControlAddThesis2.Theses = theses;
            userControlAddThesis2.LoadTheses();
        }
        private TheTienDoCuaSV selectedTD;
        public void LoadTheDanhGia()
        {
            selectedTD = ucCheckPro1.selectedTTD;
            if (selectedTD != null)
            {
                string groupId = selectedTD.Manhom.ToString();
                ucViewProgress1.LoadComments(groupId);
            }

        }

        public void LoadTheDangKy()
        {
            DataTable dt = dkDao.Load();
            List<DangKy> thedky = new List<DangKy>();

            foreach (DataRow row in dt.Rows)
            {
                DangKy dk = new DangKy();
                dk.Maluanvan = row["maluanvan"].ToString();
                dk.Tenluanvan = row["tenluanvan"].ToString();
                dk.Manhom = row["manhom"] == DBNull.Value ? 0 : Convert.ToInt32(row["manhom"]);
                dk.Sohoanthanh = row["sohoanthanh"] == DBNull.Value ? 0 : Convert.ToInt32(row["sohoanthanh"]);
                dk.Sotask = row["sotask"] == DBNull.Value ? 0 : Convert.ToInt32(row["sotask"]);

                thedky.Add(dk);
            }
            ucCheckPro1.TheDky = thedky;
            ucCheckPro1.LoadProcess();
        }

        private void btnGuiDanhGia_Click(object sender, EventArgs e)
        {
            selectedTD = ucCheckPro1.selectedTTD;
            if (selectedTD != null)
            {
                string groupId = selectedTD.Manhom.ToString();

                // Lấy nội dung của TextBox txtDanhGia
                string danhGia = ucViewProgress1.txtDanhGia.Text;

                // Lấy mã giảng viên
                string magiangvien = giangvien.Id;

                // Tạo đối tượng ChatBox mới
                ChatBox chatBox = new ChatBox(magiangvien, "", "", Convert.ToInt32(groupId), danhGia, DateTime.Now);

                // Thêm vào cơ sở dữ liệu
                chatDao.AddChatMessage(chatBox.Magiangvien, chatBox.Masinhvien, chatBox.Manhom, chatBox.Ten, chatBox.Noidungchat);

                // Load lại danh sách đánh giá với groupId tương ứng
                ucViewProgress1.LoadComments(groupId);
            }
        }
            
        
        
        private void btnViewProgress_Click(object sender, EventArgs e)
        {
            
            LoadTheDanhGia();
            HideAllButton();
            LoadDsChamDiem();
            btnGuiDanhGia.Visible = false;
            btnTinNhan.Visible = true;
            btnChamDiem.Visible = true;
            btnMoUcThemTask.Visible = true;
            selectedTD = ucCheckPro1.selectedTTD;
            if (selectedTD != null)
            {
                string groupId = selectedTD.Manhom.ToString();
                ucViewProgress1.Visible = true;
                string task = lvDao.GetThesisTaskByGroupId(groupId);
                string tlv = lvDao.GetThesisNameByMaNhom(groupId);
                string cn = lvDao.GetTechnoByNaNhom(groupId);
                
                ucViewProgress1.lblThesisName.Text = tlv;
                ucViewProgress1.lblCongNghe.Text = cn;
                List<string> studentNames = lvDao.GetStudentNamesByGroupId(groupId);
                ucViewProgress1.FLPTenSVNhom.Controls.Clear(); // Xóa các control cũ trước khi thêm mới
                List<string> tasktulamcuasv = lvDao.GetStudentTaskByGroupId(groupId);
                ucViewProgress1.FLPTaskHT.Controls.Clear();
                // Add labels for each student to the FlowLayoutPanel
                foreach (string studentName in studentNames)
                {
                    Label label = new Label();
                    label.Text = studentName;
                    label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    label.AutoSize = false;
                    label.Size = new Size(350, 25);
                    ucViewProgress1.FLPTenSVNhom.Controls.Add(label);
                }
                foreach (string tasktulam in tasktulamcuasv)
                {
                    Label label = new Label();
                    label.Text = tasktulam;
                    label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    label.AutoSize = false;
                    label.Size = new Size(350, 25);
                    ucViewProgress1.FLPTaskHT.Controls.Add(label);
                }
                if (!string.IsNullOrEmpty(task))
                {
                    string[] tasks = task.Split(',');

                    ucViewProgress1.FLPHienThiYeuCau.Controls.Clear(); // Xóa các control cũ trước khi thêm mới

                    ucViewProgress1.FLPHienThiYeuCau.FlowDirection = FlowDirection.TopDown;

                    // Set font and size for checkboxes
                    Font font = new Font("Segoe UI", 12, FontStyle.Bold);

                    // Add checkboxes for each task to the FlowLayoutPanel on UcUpdatePro
                    foreach (string t in tasks)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Text = t.Trim();
                        checkBox.Font = font; // Set font
                        checkBox.CausesValidation = true; // Set CausesValidation to true

                        // Tạo tooltip với nội dung của nhiệm vụ tương ứng
                        ToolTip toolTip = new ToolTip();
                        toolTip.SetToolTip(checkBox, t.Trim()); // Đặt nội dung tooltip
                        ucViewProgress1.FLPHienThiYeuCau.Controls.Add(checkBox);
                        checkBox.AutoSize = false;
                        checkBox.Size = new Size(350, 25);
                        UpdateCheckboxState();
                        checkBox.Enabled = false;
                    }
                }
                else
                {
                    ucViewProgress1.FLPHienThiYeuCau.Controls.Clear();
                    MessageBox.Show("Không tìm thấy nhiệm vụ cho luận văn này.");
                }
            }

        }
        private void UpdateCheckboxState()
        {
            selectedTD = ucCheckPro1.selectedTTD;
            string groupId = selectedTD.Manhom.ToString();
            // Lấy tiến độ từ csdl 
            string currentProgress = lvDao.GetThesisProgressByGroupId(groupId);

            foreach (CheckBox checkBox in ucViewProgress1.FLPHienThiYeuCau.Controls.OfType<CheckBox>())
            {
                // Kiểm tra xem nội dung của checkbox có trong tiến độ không
                string taskId = checkBox.Text.Trim();
                bool isChecked = currentProgress.Contains(taskId);
                // Cập nhật trạng thái của checkbox
                checkBox.Checked = isChecked;
            }
        }
        private void guna2CircleButton1_MouseLeave(object sender, EventArgs e)
        {
            guna2CircleButton1.Size = new Size(guna2CircleButton1.Width - 10, guna2CircleButton1.Height - 10);
            
        }
        
        private void FrmMainGV_Load(object sender, EventArgs e)
        {
            HideAllButton();
            HideAllUserControls();
            DataTable dt = lvDao.Load();
            userControlAddThesis2.dgvManageThesis.DataSource = dt;
            //userControlAddThesis2.btnSua.Click += btnSua_Click;
            userControlAddThesis2.btnXoa.Click += btnXoa_Click;
            disPlayUserInfo();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
                
            

        }
        public void HideAllButton()
        {
            btnThemThesis.Visible = false;
            btnViewProgress.Visible = false;
            btnGuiDanhGia.Visible = false;
            btnDuyet.Visible = false;
            btnDuyetSvDangKi.Visible = false;
            btnTinNhan.Visible = false;
            ucViewProgress1.FLPDanhGia.Visible=false;
            ucViewProgress1.txtDanhGia.Visible=false;
            btnChamDiem.Visible = false;
            btnLuuDiem.Visible = false;
            btnThemTaskVaoData.Visible = false;
            btnMoUcThemTask.Visible = false;
        }

        public void HideAllUserControls()
        {
            userControlAddThesis2.Visible = false;
            ucInfo1.Visible = false;
            ucMark1.Visible = false;
            ucAppPro1.Visible = false;
            ucCheckPro1.Visible = false;
            ucViewProgress1.Visible = false;
            ucDuyetSvDangKi1.Visible = false;
            ucMark2.Visible = false;
            ucThongKe1.Visible = false;
            ucThemTask1.Visible = false;
        }

        // Gọi phương thức HideAllUserControls từ một nơi khác trong lớp FrmMainGV hoặc từ một lớp khác
        private void SomeMethod()
        {
            HideAllUserControls();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            HideAllButton();
            ucInfo1.Visible = true;
        }

        private void userControlAddThesis2_Load(object sender, EventArgs e)
        {
            DataTable dt = lvDao.Load();
            userControlAddThesis2.dgvManageThesis.DataSource = dt;
            
        }
        private void disPlayUserInfo()
        {
            ucInfo1.txtTen.Text = giangvien.Ten;
            ucInfo1.txtNganh.Text = giangvien.Nganh;
            ucInfo1.dateTime.Value = giangvien.Ngaysinh;
            ucInfo1.txtDiaChi.Text = giangvien.Diachi;
            ucInfo1.txtEmail.Text = giangvien.Email;
            ucInfo1.txtSDT.Text = giangvien.Sdt;
            ucInfo1.txtGioiTinh.Text = giangvien.Gioitinh;
        }
       
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                FrmDangNhap dangNhap = new FrmDangNhap();
                dangNhap.ShowDialog();
                this.Close();
            }
        }
        
        private void btnTienDo_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            ucCheckPro1.Visible = true;
            HideAllButton();
            btnViewProgress.Visible = true;

            dkDao.UpdateSotask();
            dkDao.UpdateSohoanthanh();
            LoadTheDangKy();
        }

        public void GoBackToUcCheckPro()
        {
            // Ẩn ucViewProgress và hiện ucCheckPro
            ucViewProgress1.Visible = false;

            HideAllUserControls();
            ucCheckPro1.Visible = true;
            HideAllButton();
            btnViewProgress.Visible = true;
            btnChamDiem.Visible = false;
            dkDao.UpdateSotask();
            dkDao.UpdateSohoanthanh();
            LoadTheDangKy();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            HideAllButton();
            HideAllUserControls();
            userControlAddThesis2.Visible = true;
            btnThemThesis.Visible = true;
        }

        private void btnThemThesis_Click_1(object sender, EventArgs e)
        {
            FrmThemThesis frmThemThesis = new FrmThemThesis(giangvien);
            frmThemThesis.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoadTheses();
            LoadTheDangKy();
        }

        private void appPro_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            HideAllButton();
            ucAppPro1.Visible = true;
            btnDuyet.Visible = true;

        }
        public void LoadThesesNY()
        {
            DataTable dt = lvDao.LoadLvNY();
            List<LuanVan> theses = dt.AsEnumerable()
               .Select(row => new LuanVan()
               {
                   Maluanvan = row["maluanvan"].ToString(),
                   Tenluanvan = row["tenluanvan"].ToString(),
                   Congnghe = row["congnghe"].ToString(),
                   Tengiangvien = row["tengiangvien"].ToString(),
                   Soluong = Convert.ToInt32(row["soluongdangky"]),
                   Xetduyet = row["xetduyet"].ToString()
               })
               .ToList();
            
            ucAppPro1.Theses = theses;
            ucAppPro1.LoadTheses();
            
        }

        private string thesisId = "";
        private TheLuanVan selectedTLV;
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            selectedTLV = ucAppPro1.selectedTLV;

            if (selectedTLV != null)
            {
                thesisId = selectedTLV.Maluanvan;
                lvDao.DuyetLv(thesisId, "A");
                MessageBox.Show("Đã Duyệt");
            }
        }
        public void LoadThesesSvDky()
        {
            DataTable dt = dkDao.LoadLvSvDangKiChoDuyet();
            List<DangKy> theses = dt.AsEnumerable()
               .Select(row => new DangKy()
               {
                   Maluanvan = row["maluanvan"].ToString(),
                   Tenluanvan = row["tenluanvan"].ToString(),
                   
                   Manhom = Convert.ToInt32(row["manhom"]),
                   Xetduyet = row["xetduyet"].ToString()
               })
               .ToList();

            ucDuyetSvDangKi1.Theses = theses;
            ucDuyetSvDangKi1.LoadThesesDuyet();
        }

        private void btnChamDiem_Click_1(object sender, EventArgs e)
        {
            selectedTD = ucCheckPro1.selectedTTD;
            if (selectedTD != null)
            {
                ucMark2.Visible = true;
                btnLuuDiem.Visible = true;
                btnMoUcThemTask.Visible = false;
            }
        }

        public void LoadDsChamDiem()
        {
            selectedTD = ucCheckPro1.selectedTTD;
            if (selectedTD != null)
            {
                string groupId = selectedTD.Manhom.ToString();
                DataTable dt = dkDao.GetStudentsFromGroupId(groupId);
                List<DangKy> theses = dt.AsEnumerable()
   .Select(row => new DangKy()
   {
       Masinhvien = Convert.IsDBNull(row["masinhvien"]) ? null : row["masinhvien"].ToString(),
       Tensinhvien = Convert.IsDBNull(row["ten"]) ? null : row["ten"].ToString(),
       Sotask = Convert.IsDBNull(row["sotask"]) ? 0 : Convert.ToInt32(row["sotask"]),
       Tasktulam = Convert.IsDBNull(row["tasktulam"]) ? 0 : Convert.ToInt32(row["tasktulam"]),
       Chamdiem = Convert.IsDBNull(row["chamdiem"]) ? 0 : Convert.ToInt32(row["chamdiem"])
   })
   .ToList();

                ucMark2.Theses = theses;
                ucMark2.LoadThesesDuyet();
            }
        }
        private void btnDuyetDangKy_Click(object sender, EventArgs e)
        {
            HideAllButton();
            HideAllUserControls();
            ucDuyetSvDangKi1.Visible=true;
            btnDuyetSvDangKi.Visible=true;
        }

        
        private int manhom = 0;
        private string maluanvan = "";
        private TheDangKiLuanVan selectTDK;
        private void btnDuyetSvDangKi_Click(object sender, EventArgs e)
        {
            string duyet = "Y";
            selectTDK = ucDuyetSvDangKi1.selectedTDK;
            if (selectTDK != null)
            {
                manhom = selectTDK.MaNhom;
                maluanvan = selectTDK.Maluanvan;
                MessageBox.Show("Mã nhóm: " + manhom + "\n" + "Mã luận văn: " + maluanvan);
                if (lvDao.UpdateXetDuyet(duyet, manhom))
                {
                    MessageBox.Show("Cập nhật xét duyệt luân văn " + maluanvan + " thành công.");
                }
                lvDao.UpdateXetDuyetTableLuanVan(duyet, maluanvan);
                LoadThesesSvDky();
            }
        }
    

        private void btnTinNhan_Click(object sender, EventArgs e)
        {
            ucViewProgress1.FLPDanhGia.Visible = true;
            ucViewProgress1.txtDanhGia.Visible = true;
            btnGuiDanhGia.Visible = true;
            btnTinNhan.Visible = false;
            btnGuiDanhGia.Visible = true;
            btnLuuDiem.Visible = false;
            btnChamDiem.Visible = false;
            btnMoUcThemTask.Visible = false;
           
        }
        private string msv = " ";
        private TheChamDiem selectedCD;
        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            selectedCD = ucMark2.selectedTCD;

            if (selectedCD != null)
            {
                msv = selectedCD.Masinhvien;
                // Chuyển đổi chuỗi nhập điểm thành số thực
                float diem = float.Parse(ucMark2.txtNhapDiem.Text);
                dkDao.ChamDiem(msv, diem);
                MessageBox.Show("Đã Chấm Điểm ");
            }
        }

        

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ucThongKe1.Visible = true;
        }

        private void btnThemTaskVaoData_Click(object sender, EventArgs e)
        {
            selectedTD = ucCheckPro1.selectedTTD;
            if (selectedTD != null)
            {
                string LuanVanId = selectedTD.Maluanvan.ToString();
                string newTasks = ucThemTask1.txtNhapTaskThem.Text;

                // Get the existing tasks for the thesis
                string existingTasks = lvDao.GetTasksForThesis(LuanVanId);

                // Append the new tasks with a comma
                string updatedTasks = existingTasks + "," + newTasks;

                // Update the tasks in the database
                lvDao.UpdateTasksForThesis(LuanVanId, updatedTasks);
                MessageBox.Show("Them Task Thanh Cong !!!");
            }
        }

        private void btnMoUcThemTask_Click(object sender, EventArgs e)
        {
            ucThemTask1.Visible = true;
            btnThemTaskVaoData.Visible = true;
        }
    }
}
