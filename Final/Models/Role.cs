using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class Role
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public int Role1 { get; set; }

    public long? DermitoryId { get; set; }

    public long? BlockId { get; set; }

    public long CreatBy { get; set; }

    public DateTime CreatOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Block? Block { get; set; }

    public virtual Dormitory? Dermitory { get; set; }

    public virtual User User { get; set; } = null!;

    public static long? FindRole(long UserId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        var role = db.Roles.FirstOrDefault(i => i.UserId == UserId);
        return role?.Role1 ?? -1;
    }
    public static User? FindDormitoryOwner(long DormitoryId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        User? user = User.FindUserById(db.Roles.FirstOrDefault(i => i.DermitoryId == DormitoryId).UserId);
        return user ?? null;
    }
    public static User? FindBlockOwner(long BlockId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        User? user = User.FindUserById(db.Roles.FirstOrDefault(i => i.BlockId == BlockId).UserId);
        return user ?? null;
    }
}
