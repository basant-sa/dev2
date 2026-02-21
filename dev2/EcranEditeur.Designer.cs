namespace dev2
{
    partial class EcranEditeur
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuquitter = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColler = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGauche = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCentre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDroite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPolice = new System.Windows.Forms.ToolStripMenuItem();
            this.caractèreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItalique = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSouligne = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBarre = new System.Windows.Forms.ToolStripMenuItem();
            this.pMenu = new System.Windows.Forms.Panel();
            this.pbQuitter = new System.Windows.Forms.PictureBox();
            this.pbEnregistrer = new System.Windows.Forms.PictureBox();
            this.pbNouveau = new System.Windows.Forms.PictureBox();
            this.pbOuvrir = new System.Windows.Forms.PictureBox();
            this.rtbTexte = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnregistrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNouveau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOuvrir)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editerToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNouveau,
            this.mnuOuvrir,
            this.mnuEnregistrer,
            this.mnuquitter});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.fichierToolStripMenuItem.Text = "Fichier ";
            // 
            // mnuNouveau
            // 
            this.mnuNouveau.Name = "mnuNouveau";
            this.mnuNouveau.Size = new System.Drawing.Size(191, 26);
            this.mnuNouveau.Text = "Nouveau";
            // 
            // mnuOuvrir
            // 
            this.mnuOuvrir.Name = "mnuOuvrir";
            this.mnuOuvrir.Size = new System.Drawing.Size(191, 26);
            this.mnuOuvrir.Text = "Ouvrir";
            // 
            // mnuEnregistrer
            // 
            this.mnuEnregistrer.Name = "mnuEnregistrer";
            this.mnuEnregistrer.Size = new System.Drawing.Size(191, 26);
            this.mnuEnregistrer.Text = "Enregistrer";
            // 
            // mnuquitter
            // 
            this.mnuquitter.Name = "mnuquitter";
            this.mnuquitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuquitter.Size = new System.Drawing.Size(191, 26);
            this.mnuquitter.Text = "Quitter";
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopier,
            this.mnuCouper,
            this.mnuColler});
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editerToolStripMenuItem.Text = "Editer";
            // 
            // mnuCopier
            // 
            this.mnuCopier.Name = "mnuCopier";
            this.mnuCopier.Size = new System.Drawing.Size(140, 26);
            this.mnuCopier.Text = "Copier";
            // 
            // mnuCouper
            // 
            this.mnuCouper.Name = "mnuCouper";
            this.mnuCouper.Size = new System.Drawing.Size(140, 26);
            this.mnuCouper.Text = "Couper";
            // 
            // mnuColler
            // 
            this.mnuColler.Name = "mnuColler";
            this.mnuColler.Size = new System.Drawing.Size(140, 26);
            this.mnuColler.Text = "Coller";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.justifierToolStripMenuItem,
            this.mnuPolice,
            this.caractèreToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // justifierToolStripMenuItem
            // 
            this.justifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGauche,
            this.mnuCentre,
            this.mnuDroite});
            this.justifierToolStripMenuItem.Name = "justifierToolStripMenuItem";
            this.justifierToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.justifierToolStripMenuItem.Text = "Justifier";
            // 
            // mnuGauche
            // 
            this.mnuGauche.Name = "mnuGauche";
            this.mnuGauche.Size = new System.Drawing.Size(141, 64);
            this.mnuGauche.Text = "Gauche";
            // 
            // mnuCentre
            // 
            this.mnuCentre.Name = "mnuCentre";
            this.mnuCentre.Size = new System.Drawing.Size(141, 64);
            this.mnuCentre.Text = "\nCentre\n";
            // 
            // mnuDroite
            // 
            this.mnuDroite.Name = "mnuDroite";
            this.mnuDroite.Size = new System.Drawing.Size(141, 64);
            this.mnuDroite.Text = "\nDroite";
            // 
            // mnuPolice
            // 
            this.mnuPolice.Name = "mnuPolice";
            this.mnuPolice.Size = new System.Drawing.Size(155, 26);
            this.mnuPolice.Text = "Police";
            // 
            // caractèreToolStripMenuItem
            // 
            this.caractèreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGras,
            this.mnuItalique,
            this.mnuSouligne,
            this.mnuBarre});
            this.caractèreToolStripMenuItem.Name = "caractèreToolStripMenuItem";
            this.caractèreToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.caractèreToolStripMenuItem.Text = "Caractère";
            // 
            // mnuGras
            // 
            this.mnuGras.Name = "mnuGras";
            this.mnuGras.Size = new System.Drawing.Size(150, 26);
            this.mnuGras.Text = "Gras";
            // 
            // mnuItalique
            // 
            this.mnuItalique.Name = "mnuItalique";
            this.mnuItalique.Size = new System.Drawing.Size(150, 26);
            this.mnuItalique.Text = "Italique";
            // 
            // mnuSouligne
            // 
            this.mnuSouligne.Name = "mnuSouligne";
            this.mnuSouligne.Size = new System.Drawing.Size(150, 26);
            this.mnuSouligne.Text = "Souligné";
            // 
            // mnuBarre
            // 
            this.mnuBarre.Name = "mnuBarre";
            this.mnuBarre.Size = new System.Drawing.Size(150, 26);
            this.mnuBarre.Text = "Barré";
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.pbQuitter);
            this.pMenu.Controls.Add(this.pbEnregistrer);
            this.pMenu.Controls.Add(this.pbNouveau);
            this.pMenu.Controls.Add(this.pbOuvrir);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(0, 28);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(800, 49);
            this.pMenu.TabIndex = 1;
            // 
            // pbQuitter
            // 
            this.pbQuitter.Location = new System.Drawing.Point(155, 10);
            this.pbQuitter.Name = "pbQuitter";
            this.pbQuitter.Size = new System.Drawing.Size(32, 32);
            this.pbQuitter.TabIndex = 3;
            this.pbQuitter.TabStop = false;
            // 
            // pbEnregistrer
            // 
            this.pbEnregistrer.Location = new System.Drawing.Point(117, 12);
            this.pbEnregistrer.Name = "pbEnregistrer";
            this.pbEnregistrer.Size = new System.Drawing.Size(32, 30);
            this.pbEnregistrer.TabIndex = 2;
            this.pbEnregistrer.TabStop = false;
            // 
            // pbNouveau
            // 
            this.pbNouveau.Location = new System.Drawing.Point(37, 10);
            this.pbNouveau.Name = "pbNouveau";
            this.pbNouveau.Size = new System.Drawing.Size(34, 32);
            this.pbNouveau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNouveau.TabIndex = 0;
            this.pbNouveau.TabStop = false;
            // 
            // pbOuvrir
            // 
            this.pbOuvrir.Location = new System.Drawing.Point(77, 10);
            this.pbOuvrir.Name = "pbOuvrir";
            this.pbOuvrir.Size = new System.Drawing.Size(34, 32);
            this.pbOuvrir.TabIndex = 1;
            this.pbOuvrir.TabStop = false;
            // 
            // rtbTexte
            // 
            this.rtbTexte.Location = new System.Drawing.Point(0, 79);
            this.rtbTexte.Name = "rtbTexte";
            this.rtbTexte.Size = new System.Drawing.Size(800, 380);
            this.rtbTexte.TabIndex = 2;
            this.rtbTexte.Text = "";
            this.rtbTexte.TextChanged += new System.EventHandler(this.rtbTexte_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EcranEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbTexte);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EcranEditeur";
            this.Text = "EcranEditeur";
            this.Load += new System.EventHandler(this.EcranEditeur_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnregistrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNouveau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOuvrir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNouveau;
        private System.Windows.Forms.ToolStripMenuItem mnuOuvrir;
        private System.Windows.Forms.ToolStripMenuItem mnuEnregistrer;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuquitter;
        private System.Windows.Forms.ToolStripMenuItem mnuCopier;
        private System.Windows.Forms.ToolStripMenuItem mnuCouper;
        private System.Windows.Forms.ToolStripMenuItem mnuColler;
        private System.Windows.Forms.ToolStripMenuItem justifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGauche;
        private System.Windows.Forms.ToolStripMenuItem mnuCentre;
        private System.Windows.Forms.ToolStripMenuItem mnuDroite;
        private System.Windows.Forms.ToolStripMenuItem mnuPolice;
        private System.Windows.Forms.ToolStripMenuItem caractèreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGras;
        private System.Windows.Forms.ToolStripMenuItem mnuItalique;
        private System.Windows.Forms.ToolStripMenuItem mnuSouligne;
        private System.Windows.Forms.ToolStripMenuItem mnuBarre;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.PictureBox pbQuitter;
        private System.Windows.Forms.PictureBox pbEnregistrer;
        private System.Windows.Forms.PictureBox pbOuvrir;
        private System.Windows.Forms.PictureBox pbNouveau;
        private System.Windows.Forms.RichTextBox rtbTexte;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}