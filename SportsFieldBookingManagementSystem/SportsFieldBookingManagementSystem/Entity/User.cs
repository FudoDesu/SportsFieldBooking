using System;
using System.Collections.Generic;

namespace BusinessObject.Entity;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public int RoleId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Role Role { get; set; } = null!;
}
