using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Installation
{
    public string InstallationCode { get; set; } = null!;

    public string? Name { get; set; }

    public string? InstallationcategoryCode { get; set; }

    public string? InstallationcategorytypeCode { get; set; }

    public string? ContractCode { get; set; }

    public string? AssetCode { get; set; }

    public string? WorksiteCode { get; set; }

    public DateTime? Installationdate { get; set; }

    public DateTime? Uninstallationdate { get; set; }

    public bool Closed { get; set; }

    public string? CodeAgence { get; set; }

    public virtual Asset? AssetCodeNavigation { get; set; }

    public virtual Contract? ContractCodeNavigation { get; set; }

    public virtual Worksite? WorksiteCodeNavigation { get; set; }
}
