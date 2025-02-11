namespace GestionEntreprise
{
    public partial class Conteneur : Form
    {
        public Conteneur()
        {
            InitializeComponent();
        }

        private void Conteneur_Load(object sender, EventArgs e)
        {
            GestionEntreprise.login.MdiParent = this;
            GestionEntreprise.login.Show();
        }

        private void Conteneur_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Conteneur_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Voulez vous vraiment quiter ce programme?", GestionEntreprise.Titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
