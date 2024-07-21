using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Workstation
{
    public string WorkstationCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? WorkstationcategoryCode { get; set; }

    public string? WorkstationcategorytypeCode { get; set; }

    public string? Phone { get; set; }

    public string? UpworkstationCode { get; set; }

    public string? GeoareaCode { get; set; }

    public string ProfileCode { get; set; } = null!;

    public string BranchCode { get; set; } = null!;

    public string DatabaseCode { get; set; } = null!;

    public string WorksiteCode { get; set; } = null!;

    public string? PersonCode { get; set; }

    public string? AttendedbypersonCode { get; set; }

    public string? Attendedby2personCode { get; set; }

    public string? BudgetCode { get; set; }

    public decimal? Maximumcredit { get; set; }

    public decimal? Currentcredit { get; set; }

    public decimal? Maximumstockvalue { get; set; }

    public decimal? Currentstockvalue { get; set; }

    public string? Userfield1 { get; set; }

    public string? Userfield2 { get; set; }

    public int? Securitylevel { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? UserCode { get; set; }

    public string? CodeAgence { get; set; }

    public virtual ICollection<Asset> AssetMangementworkstationCodeNavigations { get; set; } = new List<Asset>();

    public virtual ICollection<Asset> AssetWorkstationCodeNavigations { get; set; } = new List<Asset>();

    public virtual Branch BranchCodeNavigation { get; set; } = null!;

    public virtual Database DatabaseCodeNavigation { get; set; } = null!;

    public virtual Geoarea? GeoareaCodeNavigation { get; set; }

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();

    public virtual Person? PersonCodeNavigation { get; set; }

    public virtual Worksite WorksiteCodeNavigation { get; set; } = null!;

    public virtual ICollection<WorkstationItinerary> WorkstationItineraries { get; set; } = new List<WorkstationItinerary>();

    public virtual ICollection<WorkstationTokenserie> WorkstationTokenseries { get; set; } = new List<WorkstationTokenserie>();
}
