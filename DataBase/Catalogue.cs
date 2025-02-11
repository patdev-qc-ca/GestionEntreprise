using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Catalogue
{
    public int Id { get; set; }

    public string? DescFr { get; set; }

    public string? DescEn { get; set; }

    public int Fabriquaant { get; set; }

    public string? Descrition { get; set; }

    public string? Temps { get; set; }

    public int Categorie { get; set; }

    public int Piece { get; set; }

    public virtual Piece PieceNavigation { get; set; } = null!;
}
