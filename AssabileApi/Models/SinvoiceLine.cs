using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class SinvoiceLine
{
    public string SinvoiceCode { get; set; } = null!;

    public int SinvoiceLineNumber { get; set; }

    public string ProductCode { get; set; } = null!;

    public decimal Quantity { get; set; }

    public decimal Returnedquantity { get; set; }

    public decimal Damagedquantity { get; set; }

    public decimal Freequantity { get; set; }

    public decimal Unitprice { get; set; }

    public decimal Vat1 { get; set; }

    public decimal Vat2 { get; set; }

    public string? Description { get; set; }

    public DateTime? Requesteddate { get; set; }

    public DateTime? Confirmeddate { get; set; }

    public decimal Discount1 { get; set; }

    public decimal Discount2 { get; set; }

    public decimal Discount3 { get; set; }

    public decimal Discount4 { get; set; }

    public bool Soldout { get; set; }

    public string? Userfield1 { get; set; }

    public string? Userfield2 { get; set; }

    public decimal Netunitprice { get; set; }

    public decimal Promorate { get; set; }

    public string? CodeAgence { get; set; }
}
