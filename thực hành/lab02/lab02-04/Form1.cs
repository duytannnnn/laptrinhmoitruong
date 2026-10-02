
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab02_04
{
    public partial class Form1 : Form
    {
        private const int GiaVe = 80000;
        private const int GioiHanGhe = 8;

        private readonly List<Button> danhSachGhe = new List<Button>();

        public Form1()
        {
            InitializeComponent();

            // Cấu hình danh sách phim
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.Items.AddRange(new string[]
            {
                "Avatar: Dòng Chảy Của Cát",
                "Người Nhện: Đa Vũ Trụ",
                "Elio",
                "Lật Mặt 8"
            });

            cboPhim.SelectedIndex = 0;

            // Tạo sơ đồ ghế và cập nhật giao diện
            TaoSoDoGhe();
            CapNhatThongTin();

            // Các sự kiện dùng chung
            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;
            btnXacNhan.Click += btnXacNhan_Click;
            btnHuyChon.Click += btnHuyChon_Click;
        }

        private void TaoSoDoGhe()
        {
            panelSoDoGhe.Controls.Clear();
            danhSachGhe.Clear();

            int kichThuoc = 38;
            int khoangCach = 5;

            // 5 hàng A-E, mỗi hàng có 8 ghế
            for (int hang = 0; hang < 5; hang++)
            {
                for (int cot = 1; cot <= 8; cot++)
                {
                    Button btnGhe = new Button();

                    char tenHang = (char)('A' + hang);
                    btnGhe.Text = tenHang + cot.ToString();

                    btnGhe.Name = "btnGhe" + btnGhe.Text;
                    btnGhe.Size = new Size(kichThuoc, 32);

                    btnGhe.Location = new Point(
                        10 + (cot - 1) * (kichThuoc + khoangCach),
                        10 + hang * (32 + khoangCach)
                    );

                    btnGhe.Font = new Font("Arial", 8, FontStyle.Bold);
                    btnGhe.FlatStyle = FlatStyle.Flat;
                    btnGhe.FlatAppearance.BorderSize = 1;

                    // Tag lưu trạng thái ghế
                    btnGhe.Tag = "Trống";
                    btnGhe.BackColor = Color.White;

                    // Tất cả ghế dùng chung một hàm Click
                    btnGhe.Click += btnGhe_Click;

                    danhSachGhe.Add(btnGhe);
                    panelSoDoGhe.Controls.Add(btnGhe);
                }
            }
        }

        private void btnGhe_Click(object sender, EventArgs e)
        {
            Button btnGhe = sender as Button;

            if (btnGhe == null)
                return;

            string trangThai = btnGhe.Tag.ToString();

            // Ghế đã bán thì không cho chọn
            if (trangThai == "Đã bán")
            {
                MessageBox.Show(
                    "Ghế đã được đặt!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // Ghế đang chọn -> bỏ chọn
            if (trangThai == "Đang chọn")
            {
                btnGhe.Tag = "Trống";
                btnGhe.BackColor = Color.White;
            }
            else
            {
                // Kiểm tra giới hạn 8 ghế
                int soGheDangChon = danhSachGhe.Count(
                    b => b.Tag.ToString() == "Đang chọn"
                );

                if (soGheDangChon >= GioiHanGhe)
                {
                    MessageBox.Show(
                        "Mỗi lượt đặt tối đa 8 ghế!",
                        "Vượt giới hạn",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                btnGhe.Tag = "Đang chọn";
                btnGhe.BackColor = Color.Yellow;
            }

            CapNhatThongTin();
        }

        private void CapNhatThongTin()
        {
            List<string> gheDaChon = danhSachGhe
                .Where(b => b.Tag.ToString() == "Đang chọn")
                .Select(b => b.Text)
                .ToList();

            lblGheDaChon.Text = gheDaChon.Count > 0
                ? string.Join(", ", gheDaChon)
                : "(chưa chọn ghế nào)";

            int tongTien = gheDaChon.Count * GiaVe;

            lblTongTien.Text = tongTien.ToString("N0") + "đ";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            List<Button> gheDangChon = danhSachGhe
                .Where(b => b.Tag.ToString() == "Đang chọn")
                .ToList();

            if (gheDangChon.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn ít nhất 1 ghế!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string danhSach = string.Join(
                ", ",
                gheDangChon.Select(b => b.Text)
            );

            int tongTien = gheDangChon.Count * GiaVe;

            DialogResult ketQua = MessageBox.Show(
                $"Xác nhận đặt {gheDangChon.Count} ghế:\n" +
                $"{danhSach}\n" +
                $"Tổng tiền: {tongTien:N0}đ?",
                "Xác nhận đặt vé",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                foreach (Button btnGhe in gheDangChon)
                {
                    btnGhe.Tag = "Đã bán";
                    btnGhe.BackColor = Color.IndianRed;
                    btnGhe.ForeColor = Color.White;
                }

                CapNhatThongTin();
            }
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            foreach (Button btnGhe in danhSachGhe)
            {
                if (btnGhe.Tag.ToString() == "Đang chọn")
                {
                    btnGhe.Tag = "Trống";
                    btnGhe.BackColor = Color.White;
                    btnGhe.ForeColor = Color.Black;
                }
            }

            CapNhatThongTin();
        }

        private void cboPhim_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            // Đổi phim: reset toàn bộ sơ đồ ghế
            foreach (Button btnGhe in danhSachGhe)
            {
                btnGhe.Tag = "Trống";
                btnGhe.BackColor = Color.White;
                btnGhe.ForeColor = Color.Black;
            }

            CapNhatThongTin();
        }
    }
}