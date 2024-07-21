using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class CompanyProductsalesgroup
{
    public string BranchCode { get; set; } = null!;

    public string ProductsalesgroupCode { get; set; } = null!;

    public string? Header1 { get; set; }

    public string? Header2 { get; set; }

    public string? Header3 { get; set; }

    public string? Header4 { get; set; }

    public string? Header5 { get; set; }

    public string? Header6 { get; set; }

    public string? Footer1 { get; set; }

    public string? Footer2 { get; set; }

    public string? Footer3 { get; set; }

    public string? Footer4 { get; set; }

    public string? Footer5 { get; set; }

    public string? Footer6 { get; set; }

    public string? CodeAgence { get; set; }

    public virtual Branch BranchCodeNavigation { get; set; } = null!;

    public virtual Productsalesgroup ProductsalesgroupCodeNavigation { get; set; } = null!;
}
