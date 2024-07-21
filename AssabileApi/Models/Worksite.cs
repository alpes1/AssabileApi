using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Worksite
{
    public string WorksiteCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? WorksitecategoryCode { get; set; }

    public string? WorksitecategorytypeCode { get; set; }

    public string PartnerCode { get; set; } = null!;

    public string? Num { get; set; }

    public string? Streetname1 { get; set; }

    public string? Streetname2 { get; set; }

    public string? Postalcode { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Extendedadress { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Fax { get; set; }

    public string? GeoareaCode { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public int Z { get; set; }

    public string? CodeAgence { get; set; }

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual Geoarea? GeoareaCodeNavigation { get; set; }

    public virtual ICollection<Installation> Installations { get; set; } = new List<Installation>();

    public virtual ICollection<ItineraryLine> ItineraryLines { get; set; } = new List<ItineraryLine>();

    public virtual Partner PartnerCodeNavigation { get; set; } = null!;

    public virtual ICollection<Workstation> Workstations { get; set; } = new List<Workstation>();
}
