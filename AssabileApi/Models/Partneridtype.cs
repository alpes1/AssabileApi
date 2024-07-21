using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Partneridtype
{
    public string PartneridtypeCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
