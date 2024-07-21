using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class ProfileTableattribute
{
    public string ProfileCode { get; set; } = null!;

    public string Tablename { get; set; } = null!;

    public bool Readrows { get; set; }

    public bool Insertrows { get; set; }

    public bool Modifyrows { get; set; }

    public bool Deleterows { get; set; }

    public virtual Profile ProfileCodeNavigation { get; set; } = null!;

    public virtual ICollection<ProfileTablefieldattribute> ProfileTablefieldattributes { get; set; } = new List<ProfileTablefieldattribute>();
}
