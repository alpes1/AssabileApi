using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class GeoobjectBorder
{
    public string GeoobjectCode { get; set; } = null!;

    public int Rank { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public int Z { get; set; }

    public virtual Geoobject GeoobjectCodeNavigation { get; set; } = null!;
}
