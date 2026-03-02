namespace dev2
{
    partial class EcranSpirographe
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
            this.gbParametrage = new System.Windows.Forms.GroupBox();
            this.lSommets = new System.Windows.Forms.Label();
            this.lDensite = new System.Windows.Forms.Label();
            this.lProfondeur = new System.Windows.Forms.Label();
            this.tbDensites = new System.Windows.Forms.TrackBar();
            this.tbSommets = new System.Windows.Forms.TrackBar();
            this.tbProfondeur = new System.Windows.Forms.TrackBar();
            this.bGo = new System.Windows.Forms.Button();
            this.bTrait = new System.Windows.Forms.Button();
            this.BFond = new System.Windows.Forms.Button();
            this.cdCouleur = new System.Windows.Forms.ColorDialog();
            this.gbParametrage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSommets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametrage
            // 
            this.gbParametrage.Controls.Add(this.BFond);
            this.gbParametrage.Controls.Add(this.lSommets);
            this.gbParametrage.Controls.Add(this.bTrait);
            this.gbParametrage.Controls.Add(this.lDensite);
            this.gbParametrage.Controls.Add(this.bGo);
            this.gbParametrage.Controls.Add(this.lProfondeur);
            this.gbParametrage.Controls.Add(this.tbProfondeur);
            this.gbParametrage.Controls.Add(this.tbSommets);
            this.gbParametrage.Controls.Add(this.tbDensites);
            this.gbParametrage.Location = new System.Drawing.Point(12, 18);
            this.gbParametrage.Name = "gbParametrage";
            this.gbParametrage.Size = new System.Drawing.Size(236, 401);
            this.gbParametrage.TabIndex = 0;
            this.gbParametrage.TabStop = false;
            this.gbParametrage.Text = "parametrage";
            // 
            // lSommets
            // 
            this.lSommets.Location = new System.Drawing.Point(6, 18);
            this.lSommets.Name = "lSommets";
            this.lSommets.Size = new System.Drawing.Size(221, 23);
            this.lSommets.TabIndex = 1;
            this.lSommets.Text = "Nombre de sommets(3 à 8)";
            // 
            // lDensite
            // 
            this.lDensite.Location = new System.Drawing.Point(6, 103);
            this.lDensite.Name = "lDensite";
            this.lDensite.Size = new System.Drawing.Size(221, 26);
            this.lDensite.TabIndex = 2;
            this.lDensite.Text = "Densité de dessins (5 à 20)\n ";
            // 
            // lProfondeur
            // 
            this.lProfondeur.Location = new System.Drawing.Point(3, 191);
            this.lProfondeur.Name = "lProfondeur";
            this.lProfondeur.Size = new System.Drawing.Size(221, 26);
            this.lProfondeur.TabIndex = 3;
            this.lProfondeur.Text = "Profondeur de dessin (20 a 80)\n ";
            // 
            // tbDensites
            // 
            this.tbDensites.Location = new System.Drawing.Point(6, 122);
            this.tbDensites.Name = "tbDensites";
            this.tbDensites.Size = new System.Drawing.Size(221, 56);
            this.tbDensites.TabIndex = 4;
            // 
            // tbSommets
            // 
            this.tbSommets.Location = new System.Drawing.Point(0, 44);
            this.tbSommets.Name = "tbSommets";
            this.tbSommets.Size = new System.Drawing.Size(227, 56);
            this.tbSommets.TabIndex = 5;
            // 
            // tbProfondeur
            // 
            this.tbProfondeur.Location = new System.Drawing.Point(9, 220);
            this.tbProfondeur.Name = "tbProfondeur";
            this.tbProfondeur.Size = new System.Drawing.Size(215, 56);
            this.tbProfondeur.TabIndex = 6;
            // 
            // bGo
            // 
            this.bGo.Location = new System.Drawing.Point(9, 272);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(215, 30);
            this.bGo.TabIndex = 7;
            this.bGo.Text = "GO!";
            this.bGo.UseVisualStyleBackColor = true;
            // 
            // bTrait
            // 
            this.bTrait.Location = new System.Drawing.Point(6, 320);
            this.bTrait.Name = "bTrait";
            this.bTrait.Size = new System.Drawing.Size(215, 33);
            this.bTrait.TabIndex = 8;
            this.bTrait.Text = "Trait";
            this.bTrait.UseVisualStyleBackColor = true;
            // 
            // BFond
            // 
            this.BFond.Location = new System.Drawing.Point(9, 370);
            this.BFond.Name = "BFond";
            this.BFond.Size = new System.Drawing.Size(212, 25);
            this.BFond.TabIndex = 9;
            this.BFond.Text = "Fond";
            this.BFond.UseVisualStyleBackColor = true;
            // 
            // EcranSpirographe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbParametrage);
            this.Name = "EcranSpirographe";
            this.Text = "EcranSpirographe";
            this.gbParametrage.ResumeLayout(false);
            this.gbParametrage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSommets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametrage;
        private System.Windows.Forms.Label lSommets;
        private System.Windows.Forms.Label lDensite;
        private System.Windows.Forms.Label lProfondeur;
        private System.Windows.Forms.TrackBar tbDensites;
        private System.Windows.Forms.TrackBar tbSommets;
        private System.Windows.Forms.TrackBar tbProfondeur;
        private System.Windows.Forms.Button bGo;
        private System.Windows.Forms.Button bTrait;
        private System.Windows.Forms.Button BFond;
        private System.Windows.Forms.ColorDialog cdCouleur;
    }
}