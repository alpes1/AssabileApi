using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class TmpPerformance
{
    public string? ItinerarCode { get; set; }

    public int? CompterNumber { get; set; }

    public decimal? Tauxrelve { get; set; }

    public int? InstallationnullNumber { get; set; }

    public int? AnnomalieNumber { get; set; }

    public string? PersonCode { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? CodeAgence { get; set; }
}
