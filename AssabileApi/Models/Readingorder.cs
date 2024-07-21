using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Readingorder
{
    public string ReadingorderCode { get; set; } = null!;

    public string WorkorderbatchCode { get; set; } = null!;

    public string ReadingordertypeCode { get; set; } = null!;

    public string ItineraryCode { get; set; } = null!;

    public decimal Sequence { get; set; }

    public DateTime? Creationdate { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public decimal Previousindex { get; set; }

    public DateTime Previousindexdate { get; set; }

    public string PreviousindexreasonCode { get; set; } = null!;

    public decimal Envisagedindex { get; set; }

    public decimal Maximumindex { get; set; }

    public decimal Minimumindex { get; set; }

    public decimal? Newindex { get; set; }

    public DateTime? Newindexdate { get; set; }

    public string? ExecutedbypersonCode { get; set; }

    public string? RoundCode { get; set; }

    public string Num { get; set; } = null!;

    public string Streetname1 { get; set; } = null!;

    public string Streetname2 { get; set; } = null!;

    public string Postalcode { get; set; } = null!;

    public string City { get; set; } = null!;

    public bool? InternalCounter { get; set; }

    public string? Name { get; set; }

    public string? Name2 { get; set; }

    public string? ContractCode { get; set; }

    public string InstallationCode { get; set; } = null!;

    public string? PricelistCode { get; set; }

    public string AssetCode { get; set; } = null!;

    public string ProductCode { get; set; } = null!;

    public string Serialnumber { get; set; } = null!;

    public string? Information { get; set; }

    public string? Externalreference { get; set; }

    public string? ReadingorderresultCode { get; set; }

    public string? ReadingorderresultnoteCode { get; set; }

    public int Digitsnumber { get; set; }

    public decimal Coefficient { get; set; }

    public string? Zwnummer { get; set; }

    public string? Zpruefkl { get; set; }

    public string? Zzwtyp { get; set; }

    public string? Zkennziff { get; set; }

    public string? Zwert1 { get; set; }

    public virtual Itinerary ItineraryCodeNavigation { get; set; } = null!;

    public virtual Workorderbatch WorkorderbatchCodeNavigation { get; set; } = null!;
}
