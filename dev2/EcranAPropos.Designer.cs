namespace dev2
{
    partial class EcranAPropos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranAPropos));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfo.Controls.Add(this.btnFermer);
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Location = new System.Drawing.Point(21, 12);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(767, 279);
            this.panelInfo.TabIndex = 0;
            this.panelInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInfo_Paint);
            this.panelInfo.MouseEnter += new System.EventHandler(this.panelInfo_MouseEnter);
            this.panelInfo.MouseLeave += new System.EventHandler(this.panelInfo_MouseLeave);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(306, 247);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(106, 25);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "confirmer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            this.btnFermer.MouseEnter += new System.EventHandler(this.btnFermer_MouseEnter);
            this.btnFermer.MouseLeave += new System.EventHandler(this.btnFermer_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EcranAPropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInfo);
            this.Name = "EcranAPropos";
            this.Text = "EcranAPropos";
            this.Load += new System.EventHandler(this.EcranAPropos_Load);
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}