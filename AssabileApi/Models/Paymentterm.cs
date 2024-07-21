using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Paymentterm
{
    public string PaymenttermCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal Discount { get; set; }

    public int Rank { get; set; }
}
