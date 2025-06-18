using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class TransferRoomAssetHistory
{
    public long Id { get; set; }

    public long RoomAssetId { get; set; }

    public long? StudentId { get; set; }

    public long? RoomId { get; set; }

    public long? LastRoomId { get; set; }

    public long? NewRoomId { get; set; }

    public long CreatBy { get; set; }

    public DateTime CreatOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Room? Room { get; set; }

    public virtual RoomAsset RoomAsset { get; set; } = null!;

    public virtual User? Student { get; set; }

    public static bool IsInOneRoom(long RoomAssetId, long UserID)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        TransferRoomAssetHistory tra = db.TransferRoomAssetHistorys.Where(i => i.RoomAssetId == RoomAssetId).FirstOrDefault();
        foreach (var x in db.RoomAssigments.Where(i => i.RoomId == tra.RoomId).ToList())
        {
            if (UserID == x.StudentId) return true;
        }
        return false;
    }
    public static void DeleteOwner(long AssetId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        TransferRoomAssetHistory tra = db.TransferRoomAssetHistorys.Where(i => i.RoomAssetId == AssetId).FirstOrDefault();
        db.TransferRoomAssetHistorys.Update(tra);
        tra.RoomAsset.IsUsed = false;
        db.TransferRoomAssetHistorys.Remove(tra);
        db.SaveChanges();
    }
    public static TransferRoomAssetHistory FindByAssetId(long AssetId)
    { 
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.TransferRoomAssetHistorys.Where(i => i.RoomAssetId == AssetId).FirstOrDefault();
    }

}
