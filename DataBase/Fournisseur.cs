using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Fournisseur
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    public string? Rep { get; set; }

    public string? Adresse { get; set; }

    public string? Ville { get; set; }

    public string? Province { get; set; }

    public string? Pays { get; set; }

    public string? Cp { get; set; }

    public string? Telephonne { get; set; }

    public string? Fax { get; set; }

    public string? EMail { get; set; }

    public int? Noposte { get; set; }

    public string? Siteweb { get; set; }

    public string? Commentaire { get; set; }

    public DateTime Creation { get; set; }

    public bool Supprime { get; set; }

    public string? Categorie { get; set; }

    public virtual ICollection<Bonscommande> Bonscommandes { get; set; } = new List<Bonscommande>();

    public virtual ICollection<Liaisoncontact> Liaisoncontacts { get; set; } = new List<Liaisoncontact>();

    public virtual ICollection<ListeDistribution> ListeDistributions { get; set; } = new List<ListeDistribution>();
}
