using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Productsalesgroup
{
    public string ProductsalesgroupCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<CompanyProductsalesgroup> CompanyProductsalesgroups { get; set; } = new List<CompanyProductsalesgroup>();

    public virtual ICollection<WorkstationTokenserie> WorkstationTokenseries { get; set; } = new List<WorkstationTokenserie>();
}
