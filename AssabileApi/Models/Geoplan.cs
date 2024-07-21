using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Geoplan
{
    public string GeoplanCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int TopleftX { get; set; }

    public int TopleftY { get; set; }

    public int BottomrightX { get; set; }

    public int BottomrightY { get; set; }

    public int Z { get; set; }

    public string? BackgroundcolorCoe { get; set; }

    public string? Notes { get; set; }

    public string? CodeAgence { get; set; }

    public virtual ICollection<GeoplanBackgroundimage> GeoplanBackgroundimages { get; set; } = new List<GeoplanBackgroundimage>();

    public virtual ICollection<GeoplanGeoobject> GeoplanGeoobjects { get; set; } = new List<GeoplanGeoobject>();
}
