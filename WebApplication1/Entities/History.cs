using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class History
{
    public int Id { get; set; }

    public int TourId { get; set; }

    public int UserId { get; set; }

    public bool IsPaid { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Tour Tour { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
