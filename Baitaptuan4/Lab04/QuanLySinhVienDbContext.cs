using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Policy;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

public class QuanLySinhVienDbContext : DbContext
{
    public DbSet<SinhVien> SinhViens { get; set; } = null!;
    public DbSet<Khoa> Khoas { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // LocalDB đi kèm sẵn khi cài Visual Studio, không cần cài SQL Server riêng.
        // Database "QuanLySinhVienDb" tự động được tạo khi chạy Update-Database.
        optionsBuilder.UseSqlServer(
            @"Server=.\SQLEXPRESS;Database=QuanLySinhVienDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
