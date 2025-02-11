using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Achat
{
    public int Id { get; set; }

    public int? Indexachat { get; set; }

    public string? Raison { get; set; }

    public DateOnly? Dateachat { get; set; }

    public int? Acheteur { get; set; }

    public decimal? Prixtotal { get; set; }

    public int Type { get; set; }

    public bool Modification { get; set; }

    public int Par { get; set; }

    public virtual Employe? AcheteurNavigation { get; set; }

    public virtual Type TypeNavigation { get; set; } = null!;
}
