using System;
using System.Collections.Generic;
using System.Text;

namespace lab03_02
{
    public class SinhVien

    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Khoa { get; set; }
        public double? DiemTB { get; set; }

        public SinhVien(string maSV, string hoTen,
            DateTime ngaySinh, string gioiTinh,
            string khoa, double? diemTB)
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

