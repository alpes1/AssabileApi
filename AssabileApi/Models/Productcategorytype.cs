using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Productcategorytype
{
    public string ProductcategoryCode { get; set; } = null!;

    public string ProductcategorytypeCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Rank { get; set; }

    public byte[]? Icon { get; set; }

    public virtual Productcategory ProductcategoryCodeNavigation { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
