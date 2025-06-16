using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class Dormitory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public long Capacity { get; set; }
    public long NowCapacity { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public long CreatBy { get; set; }

    public DateTime CreatOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
    public int DormitoryGender { get; set; }

    public virtual ICollection<Block> Blocks { get; set; } = new List<Block>();

    public virtual User CreatByNavigation { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
    public static Dormitory? FindDormitoryById(long DormitoryId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.Dormitories.Where(i => i.Id == DormitoryId).FirstOrDefault();
    }
    public static int FindDormitoryType(long RoomId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.Dormitories.Where(i => i.Id == Block.FindBlockById(Room.FindBlockId(RoomId)).DermitoryId).FirstOrDefault().DormitoryGender;
    }
}
