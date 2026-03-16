namespace dev2
{
    partial class EcranExplorateur
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExplorateur));
            this.tsCommandes = new System.Windows.Forms.ToolStrip();
            this.tsbQuitter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsaDetail = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsaPetitesIconesSS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaGrandesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaListe = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMessage = new System.Windows.Forms.StatusStrip();
            this.slMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tvRepertoire = new System.Windows.Forms.SplitContainer();
            this.tvRepertoiree = new System.Windows.Forms.TreeView();
            this.lvFichiers = new System.Windows.Forms.ListView();
            this.NOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAIL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CREA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MODI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilTreeView = new System.Windows.Forms.ImageList(this.components);
            this.ilGrand = new System.Windows.Forms.ImageList(this.components);
            this.ilPetit = new System.Windows.Forms.ImageList(this.components);
            this.tsCommandes.SuspendLayout();
            this.ssMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvRepertoire)).BeginInit();
            this.tvRepertoire.Panel1.SuspendLayout();
            this.tvRepertoire.Panel2.SuspendLayout();
            this.tvRepertoire.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCommandes
            // 
            this.tsCommandes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsCommandes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuitter,
            this.toolStripSeparator1,
            this.tsaDetail});
            this.tsCommandes.Location = new System.Drawing.Point(0, 0);
            this.tsCommandes.Name = "tsCommandes";
            this.tsCommandes.Size = new System.Drawing.Size(800, 27);
            this.tsCommandes.TabIndex = 0;
            this.tsCommandes.Text = "toolStrip1";
            // 
            // tsbQuitter
            // 
            this.tsbQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQuitter.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuitter.Image")));
            this.tsbQuitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuitter.Name = "tsbQuitter";
            this.tsbQuitter.Size = new System.Drawing.Size(29, 24);
            this.tsbQuitter.Text = "Quitter";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsaDetail
            // 
            this.tsaDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsaDetail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsaPetitesIconesSS,
            this.tsaGrandesIcones,
            this.tsaListe,
            this.detailToolStripMenuItem});
            this.tsaDetail.Image = ((System.Drawing.Image)(resources.GetObject("tsaDetail.Image")));
            this.tsaDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsaDetail.Name = "tsaDetail";
            this.tsaDetail.Size = new System.Drawing.Size(34, 24);
            this.tsaDetail.Text = "Apparence";
            // 
            // tsaPetitesIconesSS
            // 
            this.tsaPetitesIconesSS.Name = "tsaPetitesIconesSS";
            this.tsaPetitesIconesSS.Size = new System.Drawing.Size(188, 26);
            this.tsaPetitesIconesSS.Text = "PetitesIcones";
            // 
            // tsaGrandesIcones
            // 
            this.tsaGrandesIcones.Name = "tsaGrandesIcones";
            this.tsaGrandesIcones.Size = new System.Drawing.Size(188, 26);
            this.tsaGrandesIcones.Text = "GrandesIcones";
            // 
            // tsaListe
            // 
            this.tsaListe.Name = "tsaListe";
            this.tsaListe.Size = new System.Drawing.Size(188, 26);
            this.tsaListe.Text = "Liste";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.detailToolStripMenuItem.Text = "Detail";
            // 
            // ssMessage
            // 
            this.ssMessage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slMessage});
            this.ssMessage.Location = new System.Drawing.Point(0, 424);
            this.ssMessage.Name = "ssMessage";
            this.ssMessage.Size = new System.Drawing.Size(800, 26);
            this.ssMessage.TabIndex = 1;
            this.ssMessage.Text = "statusStrip1";
            // 
            // slMessage
            // 
            this.slMessage.Name = "slMessage";
            this.slMessage.Size = new System.Drawing.Size(67, 20);
            this.slMessage.Text = "Message";
            // 
            // tvRepertoire
            // 
            this.tvRepertoire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRepertoire.Location = new System.Drawing.Point(0, 27);
            this.tvRepertoire.Name = "tvRepertoire";
            // 
            // tvRepertoire.Panel1
            // 
            this.tvRepertoire.Panel1.Controls.Add(this.tvRepertoiree);
            // 
            // tvRepertoire.Panel2
            // 
            this.tvRepertoire.Panel2.Controls.Add(this.lvFichiers);
            this.tvRepertoire.Size = new System.Drawing.Size(800, 397);
            this.tvRepertoire.SplitterDistance = 266;
            this.tvRepertoire.TabIndex = 2;
            // 
            // tvRepertoiree
            // 
            this.tvRepertoiree.ImageIndex = 0;
            this.tvRepertoiree.ImageList = this.ilTreeView;
            this.tvRepertoiree.Location = new System.Drawing.Point(3, 3);
            this.tvRepertoiree.Name = "tvRepertoiree";
            this.tvRepertoiree.SelectedImageIndex = 0;
            this.tvRepertoiree.Size = new System.Drawing.Size(260, 391);
            this.tvRepertoiree.TabIndex = 0;
            // 
            // lvFichiers
            // 
            this.lvFichiers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NOM,
            this.TAIL,
            this.CREA,
            this.MODI});
            this.lvFichiers.FullRowSelect = true;
            this.lvFichiers.HideSelection = false;
            this.lvFichiers.LargeImageList = this.ilGrand;
            this.lvFichiers.Location = new System.Drawing.Point(-7, 3);
            this.lvFichiers.Name = "lvFichiers";
            this.lvFichiers.Size = new System.Drawing.Size(534, 391);
            this.lvFichiers.SmallImageList = this.ilPetit;
            this.lvFichiers.TabIndex = 0;
            this.lvFichiers.UseCompatibleStateImageBehavior = false;
            this.lvFichiers.View = System.Windows.Forms.View.Details;
            // 
            // NOM
            // 
            this.NOM.Text = "Nom";
            this.NOM.Width = 345;
            // 
            // TAIL
            // 
            this.TAIL.Text = "Taille";
            // 
            // CREA
            // 
            this.CREA.Text = "Ceation";
            // 
            // MODI
            // 
            this.MODI.Text = "Modification";
            // 
            // ilTreeView
            // 
            this.ilTreeView.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilTreeView.ImageSize = new System.Drawing.Size(16, 16);
            this.ilTreeView.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilGrand
            // 
            this.ilGrand.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilGrand.ImageSize = new System.Drawing.Size(16, 16);
            this.ilGrand.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilPetit
            // 
            this.ilPetit.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilPetit.ImageSize = new System.Drawing.Size(16, 16);
            this.ilPetit.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // EcranExplorateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvRepertoire);
            this.Controls.Add(this.ssMessage);
            this.Controls.Add(this.tsCommandes);
            this.Name = "EcranExplorateur";
            this.Text = "EcranExplorateur";
            this.Load += new System.EventHandler(this.EcranExplorateur_Load);
            this.tsCommandes.ResumeLayout(false);
            this.tsCommandes.PerformLayout();
            this.ssMessage.ResumeLayout(false);
            this.ssMessage.PerformLayout();
            this.tvRepertoire.Panel1.ResumeLayout(false);
            this.tvRepertoire.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tvRepertoire)).EndInit();
            this.tvRepertoire.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCommandes;
        private System.Windows.Forms.ToolStripButton tsbQuitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsaDetail;
        private System.Windows.Forms.ToolStripMenuItem tsaPetitesIconesSS;
        private System.Windows.Forms.ToolStripMenuItem tsaGrandesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsaListe;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssMessage;
        private System.Windows.Forms.ToolStripStatusLabel slMessage;
        private System.Windows.Forms.SplitContainer tvRepertoire;
        private System.Windows.Forms.TreeView tvRepertoiree;
        private System.Windows.Forms.ListView lvFichiers;
        private System.Windows.Forms.ColumnHeader NOM;
        private System.Windows.Forms.ColumnHeader TAIL;
        private System.Windows.Forms.ColumnHeader CREA;
        private System.Windows.Forms.ColumnHeader MODI;
        private System.Windows.Forms.ImageList ilTreeView;
        private System.Windows.Forms.ImageList ilGrand;
        private System.Windows.Forms.ImageList ilPetit;
    }
}