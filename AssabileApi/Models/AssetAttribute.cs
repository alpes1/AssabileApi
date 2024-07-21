using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class AssetAttribute
{
    public string AssetCode { get; set; } = null!;

    public string AttributeCode { get; set; } = null!;

    public decimal? Attributenumerictvalue { get; set; }

    public string? Attributetextvalue { get; set; }

    public DateTime? Attributedatevalue { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? CodeAgence { get; set; }

    public virtual Asset AssetCodeNavigation { get; set; } = null!;
}
