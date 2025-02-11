using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Client
{
    public int Id { get; set; }

    public string? Compagnie { get; set; }

    public string? Telephonne { get; set; }

    public string? Fax { get; set; }

    public string? Cellulaire { get; set; }

    public string? Email { get; set; }

    public string? Adresse { get; set; }

    public string? Ville { get; set; }

    public string? Province { get; set; }

    public string? Pays { get; set; }

    public string? Cp { get; set; }

    public int? Noposte { get; set; }

    public string? Commentaire { get; set; }

    public DateTime Creation { get; set; }

    public DateTime Modification { get; set; }

    public string? Contact { get; set; }

    public virtual ICollection<Liaisoncontact> Liaisoncontacts { get; set; } = new List<Liaisoncontact>();

    public virtual ICollection<Projet> Projets { get; set; } = new List<Projet>();

    public virtual ICollection<Vendeur> Vendeurs { get; set; } = new List<Vendeur>();
}
