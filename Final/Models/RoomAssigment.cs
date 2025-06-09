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
}
