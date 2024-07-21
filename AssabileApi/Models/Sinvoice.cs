using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Sinvoice
{
    public string SinvoiceCode { get; set; } = null!;

    public string PartnerCode { get; set; } = null!;

    public decimal Amount { get; set; }

    public decimal Dueamount { get; set; }

    public decimal Fixedtaxamount { get; set; }

    public DateTime? Requesteddate { get; set; }

    public DateTime Thedate { get; set; }

    public string? Contractaccount { get; set; }

    public string? ContractCode { get; set; }

    public string? ContactCode { get; set; }

    public string PersonCode { get; set; } = null!;

    public string ProductsalesgroupCode { get; set; } = null!;

    public string? ProjectCode { get; set; }

    public string WarehouseCode { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public string? PaymenttermCode { get; set; }

    public DateTime? Confirmeddate { get; set; }

    public string? SinvoicetypeCode { get; set; }

    public string? SinvoicestatusCode { get; set; }

    public string? Description { get; set; }

    public string? Externalreference1 { get; set; }

    public string? Externalreference2 { get; set; }

    public string? Exonerationreference { get; set; }

    public decimal Discount1 { get; set; }

    public decimal Discount2 { get; set; }

    public decimal Discount3 { get; set; }

    public decimal Discount4 { get; set; }

    public decimal Finaldiscount { get; set; }

    public decimal Finaldiscountrate { get; set; }

    public decimal Vat1amount { get; set; }

    public decimal Vat2amount { get; set; }

    public decimal Emptyamount { get; set; }

    public int Consignmenttype { get; set; }

    public int? Printingaccount { get; set; }

    public bool Canceled { get; set; }

    public string? SupplierCode { get; set; }

    public string? RoundCode { get; set; }

    public string? VisitCode { get; set; }

    public int Progresslevel { get; set; }

    public bool Closed { get; set; }

    public string? Userfield1 { get; set; }

    public string? Userfield2 { get; set; }

    public int Securitylevel { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? UserCode { get; set; }

    public string? Trackingkey { get; set; }

    public string? SorderCode { get; set; }

    public string? PaymentCode { get; set; }

    public string? ItineraryCode { get; set; }

    public string? CodeAgence { get; set; }

    public virtual Itinerary? ItineraryCodeNavigation { get; set; }
}
