using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Tokenserie
{
    public string TokenserieCode { get; set; } = null!;

    public string? Name { get; set; }

    public int Digitsincounter { get; set; }

    public string Invoiceprefix { get; set; } = null!;

    public int Invoicenextnumber { get; set; }

    public string Paymentprefix { get; set; } = null!;

    public int Paymentnextnumber { get; set; }

    public string Visitprefix { get; set; } = null!;

    public int Visitnextnumber { get; set; }

    public string Loadprefix { get; set; } = null!;

    public int Loadnextnumber { get; set; }

    public string Orderprefix { get; set; } = null!;

    public int Ordernextnumber { get; set; }

    public string Delnoteprefix { get; set; } = null!;

    public int Delnotenextnumber { get; set; }

    public string Roundprefix { get; set; } = null!;

    public int Roundnextnumber { get; set; }

    public string Expenseprefix { get; set; } = null!;

    public int Expensenextnumber { get; set; }

    public string Inventoryprefix { get; set; } = null!;

    public int Inventorynextnumber { get; set; }

    public string Projectprefix { get; set; } = null!;

    public int Projectnextnumber { get; set; }

    public string Facingprefix { get; set; } = null!;

    public int Facingnextnumber { get; set; }

    public string Interviewprefix { get; set; } = null!;

    public int Interviewnextnumber { get; set; }

    public string Partnerprefix { get; set; } = null!;

    public int Partnernextnumber { get; set; }

    public string Equipmentprefix { get; set; } = null!;

    public int Equipmentnextnumber { get; set; }

    public string WmRequestprefix { get; set; } = null!;

    public int WmRequestnextnumber { get; set; }

    public virtual ICollection<WorkstationTokenserie> WorkstationTokenseries { get; set; } = new List<WorkstationTokenserie>();
}
