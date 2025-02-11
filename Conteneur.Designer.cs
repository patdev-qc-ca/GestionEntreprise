namespace GestionEntreprise
{
    partial class Conteneur
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conteneur));
            statusStrip1 = new StatusStrip();
            panel1 = new Panel();
            ConnexionSQL = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(ConnexionSQL);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 27);
            panel1.TabIndex = 2;
            // 
            // ConnexionSQL
            // 
            ConnexionSQL.BackgroundImageLayout = ImageLayout.None;
            ConnexionSQL.Dock = DockStyle.Left;
            ConnexionSQL.ImageAlign = ContentAlignment.MiddleLeft;
            ConnexionSQL.Location = new Point(0, 0);
            ConnexionSQL.Name = "ConnexionSQL";
            ConnexionSQL.Size = new Size(97, 27);
            ConnexionSQL.TabIndex = 0;
            ConnexionSQL.Text = "Connexion SQL";
            ConnexionSQL.UseVisualStyleBackColor = true;
            // 
            // Conteneur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Conteneur";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Conteneur";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            FormClosing += Conteneur_FormClosing;
            FormClosed += Conteneur_FormClosed;
            Load += Conteneur_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Panel panel1;
        public Button ConnexionSQL;
    }
}
