using Covid19.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Covid19.DAL;

public class Covid19Context : DbContext
{
    public DbSet<TinhTrang> TinhTrangs { get; set; }
    public DbSet<BenhNhan> BenhNhans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder b)
    {
        b.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Covid19;Trusted_Connection=True;TrustServerCertificate=True;");
        // Nếu dùng SQL Express: Server=.\SQLEXPRESS
    }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<TinhTrang>().HasData(
            new TinhTrang { MaTT = 1, TenTT = "Âm Tính" },
            new TinhTrang { MaTT = 2, TenTT = "Dương Tính" },
            new TinhTrang { MaTT = 3, TenTT = "Tái Nhiễm" });

        mb.Entity<BenhNhan>().HasData(
            new BenhNhan
            {
                MaBN = "BN1342",
                TenBN = "Nguyễn Văn A",
                MaTT = 2,
                BNTXG = null,
                GhiChu = "Sau khi trở về từ khu cách ly tập trung để cách ly tại nhà, ..."
            },
            new BenhNhan
            {
                MaBN = "BN1347",
                TenBN = "Nguyễn Văn B",
                MaTT = 2,
                BNTXG = "BN1342",
                GhiChu = "-Nhập cảnh trên chuyến bay VN5301 từ Nhật – Cần Thơ – Sài Gòn\n-Cách ly tại khu cách ly của hãng hàng không Vietnam Airlines. ..."
            },
            new BenhNhan
            {
                MaBN = "BN1515",
                TenBN = "Nguyễn Văn C",
                MaTT = 2,
                BNTXG = null,
                GhiChu = "-Từ Qatar nhập cảnh Sân bay Tân Sơn Nhất trên chuyến bay QR970 ngày 9/1/2021\n- Cách ly ngay sau khi nhập cảnh tại TP. Hồ Chí Minh"
            },
            new BenhNhan
            {
                MaBN = "BN2222",
                TenBN = "Nguyễn Văn D",
                MaTT = 3,
                BNTXG = "BN1347",
                GhiChu = "- Tiếp xúc gần với bệnh nhân 1347"
            });
    }
}