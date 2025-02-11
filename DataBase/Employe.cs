using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Employe
{
    public Employe()
    {
    }
    public Employe(int id, string? login, string? clef, string? nom, string? initiale,
            string? telephone, string? cellulaire, bool actif, int ordres, bool supprime)
    {
        Id = id;
        Login = login;
        Clef = clef;
        Nom = nom;
        Initiale = initiale;
        Telephone = telephone;
        Cellulaire = cellulaire;
        Actif = actif;
        Ordres = ordres;
        Supprime = supprime;
    }
    public Employe(int id, string? login, string? clef, string? nom, string? initiale,
            string? telephone, string? cellulaire, bool actif, int ordres, bool supprime,
            ICollection<Achat> achats, ICollection<Alarme> alarmes, Ordre1 ordres1,
            Groupe ordresNavigation, ICollection<OutilsInOut> outilsInOuts,
            ICollection<Projet> projetCreerParNavigations, ICollection<Projet> projetParNavigations,
            ICollection<Rendezvou> rendezvous, ICollection<Vendeur> vendeurs)
    {
        Id = id;
        Login = login;
        Clef = clef;
        Nom = nom;
        Initiale = initiale;
        Telephone = telephone;
        Cellulaire = cellulaire;
        Actif = actif;
        Ordres = ordres;
        Supprime = supprime;
        Achats = achats;
        Alarmes = alarmes;
        Ordres1 = ordres1;
        OrdresNavigation = ordresNavigation;
        OutilsInOuts = outilsInOuts;
        ProjetCreerParNavigations = projetCreerParNavigations;
        ProjetParNavigations = projetParNavigations;
        Rendezvous = rendezvous;
        Vendeurs = vendeurs;
    }
    public int Id { get; set; }
    public string? Login { get; set; }
    public string? Clef { get; set; }
    public string? Nom { get; set; }
    public string? Initiale { get; set; }
    public string? Telephone { get; set; }
    public string? Cellulaire { get; set; }
    public bool Actif { get; set; }
    public int Ordres { get; set; }
    public bool Supprime { get; set; }
    public byte[] Sel { get; set; }
    public virtual ICollection<Achat> Achats { get; set; } = new List<Achat>();
    public virtual ICollection<Alarme> Alarmes { get; set; } = new List<Alarme>();
    public virtual Ordre1 Ordres1 { get; set; } = null!;
    public virtual Groupe OrdresNavigation { get; set; } = null!;
    public virtual ICollection<OutilsInOut> OutilsInOuts { get; set; } = new List<OutilsInOut>();
    public virtual ICollection<Projet> ProjetCreerParNavigations { get; set; } = new List<Projet>();
    public virtual ICollection<Projet> ProjetParNavigations { get; set; } = new List<Projet>();
    public virtual ICollection<Rendezvou> Rendezvous { get; set; } = new List<Rendezvou>();
    public virtual ICollection<Vendeur> Vendeurs { get; set; } = new List<Vendeur>();
}
