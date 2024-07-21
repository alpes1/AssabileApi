using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class WorkstationItinerary
{
    public string WorkstationCode { get; set; } = null!;

    public string ItineraryCode { get; set; } = null!;

    public int Rank { get; set; }

    public string? CodeAgence { get; set; }

    public virtual Itinerary ItineraryCodeNavigation { get; set; } = null!;

    public virtual Workstation WorkstationCodeNavigation { get; set; } = null!;
}
