using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace lab03_02
{
    public partial class FormDanhSachSinhVien : Form
    {
        private BindingList<SinhVien> danhSachSinhVien =
        new BindingList<SinhVien>();

    public FormDanhSachSinhVien()
        {
            InitializeComponent();

            dgvSinhVien.AutoGenerateColumns = true;
            dgvSinhVien.DataSource = danhSachSinhVien;
            dgvSinhVien.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            List<string> danhSachMaSV = danhSachSinhVien
                .Select(sv => sv.MaSV)
                .ToList();

            using (FormChiTietSinhVien form =
                new FormChiTietSinhVien(null, danhSachMaSV))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    danhSachSinhVien.Add(form.SinhVienKetQua);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            SinhVien sv = dgvSinhVien.CurrentRow.DataBoundItem
                as SinhVien;

            if (sv == null)
                return;

            using (FormChiTietSinhVien form =
                new FormChiTietSinhVien(sv))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SinhVien svMoi = form.SinhVienKetQua;

                    sv.HoTen = svMoi.HoTen;
                    sv.NgaySinh = svMoi.NgaySinh;
                    sv.GioiTinh = svMoi.GioiTinh;
                    sv.Khoa = svMoi.Khoa;
                    sv.DiemTB = svMoi.DiemTB;

                    dgvSinhVien.Refresh();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            SinhVien sv = dgvSinhVien.CurrentRow.DataBoundItem
                as SinhVien;

            if (sv == null)
                return;

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên " + sv.HoTen + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                danhSachSinhVien.Remove(sv);
            }
        }
    }


}
