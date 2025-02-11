using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Vendeur
{
    public int Id { get; set; }

    public int? Idclient { get; set; }

    public DateOnly? Date { get; set; }

    public string? Contact { get; set; }

    public string? Commentaire { get; set; }

    public int Enregpar { get; set; }

    public string? Type { get; set; }

    public virtual Employe EnregparNavigation { get; set; } = null!;

    public virtual Client? IdclientNavigation { get; set; }
}
