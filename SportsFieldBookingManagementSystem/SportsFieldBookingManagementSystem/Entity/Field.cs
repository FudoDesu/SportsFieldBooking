using System;
using System.Collections.Generic;

namespace BusinessObject.Entity;

public partial class Field
{
    public int FieldId { get; set; }

    public int FieldTypeId { get; set; }

    public string FieldName { get; set; } = null!;

    public string FieldAddress { get; set; } = null!;

    public decimal FieldPrice { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual FieldType FieldType { get; set; } = null!;
}
