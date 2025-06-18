using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class StudentAsset
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public long StudentId { get; set; }

    public long? LastStudentId { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? Discription { get; set; }

    public virtual User Student { get; set; } = null!;

    public static void DeleteAsset(long Id)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        db.StudentAssets.Remove(db.StudentAssets.Where(i => i.Id == Id).FirstOrDefault());
        db.SaveChanges();
    }
    public static void SetTransfer(long StudentAssetId, long UserID, long StudentId) 
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        StudentAsset asset = db.StudentAssets.Where(i => i.Id == StudentAssetId).FirstOrDefault();
        db.StudentAssets.Update(asset);
        asset.StudentId = StudentId;
        asset.LastStudentId = UserID;
        asset.TransferDate = DateTime.Now;
        db.SaveChanges();
    }
}
