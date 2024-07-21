using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Profile
{
    public string ProfileCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Person> People { get; set; } = new List<Person>();

    public virtual ICollection<ProfileTableattribute> ProfileTableattributes { get; set; } = new List<ProfileTableattribute>();

    public virtual ICollection<PrmAssabilfunction> AssabilfunctionCodes { get; set; } = new List<PrmAssabilfunction>();
}
