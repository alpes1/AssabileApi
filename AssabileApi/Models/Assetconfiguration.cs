using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class Assetconfiguration
{
    public string RdaInternetUrl { get; set; } = null!;

    public string RemoteInstanceName { get; set; } = null!;

    public string RemoteDatabaseName { get; set; } = null!;

    public string? CodeAgence { get; set; }
}
