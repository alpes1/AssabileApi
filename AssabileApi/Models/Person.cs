using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Person
{
    public string PersonCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string ProfileCode { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Cellularphone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string LanguageCode { get; set; } = null!;

    public int Requiredcontrolnumber { get; set; }

    public bool Hold { get; set; }

    public string? HoldReason { get; set; }

    public string? Userfield1 { get; set; }

    public string? Userfield2 { get; set; }

    public int Securitylevel { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? UserCode { get; set; }

    public string? CodeAgence { get; set; }

    public virtual Profile ProfileCodeNavigation { get; set; } = null!;

    public virtual ICollection<Workstation> Workstations { get; set; } = new List<Workstation>();
}
