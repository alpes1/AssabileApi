using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Geoarea
{
    public string GeoareaCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UpgeoareaCode { get; set; }

    public string? GeoobjectCode { get; set; }

    public string? Notes { get; set; }

    public string? Userfield1 { get; set; }

    public string? Userfield2 { get; set; }

    public string? CodeAgence { get; set; }

    public virtual Geoobject? GeoobjectCodeNavigation { get; set; }

    public virtual ICollection<Geoarea> InverseUpgeoareaCodeNavigation { get; set; } = new List<Geoarea>();

    public virtual Geoarea? UpgeoareaCodeNavigation { get; set; }

    public virtual ICollection<Worksite> Worksites { get; set; } = new List<Worksite>();

    public virtual ICollection<Workstation> Workstations { get; set; } = new List<Workstation>();
}
