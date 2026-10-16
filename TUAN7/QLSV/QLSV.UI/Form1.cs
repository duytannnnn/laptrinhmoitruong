using QLSV.BLL;

namespace QLSV.UI
{
    public partial class Form1 : Form
    {
        private readonly StudentService _service = new StudentService();

        public Form1()
        {
            InitializeComponent();
            lblTrangThai.Text = "Sẵn sàng.";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        private async Task TaiDanhSach()
        {
            try
            {
                var ds = await _service.GetAllAsync();
                dgvSinhVien.DataSource = ds;
                lblTrangThai.Text = $"Đã tải {ds.Count} sinh viên.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtDiem.Text, out double diem))
                {
                    MessageBox.Show("Điểm phải là số.");
                    return;
                }

                await _service.AddAsync(txtHoTen.Text, diem);
                MessageBox.Show("Thêm sinh viên thành công.");
                txtHoTen.Clear();
                txtDiem.Clear();
                await TaiDanhSach();
            }
            catch (ArgumentException ex)   // lỗi nghiệp vụ từ BLL
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSinhVien.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần sửa.");
                    return;
                }
                if (!double.TryParse(txtDiem.Text, out double diem))
                {
                    MessageBox.Show("Điểm phải là số.");
                    return;
                }

                int id = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["Id"].Value);
                await _service.UpdateAsync(id, txtHoTen.Text, diem);
                MessageBox.Show("Sửa sinh viên thành công.");
                await TaiDanhSach();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSinhVien.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
                    return;
                }

                int id = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["Id"].Value);
                string hoTen = dgvSinhVien.CurrentRow.Cells["FullName"].Value?.ToString() ?? "";

                var result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa sinh viên \"{hoTen}\" không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await _service.DeleteAsync(id);
                    MessageBox.Show("Xóa thành công.");
                    await TaiDanhSach();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnTaiLai_Click(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        private async void btn_loc_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = await _service.GetPassedAsync();
                dgvSinhVien.DataSource = ds;
                lblTrangThai.Text = $"Có {ds.Count} sinh viên đạt.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSinhVien.Rows[e.RowIndex];
                txtHoTen.Text = row.Cells["FullName"].Value?.ToString();
                txtDiem.Text = row.Cells["Grade"].Value?.ToString();
            }
        }
    }
}