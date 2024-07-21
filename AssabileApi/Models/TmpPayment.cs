using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class TmpPayment
{
    public string? PaymentCode { get; set; }

    public decimal? Amount { get; set; }

    public string? CodeAgence { get; set; }
}
