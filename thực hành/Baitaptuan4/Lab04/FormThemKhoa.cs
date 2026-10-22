using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab04
{
    public partial class FormThemKhoa : Form
    {
        // Form chính đọc 2 thuộc tính này sau khi form đóng với kết quả OK
        public int KhoaIdMoi { get; private set; }
        public string TenKhoaMoi { get; private set; } = "";

        public FormThemKhoa()
        {
            InitializeComponent();
            AcceptButton = btnLuu;   // Enter = Lưu
            CancelButton = btnHuy;   // Esc = Hủy
            StartPosition = FormStartPosition.CenterParent;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten = txttenkhoa.Text.Trim();
            if (ten == "")
            {
                MessageBox.Show("Vui lòng nhập tên khoa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhoa.Focus();
                return;
            }

            try
            {
                using var db = new QuanLySinhVienDbContext();

                if (db.Khoas.Any(k => k.TenKhoa.ToLower() == ten.ToLower()))
                {
                    MessageBox.Show("Khoa này đã tồn tại.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttenkhoa.Focus();
                    return;
                }

                var khoa = new Khoa { TenKhoa = ten };
                db.Khoas.Add(khoa);
                db.SaveChanges();

                KhoaIdMoi = khoa.Id;
                TenKhoaMoi = khoa.TenKhoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lưu được khoa:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}