using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Sortiemateriel
{
    public int Id { get; set; }

    public int Qte { get; set; }

    public int Employe { get; set; }

    public int Projet { get; set; }

    public int Piece { get; set; }

    public virtual Employe EmployeNavigation { get; set; } = null!;

    public virtual Piece PieceNavigation { get; set; } = null!;

    public virtual Projet ProjetNavigation { get; set; } = null!;
}
