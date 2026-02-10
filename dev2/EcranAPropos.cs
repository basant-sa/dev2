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
    public partial class EcranAPropos : Form
    {

        private Cursor curseurOriginal;
        public EcranAPropos()
        {
            InitializeComponent();
        }

        private void EcranAPropos_Load(object sender, EventArgs e)
        {
            
        }

        private void panelInfo_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void panelInfo_MouseEnter(object sender, EventArgs e)
        {
            curseurOriginal = this.Cursor;
            this.Cursor = Cursors.Hand;
            panelInfo.BackColor = Color.AliceBlue;
        }

        private void panelInfo_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = curseurOriginal;
            panelInfo.BackColor = Color.White;
        }

        private void btnFermer_MouseEnter(object sender, EventArgs e)
        {
            curseurOriginal = this.Cursor;
            this.Cursor = Cursors.Hand;
            btnFermer.BackColor = Color.AliceBlue;

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFermer_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = curseurOriginal;
            btnFermer.BackColor = SystemColors.Control;
        }
    }
}
