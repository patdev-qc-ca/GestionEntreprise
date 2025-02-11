using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Contact
{
    public int Id { get; set; }

    public string? Contact1 { get; set; }

    public string? Compagnie { get; set; }

    public string? Telephonne { get; set; }

    public string? Fax { get; set; }

    public string? Cellulaire { get; set; }

    public string? EMail { get; set; }

    public int? Noposte { get; set; }

    public DateTime Creation { get; set; }

    public DateTime Modification { get; set; }

    public string? Commentaire { get; set; }

    public string? Titre { get; set; }

    public virtual ICollection<Alarme> Alarmes { get; set; } = new List<Alarme>();

    public virtual ICollection<Liaisoncontact> Liaisoncontacts { get; set; } = new List<Liaisoncontact>();

    public virtual ICollection<ListeDistribution> ListeDistributions { get; set; } = new List<ListeDistribution>();

    public virtual ICollection<Projet> Projets { get; set; } = new List<Projet>();
}
