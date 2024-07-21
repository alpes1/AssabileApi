using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Readingorderresultnote
{
    public string ReadingorderresultCode { get; set; } = null!;

    public string ReadingorderresultnoteCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Categorie { get; set; } = null!;

    public string NoticeCode { get; set; } = null!;

    public string NoticeText { get; set; } = null!;

    public int NoticeType { get; set; }

    public virtual PrmReadingorderresult ReadingorderresultCodeNavigation { get; set; } = null!;
}
