using Covid19.DAL;
using Covid19.DAL.Entities;

namespace Covid19.BLL;

public class BenhNhanDTO
{
    public string MaBN { get; set; } = "";
    public string TenBN { get; set; } = "";
    public int MaTT { get; set; }
    public string TenTT { get; set; } = "";
    public string? GhiChu { get; set; }
    public string? BNTXG { get; set; }
    public string F { get; set; } = "";
}

public class BenhNhanReportDTO
{
    public string MaBN { get; set; } = "";
    public string TenBN { get; set; } = "";
    public string? GhiChu { get; set; }
}

public class TinhTrangBLL
{
    public List<TinhTrang> GetAll() => new TinhTrangDAL().GetAll();
}

public class BenhNhanBLL
{
    private readonly BenhNhanDAL dal = new();

    public List<BenhNhanDTO> GetDanhSach()
    {
        var ds = dal.GetAll();
        var dict = ds.ToDictionary(x => x.MaBN);
        return ds.Select(x => new BenhNhanDTO
        {
            MaBN = x.MaBN,
            TenBN = x.TenBN,
            MaTT = x.MaTT,
            TenTT = x.TinhTrang.TenTT,
            GhiChu = x.GhiChu,
            BNTXG = x.BNTXG,
            F = TinhF(x, dict)
        }).ToList();
    }

    public List<string> GetDanhSachLayNhiem()
    {
        var list = dal.GetAll().Select(x => x.MaBN).ToList();
        list.Insert(0, "");
        return list;
    }

    private string TinhF(BenhNhan bn, Dictionary<string, BenhNhan> dict)
    {
        int f = 0;
        var visited = new HashSet<string>();
        var cur = bn;
        while (!string.IsNullOrEmpty(cur.BNTXG))
        {
            if (!visited.Add(cur.MaBN)) return "";
            if (!dict.TryGetValue(cur.BNTXG, out var next)) return "";
            cur = next; f++;
        }
        return "F" + f;
    }

    public (bool ThanhCong, string ThongBao) LuuBenhNhan(
        string maBN, string tenBN, int maTT, string ghiChu, string bnTxg)
    {
        maBN = maBN.Trim(); tenBN = tenBN.Trim();
        if (maBN == "" || tenBN == "")
            return (false, "Vui lòng nhập đầy đủ thông tin bệnh nhân!");
        if (maBN.Length != 6)
            return (false, "Mã bệnh nhân phải có 6 kí tự!");

        var bn = new BenhNhan
        {
            MaBN = maBN,
            TenBN = tenBN,
            MaTT = maTT,
            GhiChu = string.IsNullOrWhiteSpace(ghiChu) ? null : ghiChu,
            BNTXG = string.IsNullOrWhiteSpace(bnTxg) ? null : bnTxg
        };
        if (dal.Exists(maBN)) dal.Update(bn); else dal.Add(bn);
        return (true, "Cập nhật dữ liệu thành công!");
    }

    public List<BenhNhanReportDTO> GetDuLieuThongKe(int maTT)
        => dal.GetByTinhTrang(maTT)
              .Select(x => new BenhNhanReportDTO { MaBN = x.MaBN, TenBN = x.TenBN, GhiChu = x.GhiChu })
              .ToList();
}