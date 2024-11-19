using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Garage
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
}
