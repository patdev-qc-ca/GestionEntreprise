using GestionEntreprise.DataBase;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS8604 // Existence possible d'un argument de référence null.
#pragma warning disable CS0168 // La variable est déclarée mais jamais utilisée

namespace GestionEntreprise
{
    public partial class Login : Form
    {
        private SqlConnection sql = new SqlConnection(GestionEntreprise.StringSQL);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SqlConnection Sql { get => sql; set => sql = value; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Text = GestionEntreprise.Titre + " " + Name;
            txtServeur.Text =Environment.MachineName+ "\\SQLEXPRESS";
            toolStripStatusLabel1.Text = "Framework v:"+Environment.Version.ToString();
            if (sql.State == ConnectionState.Closed) sql.Open();
            SqlDataReader record = new SqlCommand("SELECT name, database_id, create_date  FROM sys.databases;", sql).ExecuteReader();
            try
            {
                while (record.Read())
                {
                    if (!string.IsNullOrEmpty((string)record[0]))
                    {
                        if (record[0].ToString() == Application.ProductName)
                        {
                            cmbDataBase.Items.Add((string)record[0]);
                        }
                    }
                }
                if (cmbDataBase.Items.Count > 0) cmbDataBase.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source, GestionEntreprise.Titre);
            }
            record.Close();
        }

        private void cmbDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDataBase.SelectedIndex != -1)
                {
                   if (cmbDataBase.SelectedItem.ToString().ToUpper() == "GestionEntreprise".ToUpper())
                    {
                    SqlDataReader? lstTbl = new SqlCommand("SELECT [ID],[LOGIN],[CLEF],[NOM]," +
                        "[INITIALE],[TELEPHONE],[CELLULAIRE],[ACTIF],[ORDRES],[SUPPRIME]FROM [DBO].[EMPLOYES] " +
                        "WHERE SUPPRIME = 0 " +
                        "ORDER BY NOM", sql).ExecuteReader();
                        while (lstTbl.Read())
                        {
                            if (string.IsNullOrEmpty(lstTbl[0].ToString()))
                            {
                                GestionEntreprise.LstEmployes.Add(new DataBase.Employe
                                {
                                    Id = (int)lstTbl[0],
                                    Login =lstTbl[1].ToString(),
                                    Clef = string.Empty,
                                    Nom= lstTbl[3].ToString(),
                                    Initiale = lstTbl[4].ToString(),
                                    Telephone = lstTbl[5].ToString(),
                                    Cellulaire = lstTbl[6].ToString(),
                                    Actif = (bool)lstTbl[7],
                                    Ordres = (int)lstTbl[8],
                                    Supprime = (bool)lstTbl[9],
                                });
                                cmbUtilisateurs.Items.Add(lstTbl[3].ToString());
                            }
                        }
                        toolStripStatusLabel1.Text = $"il y a {GestionEntreprise.LstEmployes.Count}  employés autorisés";
                        lstTbl.Close();
                    }
                    else
                    {
                       MessageBox.Show("Ce prgramme n'est conçu que pour la base GestionEntreprise", GestionEntreprise.Titre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, GestionEntreprise.Titre);
            }
        }

        private void cmbUtilisateurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void txtPasswordUser_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordUser.Text.Length > 3)
            {
                IdConnexion.Enabled = true;
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip1.ToolTipTitle = Application.ProductName + " v:" + Application.ProductVersion;
                toolTip1.Show(txtPasswordUser.Text, this);
            }
            else { IdConnexion.Enabled = false; }
        }
        private void IdConnexion_Click(object sender, EventArgs e)
        {
            if (cmbUtilisateurs.Text == "") { return; }
            try
            {
                SqlDataReader rstEmploye=new SqlCommand($"SELECT   DISTINCT * FROM [DBO].[EMPLOYES] " +
                    $"WHERE ACTIF=1 AND SUPPRIME= 0   AND nom='{cmbUtilisateurs.Text}' " +
                    $"ORDER BY nom",sql).ExecuteReader();
                if (rstEmploye.Read())
                {
                    GestionEntreprise.IdNoEmploye = (int)rstEmploye[0];
                    GestionEntreprise.IdNomEmploye = (string)rstEmploye[3];
                    GestionEntreprise.IdLoginEmploye = (string)rstEmploye[1];
                    GestionEntreprise.IdPassEmploye = (string)rstEmploye[2];
                    GestionEntreprise.IdGroupe = (int)rstEmploye[9];
                    GestionEntreprise.IdFamille = (int)rstEmploye[10];
                    GestionEntreprise.IdSatut = (bool)rstEmploye[8];
                    GestionEntreprise.IdInitiales = (string)rstEmploye[4];
                    if (GestionEntreprise.IdGroupe == 2 | GestionEntreprise.IdGroupe == 27) { GestionEntreprise.g_admin = true; } else { GestionEntreprise.g_admin = false; }
                    GestionEntreprise.NomDB = cmbDataBase.Text;
                }
                else
                {
                    return;
                }
                if (txtPasswordUser.Text.Contains("=") | txtPasswordUser.Text.Contains(" or ") | txtPasswordUser.Text.Contains("1=1") | txtPasswordUser.Text.Contains("1 = 1") | txtPasswordUser.Text.Contains(" "))
                {
                    MessageBox.Show($"Tentative d'injection dEtectEe\n{GestionEntreprise.IdLoginEmploye}", Application.ProductName + ".SEcuritE.InjectionSQL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit(new CancelEventArgs(false));
                }
                int x = 0;
                if (txtPasswordUser.Text == GestionEntreprise.IdPassEmploye)
                {
                    GestionEntreprise.NomDB = cmbDataBase.Text;
                    GestionEntreprise.conteneur.ConnexionSQL.Visible = false;
                }
                else
                {
                    x++;
                    MessageBox.Show($"{txtPasswordUser.Text} mot de passe invalide\nVErifiez votre saisie: \n\tTestHashSalt:\n\tMot de passe pour {GestionEntreprise.IdNomEmploye} invalide\n\n\t\tFermeture de l'application", Application.ProductName + ".Secure.Login.Password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtPasswordUser.Text = string.Empty;
                    Application.Exit();
                }
                rstEmploye.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Data.ToString(), GestionEntreprise.Titre); }
           
            Close();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginSQL_Load(object sender, EventArgs e)
        {
            txtServeur.Text = Environment.MachineName + "\\SQLEXPRESS";
            Text = Application.ProductName + "." + Name;
            try
            {
                if (sql.State == 0)
                {
                    sql.Open();
                }
                SqlDataReader record = new SqlCommand("SELECT name, database_id, create_date  FROM sys.databases;", sql).ExecuteReader();
                while (record.Read())
                {
                    int x= cmbDataBase.Items.Add(record[0].ToString());
                }
                if (cmbDataBase.Items.Count > 0) cmbDataBase.SelectedIndex = 0;
                record.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source, GestionEntreprise.Titre);
            }
        }
    }
}
