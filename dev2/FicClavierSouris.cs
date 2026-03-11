using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dev2
{
    public partial class FicClavierSouris : System.Windows.Forms.Form
    {

        private int nbGauche = 0;
        private int nbDroit = 0;

        private void AfficherClic()
        {
            tbxClicGauche.Text = nbGauche.ToString();
            tbxClicDroit.Text = nbDroit.ToString();
        }

        public FicClavierSouris()
        {
            InitializeComponent();
        }

        private void pnlSouris_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butRAZ_Click(object sender, EventArgs e)
        {

        }

        private void pnlSouris_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                nbGauche++;

            }

            else if (e.Button == MouseButtons.Right) 
            { 
                nbDroit++;
            
            }

            AfficherClic();

            int largeurCase = pnlSouris.Width / 3;
            int hauteurCase=pnlSouris.Height / 3;

            int colonne = e.X / largeurCase + 1;
            int ligne =e.Y / hauteurCase + 1;

            lsbClavier.Items.Add($"clic dans ligne{ligne},colonne{colonne}");

        }

        private void pnlSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbxPositionX.Text=e.X.ToString(); 
            tbxPositionY.Text=e.Y.ToString();

        }
    }
}
