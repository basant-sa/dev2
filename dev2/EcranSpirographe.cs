using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace dev2
{
    public partial class EcranSpirographe : Form
    {
        private Color cFond;
        private Color cTrait;
        private GraphicsPath gpSauvegarde;

        public EcranSpirographe()
        {
            InitializeComponent();

            cFond=Color.White;
            cTrait=Color.Black;

            gpSauvegarde=null;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (gpSauvegarde != null) 
            {
                e.Graphics.FillRectangle
                    (
                    new SolidBrush(cFond),
                    new Rectangle (new Point(248,0),ClientSize)
                    );
                e.Graphics.DrawPath(new Pen(cTrait), gpSauvegarde);

            }
        }

        private void BFond_Click(object sender, EventArgs e)
        {
            if(cdCouleur.ShowDialog()== DialogResult.OK)
            {
                cFond=cdCouleur.Color;
                Invalidate(new Rectangle(new Point(280, 0), ClientSize));
            }
        }

        private void bTrait_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK) 
            {
                cTrait=cdCouleur.Color; 
                Invalidate(new Rectangle(new Point(248,0), ClientSize));    
            }
        }
    }
}
