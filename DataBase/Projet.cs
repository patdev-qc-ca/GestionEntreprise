using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Projet
{
    public int Id { get; set; }

    public string? Idsoumission { get; set; }

    public int? Idclient { get; set; }

    public int? Idcontact { get; set; }

    public string? Description { get; set; }

    public int Transport { get; set; }

    public DateTime Creer { get; set; }

    public int CreerPar { get; set; }

    public decimal ComptaFabrication { get; set; }

    public decimal ComptaAssemblage { get; set; }

    public decimal ComptaTest { get; set; }

    public decimal ComptaVision { get; set; }

    public decimal ComptaProgautomate { get; set; }

    public decimal ComptaProgrobot { get; set; }

    public decimal ComptaInstallation { get; set; }

    public decimal ComptaMiseservice { get; set; }

    public decimal ComptaFormation { get; set; }

    public decimal ComptaGestion { get; set; }

    public decimal ComptaShipping { get; set; }

    public decimal Nbrepersonne { get; set; }

    public double ComptaHebergement { get; set; }

    public decimal Totalhebergement { get; set; }

    public double ComptaRepas { get; set; }

    public decimal Totalrepas { get; set; }

    public double ComptaTransport { get; set; }

    public string? ComptaUnitemobile { get; set; }

    public decimal Prixemballage { get; set; }

    public decimal Tauxdessin { get; set; }

    public decimal Tauxproginterface { get; set; }

    public decimal MontantFabrication { get; set; }

    public decimal MontantAssemblage { get; set; }

    public decimal MontantTest { get; set; }

    public decimal MontantVision { get; set; }

    public decimal MontantProgautomate { get; set; }

    public decimal MontantProgrobot { get; set; }

    public decimal MontantInstallation { get; set; }

    public decimal MontantMiseservice { get; set; }

    public decimal MontantFormation { get; set; }

    public decimal MontantGestion { get; set; }

    public decimal MontantShipping { get; set; }

    public decimal MontantHebergement1 { get; set; }

    public decimal MontantHebergement2 { get; set; }

    public decimal MontantRepas { get; set; }

    public decimal MontantTransport { get; set; }

    public decimal MontantUnitemobile { get; set; }

    public decimal Imprevue { get; set; }

    public decimal ComptaImprevue { get; set; }

    public decimal ComptaTemps { get; set; }

    public decimal ComptaManuel { get; set; }

    public decimal Commission { get; set; }

    public decimal TotalCommission { get; set; }

    public decimal Prixtotal { get; set; }

    public bool Modification { get; set; }

    public int Par { get; set; }

    public decimal Prixreception { get; set; }

    public decimal Montantforfait { get; set; }

    public decimal Forfaitinitial { get; set; }

    public int? Prochainecommande { get; set; }

    public virtual ICollection<Bonscommande> Bonscommandes { get; set; } = new List<Bonscommande>();

    public virtual Employe CreerParNavigation { get; set; } = null!;

    public virtual Client? IdclientNavigation { get; set; }

    public virtual Contact? IdcontactNavigation { get; set; }

    public virtual ICollection<Inventaire> Inventaires { get; set; } = new List<Inventaire>();

    public virtual Employe ParNavigation { get; set; } = null!;

    public virtual ICollection<Soumission> Soumissions { get; set; } = new List<Soumission>();

    public virtual Transport TransportNavigation { get; set; } = null!;
}
