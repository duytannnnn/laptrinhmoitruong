using System;
using System.Collections.Generic;
using System.Text;

namespace lab02_03
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Khoa { get; set; }
        public decimal? DiemTB { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(
            string maSV,
            string hoTen,
            DateTime ngaySinh,
            string gioiTinh,
            string khoa,
            decimal? diemTB)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Khoa = khoa;
            DiemTB = diemTB;
        }
    }
}
