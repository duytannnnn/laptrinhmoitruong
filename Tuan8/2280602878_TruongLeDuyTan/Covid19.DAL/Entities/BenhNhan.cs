using Covid19.DAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("BenhNhan")]
public class BenhNhan
{
    [Key, MaxLength(6)]
    public string MaBN { get; set; } = null!;

    [Required, MaxLength(150)]
    public string TenBN { get; set; } = null!;

    public int MaTT { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string? GhiChu { get; set; }

    [MaxLength(6)]
    public string? BNTXG { get; set; }

    [ForeignKey(nameof(MaTT))]
    public virtual TinhTrang TinhTrang { get; set; } = null!;
}