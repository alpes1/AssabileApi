using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Branch
{
    public string BranchCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? CodeAgence { get; set; }

    public virtual ICollection<CompanyProductsalesgroup> CompanyProductsalesgroups { get; set; } = new List<CompanyProductsalesgroup>();

    public virtual ICollection<Round> Rounds { get; set; } = new List<Round>();

    public virtual ICollection<Workstation> Workstations { get; set; } = new List<Workstation>();
}
