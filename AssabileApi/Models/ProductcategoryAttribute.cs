using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class ProductcategoryAttribute
{
    public string ProductcategoryCode { get; set; } = null!;

    public string AttributeCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Coefficient { get; set; }

    public string? Storedprocedurename { get; set; }

    public string? Minimumvaue { get; set; }

    public string? Maximumvalue { get; set; }

    public string? Defaultvalue { get; set; }

    public virtual ICollection<ProductcategoryAttributeLov> ProductcategoryAttributeLovs { get; set; } = new List<ProductcategoryAttributeLov>();

    public virtual Productcategory ProductcategoryCodeNavigation { get; set; } = null!;
}
