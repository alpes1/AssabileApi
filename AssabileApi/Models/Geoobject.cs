using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Geoobject
{
    public string GeoobjectCode { get; set; } = null!;

    public string? Name { get; set; }

    public string? BackgroungcolorCode { get; set; }

    public string? BordercolorCode { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public int Z { get; set; }

    public string? Attribute1 { get; set; }

    public string? Attribute2 { get; set; }

    public string? Attribute3 { get; set; }

    public string? Attribute4 { get; set; }

    public string? Attribute5 { get; set; }

    public int Geoobjecttype { get; set; }

    public string? ObjectCode { get; set; }

    public string? CodeAgence { get; set; }

    public virtual ICollection<Geoarea> Geoareas { get; set; } = new List<Geoarea>();

    public virtual ICollection<GeoobjectBorder> GeoobjectBorders { get; set; } = new List<GeoobjectBorder>();

    public virtual ICollection<GeoplanGeoobject> GeoplanGeoobjects { get; set; } = new List<GeoplanGeoobject>();
}
