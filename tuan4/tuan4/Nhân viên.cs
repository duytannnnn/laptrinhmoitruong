using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace tuan4
{
    public partial class Form2 : Form
    {
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Hidden)]
        public NhanVien NV { get; set; }

        public Form2()
        {
            InitializeComponent();
            NV = new NhanVien();
        }

        private void btn_dongy_Click(object sender, EventArgs e)
        {
            if (txt_msnv.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập MSNV!");
                txt_msnv.Focus();
                return;
            }

            if (txt_tennhanvien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
                txt_tennhanvien.Focus();
                return;
            }

            double luong;

            if (!double.TryParse(txt_luongcoban.Text, out luong))
            {
                MessageBox.Show("Lương cơ bản phải là số!");
                txt_luongcoban.Focus();
                return;
            }

            NV.MSNV = txt_msnv.Text.Trim();
            NV.TenNhanVien = txt_tennhanvien.Text.Trim();
            NV.LuongCoBan = luong;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txt_msnv_TextChanged(object sender, EventArgs e)
        {
        }
    }
}