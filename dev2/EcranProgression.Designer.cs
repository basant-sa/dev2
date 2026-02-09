namespace dev2
{
    partial class EcranProgression
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
            this.lPrincipal = new System.Windows.Forms.Label();
            this.lSecondaire = new System.Windows.Forms.Label();
            this.pbPrincipal = new System.Windows.Forms.ProgressBar();
            this.pbSecondaire = new System.Windows.Forms.ProgressBar();
            this.bExecuter = new System.Windows.Forms.Button();
            this.bQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lPrincipal
            // 
            this.lPrincipal.AutoSize = true;
            this.lPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrincipal.Location = new System.Drawing.Point(37, 91);
            this.lPrincipal.Name = "lPrincipal";
            this.lPrincipal.Size = new System.Drawing.Size(148, 16);
            this.lPrincipal.TabIndex = 0;
            this.lPrincipal.Text = "Progression globale";
            // 
            // lSecondaire
            // 
            this.lSecondaire.AutoSize = true;
            this.lSecondaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSecondaire.Location = new System.Drawing.Point(68, 172);
            this.lSecondaire.Name = "lSecondaire";
            this.lSecondaire.Size = new System.Drawing.Size(117, 16);
            this.lSecondaire.TabIndex = 1;
            this.lSecondaire.Text = "Fichier en cours";
            this.lSecondaire.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.ForeColor = System.Drawing.Color.LightGreen;
            this.pbPrincipal.Location = new System.Drawing.Point(231, 84);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(542, 23);
            this.pbPrincipal.Step = 1;
            this.pbPrincipal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPrincipal.TabIndex = 2;
            // 
            // pbSecondaire
            // 
            this.pbSecondaire.ForeColor = System.Drawing.Color.LightGreen;
            this.pbSecondaire.Location = new System.Drawing.Point(231, 165);
            this.pbSecondaire.Name = "pbSecondaire";
            this.pbSecondaire.Size = new System.Drawing.Size(542, 23);
            this.pbSecondaire.Step = 1;
            this.pbSecondaire.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSecondaire.TabIndex = 3;
            // 
            // bExecuter
            // 
            this.bExecuter.Location = new System.Drawing.Point(133, 26);
            this.bExecuter.Name = "bExecuter";
            this.bExecuter.Size = new System.Drawing.Size(75, 23);
            this.bExecuter.TabIndex = 4;
            this.bExecuter.Text = "Executer";
            this.bExecuter.UseVisualStyleBackColor = true;
            this.bExecuter.Click += new System.EventHandler(this.bExecuter_Click);
            // 
            // bQuitter
            // 
            this.bQuitter.Location = new System.Drawing.Point(291, 26);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(75, 23);
            this.bQuitter.TabIndex = 5;
            this.bQuitter.Text = "Quitter";
            this.bQuitter.UseVisualStyleBackColor = true;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // EcranProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bExecuter);
            this.Controls.Add(this.pbSecondaire);
            this.Controls.Add(this.pbPrincipal);
            this.Controls.Add(this.lSecondaire);
            this.Controls.Add(this.lPrincipal);
            this.Name = "EcranProgression";
            this.Text = "EcranProgression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPrincipal;
        private System.Windows.Forms.Label lSecondaire;
        private System.Windows.Forms.ProgressBar pbPrincipal;
        private System.Windows.Forms.ProgressBar pbSecondaire;
        private System.Windows.Forms.Button bExecuter;
        private System.Windows.Forms.Button bQuitter;
    }
}