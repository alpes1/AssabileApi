using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Contract
{
    public string ContractCode { get; set; } = null!;

    public string? Name { get; set; }

    public string? ContractcategoryCode { get; set; }

    public string? ContractcategorytypeCode { get; set; }

    public string PartnerCode { get; set; } = null!;

    public string? ContactCode { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? WorkstationCode { get; set; }

    public string? Externalreference1 { get; set; }

    public string? Externalreference2 { get; set; }

    public string? Documentname { get; set; }

    public string? CodeAgence { get; set; }

    public virtual ICollection<Installation> Installations { get; set; } = new List<Installation>();

    public virtual Partner PartnerCodeNavigation { get; set; } = null!;
}
