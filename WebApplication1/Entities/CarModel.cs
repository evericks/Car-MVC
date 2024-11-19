using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class CarModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int SeatAmount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
}
