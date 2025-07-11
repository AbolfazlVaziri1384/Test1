﻿using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;

namespace Final.Models;

public partial class RoomAsset
{
    public long Id { get; set; }

    public int PartNumber { get; set; }

    public long AssetNumber { get; set; }

    public int Status { get; set; }

    public bool IsUsed { get; set; }

    public long CreatBy { get; set; }

    public DateTime CreatOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
    public bool IsDeleted { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedOn { get; set; }
    public virtual User User { get; set; } = null!;

    public virtual ICollection<Repair> Repairs { get; set; } = new List<Repair>();

    public virtual ICollection<SubstituteStudentAsset> SubstituteStudentAssets { get; set; } = new List<SubstituteStudentAsset>();

    public virtual ICollection<TransferRoomAssetHistory> TransferRoomAssetHistories { get; set; } = new List<TransferRoomAssetHistory>();

    public static RoomAsset FindRoomAssetById(long Id)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.RoomAssets.Where(i => i.Id == Id).FirstOrDefault();
    }
    public static void DeleteRoomAsset(long AssetId, long UserId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        RoomAsset ra = RoomAsset.FindRoomAssetById(AssetId);
        db.RoomAssets.Update(ra);
        ra.IsDeleted = true;
        ra.DeletedBy = Models.User.FindUserById(UserId).Id;
        ra.DeletedOn = DateTime.Now;
        db.SaveChanges();
    }
    public static void SetRoomAsset(int PartNumber, long AssetNumber, int status, long CreatBy)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        RoomAsset ra = new RoomAsset();
        ra.PartNumber = PartNumber;
        ra.AssetNumber = AssetNumber;
        ra.Status = status;
        ra.IsUsed = false;
        ra.CreatBy = CreatBy;
        ra.CreatOn = DateTime.Now;
        ra.IsDeleted = false;

        db.RoomAssets.Add(ra);
        db.SaveChanges();
    }
    public static void EditRoomAsset(long RoomAssetID, int PartNumber, long AssetNumber, int status, long ModifyBy)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        RoomAsset ra = new RoomAsset();
        ra = RoomAsset.FindRoomAssetById(RoomAssetID);
        db.RoomAssets.Update(ra);

        ra.PartNumber = PartNumber;
        ra.AssetNumber = AssetNumber;
        ra.Status = status;
        ra.IsUsed = false;
        ra.IsDeleted = false;
        ra.ModifiedBy = RoomAsset.FindRoomAssetById(ModifyBy).Id;
        ra.ModifiedOn = DateTime.Now;

        db.SaveChanges();
    }
}
