using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class PositionGp
{
    public string CodeInstallation { get; set; } = null!;

    public string Readingordercode { get; set; } = null!;

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public double? Altitude { get; set; }

    public string? CodeAgence { get; set; }

    public byte[]? Image { get; set; }

    public DateTime? Date { get; set; }

    public string? Maricule { get; set; }

    public string? Telephone { get; set; }
}
