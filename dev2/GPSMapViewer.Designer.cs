namespace dev2
{
    partial class GPSMapViewer
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.ComChoice = new System.Windows.Forms.ComboBox();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.pnlBrowser = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(44, 38);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(121, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ComChoice
            // 
            this.ComChoice.FormattingEnabled = true;
            this.ComChoice.Items.AddRange(new object[] {
            "COM1",
            "COM2"});
            this.ComChoice.Location = new System.Drawing.Point(44, 8);
            this.ComChoice.Name = "ComChoice";
            this.ComChoice.Size = new System.Drawing.Size(121, 24);
            this.ComChoice.TabIndex = 1;
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(2, 67);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(187, 371);
            this.rtbData.TabIndex = 2;
            this.rtbData.Text = "";
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Location = new System.Drawing.Point(195, 8);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(601, 440);
            this.pnlBrowser.TabIndex = 3;
            // 
            // GPSMapViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBrowser);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.ComChoice);
            this.Controls.Add(this.btnOpen);
            this.Name = "GPSMapViewer";
            this.Text = "GPSMapViewer";
            this.Load += new System.EventHandler(this.GPSMapViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox ComChoice;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.Panel pnlBrowser;
    }
}