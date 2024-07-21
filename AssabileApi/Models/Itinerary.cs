using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Itinerary
{
    public string ItineraryCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Securitylevel { get; set; }

    public string? CodeAgence { get; set; }

    public virtual ICollection<ItineraryLine> ItineraryLines { get; set; } = new List<ItineraryLine>();

    public virtual ICollection<Readingorder> Readingorders { get; set; } = new List<Readingorder>();

    public virtual ICollection<Round> Rounds { get; set; } = new List<Round>();

    public virtual ICollection<Sinvoice> Sinvoices { get; set; } = new List<Sinvoice>();

    public virtual ICollection<WorkstationItinerary> WorkstationItineraries { get; set; } = new List<WorkstationItinerary>();
}
