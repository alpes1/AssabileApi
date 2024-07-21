using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Partnercategory
{
    public string PartnercategoryCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Rank { get; set; }

    public string? UppartnercategoryCode { get; set; }

    public virtual ICollection<Partnercategorytype> Partnercategorytypes { get; set; } = new List<Partnercategorytype>();
}
