using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Language
{
    public string LanguageCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<LanguageTablefieldattribute> LanguageTablefieldattributes { get; set; } = new List<LanguageTablefieldattribute>();
}
