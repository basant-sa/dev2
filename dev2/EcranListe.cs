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
    public partial class EcranListe : Form
        
    {
        string NomFichier = "";

        void Activer(bool etat)
        {
            lbPersonne.Enabled = etat;
            bAjouter.Enabled = etat;
            bSupprimer.Enabled = etat;
            bOuvrir.Enabled = etat;
            bEnregistrer.Enabled = etat;

            gbDetail.Enabled = !etat;
        }

        public EcranListe()
        {
            InitializeComponent();
        }

        private void EcranListe_Load(object sender, EventArgs e)
        {
            Activer(true);
            //cbQualite.SelectedIndex = 0;
        }

        private void bAjouter_Click(object sender, EventArgs e)

        {
            tbNom.Text = "";
            cbQualite.Text = "";
            Activer(false);
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                lbPersonne.Items.RemoveAt(lbPersonne.SelectedIndex);
            }
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            tbNom. Text = "";
            cbQualite.Text = "";
            Activer(true);
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text;
            string qualite= cbQualite.Text;

            lbPersonne.Items.Add (nom + (qualite));
            tbNom.Text = "";
            cbQualite.Text = "";
            Activer(true);
        }
    }
}
