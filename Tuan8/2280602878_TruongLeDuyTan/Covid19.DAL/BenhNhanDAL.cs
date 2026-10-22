using Covid19.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Covid19.DAL;

public class BenhNhanDAL
{
    public List<BenhNhan> GetAll()
    {
        using var db = new Covid19Context();
        return db.BenhNhans.Include(b => b.TinhTrang).AsNoTracking().ToList();
    }

    public List<BenhNhan> GetByTinhTrang(int maTT)
    {
        using var db = new Covid19Context();
        return db.BenhNhans.Where(b => b.MaTT == maTT).AsNoTracking().ToList();
    }

    public bool Exists(string maBN)
    {
        using var db = new Covid19Context();
        return db.BenhNhans.Any(b => b.MaBN == maBN);
    }

    public void Add(BenhNhan bn)
    {
        using var db = new Covid19Context();
        db.BenhNhans.Add(bn);
        db.SaveChanges();
    }

    public void Update(BenhNhan bn)
    {
        using var db = new Covid19Context();
        var old = db.BenhNhans.Find(bn.MaBN)!;
        old.TenBN = bn.TenBN;
        old.MaTT = bn.MaTT;
        old.GhiChu = bn.GhiChu;
        old.BNTXG = bn.BNTXG;
        db.SaveChanges();
    }
}