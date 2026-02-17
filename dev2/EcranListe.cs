using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace dev2
{
    public partial class EcranListe : Form
        
    {
        [DllImport("user32.dll",EntryPoint ="SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int smLire = 0x0199;
        private const int smEcrire = 0x019A;

        private int counter = 0;

        string NomFichier = "";
        int indexModifier = -1;
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
            cbQualite.SelectedIndex = -1;
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
            cbQualite.SelectedIndex = -1;
            Activer(true);
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text == "" || cbQualite.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;

            }

            string text = tbNom.Text + "(" + cbQualite.Text + ")";

            lbPersonne.Items.Add(text);

            int index  = lbPersonne.Items.Count - 1;

            counter++;

            SendMessage(lbPersonne.Handle, smEcrire, index, counter);

            tbNom.Text = "";
            cbQualite.SelectedIndex = -1;

            Activer (true);
        }

        private void bOuvrir_Click(object sender, EventArgs e)
        {
           if (ofdOuvrir.ShowDialog()==DialogResult.OK)
           {

                NomFichier=ofdOuvrir.FileName;
                lbPersonne.Items.Clear();
                 string[] lignes= System.IO.File.ReadAllLines(NomFichier);
                foreach (string line in lignes) 
                {
                    lbPersonne.Items.Add(line);
                }
           }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (sfdEnregistrer.ShowDialog() == DialogResult.OK) 
            {
                NomFichier = sfdEnregistrer.FileName;
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(NomFichier)) 
                {
                    foreach(string item in lbPersonne.Items)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
        }

        private void lbPersonne_DoubleClick(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex == -1)
                    return;
            string contenu=lbPersonne.SelectedItem.ToString();

            int index=lbPersonne.SelectedIndex;
            int encodage = SendMessage(lbPersonne.Handle, smLire, index, 0);

            MessageBox.Show("Contenu : " + contenu +
                                "\nIndex : " + index +
                                "\nEncodage : " + encodage,
                                "Information");

            
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                indexModifier = lbPersonne.SelectedIndex;

                string texte = lbPersonne.SelectedItem.ToString();

                int pos1 = texte.IndexOf("(");
                int pos2 = texte.IndexOf(")");

                tbNom.Text = texte.Substring(0, pos1).Trim();
                cbQualite.Text = texte.Substring(pos1 + 1, pos2 - pos1 - 1);

                Activer(false);
            }
        }
    }
}
