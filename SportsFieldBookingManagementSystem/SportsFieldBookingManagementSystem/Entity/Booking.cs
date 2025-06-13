using System;
using System.Collections.Generic;

namespace BusinessObject.Entity;

public partial class Booking
{
    public int BookingId { get; set; }

    public int UserId { get; set; }

    public int FieldId { get; set; }

    public string BookingStatus { get; set; } = null!;

    public DateTime BookingDate { get; set; }

    public TimeOnly BookingStartTime { get; set; }

    public TimeOnly BookingEndTime { get; set; }

    public TimeOnly ActualEndTime { get; set; }

    public double TotalHour { get; set; }

    public decimal TotalMoney { get; set; }

    public int? TransactionId { get; set; }

    public virtual Field Field { get; set; } = null!;

    public virtual Transaction? Transaction { get; set; }

    public virtual User User { get; set; } = null!;
}
