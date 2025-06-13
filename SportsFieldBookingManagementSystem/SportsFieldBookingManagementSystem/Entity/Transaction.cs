using System;
using System.Collections.Generic;

namespace BusinessObject.Entity;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public DateTime TransactionDate { get; set; }

    public TimeOnly TransactionTime { get; set; }

    public string TransactionMethod { get; set; } = null!;

    public decimal TransactionAmmount { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
