using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Payment
{
    public string PaymentCode { get; set; } = null!;

    public string? Reference { get; set; }

    public string PaymenttermCode { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateTime? MaturityDate { get; set; }

    public DateTime Thedate { get; set; }

    public string? PartnerCode { get; set; }

    public string PersonCode { get; set; } = null!;

    public string? RoundCode { get; set; }

    public string? VisitCode { get; set; }

    public bool Locked { get; set; }

    public string? BankCode { get; set; }

    public string? Bankagency { get; set; }

    public string? Payerreference { get; set; }

    public int Printed { get; set; }

    public string? CodeAgence { get; set; }
}
