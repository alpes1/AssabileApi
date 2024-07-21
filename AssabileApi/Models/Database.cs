using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Database
{
    public string DatabaseCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime Lastdataupdate { get; set; }

    public DateTime Lasttransferdate { get; set; }

    public bool Selectivedownload { get; set; }

    public string? CodeAgence { get; set; }

    public virtual ICollection<Workstation> Workstations { get; set; } = new List<Workstation>();
}
