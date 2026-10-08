using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace tuan6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblTrangThai.Text = "Sẵn sàng.";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        public async Task ThemSinhVienAsync(string hoTen, double diem)
        {
            using (var context = new AppDbContext())
            {
                Student svMoi = new Student
                {
                    FullName = hoTen,
                    Grade = diem
                };

                context.Students.Add(svMoi);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Student>> LayDanhSachAsync()
        {
            using (var context = new AppDbContext())
            {
                return await context.Students.ToListAsync();
            }
        }

        public async Task<List<Student>> LocSinhVienDatAsync()
        {
            using (var context = new AppDbContext())
            {
                return await context.Students
                    .Where(sv => sv.Grade >= 5)
                    .OrderByDescending(sv => sv.Grade)
                    .ToListAsync();
            }
        }

        public async Task SuaSinhVienAsync(
            int id,
            string hoTenMoi,
            double diemMoi)
        {
            using (var context = new AppDbContext())
            {
                Student sv = await context.Students.FindAsync(id);

                if (sv != null)
                {
                    sv.FullName = hoTenMoi;
                    sv.Grade = diemMoi;

                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task XoaSinhVienAsync(int id)
        {
            using (var context = new AppDbContext())
            {
                Student sv = await context.Students.FindAsync(id);

                if (sv != null)
                {
                    context.Students.Remove(sv);
                    await context.SaveChangesAsync();
                }
            }
        }

        // Tải danh sách lên DataGridView
        private async Task TaiDanhSach()
        {
            try
            {
                var danhSach = await LayDanhSachAsync();

                dgvSinhVien.DataSource = danhSach;

                lblTrangThai.Text =
                    $"Đã tải {danhSach.Count} sinh viên.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải dữ liệu: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // THÊM
        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txtHoTen.Text.Trim();

                if (!double.TryParse(txtDiem.Text, out double diem))
                {
                    MessageBox.Show("Điểm phải là số.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(hoTen))
                {
                    MessageBox.Show("Vui lòng nhập họ tên.");
                    return;
                }

                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Điểm phải từ 0 đến 10.");
                    return;
                }

                await ThemSinhVienAsync(hoTen, diem);

                MessageBox.Show("Thêm sinh viên thành công.");

                txtHoTen.Clear();
                txtDiem.Clear();

                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // SỬA
        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSinhVien.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần sửa.");
                    return;
                }

                int id = Convert.ToInt32(
                    dgvSinhVien.CurrentRow.Cells["Id"].Value);

                string hoTen = txtHoTen.Text.Trim();

                if (!double.TryParse(txtDiem.Text, out double diem))
                {
                    MessageBox.Show("Điểm phải là số.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(hoTen))
                {
                    MessageBox.Show("Vui lòng nhập họ tên.");
                    return;
                }

                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Điểm phải từ 0 đến 10.");
                    return;
                }

                await SuaSinhVienAsync(id, hoTen, diem);

                MessageBox.Show("Sửa sinh viên thành công.");

                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // XÓA
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSinhVien.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
                    return;
                }

                int id = Convert.ToInt32(
                    dgvSinhVien.CurrentRow.Cells["Id"].Value);

                string hoTen =
                    dgvSinhVien.CurrentRow.Cells["FullName"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa sinh viên \"{hoTen}\" không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await XoaSinhVienAsync(id);

                    MessageBox.Show("Xóa thành công.");

                    await TaiDanhSach();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // TẢI LẠI
        private async void btnTaiLai_Click(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        // LỌC SINH VIÊN ĐẠT
        private async void btn_loc_Click(object sender, EventArgs e)
        {
            try
            {
                var danhSach = await LocSinhVienDatAsync();

                dgvSinhVien.DataSource = danhSach;

                lblTrangThai.Text =
                    $"Có {danhSach.Count} sinh viên đạt.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Click vào dòng trong DataGridView
        private void dgvSinhVien_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                txtHoTen.Text =
                    row.Cells["FullName"].Value?.ToString();

                txtDiem.Text =
                    row.Cells["Grade"].Value?.ToString();
            }
        }
    }
}