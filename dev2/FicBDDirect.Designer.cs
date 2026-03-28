namespace dev2
{
    partial class FicBDDirect
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
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.bConsulter = new System.Windows.Forms.Button();
            this.bDenombrer = new System.Windows.Forms.Button();
            this.bAjouter = new System.Windows.Forms.Button();
            this.lNom = new System.Windows.Forms.Label();
            this.lPrenom = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbConsole
            // 
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.ItemHeight = 16;
            this.lbConsole.Location = new System.Drawing.Point(22, 27);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(502, 404);
            this.lbConsole.TabIndex = 0;
            // 
            // bConsulter
            // 
            this.bConsulter.Location = new System.Drawing.Point(595, 27);
            this.bConsulter.Name = "bConsulter";
            this.bConsulter.Size = new System.Drawing.Size(144, 23);
            this.bConsulter.TabIndex = 1;
            this.bConsulter.Text = "Consulter";
            this.bConsulter.UseVisualStyleBackColor = true;
            this.bConsulter.Click += new System.EventHandler(this.bConsulter_Click);
            // 
            // bDenombrer
            // 
            this.bDenombrer.Location = new System.Drawing.Point(595, 113);
            this.bDenombrer.Name = "bDenombrer";
            this.bDenombrer.Size = new System.Drawing.Size(144, 23);
            this.bDenombrer.TabIndex = 2;
            this.bDenombrer.Text = "Denombrer";
            this.bDenombrer.UseVisualStyleBackColor = true;
            // 
            // bAjouter
            // 
            this.bAjouter.Location = new System.Drawing.Point(595, 408);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(144, 23);
            this.bAjouter.TabIndex = 3;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(592, 183);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(36, 16);
            this.lNom.TabIndex = 4;
            this.lNom.Text = "Nom";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Location = new System.Drawing.Point(592, 284);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(54, 16);
            this.lPrenom.TabIndex = 5;
            this.lPrenom.Text = "Prenom";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(595, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(595, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 22);
            this.textBox2.TabIndex = 7;
            // 
            // FicBDDirect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lPrenom);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.bDenombrer);
            this.Controls.Add(this.bConsulter);
            this.Controls.Add(this.lbConsole);
            this.Name = "FicBDDirect";
            this.Text = "FicBDDirect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbConsole;
        private System.Windows.Forms.Button bConsulter;
        private System.Windows.Forms.Button bDenombrer;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}