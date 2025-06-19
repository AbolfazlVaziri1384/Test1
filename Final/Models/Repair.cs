using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class Repair
{
    public long Id { get; set; }
    public long UserId { get; set; }

    public long RoomAssetId { get; set; }

    public int Status { get; set; }

    public string Discription { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public bool IsRepair { get; set; }
    public string Guid { get; set; }

    public virtual RoomAsset RoomAsset { get; set; } = null!;
    public virtual User User { get; set; } = null!;

    public static string SetRepair(long RoomAssetId, int Status, string Discription, long UserID)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        string guid = TimeSerial();
        Repair repair = new Repair();
        repair.RoomAssetId = RoomAssetId;
        repair.Status = Status;
        repair.Discription = Discription;
        repair.RequestDate = DateTime.Now;
        repair.IsRepair = true;
        repair.UserId = UserID;
        repair.Guid = guid;
        db.Repairs.Add(repair);
        //هنگامی که درخواست تعمیر برای یک وسیله گذاشته می شود باید وضعیت آن هم به در حال تعمیر تغییر کند 
        //تا زمانی که تعمیر به پایان برسه
        RoomAsset roomAsset = db.RoomAssets.Where(r => r.Id == RoomAssetId).FirstOrDefault();
        db.RoomAssets.Update(roomAsset);
        roomAsset.Status = 2;
        db.SaveChanges();

        return guid;

        string TimeSerial()
        {
            DateTime now = DateTime.Now;
            return $"{now:yyyyMMddHHmmssfff}";
        }

    }
    public static void Delete(long Id)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        Repair repair = db.Repairs.Where(i => i.Id == Id).FirstOrDefault();
        ////هنگامی که ما درخواستی را حذف می کنیم یعنی وسیله سالمه ؟
        //RoomAsset roomAsset = db.RoomAssets.Where(r => r.Id == repair.RoomAssetId).FirstOrDefault();
        //db.RoomAssets.Update(roomAsset);
        //roomAsset.Status = 0;
        db.Repairs.Remove(repair);
        db.SaveChanges();
    }
    public static void ChangeIsRepair(long Id)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        Repair repair = db.Repairs.Where(i => i.Id == Id).FirstOrDefault();
        db.Repairs.Update(repair);
        if (repair.IsRepair == true)
            repair.IsRepair = false;
        else
            repair.IsRepair = true;
        db.SaveChanges();
    }

}
