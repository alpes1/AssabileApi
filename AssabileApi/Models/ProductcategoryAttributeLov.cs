using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class ProductcategoryAttributeLov
{
    public string ProductcategoryCode { get; set; } = null!;

    public string AttributeCode { get; set; } = null!;

    public string Attributetextvalue { get; set; } = null!;

    public decimal Attributetextvaluenotation { get; set; }

    public virtual ProductcategoryAttribute ProductcategoryAttribute { get; set; } = null!;
}
