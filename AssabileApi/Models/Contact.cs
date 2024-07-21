using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Contact
{
    public string ContactCode { get; set; } = null!;

    public string MrMs { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string ContactcategoryCode { get; set; } = null!;

    public string ContacttypeCode { get; set; } = null!;

    public string PartnerCode { get; set; } = null!;

    public string JobtitleCode { get; set; } = null!;

    public string PartnerDepartmentCode { get; set; } = null!;

    public string PersonCode { get; set; } = null!;

    public bool Specificaddress { get; set; }

    public string Address { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Cellularphone { get; set; } = null!;

    public string Personalphone { get; set; } = null!;

    public string Assistantname { get; set; } = null!;

    public string Assistantphone { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string? Userfield1 { get; set; }

    public string? Userfield2 { get; set; }

    public int Securitylevel { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? UserCode { get; set; }

    public string? CodeAgence { get; set; }

    public virtual Partner PartnerCodeNavigation { get; set; } = null!;
}
