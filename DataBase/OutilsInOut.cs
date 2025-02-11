using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class OutilsInOut
{
    public int Id { get; set; }

    public int Employe { get; set; }

    public DateTime Sortie { get; set; }

    public DateTime? Retour { get; set; }

    public string? Commentaire { get; set; }

    public virtual Employe EmployeNavigation { get; set; } = null!;
}
