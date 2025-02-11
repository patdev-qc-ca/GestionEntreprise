using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Ordre1
{
    public int Idgroupe { get; set; }

    public string? Nomgroupe { get; set; }

    public bool? Clients { get; set; }

    public bool? Fournisseurs { get; set; }

    public bool? Contacts { get; set; }

    public bool? Contactsvendeurs { get; set; }

    public bool? Rapport { get; set; }

    public bool? Catalogue { get; set; }

    public bool? Employes { get; set; }

    public bool? Cedule { get; set; }

    public bool? Configuration { get; set; }

    public bool? Punch { get; set; }

    public bool? Outils { get; set; }

    public bool? Soumission { get; set; }

    public bool? Projet { get; set; }

    public bool? Projetelec { get; set; }

    public bool? Inventaire { get; set; }

    public bool? Achat { get; set; }

    public bool? ComptaFacturation { get; set; }

    public bool? ComptaClients { get; set; }

    public bool? ComptaFournisseurs { get; set; }

    public bool? ComptaContacts { get; set; }

    public bool? ComptaGroupes { get; set; }

    public bool? ComptaEmployes { get; set; }

    public bool? ComptaFeuillestemps { get; set; }

    public bool? ComptaOutils { get; set; }

    public bool? ComptaSoumissions { get; set; }

    public bool? ComptaProjets { get; set; }

    public bool? ComptaBonscommandes { get; set; }

    public bool? ComptaCatalogue { get; set; }

    public bool? ComptaInventaire { get; set; }

    public bool? ComptaPunchemployes { get; set; }

    public bool? ComptaReception { get; set; }

    public bool? ComptaRetourmarchandise { get; set; }

    public bool? SuppressionProjets { get; set; }

    public bool? VerrouillageTempsProjet { get; set; }

    public bool? DeverrouillageTempsProjet { get; set; }

    public virtual ICollection<Employe> EmployesNavigation { get; set; } = new List<Employe>();
}
