namespace dev2
{
    partial class EcranListe
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
            this.lFichier = new System.Windows.Forms.Label();
            this.lNom = new System.Windows.Forms.Label();
            this.lQualite = new System.Windows.Forms.Label();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bConfirmer = new System.Windows.Forms.Button();
            this.bOuvrir = new System.Windows.Forms.Button();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.bAjouter = new System.Windows.Forms.Button();
            this.lbPersonne = new System.Windows.Forms.ListBox();
            this.cbQualite = new System.Windows.Forms.ComboBox();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.ofdOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.sfdEnregistrer = new System.Windows.Forms.SaveFileDialog();
            this.bModifier = new System.Windows.Forms.Button();
            this.gbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lFichier
            // 
            this.lFichier.AutoSize = true;
            this.lFichier.Location = new System.Drawing.Point(48, 40);
            this.lFichier.Name = "lFichier";
            this.lFichier.Size = new System.Drawing.Size(98, 16);
            this.lFichier.TabIndex = 0;
            this.lFichier.Text = "Nom de Fichier";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(6, 95);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(36, 16);
            this.lNom.TabIndex = 1;
            this.lNom.Text = "Nom";
            // 
            // lQualite
            // 
            this.lQualite.AutoSize = true;
            this.lQualite.Location = new System.Drawing.Point(6, 28);
            this.lQualite.Name = "lQualite";
            this.lQualite.Size = new System.Drawing.Size(49, 16);
            this.lQualite.TabIndex = 2;
            this.lQualite.Text = "Qualité";
            // 
            // bAnnuler
            // 
            this.bAnnuler.Location = new System.Drawing.Point(109, 168);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(75, 23);
            this.bAnnuler.TabIndex = 3;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bConfirmer
            // 
            this.bConfirmer.Location = new System.Drawing.Point(9, 168);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(75, 23);
            this.bConfirmer.TabIndex = 4;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.UseVisualStyleBackColor = true;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // bOuvrir
            // 
            this.bOuvrir.Location = new System.Drawing.Point(51, 290);
            this.bOuvrir.Name = "bOuvrir";
            this.bOuvrir.Size = new System.Drawing.Size(75, 23);
            this.bOuvrir.TabIndex = 5;
            this.bOuvrir.Text = "Ouvrir";
            this.bOuvrir.UseVisualStyleBackColor = true;
            this.bOuvrir.Click += new System.EventHandler(this.bOuvrir_Click);
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Location = new System.Drawing.Point(51, 319);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.bEnregistrer.TabIndex = 6;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // bSupprimer
            // 
            this.bSupprimer.Location = new System.Drawing.Point(51, 377);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(75, 23);
            this.bSupprimer.TabIndex = 7;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // bAjouter
            // 
            this.bAjouter.Location = new System.Drawing.Point(51, 348);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(75, 23);
            this.bAjouter.TabIndex = 8;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // lbPersonne
            // 
            this.lbPersonne.FormattingEnabled = true;
            this.lbPersonne.ItemHeight = 16;
            this.lbPersonne.Location = new System.Drawing.Point(12, 59);
            this.lbPersonne.Name = "lbPersonne";
            this.lbPersonne.Size = new System.Drawing.Size(286, 212);
            this.lbPersonne.TabIndex = 9;
            this.lbPersonne.DoubleClick += new System.EventHandler(this.lbPersonne_DoubleClick);
            // 
            // cbQualite
            // 
            this.cbQualite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQualite.FormattingEnabled = true;
            this.cbQualite.Items.AddRange(new object[] {
            "Madame",
            "Mademoiselle",
            "Monsieur",
            "Mondamoiseau",
            "Indéfini"});
            this.cbQualite.Location = new System.Drawing.Point(9, 59);
            this.cbQualite.Name = "cbQualite";
            this.cbQualite.Size = new System.Drawing.Size(121, 24);
            this.cbQualite.TabIndex = 10;
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.tbNom);
            this.gbDetail.Controls.Add(this.cbQualite);
            this.gbDetail.Controls.Add(this.lQualite);
            this.gbDetail.Controls.Add(this.lNom);
            this.gbDetail.Controls.Add(this.bConfirmer);
            this.gbDetail.Controls.Add(this.bAnnuler);
            this.gbDetail.Location = new System.Drawing.Point(327, 59);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(211, 206);
            this.gbDetail.TabIndex = 11;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Détail";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(9, 114);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 22);
            this.tbNom.TabIndex = 12;
            // 
            // ofdOuvrir
            // 
            this.ofdOuvrir.FileName = "openFileDialog1";
            // 
            // bModifier
            // 
            this.bModifier.Location = new System.Drawing.Point(51, 406);
            this.bModifier.Name = "bModifier";
            this.bModifier.Size = new System.Drawing.Size(75, 23);
            this.bModifier.TabIndex = 12;
            this.bModifier.Text = "Modifier";
            this.bModifier.UseVisualStyleBackColor = true;
            this.bModifier.Click += new System.EventHandler(this.bModifier_Click);
            // 
            // EcranListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bModifier);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.lbPersonne);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.bOuvrir);
            this.Controls.Add(this.lFichier);
            this.Name = "EcranListe";
            this.Text = "EcranListe";
            this.Load += new System.EventHandler(this.EcranListe_Load);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFichier;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lQualite;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bConfirmer;
        private System.Windows.Forms.Button bOuvrir;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.ListBox lbPersonne;
        private System.Windows.Forms.ComboBox cbQualite;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.OpenFileDialog ofdOuvrir;
        private System.Windows.Forms.SaveFileDialog sfdEnregistrer;
        private System.Windows.Forms.Button bModifier;
    }
}