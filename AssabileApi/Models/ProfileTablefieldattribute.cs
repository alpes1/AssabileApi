using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class ProfileTablefieldattribute
{
    public string ProfileCode { get; set; } = null!;

    public string Tablename { get; set; } = null!;

    public string Fieldname { get; set; } = null!;

    public bool Readonly { get; set; }

    public bool Insertonly { get; set; }

    public virtual ProfileTableattribute ProfileTableattribute { get; set; } = null!;
}
