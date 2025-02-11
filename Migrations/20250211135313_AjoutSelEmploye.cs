using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionEntreprise.Migrations
{
    /// <inheritdoc />
    public partial class AjoutSelEmploye : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COMPAGNIE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TELEPHONNE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CELLULAIRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADRESSE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VILLE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PROVINCE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PAYS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NOPOSTE = table.Column<int>(type: "int", nullable: true),
                    COMMENTAIRE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATION = table.Column<DateTime>(type: "datetime", nullable: false),
                    MODIFICATION = table.Column<DateTime>(type: "datetime", nullable: false),
                    CONTACT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CLIENT__3214EC27C22EA9F4", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CONTACT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CONTACT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COMPAGNIE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TELEPHONNE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CELLULAIRE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EMAIL = table.Column<string>(name: "E-MAIL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOPOSTE = table.Column<int>(type: "int", nullable: true),
                    CREATION = table.Column<DateTime>(type: "datetime", nullable: false),
                    MODIFICATION = table.Column<DateTime>(type: "datetime", nullable: false),
                    COMMENTAIRE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TITRE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTACT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DEVISES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCIPTION = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DEVISES__3214EC27B9B2B7B1", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FOURNISSEUR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    REP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ADRESSE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VILLE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PROVINCE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PAYS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TELEPHONNE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EMAIL = table.Column<string>(name: "E-MAIL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOPOSTE = table.Column<int>(type: "int", nullable: true),
                    SITEWEB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    COMMENTAIRE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CREATION = table.Column<DateTime>(type: "datetime", nullable: false),
                    SUPPRIME = table.Column<bool>(type: "bit", nullable: false),
                    CATEGORIE = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FOURNISS__3214EC27826AFB3F", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GROUPES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    NOMGROUPE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CLIENTS = table.Column<bool>(type: "bit", nullable: false),
                    FOURNISSEURS = table.Column<bool>(type: "bit", nullable: false),
                    CONTACTS = table.Column<bool>(type: "bit", nullable: false),
                    RAPPORT = table.Column<bool>(type: "bit", nullable: false),
                    CATALOGUE = table.Column<bool>(type: "bit", nullable: false),
                    EMPLOYES = table.Column<bool>(type: "bit", nullable: false),
                    CEDULE = table.Column<bool>(type: "bit", nullable: false),
                    OUTILS = table.Column<bool>(type: "bit", nullable: false),
                    SOUMISSION = table.Column<bool>(type: "bit", nullable: false),
                    PROJET = table.Column<bool>(type: "bit", nullable: false),
                    INVENTAIRE = table.Column<bool>(type: "bit", nullable: false),
                    ACHAT = table.Column<bool>(type: "bit", nullable: false),
                    COMPTAFACTURATION = table.Column<bool>(name: "COMPTA-FACTURATION", type: "bit", nullable: false),
                    COMPTACLIENTS = table.Column<bool>(name: "COMPTA-CLIENTS", type: "bit", nullable: false),
                    COMPTAFOURNISSEURS = table.Column<bool>(name: "COMPTA-FOURNISSEURS", type: "bit", nullable: false),
                    COMPTACONTACTS = table.Column<bool>(name: "COMPTA-CONTACTS", type: "bit", nullable: false),
                    COMPTAGROUPES = table.Column<bool>(name: "COMPTA-GROUPES", type: "bit", nullable: false),
                    COMPTAEMPLOYES = table.Column<bool>(name: "COMPTA-EMPLOYES", type: "bit", nullable: false),
                    COMPTAFEUILLESTEMPS = table.Column<bool>(name: "COMPTA-FEUILLESTEMPS", type: "bit", nullable: false),
                    COMPTAOUTILS = table.Column<bool>(name: "COMPTA-OUTILS", type: "bit", nullable: false),
                    COMPTASOUMISSIONSMEC = table.Column<bool>(name: "COMPTA-SOUMISSIONSMEC", type: "bit", nullable: false),
                    COMPTAPROJETSMEC = table.Column<bool>(name: "COMPTA-PROJETSMEC", type: "bit", nullable: false),
                    COMPTASOUMISSIONSELEC = table.Column<bool>(name: "COMPTA-SOUMISSIONSELEC", type: "bit", nullable: false),
                    COMPTAPROJETSELEC = table.Column<bool>(name: "COMPTA-PROJETSELEC", type: "bit", nullable: false),
                    COMPTABONSCOMMANDES = table.Column<bool>(name: "COMPTA-BONSCOMMANDES", type: "bit", nullable: false),
                    COMPTACATALOGUE = table.Column<bool>(name: "COMPTA-CATALOGUE", type: "bit", nullable: false),
                    COMPTAINVENTAIRE = table.Column<bool>(name: "COMPTA-INVENTAIRE", type: "bit", nullable: false),
                    COMPTAPUNCH = table.Column<bool>(name: "COMPTA-PUNCH", type: "bit", nullable: false),
                    COMPTARECEPTION = table.Column<bool>(name: "COMPTA-RECEPTION", type: "bit", nullable: false),
                    COMPTARETOURMARCHANDISE = table.Column<bool>(name: "COMPTA-RETOURMARCHANDISE", type: "bit", nullable: false),
                    SUPPRESSIONPROJETS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GROUPES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturier",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    REP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ADRESSE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VILLE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PROVINCE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PAYS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TELEPHONNE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOPOSTE = table.Column<int>(type: "int", nullable: true),
                    SITEWEB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    COMMENTAIRE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CREATION = table.Column<DateTime>(type: "datetime", nullable: false),
                    SUPPRIME = table.Column<bool>(type: "bit", nullable: false),
                    CATEGORIE = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Manufact__3214EC270AA068F3", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DEPARTEMENTS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    FAMILLE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEPARTEMENTS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ORDRES",
                columns: table => new
                {
                    IDGROUPE = table.Column<int>(type: "int", nullable: false),
                    NOMGROUPE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CLIENTS = table.Column<bool>(type: "bit", nullable: true),
                    FOURNISSEURS = table.Column<bool>(type: "bit", nullable: true),
                    CONTACTS = table.Column<bool>(type: "bit", nullable: true),
                    CONTACTSVENDEURS = table.Column<bool>(type: "bit", nullable: true),
                    RAPPORT = table.Column<bool>(type: "bit", nullable: true),
                    CATALOGUE = table.Column<bool>(type: "bit", nullable: true),
                    EMPLOYES = table.Column<bool>(type: "bit", nullable: true),
                    CEDULE = table.Column<bool>(type: "bit", nullable: true),
                    CONFIGURATION = table.Column<bool>(type: "bit", nullable: true),
                    PUNCH = table.Column<bool>(type: "bit", nullable: true),
                    OUTILS = table.Column<bool>(type: "bit", nullable: true),
                    SOUMISSION = table.Column<bool>(type: "bit", nullable: true),
                    PROJET = table.Column<bool>(type: "bit", nullable: true),
                    PROJETELEC = table.Column<bool>(type: "bit", nullable: true),
                    INVENTAIRE = table.Column<bool>(type: "bit", nullable: true),
                    ACHAT = table.Column<bool>(type: "bit", nullable: true),
                    COMPTAFACTURATION = table.Column<bool>(name: "COMPTA-FACTURATION", type: "bit", nullable: true),
                    COMPTACLIENTS = table.Column<bool>(name: "COMPTA-CLIENTS", type: "bit", nullable: true),
                    COMPTAFOURNISSEURS = table.Column<bool>(name: "COMPTA-FOURNISSEURS", type: "bit", nullable: true),
                    COMPTACONTACTS = table.Column<bool>(name: "COMPTA-CONTACTS", type: "bit", nullable: true),
                    COMPTAGROUPES = table.Column<bool>(name: "COMPTA-GROUPES", type: "bit", nullable: true),
                    COMPTAEMPLOYES = table.Column<bool>(name: "COMPTA-EMPLOYES", type: "bit", nullable: true),
                    COMPTAFEUILLESTEMPS = table.Column<bool>(name: "COMPTA-FEUILLESTEMPS", type: "bit", nullable: true),
                    COMPTAOUTILS = table.Column<bool>(name: "COMPTA-OUTILS", type: "bit", nullable: true),
                    COMPTASOUMISSIONS = table.Column<bool>(name: "COMPTA-SOUMISSIONS", type: "bit", nullable: true),
                    COMPTAPROJETS = table.Column<bool>(name: "COMPTA-PROJETS", type: "bit", nullable: true),
                    COMPTABONSCOMMANDES = table.Column<bool>(name: "COMPTA-BONSCOMMANDES", type: "bit", nullable: true),
                    COMPTACATALOGUE = table.Column<bool>(name: "COMPTA-CATALOGUE", type: "bit", nullable: true),
                    COMPTAINVENTAIRE = table.Column<bool>(name: "COMPTA-INVENTAIRE", type: "bit", nullable: true),
                    COMPTAPUNCHEMPLOYES = table.Column<bool>(name: "COMPTA-PUNCHEMPLOYES", type: "bit", nullable: true),
                    COMPTARECEPTION = table.Column<bool>(name: "COMPTA-RECEPTION", type: "bit", nullable: true),
                    COMPTARETOURMARCHANDISE = table.Column<bool>(name: "COMPTA-RETOURMARCHANDISE", type: "bit", nullable: true),
                    SuppressionProjets = table.Column<bool>(type: "bit", nullable: true),
                    VerrouillageTempsProjet = table.Column<bool>(type: "bit", nullable: true),
                    DeverrouillageTempsProjet = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDRES", x => x.IDGROUPE);
                });

            migrationBuilder.CreateTable(
                name: "OUTILS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SECTEUR = table.Column<int>(type: "int", nullable: false),
                    PRIX = table.Column<decimal>(type: "money", nullable: false),
                    TYPE_ETIQUETTE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DATE_ACHAT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DATE_HORS_FONCTION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    COMMENTAIRE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OUTILS__3214EC276CA17AA6", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PIECESPARPROJET",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPROJET = table.Column<int>(type: "int", nullable: false),
                    PIECE = table.Column<int>(type: "int", nullable: true),
                    QTE = table.Column<double>(type: "float", nullable: true),
                    MANUFACT = table.Column<int>(type: "int", nullable: false),
                    FOURNISSEUR = table.Column<int>(type: "int", nullable: true),
                    TYPE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    COMMANDE = table.Column<bool>(type: "bit", nullable: false),
                    RECU = table.Column<bool>(type: "bit", nullable: false),
                    RETOUR = table.Column<bool>(type: "bit", nullable: false),
                    NORETOUR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    COMMANDEANNULEE = table.Column<bool>(type: "bit", nullable: false),
                    RECEPTION = table.Column<DateOnly>(type: "date", nullable: true),
                    QUANTITERECUE = table.Column<int>(type: "int", nullable: false),
                    COMMANDELE = table.Column<DateTime>(type: "datetime", nullable: true),
                    REQUISELE = table.Column<DateTime>(type: "datetime", nullable: false),
                    TITRECOMMANDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    COMMENTAIRE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RETOURNEE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PIECESPA__3214EC27A9A31842", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PUNCH",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    EMPLOYE = table.Column<int>(type: "int", nullable: true),
                    NOPROJET = table.Column<int>(type: "int", nullable: false),
                    DATE = table.Column<DateOnly>(type: "date", nullable: false),
                    DEBUT = table.Column<TimeOnly>(type: "time", nullable: false),
                    FIN = table.Column<TimeOnly>(type: "time", nullable: true),
                    COMMENTAIRE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FACTURE = table.Column<bool>(type: "bit", nullable: false),
                    NOFACTURE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NOCLIENT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KM = table.Column<bool>(type: "bit", nullable: false),
                    NBREKM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SECTION = table.Column<int>(type: "int", nullable: false),
                    DUREE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PUNCH", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SECTEUR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESRIPTION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SECTEUR__3214EC27949B5CE5", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SECTION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECTION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TRANSPORT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSPORT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSPORT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIAISONCONTACT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOCONTACT = table.Column<int>(type: "int", nullable: false),
                    NOCLIENT = table.Column<int>(type: "int", nullable: true),
                    NOMANUFACTURIER = table.Column<int>(type: "int", nullable: true),
                    NOFOURNISSEUR = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIAISONCONTACT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LIAISONCONTACT_CLIENT",
                        column: x => x.NOCLIENT,
                        principalTable: "CLIENT",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_LIAISONCONTACT_CONTACT",
                        column: x => x.NOCONTACT,
                        principalTable: "CONTACT",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_LIAISONCONTACT_FOURNISSEUR",
                        column: x => x.NOFOURNISSEUR,
                        principalTable: "FOURNISSEUR",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_LIAISONCONTACT_Manufacturier",
                        column: x => x.NOMANUFACTURIER,
                        principalTable: "Manufacturier",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PIECES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPIECE = table.Column<int>(type: "int", nullable: false),
                    QTE = table.Column<int>(type: "int", nullable: true),
                    DESC_FR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DESC_EN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IDMANUFACTURIER = table.Column<int>(type: "int", nullable: true),
                    PRIXLISTE = table.Column<decimal>(type: "money", nullable: false),
                    ESCOMPTE = table.Column<double>(type: "float", nullable: true),
                    PRIX_NET = table.Column<decimal>(type: "money", nullable: false),
                    IDFOURNISSEUR = table.Column<int>(type: "int", nullable: false),
                    PRIX_TOTAL = table.Column<decimal>(type: "money", nullable: false),
                    TYPE = table.Column<int>(type: "int", nullable: false),
                    COMMANDE = table.Column<bool>(type: "bit", nullable: false),
                    RETOUR = table.Column<bool>(type: "bit", nullable: false),
                    NORETOUR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RECU = table.Column<bool>(type: "bit", nullable: false),
                    DATERECEPTION = table.Column<DateOnly>(type: "date", nullable: true),
                    QUANTITERECUE = table.Column<int>(type: "int", nullable: true),
                    DATECOMMANDE = table.Column<DateOnly>(type: "date", nullable: true),
                    DATEREQUISE = table.Column<DateOnly>(type: "date", nullable: false),
                    COMMANDEANNULEE = table.Column<bool>(type: "bit", nullable: false),
                    DATERETOUR = table.Column<DateOnly>(type: "date", nullable: true),
                    PRIXORIGINE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DEVISE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIECES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PIECES_DEVISES",
                        column: x => x.DEVISE,
                        principalTable: "DEVISES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PIECES_Manufacturier",
                        column: x => x.IDMANUFACTURIER,
                        principalTable: "Manufacturier",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOGIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CLEF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NOM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    INITIALE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TELEPHONE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CELLULAIRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ACTIF = table.Column<bool>(type: "bit", nullable: false),
                    ORDRES = table.Column<int>(type: "int", nullable: false),
                    SUPPRIME = table.Column<bool>(type: "bit", nullable: false),
                    Sel = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EMPLOYES__3214EC27CF71D7F1", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EMPLOYES_GROUPES",
                        column: x => x.ORDRES,
                        principalTable: "GROUPES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_EMPLOYES_ORDRES",
                        column: x => x.ORDRES,
                        principalTable: "ORDRES",
                        principalColumn: "IDGROUPE");
                });

            migrationBuilder.CreateTable(
                name: "ListeDistribution",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoContact = table.Column<int>(type: "int", nullable: false),
                    NomCompagnie = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    isContact = table.Column<bool>(type: "bit", nullable: false),
                    isClient = table.Column<bool>(type: "bit", nullable: false),
                    isFournisseur = table.Column<bool>(type: "bit", nullable: false),
                    isChefEntreprise = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListeDistribution", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ListeDistribution_CONTACT",
                        column: x => x.NoContact,
                        principalTable: "CONTACT",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ListeDistribution_FOURNISSEUR",
                        column: x => x.NoContact,
                        principalTable: "FOURNISSEUR",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ListeDistribution_LIAISONCONTACT",
                        column: x => x.NoContact,
                        principalTable: "LIAISONCONTACT",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CATALOGUE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESC_FR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DESC_EN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FABRIQUAANT = table.Column<int>(type: "int", nullable: false),
                    DESCRITION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TEMPS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CATEGORIE = table.Column<int>(type: "int", nullable: false),
                    PIECE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CATALOGU__3214EC277A5D37A5", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CATALOGUE_PIECES",
                        column: x => x.PIECE,
                        principalTable: "PIECES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ACHATS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INDEXACHAT = table.Column<int>(type: "int", nullable: true),
                    RAISON = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATEACHAT = table.Column<DateOnly>(type: "date", nullable: true),
                    ACHETEUR = table.Column<int>(type: "int", nullable: true),
                    PRIXTOTAL = table.Column<decimal>(type: "money", nullable: true),
                    TYPE = table.Column<int>(type: "int", nullable: false),
                    MODIFICATION = table.Column<bool>(type: "bit", nullable: false),
                    PAR = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACHATS__3214EC27E238FF03", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ACHATS_EMPLOYES",
                        column: x => x.ACHETEUR,
                        principalTable: "EMPLOYES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ACHATS_TYPE",
                        column: x => x.TYPE,
                        principalTable: "TYPE",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ALARMES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMPLOYE = table.Column<int>(type: "int", nullable: false),
                    TYPE = table.Column<int>(type: "int", nullable: false),
                    DATE = table.Column<DateOnly>(type: "date", nullable: false),
                    HEURE = table.Column<TimeOnly>(type: "time", nullable: false),
                    MESSAGE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOCONTACT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ALARMES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ALARMES_CONTACT",
                        column: x => x.NOCONTACT,
                        principalTable: "CONTACT",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ALARMES_EMPLOYES",
                        column: x => x.EMPLOYE,
                        principalTable: "EMPLOYES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ALARMES_TYPE",
                        column: x => x.TYPE,
                        principalTable: "TYPE",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OUTILS_IN_OUT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMPLOYE = table.Column<int>(type: "int", nullable: false),
                    SORTIE = table.Column<DateTime>(type: "datetime", nullable: false),
                    RETOUR = table.Column<DateTime>(type: "datetime", nullable: true),
                    COMMENTAIRE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OUTILS_I__3214EC27224EE314", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OUTILS_IN_OUT_EMPLOYES",
                        column: x => x.EMPLOYE,
                        principalTable: "EMPLOYES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PROJET",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDSOUMISSION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDCLIENT = table.Column<int>(type: "int", nullable: true),
                    IDCONTACT = table.Column<int>(type: "int", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TRANSPORT = table.Column<int>(type: "int", nullable: false),
                    CREER = table.Column<DateTime>(type: "datetime", nullable: false),
                    CREER_PAR = table.Column<int>(type: "int", nullable: false),
                    COMPTAFABRICATION = table.Column<decimal>(name: "COMPTA-FABRICATION", type: "money", nullable: false),
                    COMPTAASSEMBLAGE = table.Column<decimal>(name: "COMPTA-ASSEMBLAGE", type: "money", nullable: false),
                    COMPTATEST = table.Column<decimal>(name: "COMPTA-TEST", type: "money", nullable: false),
                    COMPTAVISION = table.Column<decimal>(name: "COMPTA-VISION", type: "money", nullable: false),
                    COMPTAPROGAUTOMATE = table.Column<decimal>(name: "COMPTA-PROGAUTOMATE", type: "money", nullable: false),
                    COMPTAPROGROBOT = table.Column<decimal>(name: "COMPTA-PROGROBOT", type: "money", nullable: false),
                    COMPTAINSTALLATION = table.Column<decimal>(name: "COMPTA-INSTALLATION", type: "money", nullable: false),
                    COMPTAMISESERVICE = table.Column<decimal>(name: "COMPTA-MISESERVICE", type: "money", nullable: false),
                    COMPTAFORMATION = table.Column<decimal>(name: "COMPTA-FORMATION", type: "money", nullable: false),
                    COMPTAGESTION = table.Column<decimal>(name: "COMPTA-GESTION", type: "money", nullable: false),
                    COMPTASHIPPING = table.Column<decimal>(name: "COMPTA-SHIPPING", type: "money", nullable: false),
                    NBREPERSONNE = table.Column<decimal>(type: "money", nullable: false),
                    COMPTAHEBERGEMENT = table.Column<double>(name: "COMPTA-HEBERGEMENT", type: "float", nullable: false),
                    TOTALHEBERGEMENT = table.Column<decimal>(type: "money", nullable: false),
                    COMPTAREPAS = table.Column<double>(name: "COMPTA-REPAS", type: "float", nullable: false),
                    TOTALREPAS = table.Column<decimal>(type: "money", nullable: false),
                    COMPTATRANSPORT = table.Column<double>(name: "COMPTA-TRANSPORT", type: "float", nullable: false),
                    COMPTAUNITEMOBILE = table.Column<string>(name: "COMPTA-UNITEMOBILE", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PRIXEMBALLAGE = table.Column<decimal>(type: "money", nullable: false),
                    TAUXDESSIN = table.Column<decimal>(type: "money", nullable: false),
                    TAUXPROGINTERFACE = table.Column<decimal>(type: "money", nullable: false),
                    MONTANTFABRICATION = table.Column<decimal>(name: "MONTANT-FABRICATION", type: "money", nullable: false),
                    MONTANTASSEMBLAGE = table.Column<decimal>(name: "MONTANT-ASSEMBLAGE", type: "money", nullable: false),
                    MONTANTTEST = table.Column<decimal>(name: "MONTANT-TEST", type: "money", nullable: false),
                    MONTANTVISION = table.Column<decimal>(name: "MONTANT-VISION", type: "money", nullable: false),
                    MONTANTPROGAUTOMATE = table.Column<decimal>(name: "MONTANT-PROGAUTOMATE", type: "money", nullable: false),
                    MONTANTPROGROBOT = table.Column<decimal>(name: "MONTANT-PROGROBOT", type: "money", nullable: false),
                    MONTANTINSTALLATION = table.Column<decimal>(name: "MONTANT-INSTALLATION", type: "money", nullable: false),
                    MONTANTMISESERVICE = table.Column<decimal>(name: "MONTANT-MISESERVICE", type: "money", nullable: false),
                    MONTANTFORMATION = table.Column<decimal>(name: "MONTANT-FORMATION", type: "money", nullable: false),
                    MONTANTGESTION = table.Column<decimal>(name: "MONTANT-GESTION", type: "money", nullable: false),
                    MONTANTSHIPPING = table.Column<decimal>(name: "MONTANT-SHIPPING", type: "money", nullable: false),
                    MONTANTHEBERGEMENT1 = table.Column<decimal>(name: "MONTANT-HEBERGEMENT1", type: "money", nullable: false),
                    MONTANTHEBERGEMENT2 = table.Column<decimal>(name: "MONTANT-HEBERGEMENT2", type: "money", nullable: false),
                    MONTANTREPAS = table.Column<decimal>(name: "MONTANT-REPAS", type: "money", nullable: false),
                    MONTANTTRANSPORT = table.Column<decimal>(name: "MONTANT-TRANSPORT", type: "money", nullable: false),
                    MONTANTUNITEMOBILE = table.Column<decimal>(name: "MONTANT-UNITEMOBILE", type: "money", nullable: false),
                    IMPREVUE = table.Column<decimal>(type: "money", nullable: false),
                    COMPTAIMPREVUE = table.Column<decimal>(name: "COMPTA-IMPREVUE", type: "money", nullable: false),
                    COMPTATEMPS = table.Column<decimal>(name: "COMPTA-TEMPS", type: "money", nullable: false),
                    COMPTAMANUEL = table.Column<decimal>(name: "COMPTA-MANUEL", type: "money", nullable: false),
                    COMMISSION = table.Column<decimal>(type: "money", nullable: false),
                    TOTAL_COMMISSION = table.Column<decimal>(type: "money", nullable: false),
                    PRIXTOTAL = table.Column<decimal>(type: "money", nullable: false),
                    MODIFICATION = table.Column<bool>(type: "bit", nullable: false),
                    PAR = table.Column<int>(type: "int", nullable: false),
                    PRIXRECEPTION = table.Column<decimal>(type: "money", nullable: false),
                    MONTANTFORFAIT = table.Column<decimal>(type: "money", nullable: false),
                    FORFAITINITIAL = table.Column<decimal>(type: "money", nullable: false),
                    PROCHAINECOMMANDE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PROJET__3214EC27EB1707FD", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PROJET_CLIENT",
                        column: x => x.IDCLIENT,
                        principalTable: "CLIENT",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PROJET_CONTACT",
                        column: x => x.IDCONTACT,
                        principalTable: "CONTACT",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PROJET_EMPLOYES",
                        column: x => x.PAR,
                        principalTable: "EMPLOYES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PROJET_EMPLOYES1",
                        column: x => x.CREER_PAR,
                        principalTable: "EMPLOYES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PROJET_TRANSPORT",
                        column: x => x.TRANSPORT,
                        principalTable: "TRANSPORT",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RENDEZVOUS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMPLOYE = table.Column<int>(type: "int", nullable: false),
                    DATERDV = table.Column<DateOnly>(type: "date", nullable: false),
                    DEBUT = table.Column<TimeOnly>(type: "time", nullable: false),
                    FIN = table.Column<TimeOnly>(type: "time", nullable: false),
                    CLIENT = table.Column<int>(type: "int", nullable: false),
                    FINPROJET = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RENDEZVO__3214EC27D21622D4", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RENDEZVOUS_EMPLOYES",
                        column: x => x.EMPLOYE,
                        principalTable: "EMPLOYES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "VENDEUR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCLIENT = table.Column<int>(type: "int", nullable: true),
                    DATE = table.Column<DateOnly>(type: "date", nullable: true),
                    CONTACT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    COMMENTAIRE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ENREGPAR = table.Column<int>(type: "int", nullable: false),
                    TYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENDEUR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VENDEUR_CLIENT",
                        column: x => x.IDCLIENT,
                        principalTable: "CLIENT",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_VENDEUR_EMPLOYES",
                        column: x => x.ENREGPAR,
                        principalTable: "EMPLOYES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "BONSCOMMANDES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOFOURNISSEUR = table.Column<int>(type: "int", nullable: true),
                    NOPROJET = table.Column<int>(type: "int", nullable: false),
                    ATTENTION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TRANSPORT = table.Column<int>(type: "int", nullable: false),
                    DATEREQUISE = table.Column<DateOnly>(type: "date", nullable: false),
                    NOSOUM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DATECOMMANDE = table.Column<int>(type: "int", nullable: false),
                    COMMANDEPAR = table.Column<int>(type: "int", nullable: false),
                    TOTAL = table.Column<decimal>(type: "money", nullable: false),
                    COMMENTAIRE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BONSCOMMANDES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BONSCOMMANDES_FOURNISSEUR",
                        column: x => x.NOFOURNISSEUR,
                        principalTable: "FOURNISSEUR",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BONSCOMMANDES_PROJET",
                        column: x => x.NOPROJET,
                        principalTable: "PROJET",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BONSCOMMANDES_TRANSPORT",
                        column: x => x.TRANSPORT,
                        principalTable: "TRANSPORT",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "INVENTAIRE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIECE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MANUFACTURIER = table.Column<int>(type: "int", nullable: false),
                    QTEBOITE = table.Column<int>(type: "int", nullable: false),
                    PRIXLISTE = table.Column<decimal>(type: "money", nullable: true),
                    ESCOMPTE = table.Column<double>(type: "float", nullable: true),
                    PRIXNET = table.Column<decimal>(type: "money", nullable: false),
                    COMMENTAIRES = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LOCALISATION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STOCK = table.Column<int>(type: "int", nullable: false),
                    QTCOMMANDEE = table.Column<int>(type: "int", nullable: false),
                    NOPROJET = table.Column<int>(type: "int", nullable: false),
                    SECOMMANDEENBOITE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__INVENTAI__3214EC27CF8BA428", x => x.ID);
                    table.ForeignKey(
                        name: "FK_INVENTAIRE_PROJET",
                        column: x => x.NOPROJET,
                        principalTable: "PROJET",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SORTIEMATERIEL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QTE = table.Column<int>(type: "int", nullable: false),
                    EMPLOYE = table.Column<int>(type: "int", nullable: false),
                    PROJET = table.Column<int>(type: "int", nullable: false),
                    PIECE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_SORTIEMATERIEL_EMPLOYES",
                        column: x => x.EMPLOYE,
                        principalTable: "EMPLOYES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SORTIEMATERIEL_PIECES",
                        column: x => x.PIECE,
                        principalTable: "PIECES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SORTIEMATERIEL_PROJET",
                        column: x => x.PROJET,
                        principalTable: "PROJET",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SOUMISSION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOCLIENT = table.Column<int>(type: "int", nullable: true),
                    OUVERTURE = table.Column<DateTime>(type: "datetime", nullable: true),
                    FERMETURE = table.Column<DateTime>(type: "datetime", nullable: true),
                    RAISONFERMETURE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OUVERT = table.Column<bool>(type: "bit", nullable: false),
                    VERROUILLE = table.Column<bool>(type: "bit", nullable: false),
                    TYPE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOUMISSION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SOUMISSION_PROJET",
                        column: x => x.NOCLIENT,
                        principalTable: "PROJET",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PIECESPARSOUMISSION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDSOUMISSION = table.Column<int>(type: "int", nullable: false),
                    PIECE = table.Column<int>(type: "int", nullable: false),
                    QTE = table.Column<double>(type: "float", nullable: false),
                    TEMPS = table.Column<double>(type: "float", nullable: false),
                    DUREETOTALE = table.Column<double>(type: "float", nullable: false),
                    PRIXTOTAL = table.Column<decimal>(type: "money", nullable: false),
                    PRIXORIGINE = table.Column<decimal>(type: "money", nullable: false),
                    COMMANDE = table.Column<bool>(type: "bit", nullable: false),
                    RECU = table.Column<bool>(type: "bit", nullable: false),
                    RETOUR = table.Column<bool>(type: "bit", nullable: false),
                    COMMANDEANNULEE = table.Column<bool>(type: "bit", nullable: false),
                    COMMENTAIRE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PIECESPA__3214EC277B5D490A", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PIECESPARSOUMISSION_PIECES",
                        column: x => x.PIECE,
                        principalTable: "PIECES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PIECESPARSOUMISSION_SOUMISSION",
                        column: x => x.IDSOUMISSION,
                        principalTable: "SOUMISSION",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ACHATS_ACHETEUR",
                table: "ACHATS",
                column: "ACHETEUR");

            migrationBuilder.CreateIndex(
                name: "IX_ACHATS_TYPE",
                table: "ACHATS",
                column: "TYPE");

            migrationBuilder.CreateIndex(
                name: "IX_ALARMES_EMPLOYE",
                table: "ALARMES",
                column: "EMPLOYE");

            migrationBuilder.CreateIndex(
                name: "IX_ALARMES_NOCONTACT",
                table: "ALARMES",
                column: "NOCONTACT");

            migrationBuilder.CreateIndex(
                name: "IX_ALARMES_TYPE",
                table: "ALARMES",
                column: "TYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BONSCOMMANDES_NOFOURNISSEUR",
                table: "BONSCOMMANDES",
                column: "NOFOURNISSEUR");

            migrationBuilder.CreateIndex(
                name: "IX_BONSCOMMANDES_NOPROJET",
                table: "BONSCOMMANDES",
                column: "NOPROJET");

            migrationBuilder.CreateIndex(
                name: "IX_BONSCOMMANDES_TRANSPORT",
                table: "BONSCOMMANDES",
                column: "TRANSPORT");

            migrationBuilder.CreateIndex(
                name: "IX_CATALOGUE_PIECE",
                table: "CATALOGUE",
                column: "PIECE");

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYES_ORDRES",
                table: "EMPLOYES",
                column: "ORDRES");

            migrationBuilder.CreateIndex(
                name: "IX_INVENTAIRE_NOPROJET",
                table: "INVENTAIRE",
                column: "NOPROJET");

            migrationBuilder.CreateIndex(
                name: "IX_LIAISONCONTACT_NOCLIENT",
                table: "LIAISONCONTACT",
                column: "NOCLIENT");

            migrationBuilder.CreateIndex(
                name: "IX_LIAISONCONTACT_NOCONTACT",
                table: "LIAISONCONTACT",
                column: "NOCONTACT");

            migrationBuilder.CreateIndex(
                name: "IX_LIAISONCONTACT_NOFOURNISSEUR",
                table: "LIAISONCONTACT",
                column: "NOFOURNISSEUR");

            migrationBuilder.CreateIndex(
                name: "IX_LIAISONCONTACT_NOMANUFACTURIER",
                table: "LIAISONCONTACT",
                column: "NOMANUFACTURIER");

            migrationBuilder.CreateIndex(
                name: "IX_ListeDistribution_NoContact",
                table: "ListeDistribution",
                column: "NoContact");

            migrationBuilder.CreateIndex(
                name: "IX_OUTILS_IN_OUT_EMPLOYE",
                table: "OUTILS_IN_OUT",
                column: "EMPLOYE");

            migrationBuilder.CreateIndex(
                name: "IX_PIECES_DEVISE",
                table: "PIECES",
                column: "DEVISE");

            migrationBuilder.CreateIndex(
                name: "IX_PIECES_IDMANUFACTURIER",
                table: "PIECES",
                column: "IDMANUFACTURIER");

            migrationBuilder.CreateIndex(
                name: "IX_PIECESPARSOUMISSION_IDSOUMISSION",
                table: "PIECESPARSOUMISSION",
                column: "IDSOUMISSION");

            migrationBuilder.CreateIndex(
                name: "IX_PIECESPARSOUMISSION_PIECE",
                table: "PIECESPARSOUMISSION",
                column: "PIECE");

            migrationBuilder.CreateIndex(
                name: "IX_PROJET_CREER_PAR",
                table: "PROJET",
                column: "CREER_PAR");

            migrationBuilder.CreateIndex(
                name: "IX_PROJET_IDCLIENT",
                table: "PROJET",
                column: "IDCLIENT");

            migrationBuilder.CreateIndex(
                name: "IX_PROJET_IDCONTACT",
                table: "PROJET",
                column: "IDCONTACT");

            migrationBuilder.CreateIndex(
                name: "IX_PROJET_PAR",
                table: "PROJET",
                column: "PAR");

            migrationBuilder.CreateIndex(
                name: "IX_PROJET_TRANSPORT",
                table: "PROJET",
                column: "TRANSPORT");

            migrationBuilder.CreateIndex(
                name: "IX_RENDEZVOUS_EMPLOYE",
                table: "RENDEZVOUS",
                column: "EMPLOYE");

            migrationBuilder.CreateIndex(
                name: "IX_SORTIEMATERIEL_EMPLOYE",
                table: "SORTIEMATERIEL",
                column: "EMPLOYE");

            migrationBuilder.CreateIndex(
                name: "IX_SORTIEMATERIEL_PIECE",
                table: "SORTIEMATERIEL",
                column: "PIECE");

            migrationBuilder.CreateIndex(
                name: "IX_SORTIEMATERIEL_PROJET",
                table: "SORTIEMATERIEL",
                column: "PROJET");

            migrationBuilder.CreateIndex(
                name: "IX_SOUMISSION_NOCLIENT",
                table: "SOUMISSION",
                column: "NOCLIENT");

            migrationBuilder.CreateIndex(
                name: "IX_VENDEUR_ENREGPAR",
                table: "VENDEUR",
                column: "ENREGPAR");

            migrationBuilder.CreateIndex(
                name: "IX_VENDEUR_IDCLIENT",
                table: "VENDEUR",
                column: "IDCLIENT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACHATS");

            migrationBuilder.DropTable(
                name: "ALARMES");

            migrationBuilder.DropTable(
                name: "BONSCOMMANDES");

            migrationBuilder.DropTable(
                name: "CATALOGUE");

            migrationBuilder.DropTable(
                name: "INVENTAIRE");

            migrationBuilder.DropTable(
                name: "ListeDistribution");

            migrationBuilder.DropTable(
                name: "ORDRE");

            migrationBuilder.DropTable(
                name: "OUTILS");

            migrationBuilder.DropTable(
                name: "OUTILS_IN_OUT");

            migrationBuilder.DropTable(
                name: "PIECESPARPROJET");

            migrationBuilder.DropTable(
                name: "PIECESPARSOUMISSION");

            migrationBuilder.DropTable(
                name: "PUNCH");

            migrationBuilder.DropTable(
                name: "RENDEZVOUS");

            migrationBuilder.DropTable(
                name: "SECTEUR");

            migrationBuilder.DropTable(
                name: "SECTION");

            migrationBuilder.DropTable(
                name: "SORTIEMATERIEL");

            migrationBuilder.DropTable(
                name: "VENDEUR");

            migrationBuilder.DropTable(
                name: "TYPE");

            migrationBuilder.DropTable(
                name: "LIAISONCONTACT");

            migrationBuilder.DropTable(
                name: "SOUMISSION");

            migrationBuilder.DropTable(
                name: "PIECES");

            migrationBuilder.DropTable(
                name: "FOURNISSEUR");

            migrationBuilder.DropTable(
                name: "PROJET");

            migrationBuilder.DropTable(
                name: "DEVISES");

            migrationBuilder.DropTable(
                name: "Manufacturier");

            migrationBuilder.DropTable(
                name: "CLIENT");

            migrationBuilder.DropTable(
                name: "CONTACT");

            migrationBuilder.DropTable(
                name: "EMPLOYES");

            migrationBuilder.DropTable(
                name: "TRANSPORT");

            migrationBuilder.DropTable(
                name: "GROUPES");

            migrationBuilder.DropTable(
                name: "ORDRES");
        }
    }
}
