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
using System.IO;


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
            if (lbPersonne.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un élément");
                return;
            }

   
            int indexSupprime = lbPersonne.SelectedIndex;

           
            int encodageSupprime = SendMessage(
                lbPersonne.Handle,
                smLire,
                indexSupprime,
                0
            );

            
            lbPersonne.Items.RemoveAt(indexSupprime);

           
            for (int i = 0; i < lbPersonne.Items.Count; i++)
            {
                int encodage = SendMessage(
                    lbPersonne.Handle,
                    smLire,
                    i,
                    0
                );

                if (encodage > encodageSupprime)
                {
                    SendMessage(
                        lbPersonne.Handle,
                        smEcrire,
                        i,
                        encodage - 1
                    );
                }
            }

            
            counter--;
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
                lbPersonne.Items.Clear();
                counter = 0;

                foreach (string line in lignes)
                {
                    int pos = line.LastIndexOf("#");

                    string texte = line.Substring(0, pos);
                    int encodage = int.Parse(line.Substring(pos + 1));

                    lbPersonne.Items.Add(texte);
                    int index = lbPersonne.Items.Count - 1;

                    SendMessage(lbPersonne.Handle, smEcrire, index, encodage);

                    counter = Math.Max(counter, encodage);
                }

            }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (sfdEnregistrer.ShowDialog() == DialogResult.OK) 
            {
                NomFichier = sfdEnregistrer.FileName;
                StreamWriter sw = new StreamWriter(NomFichier);

                for (int i = 0; i < lbPersonne.Items.Count; i++)
                { 
                        string text=lbPersonne.Items[i].ToString();

                    int encodage = SendMessage(lbPersonne.Handle,smLire,
                        i,0);

                    sw.WriteLine(text + "#" + encodage);

                }
                sw.Close();

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
