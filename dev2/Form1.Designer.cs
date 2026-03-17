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
            this.S3 = new System.Windows.Forms.Button();
            this.S5 = new System.Windows.Forms.Button();
            this.S6 = new System.Windows.Forms.Button();
            this.S7 = new System.Windows.Forms.Button();
            this.S8 = new System.Windows.Forms.Button();
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
            this.editeurToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
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
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.aProposToolStripMenuItem.Text = "A Propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // S3
            // 
            this.S3.Location = new System.Drawing.Point(33, 83);
            this.S3.Name = "S3";
            this.S3.Size = new System.Drawing.Size(75, 23);
            this.S3.TabIndex = 2;
            this.S3.Text = "S3";
            this.S3.UseVisualStyleBackColor = true;
            this.S3.Click += new System.EventHandler(this.S3_Click);
            // 
            // S5
            // 
            this.S5.Location = new System.Drawing.Point(163, 83);
            this.S5.Name = "S5";
            this.S5.Size = new System.Drawing.Size(75, 23);
            this.S5.TabIndex = 3;
            this.S5.Text = "S5";
            this.S5.UseVisualStyleBackColor = true;
            this.S5.Click += new System.EventHandler(this.S5_Click);
            // 
            // S6
            // 
            this.S6.Location = new System.Drawing.Point(316, 83);
            this.S6.Name = "S6";
            this.S6.Size = new System.Drawing.Size(75, 23);
            this.S6.TabIndex = 4;
            this.S6.Text = "S6";
            this.S6.UseVisualStyleBackColor = true;
            this.S6.Click += new System.EventHandler(this.S6_Click);
            // 
            // S7
            // 
            this.S7.Location = new System.Drawing.Point(467, 83);
            this.S7.Name = "S7";
            this.S7.Size = new System.Drawing.Size(75, 23);
            this.S7.TabIndex = 5;
            this.S7.Text = "S7";
            this.S7.UseVisualStyleBackColor = true;
            this.S7.Click += new System.EventHandler(this.S7_Click);
            // 
            // S8
            // 
            this.S8.Location = new System.Drawing.Point(600, 82);
            this.S8.Name = "S8";
            this.S8.Size = new System.Drawing.Size(75, 23);
            this.S8.TabIndex = 6;
            this.S8.Text = "S8";
            this.S8.UseVisualStyleBackColor = true;
            this.S8.Click += new System.EventHandler(this.S8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.S8);
            this.Controls.Add(this.S7);
            this.Controls.Add(this.S6);
            this.Controls.Add(this.S5);
            this.Controls.Add(this.S3);
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
        private System.Windows.Forms.Button S3;
        private System.Windows.Forms.Button S5;
        private System.Windows.Forms.Button S6;
        private System.Windows.Forms.Button S7;
        private System.Windows.Forms.Button S8;
    }
}

