using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class Block
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public int FloorNumber { get; set; }

    public int RoomNumber { get; set; }

    public int Capacity { get; set; }

    public long DermitoryId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public long CreatBy { get; set; }

    public DateTime CreatOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual User CreatByNavigation { get; set; } = null!;

    public virtual Dormitory Dermitory { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
