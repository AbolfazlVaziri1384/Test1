using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class SubstituteStudentAsset
{
    public long Id { get; set; }

    public long StudentId { get; set; }

    public long LastRoomAssetId { get; set; }

    public long NewRoomAssetId { get; set; }

    public virtual RoomAsset LastRoomAsset { get; set; } = null!;

    public virtual User Student { get; set; } = null!;
}
