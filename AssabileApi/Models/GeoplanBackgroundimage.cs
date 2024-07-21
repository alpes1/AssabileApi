using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class GeoplanBackgroundimage
{
    public string GeoplanCode { get; set; } = null!;

    public string BackgroundimageCode { get; set; } = null!;

    public bool Isselected { get; set; }

    public string? CodeAgence { get; set; }

    public virtual Backgroundimage BackgroundimageCodeNavigation { get; set; } = null!;

    public virtual Geoplan GeoplanCodeNavigation { get; set; } = null!;
}
