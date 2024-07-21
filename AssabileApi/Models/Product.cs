using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Product
{
    public string ProductCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Rank { get; set; }

    public string? Longdescription { get; set; }

    public string? BrandCode { get; set; }

    public string ProductsalesgroupCode { get; set; } = null!;

    public string ProductpageCode { get; set; } = null!;

    public string ProductgroupCode { get; set; } = null!;

    public string? ProductcategoryCode { get; set; }

    public string? ProductcategorytypeCode { get; set; }

    public string? Productanalysisgroup1Code { get; set; }

    public string? Productanalysisgroup2Code { get; set; }

    public string? Productanalysisgroup3Code { get; set; }

    public string? Productanalysisgroup4Code { get; set; }

    public string? Productanalysisgroup5Code { get; set; }

    public string? UnitCode { get; set; }

    public string? ManagementmodeCode { get; set; }

    public string? AccountCode { get; set; }

    public string? Deliveryleadtime { get; set; }

    public decimal Purchaseprice { get; set; }

    public decimal Purchasediscount { get; set; }

    public decimal Shipmentcost { get; set; }

    public decimal Netpurchaseprice { get; set; }

    public decimal Salesmargin { get; set; }

    public decimal Salesprice { get; set; }

    public decimal Returnprice { get; set; }

    public decimal Salesdiscount { get; set; }

    public decimal Netsalesprice { get; set; }

    public decimal Awp { get; set; }

    public string Vat1Code { get; set; } = null!;

    public string Vat2Code { get; set; } = null!;

    public decimal TheRate { get; set; }

    public string? CustomsCode { get; set; }

    public string? Supplierreference { get; set; }

    public bool Hold { get; set; }

    public string? HoldReason { get; set; }

    public int? Packing { get; set; }

    public bool Salable { get; set; }

    public bool Returnable { get; set; }

    public bool Expirable { get; set; }

    public bool Inventoryable { get; set; }

    public bool Presencecheckable { get; set; }

    public bool Facingable { get; set; }

    public bool Apos { get; set; }

    public bool Freegood { get; set; }

    public bool Equipment { get; set; }

    public bool Virtualproduct { get; set; }

    public int Promosequence { get; set; }

    public decimal Promorate { get; set; }

    public bool Emptyproduct { get; set; }

    public decimal Spacerequirement { get; set; }

    public decimal Weight { get; set; }

    public decimal Volume { get; set; }

    public decimal Statunitrate { get; set; }

    public string? Userfield1 { get; set; }

    public string? Userfield2 { get; set; }

    public int? Securitylevel { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? UserCode { get; set; }

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual Productcategorytype Productcategorytype { get; set; } = null!;
}
