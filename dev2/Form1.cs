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
    public partial class Form1 : Form
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
    }
}
