using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class PrmReadingorderresult
{
    public string ReadingorderresultCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Readingorderresultnote> Readingorderresultnotes { get; set; } = new List<Readingorderresultnote>();
}
