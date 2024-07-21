using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class GeoplanGeoobject
{
    public string GeoplanCode { get; set; } = null!;

    public string GeoobjectCode { get; set; } = null!;

    public bool Isselected { get; set; }

    public string? CodeAgence { get; set; }

    public virtual Geoobject GeoobjectCodeNavigation { get; set; } = null!;

    public virtual Geoplan GeoplanCodeNavigation { get; set; } = null!;
}
