using System;
using System.Collections.Generic;
using System.Text;


    namespace tuan4
    {
        public class NhanVien
        {
        public string MSNV { get; set; } = "";
        public string TenNhanVien { get; set; } = "";
        public double LuongCoBan { get; set; }

            public NhanVien()
            {
            }

            public NhanVien(string msnv, string tenNhanVien, double luongCoBan)
            {
                MSNV = msnv;
                TenNhanVien = tenNhanVien;
                LuongCoBan = luongCoBan;
            }
        }
    }

