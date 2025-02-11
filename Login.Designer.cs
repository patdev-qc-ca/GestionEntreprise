using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace GestionEntreprise
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            txtServeur = new TextBox();
            label2 = new Label();
            cmbDataBase = new ComboBox();
            cmbUtilisateurs = new ComboBox();
            label3 = new Label();
            txtPasswordUser = new TextBox();
            label4 = new Label();
            IdConnexion = new Button();
            button2 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 13);
            label1.TabIndex = 0;
            label1.Text = "Serveur de données";
            // 
            // txtServeur
            // 
            txtServeur.BackColor = SystemColors.Control;
            txtServeur.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtServeur.ForeColor = SystemColors.ControlText;
            txtServeur.Location = new Point(60, 26);
            txtServeur.Name = "txtServeur";
            txtServeur.ReadOnly = true;
            txtServeur.Size = new Size(210, 20);
            txtServeur.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(57, 49);
            label2.Name = "label2";
            label2.Size = new Size(105, 13);
            label2.TabIndex = 2;
            label2.Text = "Base de données";
            // 
            // cmbDataBase
            // 
            cmbDataBase.BackColor = SystemColors.Control;
            cmbDataBase.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDataBase.ForeColor = SystemColors.ControlText;
            cmbDataBase.FormattingEnabled = true;
            cmbDataBase.Location = new Point(60, 65);
            cmbDataBase.Name = "cmbDataBase";
            cmbDataBase.Size = new Size(210, 21);
            cmbDataBase.TabIndex = 3;
            cmbDataBase.SelectedIndexChanged += cmbDataBase_SelectedIndexChanged;
            // 
            // cmbUtilisateurs
            // 
            cmbUtilisateurs.BackColor = SystemColors.Control;
            cmbUtilisateurs.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbUtilisateurs.ForeColor = SystemColors.ControlText;
            cmbUtilisateurs.FormattingEnabled = true;
            cmbUtilisateurs.Location = new Point(60, 123);
            cmbUtilisateurs.Name = "cmbUtilisateurs";
            cmbUtilisateurs.Size = new Size(210, 21);
            cmbUtilisateurs.TabIndex = 5;
            cmbUtilisateurs.SelectedIndexChanged += cmbUtilisateurs_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(57, 106);
            label3.Name = "label3";
            label3.Size = new Size(70, 13);
            label3.TabIndex = 4;
            label3.Text = "Utilisateurs";
            // 
            // txtPasswordUser
            // 
            txtPasswordUser.BackColor = SystemColors.Control;
            txtPasswordUser.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPasswordUser.ForeColor = SystemColors.ControlText;
            txtPasswordUser.Location = new Point(60, 168);
            txtPasswordUser.Name = "txtPasswordUser";
            txtPasswordUser.PasswordChar = '€';
            txtPasswordUser.Size = new Size(210, 20);
            txtPasswordUser.TabIndex = 7;
            txtPasswordUser.TextChanged += txtPasswordUser_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(57, 151);
            label4.Name = "label4";
            label4.Size = new Size(142, 13);
            label4.TabIndex = 6;
            label4.Text = "Mot de passe utilisateur";
            // 
            // IdConnexion
            // 
            IdConnexion.BackColor = Color.FromArgb(224, 224, 224);
            IdConnexion.DialogResult = DialogResult.Yes;
            IdConnexion.Enabled = false;
            IdConnexion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdConnexion.ForeColor = Color.DarkGreen;
            IdConnexion.Location = new Point(144, 213);
            IdConnexion.Name = "IdConnexion";
            IdConnexion.Size = new Size(76, 28);
            IdConnexion.TabIndex = 8;
            IdConnexion.Text = "Connexion";
            IdConnexion.UseVisualStyleBackColor = true;
            IdConnexion.Click += IdConnexion_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(226, 213);
            button2.Name = "button2";
            button2.Size = new Size(76, 28);
            button2.TabIndex = 9;
            button2.Text = "Annuler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 245);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(326, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.Navy;
            toolStripStatusLabel1.LinkColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(311, 17);
            toolStripStatusLabel1.Spring = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.SQL;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(326, 267);
            Controls.Add(statusStrip1);
            Controls.Add(button2);
            Controls.Add(IdConnexion);
            Controls.Add(txtPasswordUser);
            Controls.Add(label4);
            Controls.Add(cmbUtilisateurs);
            Controls.Add(label3);
            Controls.Add(cmbDataBase);
            Controls.Add(label2);
            Controls.Add(txtServeur);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal Label label1;
        internal Label label2;
        internal ComboBox cmbDataBase;
        internal ComboBox cmbUtilisateurs;
        internal Label label3;
        internal TextBox txtPasswordUser;
        internal Label label4;
        internal Button IdConnexion;
        internal Button button2;
        internal StatusStrip statusStrip1;
        internal ToolStripStatusLabel toolStripStatusLabel1;
        internal TextBox txtServeur;
        public static Connection odbc = new Connection();
        private ToolTip toolTip1;
    }
}