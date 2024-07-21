using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Reclamation
{
    public string ReclamationId { get; set; } = null!;

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public string? Phone { get; set; }

    public string? ContractCode { get; set; }

    public string? Description { get; set; }

    public DateTime? Date { get; set; }

    public string? Agent { get; set; }

    public string? CodeAgence { get; set; }
}
