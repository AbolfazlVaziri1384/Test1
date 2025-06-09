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
}
