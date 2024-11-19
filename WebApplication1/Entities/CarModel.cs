using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WebApplication1.Entities;

public partial class CarModel
{
    public int Id { get; set; }

    [DisplayName("Tên")]
    public string Name { get; set; } = null!;

    [DisplayName("Ghi chú")]
    public string? Description { get; set; }

    [DisplayName("Số ghế")]
    public int SeatAmount { get; set; }

    [DisplayName("Ngày tạo")]
    public DateTime? CreatedAt { get; set; }

    [DisplayName("Chuyến đi")]
    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
}
