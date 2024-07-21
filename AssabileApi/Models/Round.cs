using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Round
{
    public string RoundCode { get; set; } = null!;

    public string BranchCode { get; set; } = null!;

    public string ItineraryCode { get; set; } = null!;

    public string WorkstationCode { get; set; } = null!;

    public string PersonCode { get; set; } = null!;

    public string? AttendedbypersonCode { get; set; }

    public string? Attendedby2personCode { get; set; }

    public DateTime Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public DateTime? Departuretime { get; set; }

    public DateTime? Returntime { get; set; }

    public int? Departuremilage { get; set; }

    public int? Returnmilage { get; set; }

    public string? AssetCode { get; set; }

    public int Progresslevel { get; set; }

    public DateTime? Transerdate { get; set; }

    public int? TranserbatchCode { get; set; }

    public string? CodeAgence { get; set; }

    public virtual Branch BranchCodeNavigation { get; set; } = null!;

    public virtual Itinerary ItineraryCodeNavigation { get; set; } = null!;
}
