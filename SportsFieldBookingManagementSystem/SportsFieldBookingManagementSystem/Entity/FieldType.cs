using System;
using System.Collections.Generic;

namespace BusinessObject.Entity;

public partial class FieldType
{
    public int FieldTypeId { get; set; }

    public string FieldTypeName { get; set; } = null!;

    public virtual ICollection<Field> Fields { get; set; } = new List<Field>();
}
