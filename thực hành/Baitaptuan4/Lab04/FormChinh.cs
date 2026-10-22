using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace Lab04
{
    public partial class FormChinh : Form
    {
        // Id của sinh viên đang được chọn trên bảng (null = chưa chọn)
        private int? _selectedId = null;

        public FormChinh()
        {
            InitializeComponent();

            Load += FormChinh_Load;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnThemKhoa.Click += btnThemKhoa_Click;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
        }

        // ================= LOAD =================
        private void FormChinh_Load(object? sender, EventArgs e)
        {
            try
            {
                using var db = new QuanLySinhVienDbContext();
                db.Database.EnsureCreated(); // tạo DB + bảng nếu chưa có

                // Nạp sẵn danh sách khoa lần đầu
                if (!db.Khoas.Any())
                {
                    string[] dsKhoa =
                    {
                        "Công nghệ thông tin", "Hệ thống thông tin quản lý", "Kiến trúc - Mỹ thuật", "Xây dựng",
                        "Quản trị kinh doanh", "Marketing - Kinh doanh quốc tế", "Tài chính - Thương mại",
                        "Quản trị Du lịch - Nhà hàng - Khách sạn", "Luật", "Dược", "Y",
                        "Điều dưỡng - Kỹ thuật y học", "Thú y", "Thẩm mỹ và Khoa học sự sống", "Tiếng Anh",
                        "Nhật Bản học", "Trung Quốc học", "Hàn Quốc học",
                        "Khoa học Xã hội và Quan hệ Công chúng", "Truyền thông và Thiết kế"
                    };
                    db.Khoas.AddRange(dsKhoa.Select(t => new Khoa { TenKhoa = t }));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadKhoa();
            LoadData();
            ClearForm();
            UpdateStatus("Sẵn sàng");
        }

        private void LoadKhoa(int? selectId = null)
        {
            using var db = new QuanLySinhVienDbContext();
            var ds = db.Khoas.OrderBy(k => k.TenKhoa).ToList();

            comboBox1.DataSource = null;
            comboBox1.Items.Clear(); // xóa items cứng trong Designer
            comboBox1.DisplayMember = "TenKhoa";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = ds;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            if (selectId.HasValue) comboBox1.SelectedValue = selectId.Value;
            else comboBox1.SelectedIndex = -1;
        }

        private void LoadData()
        {
            using var db = new QuanLySinhVienDbContext();
            var ds = db.SinhViens
                .OrderBy(s => s.MaSV)
                .Select(s => new
                {
                    s.Id,
                    s.MaSV,
                    s.HoTen,
                    s.NgaySinh,
                    s.GioiTinh,
                    TenKhoa = s.Khoa!.TenKhoa,
                    s.DiemTB
                })
                .ToList();

            dgvSinhVien.DataSource = ds;

            if (dgvSinhVien.Columns.Count > 0)
            {
                dgvSinhVien.Columns["Id"]!.Visible = false;
                dgvSinhVien.Columns["MaSV"]!.HeaderText = "Mã SV";
                dgvSinhVien.Columns["HoTen"]!.HeaderText = "Họ tên";
                dgvSinhVien.Columns["NgaySinh"]!.HeaderText = "Ngày sinh";
                dgvSinhVien.Columns["NgaySinh"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvSinhVien.Columns["GioiTinh"]!.HeaderText = "Giới tính";
                dgvSinhVien.Columns["TenKhoa"]!.HeaderText = "Khoa";
                dgvSinhVien.Columns["DiemTB"]!.HeaderText = "Điểm TB";
            }
            dgvSinhVien.ClearSelection();
            lblTongso.Text = $"Tổng số sinh viên: {ds.Count}";
        }

        // ================= HỖ TRỢ =================
        private void UpdateStatus(string msg) => lblTrangthai.Text = msg;

        private void ClearForm()
        {
            _selectedId = null;
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            comboBox1.SelectedIndex = -1;
            dgvSinhVien.ClearSelection();
            txtMaSV.Focus();
        }

        // Đọc + kiểm tra dữ liệu nhập. Trả về false nếu không hợp lệ.
        private bool TryReadForm(out string maSV, out string hoTen, out DateTime ngaySinh,
                                 out string gioiTinh, out int khoaId, out double? diemTB)
        {
            maSV = txtMaSV.Text.Trim();
            hoTen = txtHoTen.Text.Trim();
            ngaySinh = dtpNgaySinh.Value.Date;
            gioiTinh = rdoNam.Checked ? "Nam" : rdoNu.Checked ? "Nữ" : "";
            khoaId = 0;
            diemTB = null;

            if (maSV == "")
            {
                Warn("Vui lòng nhập Mã số SV.", txtMaSV); return false;
            }
            if (hoTen == "")
            {
                Warn("Vui lòng nhập Họ tên.", txtHoTen); return false;
            }
            if (ngaySinh >= DateTime.Today)
            {
                Warn("Ngày sinh phải nhỏ hơn ngày hiện tại.", dtpNgaySinh); return false;
            }
            if (gioiTinh == "")
            {
                Warn("Vui lòng chọn Giới tính.", rdoNam); return false;
            }
            if (comboBox1.SelectedValue is not int id)
            {
                Warn("Vui lòng chọn Khoa.", comboBox1); return false;
            }
            khoaId = id;

            string diemStr = txtDiemTB.Text.Trim().Replace(',', '.');
            if (diemStr != "")
            {
                if (!double.TryParse(diemStr, NumberStyles.Float, CultureInfo.InvariantCulture, out double d)
                    || d < 0 || d > 10)
                {
                    Warn("Điểm TB phải là số từ 0 đến 10.", txtDiemTB); return false;
                }
                diemTB = d;
            }
            return true;
        }

        private void Warn(string msg, Control focus)
        {
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focus.Focus();
        }

        // ================= SỰ KIỆN =================
        private void btnThem_Click(object? sender, EventArgs e)
        {
            if (!TryReadForm(out var maSV, out var hoTen, out var ngaySinh,
                             out var gioiTinh, out var khoaId, out var diemTB)) return;

            using var db = new QuanLySinhVienDbContext();
            if (db.SinhViens.Any(s => s.MaSV == maSV))
            {
                Warn("Mã số SV đã tồn tại.", txtMaSV); return;
            }

            db.SinhViens.Add(new SinhVien
            {
                MaSV = maSV,
                HoTen = hoTen,
                NgaySinh = ngaySinh,
                GioiTinh = gioiTinh,
                KhoaId = khoaId,
                DiemTB = diemTB
            });
            db.SaveChanges();

            LoadData();
            ClearForm();
            UpdateStatus($"Đã thêm sinh viên {maSV}");
        }

        private void dgvSinhVien_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = (int)dgvSinhVien.Rows[e.RowIndex].Cells["Id"].Value;
            using var db = new QuanLySinhVienDbContext();
            var sv = db.SinhViens.Find(id);
            if (sv == null) return;

            _selectedId = sv.Id;
            txtMaSV.Text = sv.MaSV;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            rdoNam.Checked = sv.GioiTinh == "Nam";
            rdoNu.Checked = sv.GioiTinh == "Nữ";
            comboBox1.SelectedValue = sv.KhoaId;
            txtDiemTB.Text = sv.DiemTB?.ToString(CultureInfo.InvariantCulture) ?? "";
            UpdateStatus($"Đang chọn: {sv.MaSV} - {sv.HoTen}");
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Hãy chọn một sinh viên trong bảng để sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!TryReadForm(out var maSV, out var hoTen, out var ngaySinh,
                             out var gioiTinh, out var khoaId, out var diemTB)) return;

            using var db = new QuanLySinhVienDbContext();
            var sv = db.SinhViens.Find(_selectedId.Value);
            if (sv == null)
            {
                MessageBox.Show("Sinh viên không còn tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData(); ClearForm(); return;
            }
            if (db.SinhViens.Any(s => s.MaSV == maSV && s.Id != sv.Id))
            {
                Warn("Mã số SV đã tồn tại.", txtMaSV); return;
            }

            sv.MaSV = maSV;
            sv.HoTen = hoTen;
            sv.NgaySinh = ngaySinh;
            sv.GioiTinh = gioiTinh;
            sv.KhoaId = khoaId;
            sv.DiemTB = diemTB;
            db.SaveChanges();

            LoadData();
            ClearForm();
            UpdateStatus($"Đã cập nhật sinh viên {maSV}");
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Hãy chọn một sinh viên trong bảng để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var kq = MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {txtMaSV.Text} - {txtHoTen.Text}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes) return;

            using var db = new QuanLySinhVienDbContext();
            var sv = db.SinhViens.Find(_selectedId.Value);
            if (sv != null)
            {
                db.SinhViens.Remove(sv);
                db.SaveChanges();
            }

            string ma = txtMaSV.Text;
            LoadData();
            ClearForm();
            UpdateStatus($"Đã xóa sinh viên {ma}");
        }

        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            LoadKhoa();
            LoadData();
            ClearForm();
            UpdateStatus("Sẵn sàng");
        }

        private void btnThemKhoa_Click(object? sender, EventArgs e)
        {
            using var f = new FormThemKhoa();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                LoadKhoa(f.KhoaIdMoi); // nạp lại combobox và chọn luôn khoa vừa thêm
                UpdateStatus($"Đã thêm khoa: {f.TenKhoaMoi}");
            }
        }

        // Các handler cũ do Designer gắn sẵn (giữ lại để không lỗi biên dịch)
        private void toolStripMenuItem1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
    }
}