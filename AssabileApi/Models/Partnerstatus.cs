using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Partnerstatus
{
    public string PartnerstatusCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Rank { get; set; }

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
