using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Backgroundimage
{
    public string BackgroundimageCode { get; set; } = null!;

    public string? Name { get; set; }

    public byte[] Backgroundimage1 { get; set; } = null!;

    public int TopleftX { get; set; }

    public int TopleftY { get; set; }

    public int BottomrightX { get; set; }

    public int BottomrightY { get; set; }

    public int Z { get; set; }

    public string? TransparencycolorCoe { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<GeoplanBackgroundimage> GeoplanBackgroundimages { get; set; } = new List<GeoplanBackgroundimage>();
}
