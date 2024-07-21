using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class ItineraryLine
{
    public string ItineraryCode { get; set; } = null!;

    public string WorksiteCode { get; set; } = null!;

    public int Rank { get; set; }

    public string? CodeAgence { get; set; }

    public virtual Itinerary ItineraryCodeNavigation { get; set; } = null!;

    public virtual Worksite WorksiteCodeNavigation { get; set; } = null!;
}
