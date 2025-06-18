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
    public static bool IsRoomInUse(long RoomID)
    {
        using DormitoryDbContext dbContext = new DormitoryDbContext();
        return dbContext.TransferRoomAssetHistorys.Any(i => i.RoomId == RoomID);
    }
    public static bool IsStudentHasThisAsset(long StudentID, long PartNumber)
    {
        using DormitoryDbContext dbContext = new DormitoryDbContext();
        return dbContext.TransferRoomAssetHistorys.Any(i => i.StudentId == StudentID && i.RoomAsset.PartNumber == PartNumber);
    }
    public static void Set(long RoomAssetID, bool IsRoom, long Student_RoomId, long UserID)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        TransferRoomAssetHistory tra = new TransferRoomAssetHistory();
        tra.RoomAssetId = RoomAssetID;
        if (!IsRoom)
        {
            tra.StudentId = Student_RoomId;
            SubstituteStudentAsset ssa = new SubstituteStudentAsset();
            if (db.SubstituteStudentAssets.Where(i => i.StudentId == tra.StudentId && i.PartNumber == RoomAsset.FindRoomAssetById(RoomAssetID).PartNumber).FirstOrDefault() == null)
            {
                ssa.StudentId = Student_RoomId;
                ssa.NewRoomAssetId = RoomAssetID;
                ssa.PartNumber = RoomAsset.FindRoomAssetById(RoomAssetID).PartNumber;
                db.SubstituteStudentAssets.Add(ssa);
            }
            else
            {
                ssa = db.SubstituteStudentAssets.Where(i => i.StudentId == Student_RoomId && i.PartNumber == RoomAsset.FindRoomAssetById(RoomAssetID).PartNumber).FirstOrDefault();
                db.SubstituteStudentAssets.Update(ssa);
                ssa.LastRoomAssetId = ssa.NewRoomAssetId;
                ssa.NewRoomAssetId = RoomAssetID;
            }
        }
        else
            tra.RoomId = Student_RoomId;

        tra.CreatBy = UserID;
        tra.CreatOn = DateTime.Now;

        db.TransferRoomAssetHistorys.Add(tra);

        RoomAsset roomasset = RoomAsset.FindRoomAssetById(RoomAssetID);
        db.RoomAssets.Update(roomasset);
        roomasset.IsUsed = true;


        db.SaveChanges();
    }
    public static void Edit(long EditRoomAssetID, bool IsRoom, long Student_RoomId, long UserID)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        TransferRoomAssetHistory tra = new TransferRoomAssetHistory();
        tra = TransferRoomAssetHistory.FindByAssetId(EditRoomAssetID);
        db.TransferRoomAssetHistorys.Update(tra);

        tra.RoomAssetId = EditRoomAssetID;
        if (!IsRoom)
        {
            tra.StudentId = Student_RoomId;

            SubstituteStudentAsset ssa = new SubstituteStudentAsset();
            if (db.SubstituteStudentAssets.Where(i => i.StudentId == Student_RoomId && i.PartNumber == RoomAsset.FindRoomAssetById(EditRoomAssetID).PartNumber).FirstOrDefault() == null)
            {
                ssa.StudentId = Student_RoomId;
                ssa.NewRoomAssetId = EditRoomAssetID;
                ssa.PartNumber = RoomAsset.FindRoomAssetById(EditRoomAssetID).PartNumber;
                db.SubstituteStudentAssets.Add(ssa);
            }
            else
            {
                ssa = db.SubstituteStudentAssets.Where(i => i.StudentId == Student_RoomId && i.PartNumber == RoomAsset.FindRoomAssetById(EditRoomAssetID).PartNumber).FirstOrDefault();
                db.SubstituteStudentAssets.Update(ssa);
                ssa.LastRoomAssetId = ssa.NewRoomAssetId;
                ssa.NewRoomAssetId = EditRoomAssetID;
            }

        }

        else
            tra.RoomId = Student_RoomId;

        tra.ModifiedBy = UserID;
        tra.ModifiedOn = DateTime.Now;

        db.SaveChanges();
    }

}
