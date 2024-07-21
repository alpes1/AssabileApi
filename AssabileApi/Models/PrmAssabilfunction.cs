using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class PrmAssabilfunction
{
    public string AssabilfunctionCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Profile> ProfileCodes { get; set; } = new List<Profile>();
}
