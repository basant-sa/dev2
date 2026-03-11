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
    }
}
