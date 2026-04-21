namespace dev2
{
    partial class S14
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
            this.tbGauche = new System.Windows.Forms.TextBox();
            this.tbNbInt = new System.Windows.Forms.TextBox();
            this.tbDroite = new System.Windows.Forms.TextBox();
            this.lbResultats = new System.Windows.Forms.ListBox();
            this.Polynome = new System.Windows.Forms.Button();
            this.Trigonométrique = new System.Windows.Forms.Button();
            this.Idem_Pointeur = new System.Windows.Forms.Button();
            this.IdemPointeur = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbGauche
            // 
            this.tbGauche.Location = new System.Drawing.Point(134, 43);
            this.tbGauche.Name = "tbGauche";
            this.tbGauche.Size = new System.Drawing.Size(100, 22);
            this.tbGauche.TabIndex = 0;
            // 
            // tbNbInt
            // 
            this.tbNbInt.Location = new System.Drawing.Point(516, 43);
            this.tbNbInt.Name = "tbNbInt";
            this.tbNbInt.Size = new System.Drawing.Size(100, 22);
            this.tbNbInt.TabIndex = 1;
            // 
            // tbDroite
            // 
            this.tbDroite.Location = new System.Drawing.Point(329, 43);
            this.tbDroite.Name = "tbDroite";
            this.tbDroite.Size = new System.Drawing.Size(100, 22);
            this.tbDroite.TabIndex = 2;
            // 
            // lbResultats
            // 
            this.lbResultats.FormattingEnabled = true;
            this.lbResultats.ItemHeight = 16;
            this.lbResultats.Location = new System.Drawing.Point(134, 83);
            this.lbResultats.Name = "lbResultats";
            this.lbResultats.Size = new System.Drawing.Size(536, 196);
            this.lbResultats.TabIndex = 3;
            // 
            // Polynome
            // 
            this.Polynome.Location = new System.Drawing.Point(107, 310);
            this.Polynome.Name = "Polynome";
            this.Polynome.Size = new System.Drawing.Size(173, 23);
            this.Polynome.TabIndex = 4;
            this.Polynome.Text = "Polynome";
            this.Polynome.UseVisualStyleBackColor = true;
            this.Polynome.Click += new System.EventHandler(this.Polynome_Click);
            // 
            // Trigonométrique
            // 
            this.Trigonométrique.Location = new System.Drawing.Point(107, 369);
            this.Trigonométrique.Name = "Trigonométrique";
            this.Trigonométrique.Size = new System.Drawing.Size(173, 23);
            this.Trigonométrique.TabIndex = 5;
            this.Trigonométrique.Text = "Trigonométrique";
            this.Trigonométrique.UseVisualStyleBackColor = true;
            this.Trigonométrique.Click += new System.EventHandler(this.Trigonométrique_Click);
            // 
            // Idem_Pointeur
            // 
            this.Idem_Pointeur.Location = new System.Drawing.Point(471, 310);
            this.Idem_Pointeur.Name = "Idem_Pointeur";
            this.Idem_Pointeur.Size = new System.Drawing.Size(173, 23);
            this.Idem_Pointeur.TabIndex = 6;
            this.Idem_Pointeur.Text = "Idem_Pointeur";
            this.Idem_Pointeur.UseVisualStyleBackColor = true;
            this.Idem_Pointeur.Click += new System.EventHandler(this.Idem_Pointeur_Click);
            // 
            // IdemPointeur
            // 
            this.IdemPointeur.Location = new System.Drawing.Point(471, 369);
            this.IdemPointeur.Name = "IdemPointeur";
            this.IdemPointeur.Size = new System.Drawing.Size(173, 23);
            this.IdemPointeur.TabIndex = 7;
            this.IdemPointeur.Text = "Idem Pointeur";
            this.IdemPointeur.UseVisualStyleBackColor = true;
            this.IdemPointeur.Click += new System.EventHandler(this.IdemPointeur_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Gauche";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(329, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Droite";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(516, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Nb intervalles";
            // 
            // S14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IdemPointeur);
            this.Controls.Add(this.Idem_Pointeur);
            this.Controls.Add(this.Trigonométrique);
            this.Controls.Add(this.Polynome);
            this.Controls.Add(this.lbResultats);
            this.Controls.Add(this.tbDroite);
            this.Controls.Add(this.tbNbInt);
            this.Controls.Add(this.tbGauche);
            this.Name = "S14";
            this.Text = "S14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGauche;
        private System.Windows.Forms.TextBox tbNbInt;
        private System.Windows.Forms.TextBox tbDroite;
        private System.Windows.Forms.ListBox lbResultats;
        private System.Windows.Forms.Button Polynome;
        private System.Windows.Forms.Button Trigonométrique;
        private System.Windows.Forms.Button Idem_Pointeur;
        private System.Windows.Forms.Button IdemPointeur;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}