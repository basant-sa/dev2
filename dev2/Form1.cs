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

        private void barreDeProgressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranProgression E= new EcranProgression();
            E.ShowDialog();
        }
    }
}
