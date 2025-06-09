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

    public DateOnly? TransferDate { get; set; }

    public string? Discription { get; set; }

    public virtual User Student { get; set; } = null!;
}
