using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Partner
{
    public string PartnerCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Name2 { get; set; }

    public string? UppartnerCode { get; set; }

    public string? RootpartnerCode { get; set; }

    public string? Partnerid { get; set; }

    public string? PartneridtypeCode { get; set; }

    public string PartnercategoryCode { get; set; } = null!;

    public string PartnertypeCode { get; set; } = null!;

    public string PartnerstatusCode { get; set; } = null!;

    public string? Notes { get; set; }

    public string SaleschannelCode { get; set; } = null!;

    public string GeoareaCode { get; set; } = null!;

    public int Rank { get; set; }

    public string? Partneranalysisgroup1Code { get; set; }

    public string? Partneranalysisgroup2Code { get; set; }

    public string? Partneranalysisgroup3Code { get; set; }

    public string? Partneranalysisgroup4Code { get; set; }

    public string? Partneranalysisgroup5Code { get; set; }

    public string? Address { get; set; }

    public string? Zipcode { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Webaddress { get; set; }

    public string WorkstationCode { get; set; } = null!;

    public string? CurrencyCode { get; set; }

    public string PaymenttermCode { get; set; } = null!;

    public string? PricelistCode { get; set; }

    public string? Pricelist2Code { get; set; }

    public DateTime? Pricelist2startdate { get; set; }

    public bool Vat1Exoneration { get; set; }

    public bool Vat2Exoneration { get; set; }

    public bool FixedtaxExoneration { get; set; }

    public string? Fiscalid { get; set; }

    public decimal? Maximumcredit { get; set; }

    public decimal? Currentcredit { get; set; }

    public string? Arabicname { get; set; }

    public decimal? Maximumcredit2 { get; set; }

    public decimal? Currentcredit2 { get; set; }

    public bool Hold { get; set; }

    public string? HoldReason { get; set; }

    public bool Common { get; set; }

    public string? Userfield1 { get; set; }

    public string? Userfield2 { get; set; }

    public int Securitylevel { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? UserCode { get; set; }

    public string? CodeAgence { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<Partner> InverseUppartnerCodeNavigation { get; set; } = new List<Partner>();

    public virtual Partnercategorytype Partnercategorytype { get; set; } = null!;

    public virtual Partneridtype? PartneridtypeCodeNavigation { get; set; }

    public virtual Partnerstatus PartnerstatusCodeNavigation { get; set; } = null!;

    public virtual Partner? UppartnerCodeNavigation { get; set; }

    public virtual ICollection<Worksite> Worksites { get; set; } = new List<Worksite>();

    public virtual Workstation WorkstationCodeNavigation { get; set; } = null!;
}
