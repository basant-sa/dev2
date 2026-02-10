namespace dev2
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.contrôlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barreDeProgressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrôlesToolStripMenuItem,
            this.applicationsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // contrôlesToolStripMenuItem
            // 
            this.contrôlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem,
            this.barreDeProgressionToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.contrôlesToolStripMenuItem.Name = "contrôlesToolStripMenuItem";
            this.contrôlesToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.contrôlesToolStripMenuItem.Text = "Contrôles";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // barreDeProgressionToolStripMenuItem
            // 
            this.barreDeProgressionToolStripMenuItem.Name = "barreDeProgressionToolStripMenuItem";
            this.barreDeProgressionToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.barreDeProgressionToolStripMenuItem.Text = "Barre de progression";
            this.barreDeProgressionToolStripMenuItem.Click += new System.EventHandler(this.barreDeProgressionToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.quitterToolStripMenuItem.Text = "Quitter  ";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeurToolStripMenuItem});
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // editeurToolStripMenuItem
            // 
            this.editeurToolStripMenuItem.Name = "editeurToolStripMenuItem";
            this.editeurToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editeurToolStripMenuItem.Text = "Editeur";
            this.editeurToolStripMenuItem.Click += new System.EventHandler(this.editeurToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aProposToolStripMenuItem.Text = "A Propos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem contrôlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barreDeProgressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
    }
}

