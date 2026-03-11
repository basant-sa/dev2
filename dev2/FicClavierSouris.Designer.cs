namespace dev2
{
    partial class FicClavierSouris
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
            this.pnlSouris = new System.Windows.Forms.Panel();
            this.lblClavier = new System.Windows.Forms.Label();
            this.lblClicGauche = new System.Windows.Forms.Label();
            this.lblClicDroit = new System.Windows.Forms.Label();
            this.lblPositionX = new System.Windows.Forms.Label();
            this.lblPositionY = new System.Windows.Forms.Label();
            this.lsbClavier = new System.Windows.Forms.ListBox();
            this.butRAZ = new System.Windows.Forms.Button();
            this.tbxClicGauche = new System.Windows.Forms.TextBox();
            this.tbxPositionY = new System.Windows.Forms.TextBox();
            this.tbxPositionX = new System.Windows.Forms.TextBox();
            this.tbxClicDroit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlSouris
            // 
            this.pnlSouris.Location = new System.Drawing.Point(201, 78);
            this.pnlSouris.Name = "pnlSouris";
            this.pnlSouris.Size = new System.Drawing.Size(554, 350);
            this.pnlSouris.TabIndex = 0;
            this.pnlSouris.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSouris_Paint);
            // 
            // lblClavier
            // 
            this.lblClavier.AutoSize = true;
            this.lblClavier.Location = new System.Drawing.Point(22, 9);
            this.lblClavier.Name = "lblClavier";
            this.lblClavier.Size = new System.Drawing.Size(49, 16);
            this.lblClavier.TabIndex = 1;
            this.lblClavier.Text = "Clavier";
            // 
            // lblClicGauche
            // 
            this.lblClicGauche.AutoSize = true;
            this.lblClicGauche.Location = new System.Drawing.Point(232, 9);
            this.lblClicGauche.Name = "lblClicGauche";
            this.lblClicGauche.Size = new System.Drawing.Size(76, 16);
            this.lblClicGauche.TabIndex = 2;
            this.lblClicGauche.Text = "ClicGauche";
            // 
            // lblClicDroit
            // 
            this.lblClicDroit.AutoSize = true;
            this.lblClicDroit.Location = new System.Drawing.Point(360, 9);
            this.lblClicDroit.Name = "lblClicDroit";
            this.lblClicDroit.Size = new System.Drawing.Size(57, 16);
            this.lblClicDroit.TabIndex = 3;
            this.lblClicDroit.Text = "ClicDroit";
            // 
            // lblPositionX
            // 
            this.lblPositionX.AutoSize = true;
            this.lblPositionX.Location = new System.Drawing.Point(488, 12);
            this.lblPositionX.Name = "lblPositionX";
            this.lblPositionX.Size = new System.Drawing.Size(63, 16);
            this.lblPositionX.TabIndex = 4;
            this.lblPositionX.Text = "PositionX";
            // 
            // lblPositionY
            // 
            this.lblPositionY.AutoSize = true;
            this.lblPositionY.Location = new System.Drawing.Point(630, 12);
            this.lblPositionY.Name = "lblPositionY";
            this.lblPositionY.Size = new System.Drawing.Size(64, 16);
            this.lblPositionY.TabIndex = 5;
            this.lblPositionY.Text = "PositionY";
            // 
            // lsbClavier
            // 
            this.lsbClavier.FormattingEnabled = true;
            this.lsbClavier.ItemHeight = 16;
            this.lsbClavier.Location = new System.Drawing.Point(12, 28);
            this.lsbClavier.Name = "lsbClavier";
            this.lsbClavier.Size = new System.Drawing.Size(167, 388);
            this.lsbClavier.TabIndex = 6;
            // 
            // butRAZ
            // 
            this.butRAZ.Location = new System.Drawing.Point(12, 422);
            this.butRAZ.Name = "butRAZ";
            this.butRAZ.Size = new System.Drawing.Size(167, 23);
            this.butRAZ.TabIndex = 7;
            this.butRAZ.Text = "RAZ";
            this.butRAZ.UseVisualStyleBackColor = true;
            this.butRAZ.Click += new System.EventHandler(this.butRAZ_Click);
            // 
            // tbxClicGauche
            // 
            this.tbxClicGauche.Location = new System.Drawing.Point(228, 28);
            this.tbxClicGauche.Name = "tbxClicGauche";
            this.tbxClicGauche.Size = new System.Drawing.Size(80, 22);
            this.tbxClicGauche.TabIndex = 8;
            // 
            // tbxPositionY
            // 
            this.tbxPositionY.Location = new System.Drawing.Point(633, 31);
            this.tbxPositionY.Name = "tbxPositionY";
            this.tbxPositionY.Size = new System.Drawing.Size(75, 22);
            this.tbxPositionY.TabIndex = 9;
            // 
            // tbxPositionX
            // 
            this.tbxPositionX.Location = new System.Drawing.Point(491, 31);
            this.tbxPositionX.Name = "tbxPositionX";
            this.tbxPositionX.Size = new System.Drawing.Size(73, 22);
            this.tbxPositionX.TabIndex = 10;
            // 
            // tbxClicDroit
            // 
            this.tbxClicDroit.Location = new System.Drawing.Point(363, 28);
            this.tbxClicDroit.Name = "tbxClicDroit";
            this.tbxClicDroit.Size = new System.Drawing.Size(70, 22);
            this.tbxClicDroit.TabIndex = 11;
            // 
            // FicClavierSouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxClicDroit);
            this.Controls.Add(this.tbxPositionX);
            this.Controls.Add(this.tbxPositionY);
            this.Controls.Add(this.tbxClicGauche);
            this.Controls.Add(this.butRAZ);
            this.Controls.Add(this.lsbClavier);
            this.Controls.Add(this.lblPositionY);
            this.Controls.Add(this.lblPositionX);
            this.Controls.Add(this.lblClicDroit);
            this.Controls.Add(this.lblClicGauche);
            this.Controls.Add(this.lblClavier);
            this.Controls.Add(this.pnlSouris);
            this.Name = "FicClavierSouris";
            this.Text = "FicClavierSouris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSouris;
        private System.Windows.Forms.Label lblClavier;
        private System.Windows.Forms.Label lblClicGauche;
        private System.Windows.Forms.Label lblClicDroit;
        private System.Windows.Forms.Label lblPositionX;
        private System.Windows.Forms.Label lblPositionY;
        private System.Windows.Forms.ListBox lsbClavier;
        private System.Windows.Forms.Button butRAZ;
        private System.Windows.Forms.TextBox tbxClicGauche;
        private System.Windows.Forms.TextBox tbxPositionY;
        private System.Windows.Forms.TextBox tbxPositionX;
        private System.Windows.Forms.TextBox tbxClicDroit;
    }
}