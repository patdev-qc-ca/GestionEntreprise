using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Alarme
{
    public int Id { get; set; }

    public int Employe { get; set; }

    public int Type { get; set; }

    public DateOnly Date { get; set; }

    public TimeOnly Heure { get; set; }

    public string? Message { get; set; }

    public int? Nocontact { get; set; }

    public virtual Employe EmployeNavigation { get; set; } = null!;

    public virtual Contact? NocontactNavigation { get; set; }

    public virtual Type TypeNavigation { get; set; } = null!;
}
