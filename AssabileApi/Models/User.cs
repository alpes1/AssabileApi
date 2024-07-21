using System;
using System.Collections.Generic;

namespace AssabileApi.Models;

public partial class User
{
    public int Id { get; set; }

    public string Matricule { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public string MotDePasse { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public DateTime? DateCreation { get; set; }

    public DateTime? DateDerniereConnexion { get; set; }

    public bool? Actif { get; set; }

    public string CodeAgence { get; set; } = null!;
}
