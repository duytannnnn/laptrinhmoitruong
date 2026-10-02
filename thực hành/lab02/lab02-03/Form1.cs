
using lab02_03;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace lab02_03
{
    public partial class Form1 : Form
    {
        private BindingList<SinhVien> danhSachSV =
            new BindingList<SinhVien>();

        private BindingSource bindingSource =
            new BindingSource();

        private SinhVien sinhVienDangChon = null;

        private readonly string[] danhSachKhoa =
        {
            "Công nghệ thông tin",
            "Quản trị kinh doanh",
            "Kỹ thuật Công trình"
        };

        public Form1()
        {
            InitializeComponent();

            
            Load += Form1_Load;
            btnThem.Click += btnThem_Click;
            btnCapNhat.Click += btnCapNhat_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            cboLocKhoa.SelectedIndexChanged += cboLocKhoa_SelectedIndexChanged;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            dgvSinhVien.CellFormatting += dgvSinhVien_CellFormatting;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cboKhoa.Items.Clear();
            cboKhoa.Items.AddRange(danhSachKhoa);
            cboKhoa.SelectedIndex = -1;

            cboLocKhoa.Items.Clear();
            cboLocKhoa.Items.Add("Tất cả khoa");
            cboLocKhoa.Items.AddRange(danhSachKhoa);
            cboLocKhoa.SelectedIndex = 0;

            
            danhSachSV.Add(new SinhVien(
                "SV001", "Nguyễn Văn An",
                new DateTime(2003, 5, 12),
                "Nam", "Công nghệ thông tin", 8.2m));

            danhSachSV.Add(new SinhVien(
                "SV002", "Trần Thị Bích",
                new DateTime(2003, 8, 20),
                "Nữ", "Quản trị kinh doanh", 7.5m));

            danhSachSV.Add(new SinhVien(
                "SV003", "Lê Văn Cường",
                new DateTime(2004, 1, 15),
                "Nam", "Kỹ thuật Công trình", null));

            
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.RowHeadersVisible = false;

            colNgaySinh.DefaultCellStyle.Format = "dd/MM/yyyy";
            colDiemTB.DefaultCellStyle.Format = "0.##";

            LamMoiDanhSach();
            XoaTrang();
        }

        private void LamMoiDanhSach()
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string khoaLoc = cboLocKhoa.SelectedItem?.ToString();

            var ketQua = danhSachSV.Where(sv =>
                (string.IsNullOrEmpty(tuKhoa) ||
                 sv.MaSV.Contains(tuKhoa,
                     StringComparison.OrdinalIgnoreCase) ||
                 sv.HoTen.Contains(tuKhoa,
                     StringComparison.OrdinalIgnoreCase) ||
                 sv.Khoa.Contains(tuKhoa,
                     StringComparison.OrdinalIgnoreCase))
                &&
                (string.IsNullOrEmpty(khoaLoc) ||
                 khoaLoc == "Tất cả khoa" ||
                 sv.Khoa == khoaLoc)
            ).ToList();

            bindingSource.DataSource = new BindingList<SinhVien>(ketQua);
            dgvSinhVien.DataSource = bindingSource;

            lblTongSo.Text =
                $"Tổng số sinh viên: {danhSachSV.Count}";

            var thongKe = danhSachSV
                .GroupBy(sv => sv.Khoa)
                .Select(g => $"{g.Key}: {g.Count()}")
                .ToList();

            lblThongKe.Text = string.Join(" | ", thongKe);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            decimal? diem;

            if (!KiemTraDuLieu(out diem))
                return;

            string maSV = txtMaSV.Text.Trim();

            if (danhSachSV.Any(sv =>
                string.Equals(sv.MaSV, maSV,
                    StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                txtMaSV.Focus();
                txtMaSV.SelectAll();
                return;
            }

            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            SinhVien svMoi = new SinhVien(
                maSV,
                txtHoTen.Text.Trim(),
                dtpNgaySinh.Value.Date,
                gioiTinh,
                cboKhoa.SelectedItem.ToString(),
                diem
            );

            danhSachSV.Add(svMoi);

            LamMoiDanhSach();
            XoaTrang();

            MessageBox.Show(
                "Thêm sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (sinhVienDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            decimal? diem;

            if (!KiemTraDuLieu(out diem))
                return;

            sinhVienDangChon.HoTen = txtHoTen.Text.Trim();
            sinhVienDangChon.NgaySinh = dtpNgaySinh.Value.Date;
            sinhVienDangChon.GioiTinh =
                rdoNam.Checked ? "Nam" : "Nữ";
            sinhVienDangChon.Khoa =
                cboKhoa.SelectedItem.ToString();
            sinhVienDangChon.DiemTB = diem;

            LamMoiDanhSach();
            XoaTrang();

            MessageBox.Show(
                "Cập nhật sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (sinhVienDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                $"Bạn có chắc muốn xóa sinh viên " +
                $"{sinhVienDangChon.HoTen} ({sinhVienDangChon.MaSV})?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                danhSachSV.Remove(sinhVienDangChon);

                LamMoiDanhSach();
                XoaTrang();

                MessageBox.Show(
                    "Xóa sinh viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
        private void XoaTrang()
        {
            sinhVienDangChon = null;

            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();

            dtpNgaySinh.Value = DateTime.Today;

            rdoNam.Checked = true;
            rdoNu.Checked = false;

            cboKhoa.SelectedIndex = -1;

            txtMaSV.ReadOnly = false;

            dgvSinhVien.ClearSelection();

            txtMaSV.Focus();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaTrang();

            txtTimKiem.Clear();

            if (cboLocKhoa.Items.Count > 0)
                cboLocKhoa.SelectedIndex = 0;

            LamMoiDanhSach();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LamMoiDanhSach();
        }

        private void cboLocKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LamMoiDanhSach();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            SinhVien sv = dgvSinhVien.Rows[e.RowIndex]
                .DataBoundItem as SinhVien;

            if (sv == null)
                return;

            sinhVienDangChon = sv;

            txtMaSV.Text = sv.MaSV;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            txtDiemTB.Text = sv.DiemTB.HasValue
                ? sv.DiemTB.Value.ToString()
                : "";

            rdoNam.Checked = sv.GioiTinh == "Nam";
            rdoNu.Checked = sv.GioiTinh == "Nữ";

            cboKhoa.SelectedItem = sv.Khoa;

            // Không cho sửa mã sinh viên
            txtMaSV.ReadOnly = true;
        }

        private void dgvSinhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSinhVien.Columns[e.ColumnIndex].Name == "colDiemTB"
        && (e.Value == null || e.Value == DBNull.Value))
            {
                e.Value = "Chưa có";
                e.FormattingApplied = true;
            }
        }
        private bool KiemTraDuLieu(out decimal? diem)
        {
            diem = null;

            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!");
                txtMaSV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return false;
            }

            if (cboKhoa.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn khoa!");
                cboKhoa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiemTB.Text))
            {
                diem = null;
            }
            else
            {
                decimal giaTri;

                if (!decimal.TryParse(txtDiemTB.Text.Trim(), out giaTri)
                    || giaTri < 0 || giaTri > 10)
                {
                    MessageBox.Show(
                        "Điểm trung bình phải là số từ 0 đến 10!");

                    txtDiemTB.Focus();
                    txtDiemTB.SelectAll();
                    return false;
                }

                diem = giaTri;
            }

            return true;
        }
    }

}