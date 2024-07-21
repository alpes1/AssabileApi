using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class TmpSituationperformance
{
    public string? PersonCode { get; set; }

    public string? ItineraryCode { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public int? UnitereleveNumber { get; set; }

    public int? ReleveNumber { get; set; }

    public decimal? TauxReleve { get; set; }

    public string? CodeAgence { get; set; }
}
