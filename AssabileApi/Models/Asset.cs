using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Asset
{
    public string AssetCode { get; set; } = null!;

    public string? Name { get; set; }

    public string ProductCode { get; set; } = null!;

    public string? AssetstatusCode { get; set; }

    public string? UpassetCode { get; set; }

    public string? WorksiteCode { get; set; }

    public string? WorkstationCode { get; set; }

    public string? MangementworkstationCode { get; set; }

    public string? Serialnumber { get; set; }

    public string? Barcode { get; set; }

    public string? Notes { get; set; }

    public DateTime? Installationdate { get; set; }

    public DateTime? Garantieenddate { get; set; }

    public string? Garantiecondition { get; set; }

    public string? GarantiepartnerCode { get; set; }

    public string? GarantiecontactCode { get; set; }

    public string? CostcenterCode { get; set; }

    public string? PorderCode { get; set; }

    public string? PdelnoteCode { get; set; }

    public string? SdelnoteCode { get; set; }

    public string? Aquisitionmode { get; set; }

    public string? AccountCode { get; set; }

    public decimal? Initialvalue { get; set; }

    public DateTime? Purchasedate { get; set; }

    public string? Dprmodeid { get; set; }

    public DateTime? Dprstartdate { get; set; }

    public decimal? Dprbase { get; set; }

    public bool Closed { get; set; }

    public string? Userfield1 { get; set; }

    public string? Userfield2 { get; set; }

    public int? Securitylevel { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? UserCode { get; set; }

    public string? CodeAgence { get; set; }

    public virtual ICollection<AssetAttribute> AssetAttributes { get; set; } = new List<AssetAttribute>();

    public virtual ICollection<Installation> Installations { get; set; } = new List<Installation>();

    public virtual ICollection<Asset> InverseUpassetCodeNavigation { get; set; } = new List<Asset>();

    public virtual Workstation? MangementworkstationCodeNavigation { get; set; }

    public virtual Product ProductCodeNavigation { get; set; } = null!;

    public virtual Asset? UpassetCodeNavigation { get; set; }

    public virtual Worksite? WorksiteCodeNavigation { get; set; }

    public virtual Workstation? WorkstationCodeNavigation { get; set; }
}
