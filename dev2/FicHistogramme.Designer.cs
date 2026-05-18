namespace dev2
{
    partial class FicHistogramme
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
            this.bCreer = new System.Windows.Forms.Button();
            this.bDessiner = new System.Windows.Forms.Button();
            this.pDessin = new System.Windows.Forms.Panel();
            this.lbMonPoint = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bCreer
            // 
            this.bCreer.Location = new System.Drawing.Point(24, 12);
            this.bCreer.Name = "bCreer";
            this.bCreer.Size = new System.Drawing.Size(75, 23);
            this.bCreer.TabIndex = 0;
            this.bCreer.Text = "Creer";
            this.bCreer.UseVisualStyleBackColor = true;
            this.bCreer.Click += new System.EventHandler(this.bCreer_Click);
            // 
            // bDessiner
            // 
            this.bDessiner.Location = new System.Drawing.Point(24, 67);
            this.bDessiner.Name = "bDessiner";
            this.bDessiner.Size = new System.Drawing.Size(75, 23);
            this.bDessiner.TabIndex = 1;
            this.bDessiner.Text = "Dessiner";
            this.bDessiner.UseVisualStyleBackColor = true;
            this.bDessiner.Click += new System.EventHandler(this.bDessiner_Click);
            // 
            // pDessin
            // 
            this.pDessin.Location = new System.Drawing.Point(176, 12);
            this.pDessin.Name = "pDessin";
            this.pDessin.Size = new System.Drawing.Size(612, 434);
            this.pDessin.TabIndex = 2;
            this.pDessin.Paint += new System.Windows.Forms.PaintEventHandler(this.pDessin_Paint);
            // 
            // lbMonPoint
            // 
            this.lbMonPoint.FormattingEnabled = true;
            this.lbMonPoint.ItemHeight = 16;
            this.lbMonPoint.Location = new System.Drawing.Point(24, 132);
            this.lbMonPoint.Name = "lbMonPoint";
            this.lbMonPoint.Size = new System.Drawing.Size(120, 276);
            this.lbMonPoint.TabIndex = 3;
            // 
            // FicHistogramme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMonPoint);
            this.Controls.Add(this.pDessin);
            this.Controls.Add(this.bDessiner);
            this.Controls.Add(this.bCreer);
            this.Name = "FicHistogramme";
            this.Text = "FicHistogramme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCreer;
        private System.Windows.Forms.Button bDessiner;
        private System.Windows.Forms.Panel pDessin;
        private System.Windows.Forms.ListBox lbMonPoint;
    }
}