using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUNA1
{
    public partial class FrmMainHS : Form
    {
        private LuanVanDAO lvDao = new LuanVanDAO();
        private SinhVienDAO svDao = new SinhVienDAO();
        private DangKyDAO dkDao = new DangKyDAO();
        private SinhVien sinhvien;

        private DBConnection dbConnection = new DBConnection();
        public FrmMainHS(SinhVien sinhVien)
        {
            InitializeComponent();
            this.sinhvien = sinhVien;
            //guna2Panel1.Controls.Add(userControlAddThesis1);
            HideAllUserControls();
            LoadTheses();
            LoadSV();
            LoadTheDanhGia();
            LoadDsChamDiem();
        }
        private void HideAllButton()
        {
            btnTimKiem.Visible = false;
            btnDangKy.Visible = false;
            btnHSDeNghi.Visible = false;
            btnClose.Visible = false;
            btnLuu.Visible = false;
            btnThemSinhVien.Visible = false;
            btnThemSinhVien.Visible = false;
            txtNhapMSV.Visible = false;
            btnTimSV.Visible = false;
            btnMoUcThemSV.Visible = false;
            btnReLoad.Visible = false;
            btnBack.Visible = false;
            ucUpdatePro1.txtGuiTinNhan.Visible = false;
            ucUpdatePro1.FLPDanhGia.Visible = false;
            btnGuiTinNhan.Visible = false;
            btnTinNhan.Visible = false;
            ucUpdatePro1.lblMB.Visible = false;
            btnChatRieng.Visible = false;
        }
        private void HideAllUserControls()
        {

            ucInfo1.Visible = false;
            ucDangKiLuanVan1.Visible = false;
            ucUpdatePro1.Visible = false;
            ucThemSvVaoNhom1.Visible = false;
            ucXemDiem1.Visible = false;
            ucPhanTramTienDo1.Visible = false;
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
                   Soluong = Convert.ToInt32(row["soluongdangky"])
               })
               .ToList();

            ucDangKiLuanVan1.Theses = theses;
            ucDangKiLuanVan1.LoadTheses();

        }

        // Gọi phương thức HideAllUserControls từ một nơi khác trong lớp FrmMainGV hoặc từ một lớp khác
        private void SomeMethod()
        {
            // Gọi phương thức HideAllUserControls
            HideAllUserControls();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            HideAllButton();
            ucInfo1.Visible = true;
        }

        private void addEs_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            ucDangKiLuanVan1.Visible = true;
            btnTimKiem.Visible = true;
            btnDangKy.Visible = true;
            btnHSDeNghi.Visible = true;
            btnClose.Visible = true;
            btnLuu.Visible = false;
            btnMoUcThemSV.Visible = true;
            
            btnThemSinhVien.Visible = false;
            txtNhapMSV.Visible = false;
            btnTimSV.Visible = false;
            btnTinNhan.Visible = false;
            btnGuiTinNhan.Visible = false;
            ucUpdatePro1.lblMB.Visible = false;
        }
        private void comboBoxGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLecturer = ucDangKiLuanVan1.comboBoxGiangVien.SelectedValue.ToString();

            // Lọc luận văn theo tên giảng viên được chọn
            lvDao.FilterThesisByLecturer(selectedLecturer);
        }
        private void LoadGiangVienComboBox()
        {
            try
            {
                string sql = "SELECT tengiangvien FROM LuanVan";
                DataTable dtGiangVien = dbConnection.Load(sql);

                if (dtGiangVien != null && dtGiangVien.Rows.Count > 0)
                {
                    ucDangKiLuanVan1.comboBoxGiangVien.DataSource = dtGiangVien; 
                    ucDangKiLuanVan1.comboBoxGiangVien.DisplayMember = "tengiangvien";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading lecturer data: " + ex.Message);
            }
        }
        private void disPlayUserInfo()
        {
            ucInfo1.txtTen.Text = sinhvien.Ten;
            ucInfo1.txtNganh.Text = sinhvien.Nganh;
            ucInfo1.dateTime.Value = sinhvien.Ngaysinh;
            ucInfo1.txtDiaChi.Text = sinhvien.Diachi;
            ucInfo1.txtEmail.Text = sinhvien.Email;
            ucInfo1.txtSDT.Text = sinhvien.Sdt;
            ucInfo1.txtGioiTinh.Text = sinhvien.Gioitinh;

        }
        public void LoadTheDanhGia()
        {

            string studentId = sinhvien.Id;

            // Lấy danh sách các nhóm mà sinh viên đã tham gia
            List<int> groupIds = dkDao.GetGroupIdsByStudentId(studentId);

            foreach (int groupId in groupIds)
            {
                ucUpdatePro1.LoadComments(groupId.ToString());
            }

        }
        private void FrmMainHS_Load(object sender, EventArgs e)
        {
            
            HideAllUserControls();
            HideAllButton();

            // Thêm một checkbox vào FlowLayoutPanel
            CheckBox checkBox = new CheckBox();
            ucUpdatePro1.FLPHienThiYeuCau.Controls.Add(checkBox);

            DataTable dt = svDao.Load();
            ucDangKiLuanVan1.dgvManageThesis.DataSource = dt;
            UpdateCheckboxState();
           

            disPlayUserInfo();
            LoadGiangVienComboBox();
            ucDangKiLuanVan1.comboBoxGiangVien.DataSource = lvDao.GetLecturerNames();
            ucDangKiLuanVan1.comboBoxGiangVien.DisplayMember = "tengiangvien";

        }
        
        private List<CheckBox> checkedBoxes; // Lưu các checkbox đã check

        // Hàm lấy các checkbox đã được check
        private List<CheckBox> GetCheckedBoxes(FlowLayoutPanel flowLayoutPanel)
        {
            List<CheckBox> checkedBoxes = new List<CheckBox>();

            // Duyệt qua tất cả các control trong FlowLayoutPanel
            foreach (Control control in flowLayoutPanel.Controls)
            {
                // Kiểm tra xem control có phải là CheckBox hay không
                if (control is CheckBox checkBox)
                {
                    // Nếu checkbox được chọn, thêm vào danh sách
                    if (checkBox.Checked)
                    {
                        checkedBoxes.Add(checkBox);
                    }
                }
            }
            return checkedBoxes;
        }

        // Luu tien do
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string studentId = sinhvien.Id;
            string thesisId = lvDao.GetThesisId(studentId);

            // Lấy giá trị hiện tại của tasktulam từ cơ sở dữ liệu
            int currentTaskTulam = dkDao.GetTaskTulam(studentId);

            checkedBoxes = GetCheckedBoxes(ucUpdatePro1.FLPHienThiYeuCau);

            // Tính số lượng task mới được check
            int newCheckedTasksCount = 0;
            foreach (CheckBox checkBox in checkedBoxes)
            {
                if (checkBox.Enabled && checkBox.Checked)
                {
                    newCheckedTasksCount++;
                }
            }

            // Update số lượng tasktulam
            int updatedTaskTulam = currentTaskTulam + newCheckedTasksCount;
            dkDao.UpdateTaskTuLam(updatedTaskTulam, studentId);

            // Cập nhật lại số lượng tasktulam khi check
            ucUpdatePro1.lblSoTask.Text = Convert.ToString(updatedTaskTulam);

            string taskString = string.Join(",", checkedBoxes.Select(x => x.Text.Trim()));

            if (lvDao.UpdateThesisProgress(studentId, thesisId, taskString))
            {
               
                // Cập nhật lại trạng thái của các checkbox
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật!");
            }
            dkDao.UpdateSohoanthanh();
            UpdateCheckboxState();
        }
    
        private void UpdateCheckboxState()
        {
            string studentId = sinhvien.Id;
            string thesisId = lvDao.GetThesisId(studentId);

            // Lấy tiến độ từ csdl 
            string currentProgress = lvDao.GetThesisProgress(studentId, thesisId);

            foreach (CheckBox checkBox in ucUpdatePro1.FLPHienThiYeuCau.Controls.OfType<CheckBox>())
            {
                // Kiểm tra xem nội dung của checkbox có trong tiến độ không
                string taskId = checkBox.Text.Trim();
                bool isChecked = currentProgress.Contains(taskId);
                // Cập nhật trạng thái của checkbox
                checkBox.Checked = isChecked;

                // Vô hiệu hóa checkbox nếu nó đã được check
                checkBox.Enabled = !isChecked;
            }
        }
        private void update_Click(object sender, EventArgs e)
        {
            LoadDsChamDiem();
            LoadTheDanhGia();
            HideAllUserControls();
            HideAllButton();
            ucUpdatePro1.Visible = true;
            btnLuu.Visible = true;
            btnTinNhan.Visible = true;
            string studentId = sinhvien.Id;
            string task = lvDao.GetThesisTaskByStudentId(studentId);
            string tsn = lvDao.GetThesisNameByStudentId(studentId);
            int tasktulam = dkDao.GetTaskTulam(studentId);

            string duyet = lvDao.GetXetDuyet(studentId);

            ucUpdatePro1.labelTenLuanVan.Text = tsn;
            ucUpdatePro1.lblMaSV.Text = studentId;
            ucUpdatePro1.lblSoTask.Text = Convert.ToString(tasktulam);
            if (duyet != "Y")
            {
                MessageBox.Show("Luận văn " + tsn + " chưa được giảng viên duyệt.");
            }
            else
            {
                if (!string.IsNullOrEmpty(task))
                {
                    string[] tasks = task.Split(',');

                    ucUpdatePro1.FLPHienThiYeuCau.Controls.Clear(); // Xóa các control cũ trước khi thêm mới

                    ucUpdatePro1.FLPHienThiYeuCau.FlowDirection = FlowDirection.TopDown;

                    // Set font and size for checkboxes
                    Font font = new Font("Segoe UI", 12, FontStyle.Regular);

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
                        ucUpdatePro1.FLPHienThiYeuCau.Controls.Add(checkBox);
                        checkBox.CheckedChanged += CheckBox_CheckedChanged;
                        checkBox.AutoSize = false;
                        checkBox.Size = new Size(350, 25);

                        // Thêm nhiệm vụ vào cột taskrieng trong bảng PhanTramTask
                        dkDao.AddTaskToPhanTramTask(studentId, t.Trim());
                        int currentPercentage = dkDao.GetTaskPercentage(lvDao.GetThesisId(studentId), t.Trim());
                        ucPhanTramTienDo1.tbPhanTram.Value = currentPercentage;
                        UpdateCheckboxState();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhiệm vụ cho luận văn này.");
                }
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                // Hiển thị UserControl ucPhanTramTienDo tương ứng
                ucPhanTramTienDo1.Location = new Point(checkBox.Left, checkBox.Bottom);
                ucPhanTramTienDo1.Visible = true;
                btnChatRieng.Visible = true;

                // Lấy thông tin sinh viên và mã luận văn
                string studentId = sinhvien.Id;
                string thesisId = lvDao.GetThesisId(studentId);

                // Gán giá trị phần trăm hiện tại cho Guna2TrackBar
                int currentPercentage = dkDao.GetTaskPercentage(thesisId, checkBox.Text);
                ucPhanTramTienDo1.tbPhanTram.Value = currentPercentage;

                // Gắn sự kiện ValueChanged của Guna2TrackBar để cập nhật giá trị phần trăm
                ucPhanTramTienDo1.tbPhanTram.ValueChanged += (s, ev) =>
                {
                    Guna.UI2.WinForms.Guna2TrackBar trackBar = (Guna.UI2.WinForms.Guna2TrackBar)s;
                    // Cập nhật giá trị phần trăm vào cột phantram của bảng SQL PhanTramTask
                    UpdatePhanTramTienDo(checkBox.Text, trackBar.Value);

                    // Nếu giá trị phần trăm là 100, thực hiện lưu và ẩn ucPhanTramTienDo
                    if (trackBar.Value == 100)
                    {
                        btnLuu_Click_1(null, EventArgs.Empty);
                        ucPhanTramTienDo1.Visible = false;
                        btnChatRieng.Visible = false;
                    }
                };
            }
            else
            {
                // Ẩn UserControl ucPhanTramTienDo khi checkbox không được chọn
                ucPhanTramTienDo1.Visible = false;
            }
        }


        private void UpdatePhanTramTienDo(string taskName, int phanTram)
        {
            // Lấy thông tin sinh viên và mã luận văn
            string studentId = sinhvien.Id;
            string thesisId = lvDao.GetThesisId(studentId);

            // Cập nhật phần trăm vào cột phantram của bảng PhanTramTask
            dkDao.UpdatePhanTramTienDo(taskName, phanTram, studentId, thesisId);
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string selectedLecturer = ucDangKiLuanVan1.comboBoxGiangVien.SelectedItem as string;
            DataTable dtThesis = lvDao.FilterThesisByLecturer(selectedLecturer);

            if (dtThesis != null)
            {
                // Xóa hết các UserControl hiện tại trong FlowLayoutPanel
                ucDangKiLuanVan1.FLPLuanVan.Controls.Clear();

                // Tạo và thêm UserControl mới tương ứng với các luận văn sau khi lọc
                foreach (DataRow row in dtThesis.Rows)
                {
                    TheLuanVan theLuanVan = new TheLuanVan()
                    {
                        Tenluanvan = row["tenluanvan"].ToString(),
                        Maluanvan = row["maluanvan"].ToString(),
                        Tengiangvien = row["tengiangvien"].ToString(),
                        Congnghe = row["congnghe"].ToString(),
                        Soluong = Convert.ToInt32(row["soluongdangky"])
                    };

                    ucDangKiLuanVan1.FLPLuanVan.Controls.Add(theLuanVan);

                }
            }
        }


        private string thesisId = "";

        private TheLuanVan selectedTLV; // Biến lưu trữ luận văn được chọn

        // Sự kiện Click của TheLuanVan
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            selectedTLV = ucDangKiLuanVan1.selectedTLV;

            if (selectedTLV != null)
            {
                thesisId = selectedTLV.Maluanvan;

                // Lấy danh sách sinh viên trong nhóm
                List<string> studentIds = GetStudentIdsInGroup();

                // Thêm mã sinh viên của sinh viên đăng nhập vào danh sách nếu chưa tồn tại
                string studentId = sinhvien.Id;
                if (!studentIds.Contains(studentId))
                {
                    studentIds.Add(studentId);
                }

                // Thực hiện đăng ký cho tất cả sinh viên trong nhóm
                foreach (string memberId in studentIds)
                {
                    // Kiểm tra trùng lặp đăng ký cho sinh viên
                    int duplicateCount = lvDao.CheckDuplicateRegistration(thesisId, memberId);
                    if (duplicateCount > 0)
                    {
                        MessageBox.Show("Sinh viên có mã " + memberId + " đã đăng ký luận văn này trước đây.");
                        continue; // Chuyển sang sinh viên tiếp theo nếu đã đăng ký trước đó
                    }

                    // Thực hiện đăng ký cho sinh viên
                    int registeredCount = lvDao.GetRegisteredStudentCount(thesisId);
                    int maxRegister = lvDao.GetMaxCountRegister(thesisId);
                    int availableRegister = maxRegister - registeredCount;

                    if (availableRegister <= 0)
                    {
                        MessageBox.Show("Luan van nay da du so luong sinh vien dang ky toi da!");
                        return;
                    }

                    // Thực hiện đăng ký
                    string sql = "INSERT INTO DangKy (maluanvan, masinhvien, xetduyet ) VALUES (@maluanvan, @masinhvien, @xetduyet)";
                    using (SqlConnection connection = DBConnection.GetSqlConnection())
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@maluanvan", thesisId);
                        command.Parameters.AddWithValue("@masinhvien", memberId);
                        command.Parameters.AddWithValue("@xetduyet", "NY");
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dang ky thanh cong cho sinh vien co ma " + memberId);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 luận văn để đăng ký");
            }

        }

        private void btnHSDeNghi_Click_1(object sender, EventArgs e)
        {
            FrmHSThemLuanVan frmhsthem = new FrmHSThemLuanVan(sinhvien);
            frmhsthem.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoadTheses();
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
        private List<string> studentIdsInGroup = new List<string>();

        private List<string> GetStudentIdsInGroup()
        {
            return studentIdsInGroup;
        }
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            string studentId = txtNhapMSV.Text.Trim();

            // Kiểm tra xem mã sinh viên đã tồn tại trong danh sách chưa
            if (!studentIdsInGroup.Contains(studentId))
            {
                // Thêm mã sinh viên vào danh sách
                studentIdsInGroup.Add(studentId);
                MessageBox.Show("Thêm sinh viên thành công!");
            }
            else
            {
                MessageBox.Show("Mã sinh viên đã tồn tại trong nhóm!");
            }

            // Xóa nội dung trong ô textbox sau khi thêm
            txtNhapMSV.Text = "";
        }
        public void LoadSV()
        {
            DataTable dt = svDao.LoadSv();
            List<SinhVien> SVien = dt.AsEnumerable()
               .Select(row => new SinhVien()
               {
                   Ten = row["ten"].ToString(),
                   Id = row["masinhvien"].ToString(),
                   Email = row["email"].ToString()
                   
               })
               .ToList();

            ucThemSvVaoNhom1.SVs = SVien;
            ucThemSvVaoNhom1.LoadSVs();
        }

        private void btnMoUcThemSV_Click(object sender, EventArgs e)
        {
            ucThemSvVaoNhom1.Visible = true;
            btnThemSinhVien.Visible = true;
            txtNhapMSV.Visible = true;
            btnTimSV.Visible = true;
            btnReLoad.Visible = true;
            btnBack.Visible = true;
            ucUpdatePro1.lblMB.Visible = false;
        }

        private void btnTimSV_Click(object sender, EventArgs e)
        {
            string SvId = txtNhapMSV.Text.Trim();

            if (!string.IsNullOrEmpty(SvId))
            {
                DataTable result = svDao.FilterBySVId(SvId);
                List<SinhVien> SVien = new List<SinhVien>();

                foreach (DataRow row in result.Rows)
                {
                    SinhVien sv = new SinhVien
                    {
                        Ten = row["ten"].ToString(),
                        Id = row["masinhvien"].ToString(),
                        Email = row["email"].ToString()
                        
                    };
                    SVien.Add(sv);
                }

                ucThemSvVaoNhom1.SVs = SVien;
                ucThemSvVaoNhom1.LoadSVs();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để tìm kiếm.");
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadSV();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ucThemSvVaoNhom1.Visible = false;
            btnThemSinhVien.Visible = false;
            txtNhapMSV.Visible = false;
            btnTimSV.Visible = false;
            btnReLoad.Visible = false;
            btnBack.Visible = false;
            ucUpdatePro1.lblMB.Visible = false;
        }
        BoxChatDAO chatDao = new BoxChatDAO();
        private void btnGuiTinNhan_Click(object sender, EventArgs e)
        {
            string studentId = sinhvien.Id;

            // Lấy thông tin nhóm đang tham gia của sinh viên
            List<int> groupIds = dkDao.GetGroupIdsByStudentId(studentId);

            foreach (int groupId in groupIds)
            {
                // Lấy nội dung của tin nhắn từ TextBox
                string tinNhan = ucUpdatePro1.txtGuiTinNhan.Text;

                // Tạo đối tượng ChatBox mới
                ChatBox chatBox = new ChatBox("", studentId, "", groupId, tinNhan, DateTime.Now);

                // Thêm tin nhắn vào cơ sở dữ liệu
                chatDao.AddChatMessage(chatBox.Magiangvien, chatBox.Masinhvien, chatBox.Manhom, chatBox.Ten, chatBox.Noidungchat);

                // Load lại danh sách tin nhắn với groupId tương ứng
                ucUpdatePro1.LoadComments(groupId.ToString());
            }
        }

        private void btnTinNhan_Click(object sender, EventArgs e)
        {
            ucUpdatePro1.txtGuiTinNhan.Visible = true;
            ucUpdatePro1.FLPDanhGia.Visible = true;
            btnGuiTinNhan.Visible = true;
            btnTinNhan.Visible=false;
            btnLuu.Visible = false;
            ucUpdatePro1.lblMB.Visible = true;
        }
        public void LoadDsChamDiem()
        {
            
                DataTable dt = dkDao.GetStudentsFromId(sinhvien.Id);
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

                ucXemDiem1.Theses = theses;
                ucXemDiem1.LoadThesesDuyet();
            
        }

        private void checkPro_Click(object sender, EventArgs e)
        {
            HideAllButton();
            HideAllUserControls();
            ucXemDiem1.Visible = true;
        }

        private void ucXemDiem1_Load(object sender, EventArgs e)
        {

        }

        private void btnChatRieng_Click(object sender, EventArgs e)
        {
            string studentId = sinhvien.Id;

            // Lấy thông tin nhóm đang tham gia của sinh viên
            List<int> groupIds = dkDao.GetGroupIdsByStudentId(studentId);

            foreach (int groupId in groupIds)
            {
                // Lấy nội dung của tin nhắn từ TextBox
                string tinNhan = ucPhanTramTienDo1.txtGuiTinNhan.Text;

                // Tạo đối tượng ChatBox mới
                ChatBox chatBox = new ChatBox("", studentId, "", groupId, tinNhan, DateTime.Now);

                // Thêm tin nhắn vào cơ sở dữ liệu
                chatDao.AddChatMessage(chatBox.Magiangvien, chatBox.Masinhvien, chatBox.Manhom, chatBox.Ten, chatBox.Noidungchat);

                // Load lại danh sách tin nhắn với groupId tương ứng
                ucPhanTramTienDo1.LoadComments(groupId.ToString());
            }
        }
    }
}
