using System;
using System.Linq;
using System.Windows.Forms;
using lab02_03;

namespace lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MdiChildActivate += FormChinh_MdiChildActivate;
            this.FormClosing += FormChinh_FormClosing;
        }

        // Cập nhật tiêu đề khi chuyển cửa sổ con
        private void FormChinh_MdiChildActivate(object? sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.Text = $"Hệ Thống Quản Lý — HUTECH | Đang xem: {this.ActiveMdiChild.Text}";
            }
            else
            {
                this.Text = "Hệ Thống Quản Lý — HUTECH";
            }
        }

        // Xác nhận trước khi thoát
        private void FormChinh_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                var ketQua = MessageBox.Show(
                    "Vẫn còn cửa sổ con đang mở. Bạn có chắc muốn thoát ứng dụng?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (ketQua == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void cửaSỏToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sắpXếpDọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sắpXếpNgangToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mnuCuaSo_Click(object sender, EventArgs e)
        {
        }

        private void mnuHeThong_Click(object sender, EventArgs e)
        {
        }

        // Sắp xếp tầng
        private void mnuSapXepTang_Click(object sender, EventArgs e)
        {
            if (!KiemTraCoCuaSoDangMo()) return;
            this.LayoutMdi(MdiLayout.Cascade);
        }

        // Sắp xếp ngang
        private void mnuSapXepNgang_Click(object sender, EventArgs e)
        {
            if (!KiemTraCoCuaSoDangMo()) return;
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        // Sắp xếp dọc
        private void mnuSapXepDoc_Click(object sender, EventArgs e)
        {
            if (!KiemTraCoCuaSoDangMo()) return;
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        // Kiểm tra cửa sổ MDI
        private bool KiemTraCoCuaSoDangMo()
        {
            if (this.MdiChildren.Length == 0)
            {
                MessageBox.Show(
                    "Chưa có cửa sổ nào để sắp xếp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return false;
            }

            return true;
        }

        // Đóng tất cả cửa sổ con
        private void mnuDongTatCa_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                MessageBox.Show(
                    "Không có cửa sổ nào đang mở!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            var ketQua = MessageBox.Show(
                $"Bạn có chắc muốn đóng tất cả {this.MdiChildren.Length} cửa sổ đang mở?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                foreach (Form formCon in this.MdiChildren.ToList())
                {
                    formCon.Close();
                }
            }
        }

        // Mở form Sinh Viên
        private void mnuMoSinhVien_Click(object sender, EventArgs e)
        {
            MoFormKhongTrung<FormQuanLySinhVien>();
        }

        // Mở form Khóa Học
        private void mnuMoKhoaHoc_Click(object sender, EventArgs e)
        {
            MoFormKhongTrung<FormQuanLyKhoaHoc>();
        }

        // Không mở trùng form
        private void MoFormKhongTrung<T>() where T : Form, new()
        {
            foreach (Form formCon in this.MdiChildren)
            {
                if (formCon is T)
                {
                    formCon.Activate();
                    return;
                }
            }

            T formMoi = new T();
            formMoi.MdiParent = this;
            formMoi.Show();
        }
    }
}

