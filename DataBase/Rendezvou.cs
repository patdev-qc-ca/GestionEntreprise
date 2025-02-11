using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Rendezvou
{
    public int Id { get; set; }

    public int Employe { get; set; }

    public DateOnly Daterdv { get; set; }

    public TimeOnly Debut { get; set; }

    public TimeOnly Fin { get; set; }

    public int Client { get; set; }

    public int? Finprojet { get; set; }

    public virtual Employe EmployeNavigation { get; set; } = null!;
}
