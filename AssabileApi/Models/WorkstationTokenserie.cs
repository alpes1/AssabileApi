using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class WorkstationTokenserie
{
    public string WorkstationCode { get; set; } = null!;

    public string ProductsalesgroupCode { get; set; } = null!;

    public string TokenserieCode { get; set; } = null!;

    public string? CodeAgence { get; set; }

    public virtual Productsalesgroup ProductsalesgroupCodeNavigation { get; set; } = null!;

    public virtual Tokenserie TokenserieCodeNavigation { get; set; } = null!;

    public virtual Workstation WorkstationCodeNavigation { get; set; } = null!;
}
