using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class Repair
{
    public long Id { get; set; }
    public long UserId { get; set; }

    public long RoomAssetId { get; set; }

    public bool Status { get; set; }

    public string Discription { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public bool IsRepair { get; set; }

    public virtual RoomAsset RoomAsset { get; set; } = null!;
    public virtual User User { get; set; } = null!;
}
