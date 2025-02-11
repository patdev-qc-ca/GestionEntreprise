using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Soumission
{
    public int Id { get; set; }

    public int? Noclient { get; set; }

    public DateTime? Ouverture { get; set; }

    public DateTime? Fermeture { get; set; }

    public string? Raisonfermeture { get; set; }

    public bool Ouvert { get; set; }

    public bool Verrouille { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }

    public virtual Projet? NoclientNavigation { get; set; }

    public virtual ICollection<Piecesparsoumission> Piecesparsoumissions { get; set; } = new List<Piecesparsoumission>();
}
