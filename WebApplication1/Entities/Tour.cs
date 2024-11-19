using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WebApplication1.Entities;

public partial class Tour
{
    public int Id { get; set; }

    [DisplayName("Tên")]
    public string Name { get; set; } = null!;

    [DisplayName("Ảnh")]
    public string? ThumbnailUrl { get; set; }

    [DisplayName("Giờ bắt đầu")]
    public DateTime? StartTime { get; set; }

    [DisplayName("Giờ kết thúc")]
    public DateTime? EndTime { get; set; }

    [DisplayName("Địa điểm bắt đầu")]
    public string From { get; set; } = null!;

    [DisplayName("Địa điểm đến")]
    public string To { get; set; } = null!;

    [DisplayName("Số ghế")]
    public int SeatAmount { get; set; }

    [DisplayName("Trạng thái")]
    public string Status { get; set; } = null!;

    [DisplayName("Loại xe")]
    public int CarModelId { get; set; }

    [DisplayName("Nhà xe")]
    public int GarageId { get; set; }

    [DisplayName("Ngày tạo")]
    public DateTime? CreatedAt { get; set; }

    [DisplayName("Loại xe")]
    public virtual CarModel CarModel { get; set; } = null!;

    [DisplayName("Nhà xe")]
    public virtual Garage Garage { get; set; } = null!;

    [DisplayName("Lịch sử")]
    public virtual ICollection<History> Histories { get; set; } = new List<History>();
}
