using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class LanguageTablefieldattribute
{
    public string LanguageCode { get; set; } = null!;

    public string Tablename { get; set; } = null!;

    public string Fieldname { get; set; } = null!;

    public string Fieldlabel { get; set; } = null!;

    public string? Fieldhelp { get; set; }

    public virtual Language LanguageCodeNavigation { get; set; } = null!;
}
