﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
namespace GenererDatabase
{
    internal class GenererDatabase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Construction Database GestionEntreprise");
            ModelBuilder modelBuilder = new ModelBuilder();
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);
            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
            modelBuilder.Entity("GestionEntreprise.DataBase.Achat", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<int?>("Acheteur").HasColumnType("int").HasColumnName("ACHETEUR");
                b.Property<DateOnly?>("Dateachat").HasColumnType("date").HasColumnName("DATEACHAT");
                b.Property<int?>("Indexachat").HasColumnType("int").HasColumnName("INDEXACHAT");
                b.Property<bool>("Modification").HasColumnType("bit").HasColumnName("MODIFICATION");
                b.Property<int>("Par").HasColumnType("int").HasColumnName("PAR");
                b.Property<decimal?>("Prixtotal").HasColumnType("money").HasColumnName("PRIXTOTAL");
                b.Property<string>("Raison").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("RAISON");
                b.Property<int>("Type").HasColumnType("int").HasColumnName("TYPE");
                b.HasKey("Id").HasName("PK__ACHATS__3214EC27E238FF03");
                b.HasIndex("Acheteur");
                b.HasIndex("Type");
                b.ToTable("ACHATS", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Alarme", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<DateOnly>("Date").HasColumnType("date").HasColumnName("DATE");
                b.Property<int>("Employe").HasColumnType("int").HasColumnName("EMPLOYE");
                b.Property<TimeOnly>("Heure").HasColumnType("time").HasColumnName("HEURE");
                b.Property<string>("Message").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("MESSAGE");
                b.Property<int?>("Nocontact").HasColumnType("int").HasColumnName("NOCONTACT");
                b.Property<int>("Type").HasColumnType("int").HasColumnName("TYPE");
                b.HasKey("Id");
                b.HasIndex("Employe");
                b.HasIndex("Nocontact");
                b.HasIndex("Type");
                b.ToTable("ALARMES", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Bonscommande", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Attention").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("ATTENTION");
                b.Property<int>("Commandepar").HasColumnType("int").HasColumnName("COMMANDEPAR");
                b.Property<string>("Commentaire").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("COMMENTAIRE");
                b.Property<int>("Datecommande").HasColumnType("int").HasColumnName("DATECOMMANDE");
                b.Property<DateOnly>("Daterequise").HasColumnType("date").HasColumnName("DATEREQUISE");
                b.Property<int?>("Nofournisseur").HasColumnType("int").HasColumnName("NOFOURNISSEUR");
                b.Property<int>("Noprojet").HasColumnType("int").HasColumnName("NOPROJET");
                b.Property<string>("Nosoum").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("NOSOUM");
                b.Property<decimal>("Total").HasColumnType("money").HasColumnName("TOTAL");
                b.Property<int>("Transport").HasColumnType("int").HasColumnName("TRANSPORT");
                b.HasKey("Id");
                b.HasIndex("Nofournisseur");
                b.HasIndex("Noprojet");
                b.HasIndex("Transport");
                b.ToTable("BONSCOMMANDES", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Catalogue", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<int>("Categorie").HasColumnType("int").HasColumnName("CATEGORIE");
                b.Property<string>("DescEn").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("DESC_EN");
                b.Property<string>("DescFr").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("DESC_FR");
                b.Property<string>("Descrition").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("DESCRITION");
                b.Property<int>("Fabriquaant").HasColumnType("int").HasColumnName("FABRIQUAANT");
                b.Property<int>("Piece").HasColumnType("int").HasColumnName("PIECE");
                b.Property<string>("Temps").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("TEMPS");
                b.HasKey("Id").HasName("PK__CATALOGU__3214EC277A5D37A5");
                b.HasIndex("Piece");
                b.ToTable("CATALOGUE", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Client", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Adresse").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("ADRESSE");
                b.Property<string>("Cellulaire").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("CELLULAIRE");
                b.Property<string>("Commentaire").HasColumnType("nvarchar(max)").HasColumnName("COMMENTAIRE");
                b.Property<string>("Compagnie").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("COMPAGNIE");
                b.Property<string>("Contact").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("CONTACT");
                b.Property<string>("Cp").HasMaxLength(25).HasColumnType("nvarchar(25)").HasColumnName("CP");
                b.Property<DateTime>("Creation").HasColumnType("datetime").HasColumnName("CREATION");
                b.Property<string>("Email").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("EMAIL");
                b.Property<string>("Fax").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("FAX");
                b.Property<DateTime>("Modification").HasColumnType("datetime").HasColumnName("MODIFICATION");
                b.Property<int?>("Noposte").HasColumnType("int").HasColumnName("NOPOSTE");
                b.Property<string>("Pays").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("PAYS");
                b.Property<string>("Province").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("PROVINCE");
                b.Property<string>("Telephonne").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("TELEPHONNE");
                b.Property<string>("Ville").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("VILLE");
                b.HasKey("Id").HasName("PK__CLIENT__3214EC27C22EA9F4");
                b.ToTable("CLIENT", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Contact", b =>
            {
                b.Property<int>("Id").HasColumnType("int").HasColumnName("ID");
                b.Property<string>("Cellulaire").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("CELLULAIRE");
                b.Property<string>("Commentaire").HasColumnType("nvarchar(max)").HasColumnName("COMMENTAIRE");
                b.Property<string>("Compagnie").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("COMPAGNIE");
                b.Property<string>("Contact1").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("CONTACT");
                b.Property<DateTime>("Creation").HasColumnType("datetime").HasColumnName("CREATION");
                b.Property<string>("EMail").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("E-MAIL");
                b.Property<string>("Fax").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("FAX");
                b.Property<DateTime>("Modification").HasColumnType("datetime").HasColumnName("MODIFICATION");
                b.Property<int?>("Noposte").HasColumnType("int").HasColumnName("NOPOSTE");
                b.Property<string>("Telephonne").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("TELEPHONNE");
                b.Property<string>("Titre").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("TITRE");
                b.HasKey("Id");
                b.ToTable("CONTACT", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Devise", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Desciption").IsRequired().HasMaxLength(10).HasColumnType("nvarchar(10)").HasColumnName("DESCIPTION");
                b.HasKey("Id").HasName("PK__DEVISES__3214EC27B9B2B7B1");
                b.ToTable("DEVISES", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Employe", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<bool>("Actif").HasColumnType("bit").HasColumnName("ACTIF");
                b.Property<string>("Cellulaire").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("CELLULAIRE");
                b.Property<string>("Clef").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("CLEF");
                b.Property<string>("Initiale").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("INITIALE");
                b.Property<string>("Login").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("LOGIN");
                b.Property<string>("Nom").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("NOM");
                b.Property<int>("Ordres").HasColumnType("int").HasColumnName("ORDRES");
                b.Property<byte[]>("Sel").IsRequired().HasColumnType("varbinary(max)");
                b.Property<bool>("Supprime").HasColumnType("bit").HasColumnName("SUPPRIME");
                b.Property<string>("Telephone").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("TELEPHONE");
                b.HasKey("Id").HasName("PK__EMPLOYES__3214EC27CF71D7F1");
                b.HasIndex("Ordres");
                b.ToTable("EMPLOYES", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Fournisseur", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Adresse").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("ADRESSE");
                b.Property<string>("Categorie").HasMaxLength(40).HasColumnType("nvarchar(40)").HasColumnName("CATEGORIE");
                b.Property<string>("Commentaire").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("COMMENTAIRE");
                b.Property<string>("Cp").HasMaxLength(25).HasColumnType("nvarchar(25)").HasColumnName("CP");
                b.Property<DateTime>("Creation").HasColumnType("datetime").HasColumnName("CREATION");
                b.Property<string>("EMail").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("E-MAIL");
                b.Property<string>("Fax").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("FAX");
                b.Property<string>("Nom").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("NOM");
                b.Property<int?>("Noposte").HasColumnType("int").HasColumnName("NOPOSTE");
                b.Property<string>("Pays").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("PAYS");
                b.Property<string>("Province").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("PROVINCE");
                b.Property<string>("Rep").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("REP");
                b.Property<string>("Siteweb").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("SITEWEB");
                b.Property<bool>("Supprime").HasColumnType("bit").HasColumnName("SUPPRIME");
                b.Property<string>("Telephonne").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("TELEPHONNE");
                b.Property<string>("Ville").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("VILLE");
                b.HasKey("Id").HasName("PK__FOURNISS__3214EC27826AFB3F");
                b.ToTable("FOURNISSEUR", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Groupe", b =>
            {
                b.Property<int>("Id").HasColumnType("int").HasColumnName("ID");
                b.Property<bool>("Achat").HasColumnType("bit").HasColumnName("ACHAT");
                b.Property<bool>("Catalogue").HasColumnType("bit").HasColumnName("CATALOGUE");
                b.Property<bool>("Cedule").HasColumnType("bit").HasColumnName("CEDULE");
                b.Property<bool>("Clients").HasColumnType("bit").HasColumnName("CLIENTS");
                b.Property<bool>("ComptaBonscommandes").HasColumnType("bit").HasColumnName("COMPTA-BONSCOMMANDES");
                b.Property<bool>("ComptaCatalogue").HasColumnType("bit").HasColumnName("COMPTA-CATALOGUE");
                b.Property<bool>("ComptaClients").HasColumnType("bit").HasColumnName("COMPTA-CLIENTS");
                b.Property<bool>("ComptaContacts").HasColumnType("bit").HasColumnName("COMPTA-CONTACTS");
                b.Property<bool>("ComptaEmployes").HasColumnType("bit").HasColumnName("COMPTA-EMPLOYES");
                b.Property<bool>("ComptaFacturation").HasColumnType("bit").HasColumnName("COMPTA-FACTURATION");
                b.Property<bool>("ComptaFeuillestemps").HasColumnType("bit").HasColumnName("COMPTA-FEUILLESTEMPS");
                b.Property<bool>("ComptaFournisseurs").HasColumnType("bit").HasColumnName("COMPTA-FOURNISSEURS");
                b.Property<bool>("ComptaGroupes").HasColumnType("bit").HasColumnName("COMPTA-GROUPES");
                b.Property<bool>("ComptaInventaire").HasColumnType("bit").HasColumnName("COMPTA-INVENTAIRE");
                b.Property<bool>("ComptaOutils").HasColumnType("bit").HasColumnName("COMPTA-OUTILS");
                b.Property<bool>("ComptaProjetselec").HasColumnType("bit").HasColumnName("COMPTA-PROJETSELEC");
                b.Property<bool>("ComptaProjetsmec").HasColumnType("bit").HasColumnName("COMPTA-PROJETSMEC");
                b.Property<bool>("ComptaPunch").HasColumnType("bit").HasColumnName("COMPTA-PUNCH");
                b.Property<bool>("ComptaReception").HasColumnType("bit").HasColumnName("COMPTA-RECEPTION");
                b.Property<bool>("ComptaRetourmarchandise").HasColumnType("bit").HasColumnName("COMPTA-RETOURMARCHANDISE");
                b.Property<bool>("ComptaSoumissionselec").HasColumnType("bit").HasColumnName("COMPTA-SOUMISSIONSELEC");
                b.Property<bool>("ComptaSoumissionsmec").HasColumnType("bit").HasColumnName("COMPTA-SOUMISSIONSMEC");
                b.Property<bool>("Contacts").HasColumnType("bit").HasColumnName("CONTACTS");
                b.Property<bool>("Employes").HasColumnType("bit").HasColumnName("EMPLOYES");
                b.Property<bool>("Fournisseurs").HasColumnType("bit").HasColumnName("FOURNISSEURS");
                b.Property<bool>("Inventaire").HasColumnType("bit").HasColumnName("INVENTAIRE");
                b.Property<string>("Nomgroupe").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("NOMGROUPE");
                b.Property<bool>("Outils").HasColumnType("bit").HasColumnName("OUTILS");
                b.Property<bool>("Projet").HasColumnType("bit").HasColumnName("PROJET");
                b.Property<bool>("Rapport").HasColumnType("bit").HasColumnName("RAPPORT");
                b.Property<bool>("Soumission").HasColumnType("bit").HasColumnName("SOUMISSION");
                b.Property<bool>("Suppressionprojets").HasColumnType("bit").HasColumnName("SUPPRESSIONPROJETS");
                b.HasKey("Id");
                b.ToTable("GROUPES", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Inventaire", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Commentaires").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("COMMENTAIRES");
                b.Property<string>("Description").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("DESCRIPTION");
                b.Property<double?>("Escompte").HasColumnType("float").HasColumnName("ESCOMPTE");
                b.Property<string>("Localisation").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("LOCALISATION");
                b.Property<int>("Manufacturier").HasColumnType("int").HasColumnName("MANUFACTURIER");
                b.Property<int>("Noprojet").HasColumnType("int").HasColumnName("NOPROJET");
                b.Property<string>("Piece").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("PIECE");
                b.Property<decimal?>("Prixliste").HasColumnType("money").HasColumnName("PRIXLISTE");
                b.Property<decimal>("Prixnet").HasColumnType("money").HasColumnName("PRIXNET");
                b.Property<int>("Qtcommandee").HasColumnType("int").HasColumnName("QTCOMMANDEE");
                b.Property<int>("Qteboite").HasColumnType("int").HasColumnName("QTEBOITE");
                b.Property<bool>("Secommandeenboite").HasColumnType("bit").HasColumnName("SECOMMANDEENBOITE");
                b.Property<int>("Stock").HasColumnType("int").HasColumnName("STOCK");
                b.HasKey("Id").HasName("PK__INVENTAI__3214EC27CF8BA428");
                b.HasIndex("Noprojet");
                b.ToTable("INVENTAIRE", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Liaisoncontact", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<int?>("Noclient").HasColumnType("int").HasColumnName("NOCLIENT");
                b.Property<int>("Nocontact").HasColumnType("int").HasColumnName("NOCONTACT");
                b.Property<int?>("Nofournisseur").HasColumnType("int").HasColumnName("NOFOURNISSEUR");
                b.Property<int?>("Nomanufacturier").HasColumnType("int").HasColumnName("NOMANUFACTURIER");
                b.HasKey("Id");
                b.HasIndex("Noclient");
                b.HasIndex("Nocontact");
                b.HasIndex("Nofournisseur");
                b.HasIndex("Nomanufacturier");
                b.ToTable("LIAISONCONTACT", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.ListeDistribution", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<bool>("IsChefEntreprise").HasColumnType("bit").HasColumnName("isChefEntreprise");
                b.Property<bool>("IsClient").HasColumnType("bit").HasColumnName("isClient");
                b.Property<bool>("IsContact").HasColumnType("bit").HasColumnName("isContact");
                b.Property<bool>("IsFournisseur").HasColumnType("bit").HasColumnName("isFournisseur");
                b.Property<int>("NoContact").HasColumnType("int");
                b.Property<string>("NomCompagnie").IsRequired().HasMaxLength(200).HasColumnType("nvarchar(200)");
                b.HasKey("Id");
                b.HasIndex("NoContact");
                b.ToTable("ListeDistribution", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Manufacturier", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Adresse").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("ADRESSE");
                b.Property<string>("Categorie").HasMaxLength(40).HasColumnType("nvarchar(40)").HasColumnName("CATEGORIE");
                b.Property<string>("Commentaire").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("COMMENTAIRE");
                b.Property<string>("Cp").HasMaxLength(25).HasColumnType("nvarchar(25)").HasColumnName("CP");
                b.Property<DateTime>("Creation").HasColumnType("datetime").HasColumnName("CREATION");
                b.Property<string>("Email").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("EMAIL");
                b.Property<string>("Fax").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("FAX");
                b.Property<string>("Nom").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("NOM");
                b.Property<int?>("Noposte").HasColumnType("int").HasColumnName("NOPOSTE");
                b.Property<string>("Pays").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("PAYS");
                b.Property<string>("Province").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("PROVINCE");
                b.Property<string>("Rep").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("REP");
                b.Property<string>("Siteweb").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("SITEWEB");
                b.Property<bool>("Supprime").HasColumnType("bit").HasColumnName("SUPPRIME");
                b.Property<string>("Telephonne").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("TELEPHONNE");
                b.Property<string>("Ville").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("VILLE");
                b.HasKey("Id").HasName("PK__Manufact__3214EC270AA068F3");
                b.ToTable("Manufacturier", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Ordre", b =>
            {
                b.Property<int>("Id").HasColumnType("int").HasColumnName("ID");
                b.Property<string>("Famille").IsRequired().HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("FAMILLE");
                b.HasKey("Id");
                b.ToTable("ORDRE", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Ordre1", b =>
            {
                b.Property<int>("Idgroupe").HasColumnType("int").HasColumnName("IDGROUPE");
                b.Property<bool?>("Achat").HasColumnType("bit").HasColumnName("ACHAT");
                b.Property<bool?>("Catalogue").HasColumnType("bit").HasColumnName("CATALOGUE");
                b.Property<bool?>("Cedule").HasColumnType("bit").HasColumnName("CEDULE");
                b.Property<bool?>("Clients").HasColumnType("bit").HasColumnName("CLIENTS");
                b.Property<bool?>("ComptaBonscommandes").HasColumnType("bit").HasColumnName("COMPTA-BONSCOMMANDES");
                b.Property<bool?>("ComptaCatalogue").HasColumnType("bit").HasColumnName("COMPTA-CATALOGUE");
                b.Property<bool?>("ComptaClients").HasColumnType("bit").HasColumnName("COMPTA-CLIENTS");
                b.Property<bool?>("ComptaContacts").HasColumnType("bit").HasColumnName("COMPTA-CONTACTS");
                b.Property<bool?>("ComptaEmployes").HasColumnType("bit").HasColumnName("COMPTA-EMPLOYES");
                b.Property<bool?>("ComptaFacturation").HasColumnType("bit").HasColumnName("COMPTA-FACTURATION");
                b.Property<bool?>("ComptaFeuillestemps").HasColumnType("bit").HasColumnName("COMPTA-FEUILLESTEMPS");
                b.Property<bool?>("ComptaFournisseurs").HasColumnType("bit").HasColumnName("COMPTA-FOURNISSEURS");
                b.Property<bool?>("ComptaGroupes").HasColumnType("bit").HasColumnName("COMPTA-GROUPES");
                b.Property<bool?>("ComptaInventaire").HasColumnType("bit").HasColumnName("COMPTA-INVENTAIRE");
                b.Property<bool?>("ComptaOutils").HasColumnType("bit").HasColumnName("COMPTA-OUTILS");
                b.Property<bool?>("ComptaProjets").HasColumnType("bit").HasColumnName("COMPTA-PROJETS");
                b.Property<bool?>("ComptaPunchemployes").HasColumnType("bit").HasColumnName("COMPTA-PUNCHEMPLOYES");
                b.Property<bool?>("ComptaReception").HasColumnType("bit").HasColumnName("COMPTA-RECEPTION");
                b.Property<bool?>("ComptaRetourmarchandise").HasColumnType("bit").HasColumnName("COMPTA-RETOURMARCHANDISE");
                b.Property<bool?>("ComptaSoumissions").HasColumnType("bit").HasColumnName("COMPTA-SOUMISSIONS");
                b.Property<bool?>("Configuration").HasColumnType("bit").HasColumnName("CONFIGURATION");
                b.Property<bool?>("Contacts").HasColumnType("bit").HasColumnName("CONTACTS");
                b.Property<bool?>("Contactsvendeurs").HasColumnType("bit").HasColumnName("CONTACTSVENDEURS");
                b.Property<bool?>("DeverrouillageTempsProjet").HasColumnType("bit");
                b.Property<bool?>("Employes").HasColumnType("bit").HasColumnName("EMPLOYES");
                b.Property<bool?>("Fournisseurs").HasColumnType("bit").HasColumnName("FOURNISSEURS");
                b.Property<bool?>("Inventaire").HasColumnType("bit").HasColumnName("INVENTAIRE");
                b.Property<string>("Nomgroupe").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("NOMGROUPE");
                b.Property<bool?>("Outils").HasColumnType("bit").HasColumnName("OUTILS");
                b.Property<bool?>("Projet").HasColumnType("bit").HasColumnName("PROJET");
                b.Property<bool?>("Projetelec").HasColumnType("bit").HasColumnName("PROJETELEC");
                b.Property<bool?>("Punch").HasColumnType("bit").HasColumnName("PUNCH");
                b.Property<bool?>("Rapport").HasColumnType("bit").HasColumnName("RAPPORT");
                b.Property<bool?>("Soumission").HasColumnType("bit").HasColumnName("SOUMISSION");
                b.Property<bool?>("SuppressionProjets").HasColumnType("bit");
                b.Property<bool?>("VerrouillageTempsProjet").HasColumnType("bit");
                b.HasKey("Idgroupe");
                b.ToTable("ORDRES", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Outil", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Commentaire").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("COMMENTAIRE");
                b.Property<string>("DateAchat").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("DATE_ACHAT");
                b.Property<string>("DateHorsFonction").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("DATE_HORS_FONCTION");
                b.Property<string>("Description").HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("DESCRIPTION");
                b.Property<decimal>("Prix").HasColumnType("money").HasColumnName("PRIX");
                b.Property<int>("Secteur").HasColumnType("int").HasColumnName("SECTEUR");
                b.Property<string>("TypeEtiquette").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("TYPE_ETIQUETTE");
                b.HasKey("Id").HasName("PK__OUTILS__3214EC276CA17AA6");
                b.ToTable("OUTILS", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.OutilsInOut", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Commentaire").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("COMMENTAIRE");
                b.Property<int>("Employe").HasColumnType("int").HasColumnName("EMPLOYE");
                b.Property<DateTime?>("Retour").HasColumnType("datetime").HasColumnName("RETOUR");
                b.Property<DateTime>("Sortie").HasColumnType("datetime").HasColumnName("SORTIE");
                b.HasKey("Id").HasName("PK__OUTILS_I__3214EC27224EE314");
                b.HasIndex("Employe");
                b.ToTable("OUTILS_IN_OUT", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Piece", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<bool>("Commande").HasColumnType("bit").HasColumnName("COMMANDE");
                b.Property<bool>("Commandeannulee").HasColumnType("bit").HasColumnName("COMMANDEANNULEE");
                b.Property<DateOnly?>("Datecommande").HasColumnType("date").HasColumnName("DATECOMMANDE");
                b.Property<DateOnly?>("Datereception").HasColumnType("date").HasColumnName("DATERECEPTION");
                b.Property<DateOnly>("Daterequise").HasColumnType("date").HasColumnName("DATEREQUISE");
                b.Property<DateOnly?>("Dateretour").HasColumnType("date").HasColumnName("DATERETOUR");
                b.Property<string>("DescEn").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("DESC_EN");
                b.Property<string>("DescFr").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("DESC_FR");
                b.Property<int?>("Devise").HasColumnType("int").HasColumnName("DEVISE");
                b.Property<double?>("Escompte").HasColumnType("float").HasColumnName("ESCOMPTE");
                b.Property<int>("Idfournisseur").HasColumnType("int").HasColumnName("IDFOURNISSEUR");
                b.Property<int?>("Idmanufacturier").HasColumnType("int").HasColumnName("IDMANUFACTURIER");
                b.Property<int>("Idpiece").HasColumnType("int").HasColumnName("IDPIECE");
                b.Property<string>("Noretour").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("NORETOUR");
                b.Property<decimal>("PrixNet").HasColumnType("money").HasColumnName("PRIX_NET");
                b.Property<decimal>("PrixTotal").HasColumnType("money").HasColumnName("PRIX_TOTAL");
                b.Property<decimal>("Prixliste").HasColumnType("money").HasColumnName("PRIXLISTE");
                b.Property<string>("Prixorigine").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("PRIXORIGINE");
                b.Property<int?>("Qte").HasColumnType("int").HasColumnName("QTE");
                b.Property<int?>("Quantiterecue").HasColumnType("int").HasColumnName("QUANTITERECUE");
                b.Property<bool>("Recu").HasColumnType("bit").HasColumnName("RECU");
                b.Property<bool>("Retour").HasColumnType("bit").HasColumnName("RETOUR");
                b.Property<int>("Type").HasColumnType("int").HasColumnName("TYPE");
                b.HasKey("Id");
                b.HasIndex("Devise");
                b.HasIndex("Idmanufacturier");
                b.ToTable("PIECES", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Piecesparprojet", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<bool>("Commande").HasColumnType("bit").HasColumnName("COMMANDE");
                b.Property<bool>("Commandeannulee").HasColumnType("bit").HasColumnName("COMMANDEANNULEE");
                b.Property<DateTime?>("Commandele").HasColumnType("datetime").HasColumnName("COMMANDELE");
                b.Property<string>("Commentaire").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("COMMENTAIRE");
                b.Property<int?>("Fournisseur").HasColumnType("int").HasColumnName("FOURNISSEUR");
                b.Property<int>("Idprojet").HasColumnType("int").HasColumnName("IDPROJET");
                b.Property<int>("Manufact").HasColumnType("int").HasColumnName("MANUFACT");
                b.Property<string>("Noretour").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("NORETOUR");
                b.Property<int?>("Piece").HasColumnType("int").HasColumnName("PIECE");
                b.Property<double?>("Qte").HasColumnType("float").HasColumnName("QTE");
                b.Property<int>("Quantiterecue").HasColumnType("int").HasColumnName("QUANTITERECUE");
                b.Property<DateOnly?>("Reception").HasColumnType("date").HasColumnName("RECEPTION");
                b.Property<bool>("Recu").HasColumnType("bit").HasColumnName("RECU");
                b.Property<DateTime>("Requisele").HasColumnType("datetime").HasColumnName("REQUISELE");
                b.Property<bool>("Retour").HasColumnType("bit").HasColumnName("RETOUR");
                b.Property<DateTime?>("Retournee").HasColumnType("datetime").HasColumnName("RETOURNEE");
                b.Property<string>("Titrecommande").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("TITRECOMMANDE");
                b.Property<string>("Type").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("TYPE");
                b.HasKey("Id").HasName("PK__PIECESPA__3214EC27A9A31842");
                b.ToTable("PIECESPARPROJET", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Piecesparsoumission", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<bool>("Commande").HasColumnType("bit").HasColumnName("COMMANDE");
                b.Property<bool>("Commandeannulee").HasColumnType("bit").HasColumnName("COMMANDEANNULEE");
                b.Property<string>("Commentaire").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("COMMENTAIRE");
                b.Property<double>("Dureetotale").HasColumnType("float").HasColumnName("DUREETOTALE");
                b.Property<int>("Idsoumission").HasColumnType("int").HasColumnName("IDSOUMISSION");
                b.Property<int>("Piece").HasColumnType("int").HasColumnName("PIECE");
                b.Property<decimal>("Prixorigine").HasColumnType("money").HasColumnName("PRIXORIGINE");
                b.Property<decimal>("Prixtotal").HasColumnType("money").HasColumnName("PRIXTOTAL");
                b.Property<double>("Qte").HasColumnType("float").HasColumnName("QTE");
                b.Property<bool>("Recu").HasColumnType("bit").HasColumnName("RECU");
                b.Property<bool>("Retour").HasColumnType("bit").HasColumnName("RETOUR");
                b.Property<double>("Temps").HasColumnType("float").HasColumnName("TEMPS");
                b.HasKey("Id").HasName("PK__PIECESPA__3214EC277B5D490A");
                b.HasIndex("Idsoumission");
                b.HasIndex("Piece");
                b.ToTable("PIECESPARSOUMISSION", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Projet", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<decimal>("Commission").HasColumnType("money").HasColumnName("COMMISSION");
                b.Property<decimal>("ComptaAssemblage").HasColumnType("money").HasColumnName("COMPTA-ASSEMBLAGE");
                b.Property<decimal>("ComptaFabrication").HasColumnType("money").HasColumnName("COMPTA-FABRICATION");
                b.Property<decimal>("ComptaFormation").HasColumnType("money").HasColumnName("COMPTA-FORMATION");
                b.Property<decimal>("ComptaGestion").HasColumnType("money").HasColumnName("COMPTA-GESTION");
                b.Property<double>("ComptaHebergement").HasColumnType("float").HasColumnName("COMPTA-HEBERGEMENT");
                b.Property<decimal>("ComptaImprevue").HasColumnType("money").HasColumnName("COMPTA-IMPREVUE");
                b.Property<decimal>("ComptaInstallation").HasColumnType("money").HasColumnName("COMPTA-INSTALLATION");
                b.Property<decimal>("ComptaManuel").HasColumnType("money").HasColumnName("COMPTA-MANUEL");
                b.Property<decimal>("ComptaMiseservice").HasColumnType("money").HasColumnName("COMPTA-MISESERVICE");
                b.Property<decimal>("ComptaProgautomate").HasColumnType("money").HasColumnName("COMPTA-PROGAUTOMATE");
                b.Property<decimal>("ComptaProgrobot").HasColumnType("money").HasColumnName("COMPTA-PROGROBOT");
                b.Property<double>("ComptaRepas").HasColumnType("float").HasColumnName("COMPTA-REPAS");
                b.Property<decimal>("ComptaShipping").HasColumnType("money").HasColumnName("COMPTA-SHIPPING");
                b.Property<decimal>("ComptaTemps").HasColumnType("money").HasColumnName("COMPTA-TEMPS");
                b.Property<decimal>("ComptaTest").HasColumnType("money").HasColumnName("COMPTA-TEST");
                b.Property<double>("ComptaTransport").HasColumnType("float").HasColumnName("COMPTA-TRANSPORT");
                b.Property<string>("ComptaUnitemobile").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("COMPTA-UNITEMOBILE");
                b.Property<decimal>("ComptaVision").HasColumnType("money").HasColumnName("COMPTA-VISION");
                b.Property<DateTime>("Creer").HasColumnType("datetime").HasColumnName("CREER");
                b.Property<int>("CreerPar").HasColumnType("int").HasColumnName("CREER_PAR");
                b.Property<string>("Description").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("DESCRIPTION");
                b.Property<decimal>("Forfaitinitial").HasColumnType("money").HasColumnName("FORFAITINITIAL");
                b.Property<int?>("Idclient").HasColumnType("int").HasColumnName("IDCLIENT");
                b.Property<int?>("Idcontact").HasColumnType("int").HasColumnName("IDCONTACT");
                b.Property<string>("Idsoumission").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("IDSOUMISSION");
                b.Property<decimal>("Imprevue").HasColumnType("money").HasColumnName("IMPREVUE");
                b.Property<bool>("Modification").HasColumnType("bit").HasColumnName("MODIFICATION");
                b.Property<decimal>("MontantAssemblage").HasColumnType("money").HasColumnName("MONTANT-ASSEMBLAGE");
                b.Property<decimal>("MontantFabrication").HasColumnType("money").HasColumnName("MONTANT-FABRICATION");
                b.Property<decimal>("MontantFormation").HasColumnType("money").HasColumnName("MONTANT-FORMATION");
                b.Property<decimal>("MontantGestion").HasColumnType("money").HasColumnName("MONTANT-GESTION");
                b.Property<decimal>("MontantHebergement1").HasColumnType("money").HasColumnName("MONTANT-HEBERGEMENT1");
                b.Property<decimal>("MontantHebergement2").HasColumnType("money").HasColumnName("MONTANT-HEBERGEMENT2");
                b.Property<decimal>("MontantInstallation").HasColumnType("money").HasColumnName("MONTANT-INSTALLATION");
                b.Property<decimal>("MontantMiseservice").HasColumnType("money").HasColumnName("MONTANT-MISESERVICE");
                b.Property<decimal>("MontantProgautomate").HasColumnType("money").HasColumnName("MONTANT-PROGAUTOMATE");
                b.Property<decimal>("MontantProgrobot").HasColumnType("money").HasColumnName("MONTANT-PROGROBOT");
                b.Property<decimal>("MontantRepas").HasColumnType("money").HasColumnName("MONTANT-REPAS");
                b.Property<decimal>("MontantShipping").HasColumnType("money").HasColumnName("MONTANT-SHIPPING");
                b.Property<decimal>("MontantTest").HasColumnType("money").HasColumnName("MONTANT-TEST");
                b.Property<decimal>("MontantTransport").HasColumnType("money").HasColumnName("MONTANT-TRANSPORT");
                b.Property<decimal>("MontantUnitemobile").HasColumnType("money").HasColumnName("MONTANT-UNITEMOBILE");
                b.Property<decimal>("MontantVision").HasColumnType("money").HasColumnName("MONTANT-VISION");
                b.Property<decimal>("Montantforfait").HasColumnType("money").HasColumnName("MONTANTFORFAIT");
                b.Property<decimal>("Nbrepersonne").HasColumnType("money").HasColumnName("NBREPERSONNE");
                b.Property<int>("Par").HasColumnType("int").HasColumnName("PAR");
                b.Property<decimal>("Prixemballage").HasColumnType("money").HasColumnName("PRIXEMBALLAGE");
                b.Property<decimal>("Prixreception").HasColumnType("money").HasColumnName("PRIXRECEPTION");
                b.Property<decimal>("Prixtotal").HasColumnType("money").HasColumnName("PRIXTOTAL");
                b.Property<int?>("Prochainecommande").HasColumnType("int").HasColumnName("PROCHAINECOMMANDE");
                b.Property<decimal>("Tauxdessin").HasColumnType("money").HasColumnName("TAUXDESSIN");
                b.Property<decimal>("Tauxproginterface").HasColumnType("money").HasColumnName("TAUXPROGINTERFACE");
                b.Property<decimal>("TotalCommission").HasColumnType("money").HasColumnName("TOTAL_COMMISSION");
                b.Property<decimal>("Totalhebergement").HasColumnType("money").HasColumnName("TOTALHEBERGEMENT");
                b.Property<decimal>("Totalrepas").HasColumnType("money").HasColumnName("TOTALREPAS");
                b.Property<int>("Transport").HasColumnType("int").HasColumnName("TRANSPORT");
                b.HasKey("Id").HasName("PK__PROJET__3214EC27EB1707FD");
                b.HasIndex("CreerPar");
                b.HasIndex("Idclient");
                b.HasIndex("Idcontact");
                b.HasIndex("Par");
                b.HasIndex("Transport");
                b.ToTable("PROJET", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Punch", b =>
            {
                b.Property<int>("Id").HasColumnType("int").HasColumnName("ID");
                b.Property<string>("Commentaire").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("COMMENTAIRE");
                b.Property<DateOnly>("Date").HasColumnType("date").HasColumnName("DATE");
                b.Property<TimeOnly>("Debut").HasColumnType("time").HasColumnName("DEBUT");
                b.Property<string>("Duree").HasMaxLength(10).HasColumnType("nvarchar(10)").HasColumnName("DUREE");
                b.Property<int?>("Employe").HasColumnType("int").HasColumnName("EMPLOYE");
                b.Property<bool>("Facture").HasColumnType("bit").HasColumnName("FACTURE");
                b.Property<TimeOnly?>("Fin").HasColumnType("time").HasColumnName("FIN");
                b.Property<bool>("Km").HasColumnType("bit").HasColumnName("KM");
                b.Property<string>("Nbrekm").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("NBREKM");
                b.Property<string>("Noclient").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("NOCLIENT");
                b.Property<string>("Nofacture").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("NOFACTURE");
                b.Property<int>("Noprojet").HasColumnType("int").HasColumnName("NOPROJET");
                b.Property<int>("Section").HasColumnType("int").HasColumnName("SECTION");
                b.HasKey("Id");
                b.ToTable("PUNCH", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Rendezvou", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<int>("Client").HasColumnType("int").HasColumnName("CLIENT");
                b.Property<DateOnly>("Daterdv").HasColumnType("date").HasColumnName("DATERDV");
                b.Property<TimeOnly>("Debut").HasColumnType("time").HasColumnName("DEBUT");
                b.Property<int>("Employe").HasColumnType("int").HasColumnName("EMPLOYE");
                b.Property<TimeOnly>("Fin").HasColumnType("time").HasColumnName("FIN");
                b.Property<int?>("Finprojet").HasColumnType("int").HasColumnName("FINPROJET");
                b.HasKey("Id").HasName("PK__RENDEZVO__3214EC27D21622D4");
                b.HasIndex("Employe");
                b.ToTable("RENDEZVOUS", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Secteur", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Desription").IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)").HasColumnName("DESRIPTION");
                b.HasKey("Id").HasName("PK__SECTEUR__3214EC27949B5CE5");
                b.ToTable("SECTEUR", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Section", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Description").IsRequired().HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("DESCRIPTION");
                b.HasKey("Id");
                b.ToTable("SECTION", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Sortiemateriel", b =>
            {
                b.Property<int>("Employe").HasColumnType("int").HasColumnName("EMPLOYE");
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<int>("Piece").HasColumnType("int").HasColumnName("PIECE");
                b.Property<int>("Projet").HasColumnType("int").HasColumnName("PROJET");
                b.Property<int>("Qte").HasColumnType("int").HasColumnName("QTE");
                b.HasIndex("Employe");
                b.HasIndex("Piece");
                b.HasIndex("Projet");
                b.ToTable("SORTIEMATERIEL", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Soumission", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Description").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("DESCRIPTION");
                b.Property<DateTime?>("Fermeture").HasColumnType("datetime").HasColumnName("FERMETURE");
                b.Property<int?>("Noclient").HasColumnType("int").HasColumnName("NOCLIENT");
                b.Property<bool>("Ouvert").HasColumnType("bit").HasColumnName("OUVERT");
                b.Property<DateTime?>("Ouverture").HasColumnType("datetime").HasColumnName("OUVERTURE");
                b.Property<string>("Raisonfermeture").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("RAISONFERMETURE");
                b.Property<string>("Type").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("TYPE");
                b.Property<bool>("Verrouille").HasColumnType("bit").HasColumnName("VERROUILLE");
                b.HasKey("Id");
                b.HasIndex("Noclient");
                b.ToTable("SOUMISSION", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Transport", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Transport1").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("TRANSPORT");
                b.HasKey("Id");
                b.ToTable("TRANSPORT", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Type", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Description").IsRequired().HasMaxLength(15).HasColumnType("nvarchar(15)").HasColumnName("DESCRIPTION");
                b.HasKey("Id");
                b.ToTable("TYPE", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Vendeur", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("ID");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
                b.Property<string>("Commentaire").HasMaxLength(255).HasColumnType("nvarchar(255)").HasColumnName("COMMENTAIRE");
                b.Property<string>("Contact").HasMaxLength(50).HasColumnType("nvarchar(50)").HasColumnName("CONTACT");
                b.Property<DateOnly?>("Date").HasColumnType("date").HasColumnName("DATE");
                b.Property<int>("Enregpar").HasColumnType("int").HasColumnName("ENREGPAR");
                b.Property<int?>("Idclient").HasColumnType("int").HasColumnName("IDCLIENT");
                b.Property<string>("Type").HasMaxLength(25).HasColumnType("nvarchar(25)").HasColumnName("TYPE");
                b.HasKey("Id");
                b.HasIndex("Enregpar");
                b.HasIndex("Idclient");
                b.ToTable("VENDEUR", string.Empty);
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Achat", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Employe", "AcheteurNavigation").WithMany("Achats").HasForeignKey("Acheteur").HasConstraintName("FK_ACHATS_EMPLOYES");
                b.HasOne("GestionEntreprise.DataBase.Type", "TypeNavigation").WithMany("Achats").HasForeignKey("Type").IsRequired().HasConstraintName("FK_ACHATS_TYPE");
                b.Navigation("AcheteurNavigation");
                b.Navigation("TypeNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Alarme", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Employe", "EmployeNavigation").WithMany("Alarmes").HasForeignKey("Employe").IsRequired().HasConstraintName("FK_ALARMES_EMPLOYES");
                b.HasOne("GestionEntreprise.DataBase.Contact", "NocontactNavigation").WithMany("Alarmes").HasForeignKey("Nocontact").HasConstraintName("FK_ALARMES_CONTACT");
                b.HasOne("GestionEntreprise.DataBase.Type", "TypeNavigation").WithMany("Alarmes").HasForeignKey("Type").IsRequired().HasConstraintName("FK_ALARMES_TYPE");
                b.Navigation("EmployeNavigation");
                b.Navigation("NocontactNavigation");
                b.Navigation("TypeNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Bonscommande", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Fournisseur", "NofournisseurNavigation").WithMany("Bonscommandes").HasForeignKey("Nofournisseur").HasConstraintName("FK_BONSCOMMANDES_FOURNISSEUR");
                b.HasOne("GestionEntreprise.DataBase.Projet", "NoprojetNavigation").WithMany("Bonscommandes").HasForeignKey("Noprojet").IsRequired().HasConstraintName("FK_BONSCOMMANDES_PROJET");
                b.HasOne("GestionEntreprise.DataBase.Transport", "TransportNavigation").WithMany("Bonscommandes").HasForeignKey("Transport").IsRequired().HasConstraintName("FK_BONSCOMMANDES_TRANSPORT");
                b.Navigation("NofournisseurNavigation");
                b.Navigation("NoprojetNavigation");
                b.Navigation("TransportNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Catalogue", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Piece", "PieceNavigation").WithMany("Catalogues").HasForeignKey("Piece").IsRequired().HasConstraintName("FK_CATALOGUE_PIECES");
                b.Navigation("PieceNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Employe", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Groupe", "OrdresNavigation").WithMany("EmployesNavigation").HasForeignKey("Ordres").IsRequired().HasConstraintName("FK_EMPLOYES_GROUPES");
                b.HasOne("GestionEntreprise.DataBase.Ordre1", "Ordres1").WithMany("EmployesNavigation").HasForeignKey("Ordres").IsRequired().HasConstraintName("FK_EMPLOYES_ORDRES");
                b.Navigation("Ordres1");
                b.Navigation("OrdresNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Inventaire", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Projet", "NoprojetNavigation").WithMany("Inventaires").HasForeignKey("Noprojet").IsRequired().HasConstraintName("FK_INVENTAIRE_PROJET");
                b.Navigation("NoprojetNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Liaisoncontact", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Client", "NoclientNavigation").WithMany("Liaisoncontacts").HasForeignKey("Noclient").HasConstraintName("FK_LIAISONCONTACT_CLIENT");
                b.HasOne("GestionEntreprise.DataBase.Contact", "NocontactNavigation").WithMany("Liaisoncontacts").HasForeignKey("Nocontact").IsRequired().HasConstraintName("FK_LIAISONCONTACT_CONTACT");
                b.HasOne("GestionEntreprise.DataBase.Fournisseur", "NofournisseurNavigation").WithMany("Liaisoncontacts").HasForeignKey("Nofournisseur").HasConstraintName("FK_LIAISONCONTACT_FOURNISSEUR");
                b.HasOne("GestionEntreprise.DataBase.Manufacturier", "NomanufacturierNavigation").WithMany("Liaisoncontacts").HasForeignKey("Nomanufacturier").HasConstraintName("FK_LIAISONCONTACT_Manufacturier");
                b.Navigation("NoclientNavigation");
                b.Navigation("NocontactNavigation");
                b.Navigation("NofournisseurNavigation");
                b.Navigation("NomanufacturierNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.ListeDistribution", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Contact", "NoContactNavigation").WithMany("ListeDistributions").HasForeignKey("NoContact").IsRequired().HasConstraintName("FK_ListeDistribution_CONTACT");
                b.HasOne("GestionEntreprise.DataBase.Fournisseur", "NoContact1").WithMany("ListeDistributions").HasForeignKey("NoContact").IsRequired().HasConstraintName("FK_ListeDistribution_FOURNISSEUR");
                b.HasOne("GestionEntreprise.DataBase.Liaisoncontact", "NoContact2").WithMany("ListeDistributions").HasForeignKey("NoContact").IsRequired().HasConstraintName("FK_ListeDistribution_LIAISONCONTACT");
                b.Navigation("NoContact1");
                b.Navigation("NoContact2");
                b.Navigation("NoContactNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.OutilsInOut", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Employe", "EmployeNavigation").WithMany("OutilsInOuts").HasForeignKey("Employe").IsRequired().HasConstraintName("FK_OUTILS_IN_OUT_EMPLOYES");
                b.Navigation("EmployeNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Piece", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Devise", "DeviseNavigation").WithMany("Pieces").HasForeignKey("Devise").HasConstraintName("FK_PIECES_DEVISES");
                b.HasOne("GestionEntreprise.DataBase.Manufacturier", "IdmanufacturierNavigation").WithMany("Pieces").HasForeignKey("Idmanufacturier").HasConstraintName("FK_PIECES_Manufacturier");
                b.Navigation("DeviseNavigation");
                b.Navigation("IdmanufacturierNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Piecesparsoumission", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Soumission", "IdsoumissionNavigation").WithMany("Piecesparsoumissions").HasForeignKey("Idsoumission").IsRequired().HasConstraintName("FK_PIECESPARSOUMISSION_SOUMISSION");
                b.HasOne("GestionEntreprise.DataBase.Piece", "PieceNavigation").WithMany("Piecesparsoumissions").HasForeignKey("Piece").IsRequired().HasConstraintName("FK_PIECESPARSOUMISSION_PIECES");
                b.Navigation("IdsoumissionNavigation");
                b.Navigation("PieceNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Projet", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Employe", "CreerParNavigation").WithMany("ProjetCreerParNavigations").HasForeignKey("CreerPar").IsRequired().HasConstraintName("FK_PROJET_EMPLOYES1");
                b.HasOne("GestionEntreprise.DataBase.Client", "IdclientNavigation").WithMany("Projets").HasForeignKey("Idclient").HasConstraintName("FK_PROJET_CLIENT");
                b.HasOne("GestionEntreprise.DataBase.Contact", "IdcontactNavigation").WithMany("Projets").HasForeignKey("Idcontact").HasConstraintName("FK_PROJET_CONTACT");
                b.HasOne("GestionEntreprise.DataBase.Employe", "ParNavigation").WithMany("ProjetParNavigations").HasForeignKey("Par").IsRequired().HasConstraintName("FK_PROJET_EMPLOYES");
                b.HasOne("GestionEntreprise.DataBase.Transport", "TransportNavigation").WithMany("Projets").HasForeignKey("Transport").IsRequired().HasConstraintName("FK_PROJET_TRANSPORT");
                b.Navigation("CreerParNavigation");
                b.Navigation("IdclientNavigation");
                b.Navigation("IdcontactNavigation");
                b.Navigation("ParNavigation");
                b.Navigation("TransportNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Rendezvou", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Employe", "EmployeNavigation").WithMany("Rendezvous").HasForeignKey("Employe").IsRequired().HasConstraintName("FK_RENDEZVOUS_EMPLOYES");
                b.Navigation("EmployeNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Sortiemateriel", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Employe", "EmployeNavigation").WithMany().HasForeignKey("Employe").IsRequired().HasConstraintName("FK_SORTIEMATERIEL_EMPLOYES");
                b.HasOne("GestionEntreprise.DataBase.Piece", "PieceNavigation").WithMany().HasForeignKey("Piece").IsRequired().HasConstraintName("FK_SORTIEMATERIEL_PIECES");
                b.HasOne("GestionEntreprise.DataBase.Projet", "ProjetNavigation").WithMany().HasForeignKey("Projet").IsRequired().HasConstraintName("FK_SORTIEMATERIEL_PROJET");
                b.Navigation("EmployeNavigation");
                b.Navigation("PieceNavigation");
                b.Navigation("ProjetNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Soumission", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Projet", "NoclientNavigation").WithMany("Soumissions").HasForeignKey("Noclient").HasConstraintName("FK_SOUMISSION_PROJET");
                b.Navigation("NoclientNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Vendeur", b =>
            {
                b.HasOne("GestionEntreprise.DataBase.Employe", "EnregparNavigation").WithMany("Vendeurs").HasForeignKey("Enregpar").IsRequired().HasConstraintName("FK_VENDEUR_EMPLOYES");
                b.HasOne("GestionEntreprise.DataBase.Client", "IdclientNavigation").WithMany("Vendeurs").HasForeignKey("Idclient").HasConstraintName("FK_VENDEUR_CLIENT");
                b.Navigation("EnregparNavigation");
                b.Navigation("IdclientNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Client", b =>
            {
                b.Navigation("Liaisoncontacts");
                b.Navigation("Projets");
                b.Navigation("Vendeurs");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Contact", b =>
            {
                b.Navigation("Alarmes");
                b.Navigation("Liaisoncontacts");
                b.Navigation("ListeDistributions");
                b.Navigation("Projets");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Devise", b =>
            {
                b.Navigation("Pieces");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Employe", b =>
            {
                b.Navigation("Achats");
                b.Navigation("Alarmes");
                b.Navigation("OutilsInOuts");
                b.Navigation("ProjetCreerParNavigations");
                b.Navigation("ProjetParNavigations");
                b.Navigation("Rendezvous");
                b.Navigation("Vendeurs");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Fournisseur", b =>
            {
                b.Navigation("Bonscommandes");
                b.Navigation("Liaisoncontacts");
                b.Navigation("ListeDistributions");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Groupe", b =>
            {
                b.Navigation("EmployesNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Liaisoncontact", b =>
            {
                b.Navigation("ListeDistributions");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Manufacturier", b =>
            {
                b.Navigation("Liaisoncontacts");
                b.Navigation("Pieces");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Ordre1", b =>
            {
                b.Navigation("EmployesNavigation");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Piece", b =>
            {
                b.Navigation("Catalogues");
                b.Navigation("Piecesparsoumissions");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Projet", b =>
            {
                b.Navigation("Bonscommandes");
                b.Navigation("Inventaires");
                b.Navigation("Soumissions");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Soumission", b =>
            {
                b.Navigation("Piecesparsoumissions");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Transport", b =>
            {
                b.Navigation("Bonscommandes");
                b.Navigation("Projets");
            });
            modelBuilder.Entity("GestionEntreprise.DataBase.Type", b =>
            {
                b.Navigation("Achats");
                b.Navigation("Alarmes");
            });
#pragma warning restore 612, 618
        }
    }
}