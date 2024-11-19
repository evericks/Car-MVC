using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WebApplication1.Entities;

public partial class Garage
{
    public int Id { get; set; }

    [DisplayName("Tên")]
    public string Name { get; set; } = null!;

    [DisplayName("Địa chỉ")]
    public string? Address { get; set; }

    [DisplayName("Số điện thoại")]
    public string? Phone { get; set; }

    public string? Email { get; set; }

    [DisplayName("Ngày tạo")]
    public DateTime? CreatedAt { get; set; }

    [DisplayName("Chuyến đi")]
    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
}
