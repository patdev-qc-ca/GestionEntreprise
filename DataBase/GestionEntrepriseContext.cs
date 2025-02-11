using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace GestionEntreprise.DataBase;
public partial class GestionEntrepriseContext : DbContext
{
    internal static DbContext context;
    public GestionEntrepriseContext() => context = this;
    public GestionEntrepriseContext(DbContextOptions<GestionEntrepriseContext> options) : base(options) => context = this;
    public virtual DbSet<Achat> Achats { get; set; }
    public virtual DbSet<Alarme> Alarmes { get; set; }
    public virtual DbSet<Bonscommande> Bonscommandes { get; set; }
    public virtual DbSet<Catalogue> Catalogues { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Contact> Contacts { get; set; }
    public virtual DbSet<Devise> Devises { get; set; }
    public virtual DbSet<Employe> Employes { get; set; }
    public virtual DbSet<Fournisseur> Fournisseurs { get; set; }
    public virtual DbSet<Groupe> Groupes { get; set; }
    public virtual DbSet<Inventaire> Inventaires { get; set; }
    public virtual DbSet<Liaisoncontact> Liaisoncontacts { get; set; }
    public virtual DbSet<ListeDistribution> ListeDistributions { get; set; }
    public virtual DbSet<Manufacturier> Manufacturiers { get; set; }
    public virtual DbSet<Ordre> Ordres { get; set; }
    public virtual DbSet<Ordre1> Ordres1 { get; set; }
    public virtual DbSet<Outil> Outils { get; set; }
    public virtual DbSet<OutilsInOut> OutilsInOuts { get; set; }
    public virtual DbSet<Piece> Pieces { get; set; }
    public virtual DbSet<Piecesparprojet> Piecesparprojets { get; set; }
    public virtual DbSet<Piecesparsoumission> Piecesparsoumissions { get; set; }
    public virtual DbSet<Projet> Projets { get; set; }
    public virtual DbSet<Punch> Punches { get; set; }
    public virtual DbSet<Rendezvou> Rendezvous { get; set; }
    public virtual DbSet<Secteur> Secteurs { get; set; }
    public virtual DbSet<Section> Sections { get; set; }
    public virtual DbSet<Sortiemateriel> Sortiemateriels { get; set; }
    public virtual DbSet<Soumission> Soumissions { get; set; }
    public virtual DbSet<Transport> Transports { get; set; }
    public virtual DbSet<Type> Types { get; set; }
    public virtual DbSet<Vendeur> Vendeurs { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=> optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=GestionEntreprise;Trusted_Connection=True;Persist Security Info=True;Encrypt=true;TrustServerCertificate=yes");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Achat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACHATS__3214EC27E238FF03");
            entity.ToTable("ACHATS");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Acheteur).HasColumnName("ACHETEUR");
            entity.Property(e => e.Dateachat).HasColumnName("DATEACHAT");
            entity.Property(e => e.Indexachat).HasColumnName("INDEXACHAT");
            entity.Property(e => e.Modification).HasColumnName("MODIFICATION");
            entity.Property(e => e.Par).HasColumnName("PAR");
            entity.Property(e => e.Prixtotal).HasColumnType("money").HasColumnName("PRIXTOTAL");
            entity.Property(e => e.Raison).HasMaxLength(255).HasColumnName("RAISON");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.HasOne(d => d.AcheteurNavigation).WithMany(p => p.Achats).HasForeignKey(d => d.Acheteur).HasConstraintName("FK_ACHATS_EMPLOYES");
            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Achats).HasForeignKey(d => d.Type).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ACHATS_TYPE");
        });
        modelBuilder.Entity<Alarme>(entity =>
        {
            entity.ToTable("ALARMES");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnName("DATE");
            entity.Property(e => e.Employe).HasColumnName("EMPLOYE");
            entity.Property(e => e.Heure).HasColumnName("HEURE");
            entity.Property(e => e.Message).HasMaxLength(255).HasColumnName("MESSAGE");
            entity.Property(e => e.Nocontact).HasColumnName("NOCONTACT");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.HasOne(d => d.EmployeNavigation).WithMany(p => p.Alarmes).HasForeignKey(d => d.Employe).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ALARMES_EMPLOYES");
            entity.HasOne(d => d.NocontactNavigation).WithMany(p => p.Alarmes).HasForeignKey(d => d.Nocontact).HasConstraintName("FK_ALARMES_CONTACT");
            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Alarmes).HasForeignKey(d => d.Type).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ALARMES_TYPE");
        });
        modelBuilder.Entity<Bonscommande>(entity =>
        {
            entity.ToTable("BONSCOMMANDES");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Attention).HasMaxLength(50).HasColumnName("ATTENTION");
            entity.Property(e => e.Commandepar).HasColumnName("COMMANDEPAR");
            entity.Property(e => e.Commentaire).HasMaxLength(255).HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Datecommande).HasColumnName("DATECOMMANDE");
            entity.Property(e => e.Daterequise).HasColumnName("DATEREQUISE");
            entity.Property(e => e.Nofournisseur).HasColumnName("NOFOURNISSEUR");
            entity.Property(e => e.Noprojet).HasColumnName("NOPROJET");
            entity.Property(e => e.Nosoum).HasMaxLength(50).HasColumnName("NOSOUM");
            entity.Property(e => e.Total).HasColumnType("money").HasColumnName("TOTAL");
            entity.Property(e => e.Transport).HasColumnName("TRANSPORT");
            entity.HasOne(d => d.NofournisseurNavigation).WithMany(p => p.Bonscommandes).HasForeignKey(d => d.Nofournisseur).HasConstraintName("FK_BONSCOMMANDES_FOURNISSEUR");
            entity.HasOne(d => d.NoprojetNavigation).WithMany(p => p.Bonscommandes).HasForeignKey(d => d.Noprojet).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_BONSCOMMANDES_PROJET");
            entity.HasOne(d => d.TransportNavigation).WithMany(p => p.Bonscommandes).HasForeignKey(d => d.Transport).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_BONSCOMMANDES_TRANSPORT");
        });
        modelBuilder.Entity<Catalogue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CATALOGU__3214EC277A5D37A5");
            entity.ToTable("CATALOGUE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Categorie).HasColumnName("CATEGORIE");
            entity.Property(e => e.DescEn).HasMaxLength(255).HasColumnName("DESC_EN");
            entity.Property(e => e.DescFr).HasMaxLength(255).HasColumnName("DESC_FR");
            entity.Property(e => e.Descrition).HasMaxLength(100).HasColumnName("DESCRITION");
            entity.Property(e => e.Fabriquaant).HasColumnName("FABRIQUAANT");
            entity.Property(e => e.Piece).HasColumnName("PIECE");
            entity.Property(e => e.Temps).HasMaxLength(50).HasColumnName("TEMPS");
            entity.HasOne(d => d.PieceNavigation).WithMany(p => p.Catalogues).HasForeignKey(d => d.Piece).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CATALOGUE_PIECES");
        });
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CLIENT__3214EC27C22EA9F4");
            entity.ToTable("CLIENT");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adresse).HasMaxLength(100).HasColumnName("ADRESSE");
            entity.Property(e => e.Cellulaire).HasMaxLength(50).HasColumnName("CELLULAIRE");
            entity.Property(e => e.Commentaire).HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Compagnie).HasMaxLength(100).HasColumnName("COMPAGNIE");
            entity.Property(e => e.Contact).HasMaxLength(50).HasColumnName("CONTACT");
            entity.Property(e => e.Cp).HasMaxLength(25).HasColumnName("CP");
            entity.Property(e => e.Creation).HasColumnType("datetime").HasColumnName("CREATION");
            entity.Property(e => e.Email).HasMaxLength(255).HasColumnName("EMAIL");
            entity.Property(e => e.Fax).HasMaxLength(50).HasColumnName("FAX");
            entity.Property(e => e.Modification).HasColumnType("datetime").HasColumnName("MODIFICATION");
            entity.Property(e => e.Noposte).HasColumnName("NOPOSTE");
            entity.Property(e => e.Pays).HasMaxLength(100).HasColumnName("PAYS");
            entity.Property(e => e.Province).HasMaxLength(100).HasColumnName("PROVINCE");
            entity.Property(e => e.Telephonne).HasMaxLength(50).HasColumnName("TELEPHONNE");
            entity.Property(e => e.Ville).HasMaxLength(100).HasColumnName("VILLE");
        });
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.ToTable("CONTACT");
            entity.Property(e => e.Id).ValueGeneratedNever().HasColumnName("ID");
            entity.Property(e => e.Cellulaire).HasMaxLength(100).HasColumnName("CELLULAIRE");
            entity.Property(e => e.Commentaire).HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Compagnie).HasMaxLength(100).HasColumnName("COMPAGNIE");
            entity.Property(e => e.Contact1).HasMaxLength(255).HasColumnName("CONTACT");
            entity.Property(e => e.Creation).HasColumnType("datetime").HasColumnName("CREATION");
            entity.Property(e => e.EMail).HasMaxLength(255).HasColumnName("E-MAIL");
            entity.Property(e => e.Fax).HasMaxLength(100).HasColumnName("FAX");
            entity.Property(e => e.Modification).HasColumnType("datetime").HasColumnName("MODIFICATION");
            entity.Property(e => e.Noposte).HasColumnName("NOPOSTE");
            entity.Property(e => e.Telephonne).HasMaxLength(100).HasColumnName("TELEPHONNE");
            entity.Property(e => e.Titre).HasMaxLength(255).HasColumnName("TITRE");
        });
        modelBuilder.Entity<Devise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DEVISES__3214EC27B9B2B7B1");
            entity.ToTable("DEVISES");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Desciption).HasMaxLength(10).HasColumnName("DESCIPTION");
        });
        modelBuilder.Entity<Employe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EMPLOYES__3214EC27CF71D7F1");
            entity.ToTable("EMPLOYES");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Actif).HasColumnName("ACTIF");
            entity.Property(e => e.Cellulaire).HasMaxLength(50).HasColumnName("CELLULAIRE");
            entity.Property(e => e.Clef).HasMaxLength(50).HasColumnName("CLEF");
            entity.Property(e => e.Initiale).HasMaxLength(50).HasColumnName("INITIALE");
            entity.Property(e => e.Login).HasMaxLength(50).HasColumnName("LOGIN");
            entity.Property(e => e.Nom).HasMaxLength(50).HasColumnName("NOM");
            entity.Property(e => e.Ordres).HasColumnName("ORDRES");
            entity.Property(e => e.Supprime).HasColumnName("SUPPRIME");
            entity.Property(e => e.Telephone).HasMaxLength(50).HasColumnName("TELEPHONE");
            entity.HasOne(d => d.OrdresNavigation).WithMany(p => p.EmployesNavigation).HasForeignKey(d => d.Ordres).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EMPLOYES_GROUPES");
            entity.HasOne(d => d.Ordres1).WithMany(p => p.EmployesNavigation).HasForeignKey(d => d.Ordres).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EMPLOYES_ORDRES");
        });
        modelBuilder.Entity<Fournisseur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FOURNISS__3214EC27826AFB3F");
            entity.ToTable("FOURNISSEUR");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adresse).HasMaxLength(100).HasColumnName("ADRESSE");
            entity.Property(e => e.Categorie).HasMaxLength(40).HasColumnName("CATEGORIE");
            entity.Property(e => e.Commentaire).HasMaxLength(255).HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Cp).HasMaxLength(25).HasColumnName("CP");
            entity.Property(e => e.Creation).HasColumnType("datetime").HasColumnName("CREATION");
            entity.Property(e => e.EMail).HasMaxLength(255).HasColumnName("E-MAIL");
            entity.Property(e => e.Fax).HasMaxLength(100).HasColumnName("FAX");
            entity.Property(e => e.Nom).HasMaxLength(100).HasColumnName("NOM");
            entity.Property(e => e.Noposte).HasColumnName("NOPOSTE");
            entity.Property(e => e.Pays).HasMaxLength(100).HasColumnName("PAYS");
            entity.Property(e => e.Province).HasMaxLength(100).HasColumnName("PROVINCE");
            entity.Property(e => e.Rep).HasMaxLength(100).HasColumnName("REP");
            entity.Property(e => e.Siteweb).HasMaxLength(50).HasColumnName("SITEWEB");
            entity.Property(e => e.Supprime).HasColumnName("SUPPRIME");
            entity.Property(e => e.Telephonne).HasMaxLength(100).HasColumnName("TELEPHONNE");
            entity.Property(e => e.Ville).HasMaxLength(100).HasColumnName("VILLE");
        });
        modelBuilder.Entity<Groupe>(entity =>
        {
            entity.ToTable("GROUPES");
            entity.Property(e => e.Id).ValueGeneratedNever().HasColumnName("ID");
            entity.Property(e => e.Achat).HasColumnName("ACHAT");
            entity.Property(e => e.Catalogue).HasColumnName("CATALOGUE");
            entity.Property(e => e.Cedule).HasColumnName("CEDULE");
            entity.Property(e => e.Clients).HasColumnName("CLIENTS");
            entity.Property(e => e.ComptaBonscommandes).HasColumnName("COMPTA-BONSCOMMANDES");
            entity.Property(e => e.ComptaCatalogue).HasColumnName("COMPTA-CATALOGUE");
            entity.Property(e => e.ComptaClients).HasColumnName("COMPTA-CLIENTS");
            entity.Property(e => e.ComptaContacts).HasColumnName("COMPTA-CONTACTS");
            entity.Property(e => e.ComptaEmployes).HasColumnName("COMPTA-EMPLOYES");
            entity.Property(e => e.ComptaFacturation).HasColumnName("COMPTA-FACTURATION");
            entity.Property(e => e.ComptaFeuillestemps).HasColumnName("COMPTA-FEUILLESTEMPS");
            entity.Property(e => e.ComptaFournisseurs).HasColumnName("COMPTA-FOURNISSEURS");
            entity.Property(e => e.ComptaGroupes).HasColumnName("COMPTA-GROUPES");
            entity.Property(e => e.ComptaInventaire).HasColumnName("COMPTA-INVENTAIRE");
            entity.Property(e => e.ComptaOutils).HasColumnName("COMPTA-OUTILS");
            entity.Property(e => e.ComptaProjetselec).HasColumnName("COMPTA-PROJETSELEC");
            entity.Property(e => e.ComptaProjetsmec).HasColumnName("COMPTA-PROJETSMEC");
            entity.Property(e => e.ComptaPunch).HasColumnName("COMPTA-PUNCH");
            entity.Property(e => e.ComptaReception).HasColumnName("COMPTA-RECEPTION");
            entity.Property(e => e.ComptaRetourmarchandise).HasColumnName("COMPTA-RETOURMARCHANDISE");
            entity.Property(e => e.ComptaSoumissionselec).HasColumnName("COMPTA-SOUMISSIONSELEC");
            entity.Property(e => e.ComptaSoumissionsmec).HasColumnName("COMPTA-SOUMISSIONSMEC");
            entity.Property(e => e.Contacts).HasColumnName("CONTACTS");
            entity.Property(e => e.Employes).HasColumnName("EMPLOYES");
            entity.Property(e => e.Fournisseurs).HasColumnName("FOURNISSEURS");
            entity.Property(e => e.Inventaire).HasColumnName("INVENTAIRE");
            entity.Property(e => e.Nomgroupe).HasMaxLength(50).HasColumnName("NOMGROUPE");
            entity.Property(e => e.Outils).HasColumnName("OUTILS");
            entity.Property(e => e.Projet).HasColumnName("PROJET");
            entity.Property(e => e.Rapport).HasColumnName("RAPPORT");
            entity.Property(e => e.Soumission).HasColumnName("SOUMISSION");
            entity.Property(e => e.Suppressionprojets).HasColumnName("SUPPRESSIONPROJETS");
        });
        modelBuilder.Entity<Inventaire>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INVENTAI__3214EC27CF8BA428");
            entity.ToTable("INVENTAIRE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Commentaires).HasMaxLength(50).HasColumnName("COMMENTAIRES");
            entity.Property(e => e.Description).HasMaxLength(255).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Escompte).HasColumnName("ESCOMPTE");
            entity.Property(e => e.Localisation).HasMaxLength(50).HasColumnName("LOCALISATION");
            entity.Property(e => e.Manufacturier).HasColumnName("MANUFACTURIER");
            entity.Property(e => e.Noprojet).HasColumnName("NOPROJET");
            entity.Property(e => e.Piece).HasMaxLength(50).HasColumnName("PIECE");
            entity.Property(e => e.Prixliste).HasColumnType("money").HasColumnName("PRIXLISTE");
            entity.Property(e => e.Prixnet).HasColumnType("money").HasColumnName("PRIXNET");
            entity.Property(e => e.Qtcommandee).HasColumnName("QTCOMMANDEE");
            entity.Property(e => e.Qteboite).HasColumnName("QTEBOITE");
            entity.Property(e => e.Secommandeenboite).HasColumnName("SECOMMANDEENBOITE");
            entity.Property(e => e.Stock).HasColumnName("STOCK");
            entity.HasOne(d => d.NoprojetNavigation).WithMany(p => p.Inventaires).HasForeignKey(d => d.Noprojet).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_INVENTAIRE_PROJET");
        });
        modelBuilder.Entity<Liaisoncontact>(entity =>
        {
            entity.ToTable("LIAISONCONTACT");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Noclient).HasColumnName("NOCLIENT");
            entity.Property(e => e.Nocontact).HasColumnName("NOCONTACT");
            entity.Property(e => e.Nofournisseur).HasColumnName("NOFOURNISSEUR");
            entity.Property(e => e.Nomanufacturier).HasColumnName("NOMANUFACTURIER");
            entity.HasOne(d => d.NoclientNavigation).WithMany(p => p.Liaisoncontacts).HasForeignKey(d => d.Noclient).HasConstraintName("FK_LIAISONCONTACT_CLIENT");
            entity.HasOne(d => d.NocontactNavigation).WithMany(p => p.Liaisoncontacts).HasForeignKey(d => d.Nocontact).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_LIAISONCONTACT_CONTACT");
            entity.HasOne(d => d.NofournisseurNavigation).WithMany(p => p.Liaisoncontacts).HasForeignKey(d => d.Nofournisseur).HasConstraintName("FK_LIAISONCONTACT_FOURNISSEUR");
            entity.HasOne(d => d.NomanufacturierNavigation).WithMany(p => p.Liaisoncontacts).HasForeignKey(d => d.Nomanufacturier).HasConstraintName("FK_LIAISONCONTACT_Manufacturier");
        });
        modelBuilder.Entity<ListeDistribution>(entity =>
        {
            entity.ToTable("ListeDistribution");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsChefEntreprise).HasColumnName("isChefEntreprise");
            entity.Property(e => e.IsClient).HasColumnName("isClient");
            entity.Property(e => e.IsContact).HasColumnName("isContact");
            entity.Property(e => e.IsFournisseur).HasColumnName("isFournisseur");
            entity.Property(e => e.NomCompagnie).HasMaxLength(200);
            entity.HasOne(d => d.NoContactNavigation).WithMany(p => p.ListeDistributions).HasForeignKey(d => d.NoContact).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ListeDistribution_CONTACT");
            entity.HasOne(d => d.NoContact1).WithMany(p => p.ListeDistributions).HasForeignKey(d => d.NoContact).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ListeDistribution_FOURNISSEUR");
            entity.HasOne(d => d.NoContact2).WithMany(p => p.ListeDistributions).HasForeignKey(d => d.NoContact).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ListeDistribution_LIAISONCONTACT");
        });
        modelBuilder.Entity<Manufacturier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Manufact__3214EC270AA068F3");
            entity.ToTable("Manufacturier");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adresse).HasMaxLength(100).HasColumnName("ADRESSE");
            entity.Property(e => e.Categorie).HasMaxLength(40).HasColumnName("CATEGORIE");
            entity.Property(e => e.Commentaire).HasMaxLength(255).HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Cp).HasMaxLength(25).HasColumnName("CP");
            entity.Property(e => e.Creation).HasColumnType("datetime").HasColumnName("CREATION");
            entity.Property(e => e.Email).HasMaxLength(255).HasColumnName("EMAIL");
            entity.Property(e => e.Fax).HasMaxLength(100).HasColumnName("FAX");
            entity.Property(e => e.Nom).HasMaxLength(100).HasColumnName("NOM");
            entity.Property(e => e.Noposte).HasColumnName("NOPOSTE");
            entity.Property(e => e.Pays).HasMaxLength(100).HasColumnName("PAYS");
            entity.Property(e => e.Province).HasMaxLength(100).HasColumnName("PROVINCE");
            entity.Property(e => e.Rep).HasMaxLength(100).HasColumnName("REP");
            entity.Property(e => e.Siteweb).HasMaxLength(50).HasColumnName("SITEWEB");
            entity.Property(e => e.Supprime).HasColumnName("SUPPRIME");
            entity.Property(e => e.Telephonne).HasMaxLength(100).HasColumnName("TELEPHONNE");
            entity.Property(e => e.Ville).HasMaxLength(100).HasColumnName("VILLE");
        });
        modelBuilder.Entity<Ordre>(entity =>
        {
            entity.ToTable("ORDRE");
            entity.Property(e => e.Id).ValueGeneratedNever().HasColumnName("ID");
            entity.Property(e => e.Famille).HasMaxLength(50).HasColumnName("FAMILLE");
        });
        modelBuilder.Entity<Ordre1>(entity =>
        {
            entity.HasKey(e => e.Idgroupe);
            entity.ToTable("ORDRES");
            entity.Property(e => e.Idgroupe).ValueGeneratedNever().HasColumnName("IDGROUPE");
            entity.Property(e => e.Achat).HasColumnName("ACHAT");
            entity.Property(e => e.Catalogue).HasColumnName("CATALOGUE");
            entity.Property(e => e.Cedule).HasColumnName("CEDULE");
            entity.Property(e => e.Clients).HasColumnName("CLIENTS");
            entity.Property(e => e.ComptaBonscommandes).HasColumnName("COMPTA-BONSCOMMANDES");
            entity.Property(e => e.ComptaCatalogue).HasColumnName("COMPTA-CATALOGUE");
            entity.Property(e => e.ComptaClients).HasColumnName("COMPTA-CLIENTS");
            entity.Property(e => e.ComptaContacts).HasColumnName("COMPTA-CONTACTS");
            entity.Property(e => e.ComptaEmployes).HasColumnName("COMPTA-EMPLOYES");
            entity.Property(e => e.ComptaFacturation).HasColumnName("COMPTA-FACTURATION");
            entity.Property(e => e.ComptaFeuillestemps).HasColumnName("COMPTA-FEUILLESTEMPS");
            entity.Property(e => e.ComptaFournisseurs).HasColumnName("COMPTA-FOURNISSEURS");
            entity.Property(e => e.ComptaGroupes).HasColumnName("COMPTA-GROUPES");
            entity.Property(e => e.ComptaInventaire).HasColumnName("COMPTA-INVENTAIRE");
            entity.Property(e => e.ComptaOutils).HasColumnName("COMPTA-OUTILS");
            entity.Property(e => e.ComptaProjets).HasColumnName("COMPTA-PROJETS");
            entity.Property(e => e.ComptaPunchemployes).HasColumnName("COMPTA-PUNCHEMPLOYES");
            entity.Property(e => e.ComptaReception).HasColumnName("COMPTA-RECEPTION");
            entity.Property(e => e.ComptaRetourmarchandise).HasColumnName("COMPTA-RETOURMARCHANDISE");
            entity.Property(e => e.ComptaSoumissions).HasColumnName("COMPTA-SOUMISSIONS");
            entity.Property(e => e.Configuration).HasColumnName("CONFIGURATION");
            entity.Property(e => e.Contacts).HasColumnName("CONTACTS");
            entity.Property(e => e.Contactsvendeurs).HasColumnName("CONTACTSVENDEURS");
            entity.Property(e => e.Employes).HasColumnName("EMPLOYES");
            entity.Property(e => e.Fournisseurs).HasColumnName("FOURNISSEURS");
            entity.Property(e => e.Inventaire).HasColumnName("INVENTAIRE");
            entity.Property(e => e.Nomgroupe).HasMaxLength(50).HasColumnName("NOMGROUPE");
            entity.Property(e => e.Outils).HasColumnName("OUTILS");
            entity.Property(e => e.Projet).HasColumnName("PROJET");
            entity.Property(e => e.Projetelec).HasColumnName("PROJETELEC");
            entity.Property(e => e.Punch).HasColumnName("PUNCH");
            entity.Property(e => e.Rapport).HasColumnName("RAPPORT");
            entity.Property(e => e.Soumission).HasColumnName("SOUMISSION");
        });
        modelBuilder.Entity<Outil>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OUTILS__3214EC276CA17AA6");
            entity.ToTable("OUTILS");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Commentaire).HasMaxLength(255).HasColumnName("COMMENTAIRE");
            entity.Property(e => e.DateAchat).HasMaxLength(50).HasColumnName("DATE_ACHAT");
            entity.Property(e => e.DateHorsFonction).HasMaxLength(50).HasColumnName("DATE_HORS_FONCTION");
            entity.Property(e => e.Description).HasMaxLength(100).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Prix).HasColumnType("money").HasColumnName("PRIX");
            entity.Property(e => e.Secteur).HasColumnName("SECTEUR");
            entity.Property(e => e.TypeEtiquette).HasMaxLength(50).HasColumnName("TYPE_ETIQUETTE");
        });
        modelBuilder.Entity<OutilsInOut>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OUTILS_I__3214EC27224EE314");
            entity.ToTable("OUTILS_IN_OUT");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Commentaire).HasMaxLength(255).HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Employe).HasColumnName("EMPLOYE");
            entity.Property(e => e.Retour).HasColumnType("datetime").HasColumnName("RETOUR");
            entity.Property(e => e.Sortie).HasColumnType("datetime").HasColumnName("SORTIE");
            entity.HasOne(d => d.EmployeNavigation).WithMany(p => p.OutilsInOuts).HasForeignKey(d => d.Employe).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_OUTILS_IN_OUT_EMPLOYES");
        });
        modelBuilder.Entity<Piece>(entity =>
        {
            entity.ToTable("PIECES");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Commande).HasColumnName("COMMANDE");
            entity.Property(e => e.Commandeannulee).HasColumnName("COMMANDEANNULEE");
            entity.Property(e => e.Datecommande).HasColumnName("DATECOMMANDE");
            entity.Property(e => e.Datereception).HasColumnName("DATERECEPTION");
            entity.Property(e => e.Daterequise).HasColumnName("DATEREQUISE");
            entity.Property(e => e.Dateretour).HasColumnName("DATERETOUR");
            entity.Property(e => e.DescEn).HasMaxLength(255).HasColumnName("DESC_EN");
            entity.Property(e => e.DescFr).HasMaxLength(255).HasColumnName("DESC_FR");
            entity.Property(e => e.Devise).HasColumnName("DEVISE");
            entity.Property(e => e.Escompte).HasColumnName("ESCOMPTE");
            entity.Property(e => e.Idfournisseur).HasColumnName("IDFOURNISSEUR");
            entity.Property(e => e.Idmanufacturier).HasColumnName("IDMANUFACTURIER");
            entity.Property(e => e.Idpiece).HasColumnName("IDPIECE");
            entity.Property(e => e.Noretour).HasMaxLength(50).HasColumnName("NORETOUR");
            entity.Property(e => e.PrixNet).HasColumnType("money").HasColumnName("PRIX_NET");
            entity.Property(e => e.PrixTotal).HasColumnType("money").HasColumnName("PRIX_TOTAL");
            entity.Property(e => e.Prixliste).HasColumnType("money").HasColumnName("PRIXLISTE");
            entity.Property(e => e.Prixorigine).HasMaxLength(50).HasColumnName("PRIXORIGINE");
            entity.Property(e => e.Qte).HasColumnName("QTE");
            entity.Property(e => e.Quantiterecue).HasColumnName("QUANTITERECUE");
            entity.Property(e => e.Recu).HasColumnName("RECU");
            entity.Property(e => e.Retour).HasColumnName("RETOUR");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.HasOne(d => d.DeviseNavigation).WithMany(p => p.Pieces).HasForeignKey(d => d.Devise).HasConstraintName("FK_PIECES_DEVISES");
            entity.HasOne(d => d.IdmanufacturierNavigation).WithMany(p => p.Pieces).HasForeignKey(d => d.Idmanufacturier).HasConstraintName("FK_PIECES_Manufacturier");
        });
        modelBuilder.Entity<Piecesparprojet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PIECESPA__3214EC27A9A31842");
            entity.ToTable("PIECESPARPROJET");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Commande).HasColumnName("COMMANDE");
            entity.Property(e => e.Commandeannulee).HasColumnName("COMMANDEANNULEE");
            entity.Property(e => e.Commandele).HasColumnType("datetime").HasColumnName("COMMANDELE");
            entity.Property(e => e.Commentaire).HasMaxLength(255).HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Fournisseur).HasColumnName("FOURNISSEUR");
            entity.Property(e => e.Idprojet).HasColumnName("IDPROJET");
            entity.Property(e => e.Manufact).HasColumnName("MANUFACT");
            entity.Property(e => e.Noretour).HasMaxLength(50).HasColumnName("NORETOUR");
            entity.Property(e => e.Piece).HasColumnName("PIECE");
            entity.Property(e => e.Qte).HasColumnName("QTE");
            entity.Property(e => e.Quantiterecue).HasColumnName("QUANTITERECUE");
            entity.Property(e => e.Reception).HasColumnName("RECEPTION");
            entity.Property(e => e.Recu).HasColumnName("RECU");
            entity.Property(e => e.Requisele).HasColumnType("datetime").HasColumnName("REQUISELE");
            entity.Property(e => e.Retour).HasColumnName("RETOUR");
            entity.Property(e => e.Retournee).HasColumnType("datetime").HasColumnName("RETOURNEE");
            entity.Property(e => e.Titrecommande).HasMaxLength(50).HasColumnName("TITRECOMMANDE");
            entity.Property(e => e.Type).HasMaxLength(50).HasColumnName("TYPE");
        });
        modelBuilder.Entity<Piecesparsoumission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PIECESPA__3214EC277B5D490A");
            entity.ToTable("PIECESPARSOUMISSION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Commande).HasColumnName("COMMANDE");
            entity.Property(e => e.Commandeannulee).HasColumnName("COMMANDEANNULEE");
            entity.Property(e => e.Commentaire).HasMaxLength(255).HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Dureetotale).HasColumnName("DUREETOTALE");
            entity.Property(e => e.Idsoumission).HasColumnName("IDSOUMISSION");
            entity.Property(e => e.Piece).HasColumnName("PIECE");
            entity.Property(e => e.Prixorigine).HasColumnType("money").HasColumnName("PRIXORIGINE");
            entity.Property(e => e.Prixtotal).HasColumnType("money").HasColumnName("PRIXTOTAL");
            entity.Property(e => e.Qte).HasColumnName("QTE");
            entity.Property(e => e.Recu).HasColumnName("RECU");
            entity.Property(e => e.Retour).HasColumnName("RETOUR");
            entity.Property(e => e.Temps).HasColumnName("TEMPS");
            entity.HasOne(d => d.IdsoumissionNavigation).WithMany(p => p.Piecesparsoumissions).HasForeignKey(d => d.Idsoumission).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PIECESPARSOUMISSION_SOUMISSION");
            entity.HasOne(d => d.PieceNavigation).WithMany(p => p.Piecesparsoumissions).HasForeignKey(d => d.Piece).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PIECESPARSOUMISSION_PIECES");
        });
        modelBuilder.Entity<Projet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PROJET__3214EC27EB1707FD");
            entity.ToTable("PROJET");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Commission).HasColumnType("money").HasColumnName("COMMISSION");
            entity.Property(e => e.ComptaAssemblage).HasColumnType("money").HasColumnName("COMPTA-ASSEMBLAGE");
            entity.Property(e => e.ComptaFabrication).HasColumnType("money").HasColumnName("COMPTA-FABRICATION");
            entity.Property(e => e.ComptaFormation).HasColumnType("money").HasColumnName("COMPTA-FORMATION");
            entity.Property(e => e.ComptaGestion).HasColumnType("money").HasColumnName("COMPTA-GESTION");
            entity.Property(e => e.ComptaHebergement).HasColumnName("COMPTA-HEBERGEMENT");
            entity.Property(e => e.ComptaImprevue).HasColumnType("money").HasColumnName("COMPTA-IMPREVUE");
            entity.Property(e => e.ComptaInstallation).HasColumnType("money").HasColumnName("COMPTA-INSTALLATION");
            entity.Property(e => e.ComptaManuel).HasColumnType("money").HasColumnName("COMPTA-MANUEL");
            entity.Property(e => e.ComptaMiseservice).HasColumnType("money").HasColumnName("COMPTA-MISESERVICE");
            entity.Property(e => e.ComptaProgautomate).HasColumnType("money").HasColumnName("COMPTA-PROGAUTOMATE");
            entity.Property(e => e.ComptaProgrobot).HasColumnType("money").HasColumnName("COMPTA-PROGROBOT");
            entity.Property(e => e.ComptaRepas).HasColumnName("COMPTA-REPAS");
            entity.Property(e => e.ComptaShipping).HasColumnType("money").HasColumnName("COMPTA-SHIPPING");
            entity.Property(e => e.ComptaTemps).HasColumnType("money").HasColumnName("COMPTA-TEMPS");
            entity.Property(e => e.ComptaTest).HasColumnType("money").HasColumnName("COMPTA-TEST");
            entity.Property(e => e.ComptaTransport).HasColumnName("COMPTA-TRANSPORT");
            entity.Property(e => e.ComptaUnitemobile).HasMaxLength(50).HasColumnName("COMPTA-UNITEMOBILE");
            entity.Property(e => e.ComptaVision).HasColumnType("money").HasColumnName("COMPTA-VISION");
            entity.Property(e => e.Creer).HasColumnType("datetime").HasColumnName("CREER");
            entity.Property(e => e.CreerPar).HasColumnName("CREER_PAR");
            entity.Property(e => e.Description).HasMaxLength(255).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Forfaitinitial).HasColumnType("money").HasColumnName("FORFAITINITIAL");
            entity.Property(e => e.Idclient).HasColumnName("IDCLIENT");
            entity.Property(e => e.Idcontact).HasColumnName("IDCONTACT");
            entity.Property(e => e.Idsoumission).HasMaxLength(50).HasColumnName("IDSOUMISSION");
            entity.Property(e => e.Imprevue).HasColumnType("money").HasColumnName("IMPREVUE");
            entity.Property(e => e.Modification).HasColumnName("MODIFICATION");
            entity.Property(e => e.MontantAssemblage).HasColumnType("money").HasColumnName("MONTANT-ASSEMBLAGE");
            entity.Property(e => e.MontantFabrication).HasColumnType("money").HasColumnName("MONTANT-FABRICATION");
            entity.Property(e => e.MontantFormation).HasColumnType("money").HasColumnName("MONTANT-FORMATION");
            entity.Property(e => e.MontantGestion).HasColumnType("money").HasColumnName("MONTANT-GESTION");
            entity.Property(e => e.MontantHebergement1).HasColumnType("money").HasColumnName("MONTANT-HEBERGEMENT1");
            entity.Property(e => e.MontantHebergement2).HasColumnType("money").HasColumnName("MONTANT-HEBERGEMENT2");
            entity.Property(e => e.MontantInstallation).HasColumnType("money").HasColumnName("MONTANT-INSTALLATION");
            entity.Property(e => e.MontantMiseservice).HasColumnType("money").HasColumnName("MONTANT-MISESERVICE");
            entity.Property(e => e.MontantProgautomate).HasColumnType("money").HasColumnName("MONTANT-PROGAUTOMATE");
            entity.Property(e => e.MontantProgrobot).HasColumnType("money").HasColumnName("MONTANT-PROGROBOT");
            entity.Property(e => e.MontantRepas).HasColumnType("money").HasColumnName("MONTANT-REPAS");
            entity.Property(e => e.MontantShipping).HasColumnType("money").HasColumnName("MONTANT-SHIPPING");
            entity.Property(e => e.MontantTest).HasColumnType("money").HasColumnName("MONTANT-TEST");
            entity.Property(e => e.MontantTransport).HasColumnType("money").HasColumnName("MONTANT-TRANSPORT");
            entity.Property(e => e.MontantUnitemobile).HasColumnType("money").HasColumnName("MONTANT-UNITEMOBILE");
            entity.Property(e => e.MontantVision).HasColumnType("money").HasColumnName("MONTANT-VISION");
            entity.Property(e => e.Montantforfait).HasColumnType("money").HasColumnName("MONTANTFORFAIT");
            entity.Property(e => e.Nbrepersonne).HasColumnType("money").HasColumnName("NBREPERSONNE");
            entity.Property(e => e.Par).HasColumnName("PAR");
            entity.Property(e => e.Prixemballage).HasColumnType("money").HasColumnName("PRIXEMBALLAGE");
            entity.Property(e => e.Prixreception).HasColumnType("money").HasColumnName("PRIXRECEPTION");
            entity.Property(e => e.Prixtotal).HasColumnType("money").HasColumnName("PRIXTOTAL");
            entity.Property(e => e.Prochainecommande).HasColumnName("PROCHAINECOMMANDE");
            entity.Property(e => e.Tauxdessin).HasColumnType("money").HasColumnName("TAUXDESSIN");
            entity.Property(e => e.Tauxproginterface).HasColumnType("money").HasColumnName("TAUXPROGINTERFACE");
            entity.Property(e => e.TotalCommission).HasColumnType("money").HasColumnName("TOTAL_COMMISSION");
            entity.Property(e => e.Totalhebergement).HasColumnType("money").HasColumnName("TOTALHEBERGEMENT");
            entity.Property(e => e.Totalrepas).HasColumnType("money").HasColumnName("TOTALREPAS");
            entity.Property(e => e.Transport).HasColumnName("TRANSPORT");
            entity.HasOne(d => d.CreerParNavigation).WithMany(p => p.ProjetCreerParNavigations).HasForeignKey(d => d.CreerPar).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PROJET_EMPLOYES1");
            entity.HasOne(d => d.IdclientNavigation).WithMany(p => p.Projets).HasForeignKey(d => d.Idclient).HasConstraintName("FK_PROJET_CLIENT");
            entity.HasOne(d => d.IdcontactNavigation).WithMany(p => p.Projets).HasForeignKey(d => d.Idcontact).HasConstraintName("FK_PROJET_CONTACT");
            entity.HasOne(d => d.ParNavigation).WithMany(p => p.ProjetParNavigations).HasForeignKey(d => d.Par).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PROJET_EMPLOYES");
            entity.HasOne(d => d.TransportNavigation).WithMany(p => p.Projets).HasForeignKey(d => d.Transport).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PROJET_TRANSPORT");
        });
        modelBuilder.Entity<Punch>(entity =>
        {
            entity.ToTable("PUNCH");
            entity.Property(e => e.Id).ValueGeneratedNever().HasColumnName("ID");
            entity.Property(e => e.Commentaire).HasMaxLength(255).HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Date).HasColumnName("DATE");
            entity.Property(e => e.Debut).HasColumnName("DEBUT");
            entity.Property(e => e.Duree).HasMaxLength(10).HasColumnName("DUREE");
            entity.Property(e => e.Employe).HasColumnName("EMPLOYE");
            entity.Property(e => e.Facture).HasColumnName("FACTURE");
            entity.Property(e => e.Fin).HasColumnName("FIN");
            entity.Property(e => e.Km).HasColumnName("KM");
            entity.Property(e => e.Nbrekm).HasMaxLength(50).HasColumnName("NBREKM");
            entity.Property(e => e.Noclient).HasMaxLength(50).HasColumnName("NOCLIENT");
            entity.Property(e => e.Nofacture).HasMaxLength(50).HasColumnName("NOFACTURE");
            entity.Property(e => e.Noprojet).HasColumnName("NOPROJET");
            entity.Property(e => e.Section).HasColumnName("SECTION");
        });
        modelBuilder.Entity<Rendezvou>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RENDEZVO__3214EC27D21622D4");
            entity.ToTable("RENDEZVOUS");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Client).HasColumnName("CLIENT");
            entity.Property(e => e.Daterdv).HasColumnName("DATERDV");
            entity.Property(e => e.Debut).HasColumnName("DEBUT");
            entity.Property(e => e.Employe).HasColumnName("EMPLOYE");
            entity.Property(e => e.Fin).HasColumnName("FIN");
            entity.Property(e => e.Finprojet).HasColumnName("FINPROJET");
            entity.HasOne(d => d.EmployeNavigation).WithMany(p => p.Rendezvous).HasForeignKey(d => d.Employe).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_RENDEZVOUS_EMPLOYES");
        });
        modelBuilder.Entity<Secteur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SECTEUR__3214EC27949B5CE5");
            entity.ToTable("SECTEUR");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Desription).HasMaxLength(100).HasColumnName("DESRIPTION");
        });
        modelBuilder.Entity<Section>(entity =>
        {
            entity.ToTable("SECTION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(50).HasColumnName("DESCRIPTION");
        });
        modelBuilder.Entity<Sortiemateriel>(entity =>
        {
            entity.HasNoKey().ToTable("SORTIEMATERIEL");
            entity.Property(e => e.Employe).HasColumnName("EMPLOYE");
            entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("ID");
            entity.Property(e => e.Piece).HasColumnName("PIECE");
            entity.Property(e => e.Projet).HasColumnName("PROJET");
            entity.Property(e => e.Qte).HasColumnName("QTE");
            entity.HasOne(d => d.EmployeNavigation).WithMany().HasForeignKey(d => d.Employe).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SORTIEMATERIEL_EMPLOYES");
            entity.HasOne(d => d.PieceNavigation).WithMany().HasForeignKey(d => d.Piece).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SORTIEMATERIEL_PIECES");
            entity.HasOne(d => d.ProjetNavigation).WithMany().HasForeignKey(d => d.Projet).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SORTIEMATERIEL_PROJET");
        });
        modelBuilder.Entity<Soumission>(entity =>
        {
            entity.ToTable("SOUMISSION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(255).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Fermeture).HasColumnType("datetime").HasColumnName("FERMETURE");
            entity.Property(e => e.Noclient).HasColumnName("NOCLIENT");
            entity.Property(e => e.Ouvert).HasColumnName("OUVERT");
            entity.Property(e => e.Ouverture).HasColumnType("datetime").HasColumnName("OUVERTURE");
            entity.Property(e => e.Raisonfermeture).HasMaxLength(255).HasColumnName("RAISONFERMETURE");
            entity.Property(e => e.Type).HasMaxLength(50).HasColumnName("TYPE");
            entity.Property(e => e.Verrouille).HasColumnName("VERROUILLE");
            entity.HasOne(d => d.NoclientNavigation).WithMany(p => p.Soumissions).HasForeignKey(d => d.Noclient).HasConstraintName("FK_SOUMISSION_PROJET");
        });
        modelBuilder.Entity<Transport>(entity =>
        {
            entity.ToTable("TRANSPORT");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Transport1).HasMaxLength(50).HasColumnName("TRANSPORT");
        });
        modelBuilder.Entity<Type>(entity =>
        {
            entity.ToTable("TYPE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(15).HasColumnName("DESCRIPTION");
        });
        modelBuilder.Entity<Vendeur>(entity =>
        {
            entity.ToTable("VENDEUR");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Commentaire).HasMaxLength(255).HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Contact).HasMaxLength(50).HasColumnName("CONTACT");
            entity.Property(e => e.Date).HasColumnName("DATE");
            entity.Property(e => e.Enregpar).HasColumnName("ENREGPAR");
            entity.Property(e => e.Idclient).HasColumnName("IDCLIENT");
            entity.Property(e => e.Type).HasMaxLength(25).HasColumnName("TYPE");
            entity.HasOne(d => d.EnregparNavigation).WithMany(p => p.Vendeurs).HasForeignKey(d => d.Enregpar).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_VENDEUR_EMPLOYES");
            entity.HasOne(d => d.IdclientNavigation).WithMany(p => p.Vendeurs).HasForeignKey(d => d.Idclient).HasConstraintName("FK_VENDEUR_CLIENT");
        });
        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
