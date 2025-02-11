using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Bonscommande
{
    public int Id { get; set; }

    public int? Nofournisseur { get; set; }

    public int Noprojet { get; set; }

    public string? Attention { get; set; }

    public int Transport { get; set; }

    public DateOnly Daterequise { get; set; }

    public string? Nosoum { get; set; }

    public int Datecommande { get; set; }

    public int Commandepar { get; set; }

    public decimal Total { get; set; }

    public string? Commentaire { get; set; }

    public virtual Fournisseur? NofournisseurNavigation { get; set; }

    public virtual Projet NoprojetNavigation { get; set; } = null!;

    public virtual Transport TransportNavigation { get; set; } = null!;
}
