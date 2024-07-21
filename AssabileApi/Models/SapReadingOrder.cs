using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class SapReadingOrder
{
    public string DocumentNumber { get; set; } = null!;

    public int BatchNumber { get; set; }

    public decimal ReadingOrderReason { get; set; }

    public string DeviceCode { get; set; } = null!;

    public string AgencyCode { get; set; } = null!;

    public decimal Sequence { get; set; }

    public decimal InputKey { get; set; }

    public decimal? ControlKey { get; set; }

    public decimal ReadingOrderUnitSequence { get; set; }

    public string Location { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string Number { get; set; } = null!;

    public string UsualStreet { get; set; } = null!;

    public string? InternalCounter { get; set; }

    public string? Lastname { get; set; }

    public string? Firstname { get; set; }

    public string? ContractCode { get; set; }

    public string Installation { get; set; } = null!;

    public string EqptSerialNumber { get; set; } = null!;

    public string EqptType { get; set; } = null!;

    public string EqptFactorySerialNumber { get; set; } = null!;

    public string? Information { get; set; }

    public string? Coefficient { get; set; }

    public string ReadingOrderStartdate { get; set; } = null!;

    public string? ReadingOrderEnddate { get; set; }

    public decimal PreviousIndex { get; set; }

    public string PreviousIndexDate { get; set; } = null!;

    public decimal PreviousIndexReason { get; set; }

    public decimal EnvisagedIndex { get; set; }

    public decimal MaximumIndex { get; set; }

    public decimal MinimumIndex { get; set; }

    public string ExtractionDate { get; set; } = null!;

    public string TransferDate { get; set; } = null!;

    public decimal? NewIndex { get; set; }

    public string? NewIndexDate { get; set; }

    public string? PersonCode { get; set; }

    public string? PersonNotice { get; set; }

    public string? ExternalReference { get; set; }

    public Guid Rowguid { get; set; }

    public string? CodeAgence { get; set; }
}
