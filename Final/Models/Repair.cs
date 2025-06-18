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

    public virtual RoomAsset RoomAsset { get; set; } = null!;
    public virtual User User { get; set; } = null!;

    public static void SetRepair(long RoomAssetId , int Status , string Discription , long UserID)
    {
        using DormitoryDbContext db = new DormitoryDbContext();

        Repair repair = new Repair();
        repair.RoomAssetId = RoomAssetId;
        repair.Status = Status;
        repair.Discription = Discription;
        repair.RequestDate = DateTime.Now;
        repair.IsRepair = true;
        repair.UserId = UserID;
        db.Repairs.Add(repair);
        //هنگامی که درخواست تعمیر برای یک وسیله گذاشته می شود باید وضعیت آن هم به در حال تعمیر تغییر کند 
        //تا زمانی که تعمیر به پایان برسه
        RoomAsset roomAsset = db.RoomAssets.Where(r => r.Id == RoomAssetId).FirstOrDefault();
        db.RoomAssets.Update(roomAsset);
        roomAsset.Status = 2;
        db.SaveChanges();
    }
}
