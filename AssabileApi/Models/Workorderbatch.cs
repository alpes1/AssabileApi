using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Workorderbatch
{
    public string WorkorderbatchCode { get; set; } = null!;

    public DateTime Thedate { get; set; }

    public string? WorkstationCode { get; set; }

    public string? WorkorderbatchtypeCode { get; set; }

    public string? WorkorderbatchstatusCode { get; set; }

    public string? CodeAgence { get; set; }

    public virtual ICollection<Readingorder> Readingorders { get; set; } = new List<Readingorder>();
}
