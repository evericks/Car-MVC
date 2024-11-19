using System;
using System.ComponentModel;

namespace WebApplication1.Entities;

public partial class User
{
    public int Id { get; set; }

    [DisplayName("Tên")]
    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    [DisplayName("Số điện thoại")]
    public string? Phone { get; set; }

    [DisplayName("Địa chỉ")]
    public string? Address { get; set; }

    [DisplayName("Tên tài khoản")]
    public string Username { get; set; } = null!;

    [DisplayName("Mật khẩu")]
    public string Password { get; set; } = null!;

    [DisplayName("Ngày tạo")]
    public DateTime? CreatedAt { get; set; }

    [DisplayName("Lịch sử")]
    public virtual ICollection<History> Histories { get; set; } = new List<History>();
}
