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
    }
}
