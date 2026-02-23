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
    public partial class EcranEditeur : Form
    {

        string sFichier;
        bool bModifier;

        void FichierEnregistrer()
        {
            if (sFichier == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sFichier = saveFileDialog1.FileName;
                }
                else
                {
                    return;
                }
            }

            rtbTexte.SaveFile(sFichier, RichTextBoxStreamType.RichText);
            bModifier = false;
        }




        bool VerifierSauver()
        {
            if (bModifier)
            {
                DialogResult rep = MessageBox.Show(
                    "Voulez-vous enregistrer les modifications ?",
                    "Confirmation",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (rep == DialogResult.Yes)
                {
                    FichierEnregistrer();
                    return true;
                }
                else if (rep == DialogResult.No)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }


        public EcranEditeur()
        {
            InitializeComponent();
        }

        private void EcranEditeur_Load(object sender, EventArgs e)
        {
            bModifier=false;
            sFichier = "";
        }

        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            bModifier = true;
        }

        private void mnuNouveau_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver())
            
                return;

                rtbTexte.Clear();
                sFichier = "";
                bModifier = false;
            
        }

        private void pbNouveau_Click(object sender, EventArgs e)
        {
            mnuNouveau_Click(sender, e);
        }

        private void mnuOuvrir_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver())
            {
                return;
            }
            
                
                if (openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    sFichier=openFileDialog1.FileName;
                    rtbTexte.LoadFile(sFichier, RichTextBoxStreamType.RichText);
                    bModifier = false;
                }
            
        }

        private void pbOuvrir_Click(object sender, EventArgs e)
        {
            mnuOuvrir_Click(sender, e);
        }

        private void mnuEnregistrer_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void pbEnregistrer_Click(object sender, EventArgs e)
        {
            mnuEnregistrer_Click(sender, e);

        }

        private void mnuquitter_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver()) 
            
                return ;
                
                this.Close();
            
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            mnuquitter_Click(sender, e);
        }

        private void mnuCopier_Click(object sender, EventArgs e)
        {
            rtbTexte.Copy();
        }

        private void mnuCouper_Click(object sender, EventArgs e)
        {
            rtbTexte.Cut();
        }

        private void mnuColler_Click(object sender, EventArgs e)
        {
            rtbTexte.Paste();
        }

        private void mnuGauche_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void mnuCentre_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment=HorizontalAlignment.Center;
        }

        private void mnuDroite_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment=HorizontalAlignment.Right;
        }
    }
}
