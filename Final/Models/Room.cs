using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class Room
{
    public long Id { get; set; }

    public int FloorNumber { get; set; }

    public long BlockId { get; set; }

    public int Number { get; set; }

    public int Capacity { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public long CreatBy { get; set; }

    public DateTime CreatOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Block Block { get; set; } = null!;

    public virtual User CreatByNavigation { get; set; } = null!;

    public virtual ICollection<RoomAssigment> RoomAssigments { get; set; } = new List<RoomAssigment>();

    public virtual ICollection<TransferRoomAssetHistory> TransferRoomAssetHistories { get; set; } = new List<TransferRoomAssetHistory>();
}
