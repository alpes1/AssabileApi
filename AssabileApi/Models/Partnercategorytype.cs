using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Partnercategorytype
{
    public string PartnercategoryCode { get; set; } = null!;

    public string PartnercategorytypeCode { get; set; } = null!;

    public string? Name { get; set; }

    public int Rank { get; set; }

    public virtual Partnercategory PartnercategoryCodeNavigation { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
