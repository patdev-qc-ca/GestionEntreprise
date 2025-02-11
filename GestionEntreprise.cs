namespace GestionEntreprise
{
    internal static class GestionEntreprise
    {
        public static string StringSQL = "Data Source=" +
             Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=GestionEntreprise;" +
             "Persist Security Info=True;Encrypt=true;TrustServerCertificate=yes;User Id = sa; Password=Password01$;";
        public static string Titre = $"{Application.ProductName} v:{Application.ProductVersion}";
        public static Conteneur conteneur = new Conteneur();
        public static Login login = new Login();
        public static List<DataBase.Employe> LstEmployes = [];
        public static List<DataBase.Groupe> lstGroupes = [];
        public static bool g_admin;
        public static int IdGroupe;
        public static int IdNoEmploye;
        public static string? IdNomEmploye;
        public static string? IdLoginEmploye;
        public static string? IdPassEmploye;
        public static int IdFamille;
        public static bool IdSatut;
        public static string? IdInitiales;
        public static string? NomDB=Application.ProductName;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Conteneur());
        }
    }
}