using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Productcategory
{
    public string ProductcategoryCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Rank { get; set; }

    public string? UpproductcategoryCode { get; set; }

    public virtual ICollection<ProductcategoryAttribute> ProductcategoryAttributes { get; set; } = new List<ProductcategoryAttribute>();

    public virtual ICollection<Productcategorytype> Productcategorytypes { get; set; } = new List<Productcategorytype>();
}
