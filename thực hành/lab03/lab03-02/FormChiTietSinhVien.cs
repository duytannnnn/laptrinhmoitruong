using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab03_02
{
    public partial class FormChiTietSinhVien : Form
    {
        private bool laThemMoi;
        private List<string> danhSachMaSV;

        public SinhVien SinhVienKetQua { get; private set; }

        public FormChiTietSinhVien(
            SinhVien sv = null,
            List<string> danhSachMaSV = null)
        {
            InitializeComponent();

            this.danhSachMaSV = danhSachMaSV ?? new List<string>();
            laThemMoi = sv == null;

            if (laThemMoi)
            {
                Text = "Thêm sinh viên mới";
                rdoNam.Checked = true;
                dtpNgaySinh.Value = new DateTime(2003, 1, 1);
                cboKhoa.SelectedIndex = 0;
            }
            else
            {
                Text = "Thông tin sinh viên";
                txtMaSV.Text = sv.MaSV;
                txtHoTen.Text = sv.HoTen;
                dtpNgaySinh.Value = sv.NgaySinh;
                rdoNam.Checked = sv.GioiTinh == "Nam";
                rdoNu.Checked = sv.GioiTinh == "Nữ";
                cboKhoa.SelectedItem = sv.Khoa;
                txtDiemTB.Text = sv.DiemTB.HasValue
                    ? sv.DiemTB.Value.ToString()
                    : "";
                txtMaSV.ReadOnly = true;
            }

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();

            if (maSV == "")
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên!");
                txtMaSV.Focus();
                return;
            }

            if (hoTen == "")
            {
                MessageBox.Show("Vui lòng nhập Họ và tên!");
                txtHoTen.Focus();
                return;
            }

            if (laThemMoi && danhSachMaSV.Any(
                x => x.Equals(maSV, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                txtMaSV.Focus();
                return;
            }

            if (cboKhoa.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Khoa!");
                cboKhoa.Focus();
                return;
            }

            double? diemTB = null;

            if (txtDiemTB.Text.Trim() != "")
            {
                double diem;

                if (!double.TryParse(txtDiemTB.Text.Trim(), out diem)
                    || diem < 0 || diem > 10)
                {
                    MessageBox.Show(
                        "Điểm trung bình phải là số từ 0 đến 10!");
                    txtDiemTB.Focus();
                    return;
                }

                diemTB = diem;
            }

            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";        

            SinhVienKetQua = new SinhVien(
                maSV,
                hoTen,
                dtpNgaySinh.Value,
                gioiTinh,
                cboKhoa.Text,
                diemTB
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}