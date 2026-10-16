using System;

public class SinhVien
{
    public int Id { get; set; }
    public string MaSV { get; set; } = "";
    public string HoTen { get; set; } = "";
    public DateTime NgaySinh { get; set; }
    public string GioiTinh { get; set; } = "";
    public double? DiemTB { get; set; }

    // ===== Khóa ngoại (Foreign Key) trỏ tới Khoa =====
    public int KhoaId { get; set; }  // cột lưu Id của Khoa
    public Khoa? Khoa { get; set; }  // navigation property - EF Core dùng để "nối" 2 bảng
}

