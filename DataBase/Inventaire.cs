using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Inventaire
{
    public int Id { get; set; }

    public string? Piece { get; set; }

    public string? Description { get; set; }

    public int Manufacturier { get; set; }

    public int Qteboite { get; set; }

    public decimal? Prixliste { get; set; }

    public double? Escompte { get; set; }

    public decimal Prixnet { get; set; }

    public string? Commentaires { get; set; }

    public string? Localisation { get; set; }

    public int Stock { get; set; }

    public int Qtcommandee { get; set; }

    public int Noprojet { get; set; }

    public bool Secommandeenboite { get; set; }

    public virtual Projet NoprojetNavigation { get; set; } = null!;
}
