
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab02_01
{
    public partial class dtpNgaySinh : Form
    {
        public dtpNgaySinh()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên!",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return;
            }

            
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            
            DateTime ngaySinh = dateTimePickerNgaySinh.Value;
            DateTime homNay = DateTime.Today;

            int tuoi = homNay.Year - ngaySinh.Year;

            if (ngaySinh.Date > homNay.AddYears(-tuoi))
            {
                tuoi--;
            }

          
            List<string> soThich = new List<string>();

            if (chkDocSach.Checked)
                soThich.Add("Đọc sách");

            if (chkTheThao.Checked)
                soThich.Add("Thể thao");

            if (chkAmNhac.Checked)
                soThich.Add("Âm nhạc");

           
            string chuoiSoThich = soThich.Count > 0
                ? string.Join(", ", soThich)
                : "chưa chọn sở thích nào";

            lblKetQua.Text =
                $"Xin chào {gioiTinh} {txtHoTen.Text.Trim()}, {tuoi} tuổi.\n" + $"Sở thích: {chuoiSoThich}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoNam.Checked = true;
            dateTimePickerNgaySinh.Value = new DateTime(2000, 1, 1);
            lblKetQua.Text = "";
        }
    }
}