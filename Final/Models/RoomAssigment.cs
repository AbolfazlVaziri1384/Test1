using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class RoomAssigment
{
    public long Id { get; set; }

    public long StudentId { get; set; }

    public long RoomId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public long CreatBy { get; set; }

    public DateTime CreatOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Room Room { get; set; } = null!;

    public virtual User Student { get; set; } = null!;

    public static bool AnyRoomAssigment(long StudentId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.RoomAssigments.Any(i => i.StudentId == StudentId);
    }
    public static RoomAssigment? FindById(long RoomAssigmentId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.RoomAssigments.Where(i => i.Id == RoomAssigmentId).FirstOrDefault();
    }
    public static RoomAssigment? FindByUserId(long UserId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.RoomAssigments.Where(i => i.StudentId == UserId).FirstOrDefault();
    }
    public static void SetRoomAssigment(long StudentId, long RoomId , long UserID)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        RoomAssigment ra = new RoomAssigment();
        ra.StudentId = StudentId;
        ra.RoomId = RoomId;
        ra.IsDeleted = false;
        ra.CreatBy = UserID;
        ra.CreatOn = DateTime.Now;
        db.RoomAssigments.Add(ra);
        db.SaveChanges();
    }
    public static void EditRoomAssigment(long RoomAssigmentEditId, long UserID, long StudentId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        RoomAssigment? ra = new RoomAssigment();
        ra = RoomAssigment.FindById(RoomAssigmentEditId);
        db.RoomAssigments.Update(ra);

        ra.StudentId = StudentId;
        ra.IsDeleted = false;
        ra.ModifiedBy = User.FindUserById(UserID).Id;
        ra.ModifiedOn = DateTime.Now;

        db.SaveChanges();
    }
}
