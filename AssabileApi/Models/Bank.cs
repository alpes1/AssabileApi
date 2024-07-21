using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Bank
{
    public string BankCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? CodeAgence { get; set; }
}
