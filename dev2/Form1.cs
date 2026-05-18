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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void barreDeProgressionToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    EcranProgression E= new EcranProgression();
        //    E.ShowDialog();
        //}


        private void MethodeNonImplemente()
        {
            MessageBox.Show("Fonction non implémentée.");
            
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodeNonImplemente();
        }

        private void editeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodeNonImplemente();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barreDeProgressionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EcranProgression E = new EcranProgression();
            E.ShowDialog();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranAPropos F = new EcranAPropos();
            F.ShowDialog();
        }

        private void S3_Click(object sender, EventArgs e)
        {
            EcranListe L=new EcranListe();
            L.ShowDialog();
        }

        private void S5_Click(object sender, EventArgs e)
        {
            EcranEditeur R = new EcranEditeur();
            R.ShowDialog();
        }

        private void S6_Click(object sender, EventArgs e)
        {
            EcranSpirographe P =new EcranSpirographe();
            P.ShowDialog();
        }

        private void S7_Click(object sender, EventArgs e)
        {
            FicClavierSouris F=new FicClavierSouris();
            F.ShowDialog();
        }

        private void S8_Click(object sender, EventArgs e)
        {
            EcranExplorateur P=new EcranExplorateur();
            P.ShowDialog();
        }

        private void S9_Click(object sender, EventArgs e)
        {
            GPSMapViewer G=new GPSMapViewer();
            G.ShowDialog();
        }

        private void S10_Click(object sender, EventArgs e)
        {
            FicBDDirect F = new FicBDDirect();
            F.ShowDialog();

        }

        private void S12_Click(object sender, EventArgs e)
        {
            S12 S=new S12();

            S.ShowDialog();
        }

        private void S14_Click(object sender, EventArgs e)
        {
            S14 S = new S14();
            S.ShowDialog();
        }

        private void Histogramme_Click(object sender, EventArgs e)
        {
            FicHistogramme H= new FicHistogramme();  
            H.Show();
        }
    }
}
