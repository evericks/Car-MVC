using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Tour
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? ThumbnailUrl { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string From { get; set; } = null!;

    public string To { get; set; } = null!;

    public int SeatAmount { get; set; }

    public string Status { get; set; } = null!;

    public int CarModelId { get; set; }

    public int GarageId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual CarModel CarModel { get; set; } = null!;

    public virtual Garage Garage { get; set; } = null!;

    public virtual ICollection<History> Histories { get; set; } = new List<History>();
}
