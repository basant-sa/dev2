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
    public partial class EcranSpirographe : System.Windows.Forms.Form
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
                int zoneX = 248;
                int zoneWidth = ClientSize.Width - zoneX;
                int zoneHeight = ClientSize.Height;

                using (SolidBrush b = new SolidBrush(cFond))
                {
                    e.Graphics.FillRectangle(
                        b,
                        new Rectangle(zoneX, 0, zoneWidth, zoneHeight)
                    );
                }

                using (Pen p = new Pen(cTrait))
                {
                    e.Graphics.DrawPath(p, gpSauvegarde);

                    Graphics g = e.Graphics;

                    int r = 60;
                    int xc = 120;
                    int yc = 120;

                    g.DrawEllipse(Pens.Black, xc - r, yc - r, 2 * r, 2 * r);

                    DateTime now = DateTime.Now;

                    double angleSec = Math.PI * 2 * now.Second / 60;

                    int xs = xc + (int)(r * 0.9 * Math.Sin(angleSec));
                    int ys = yc - (int)(r * 0.9 * Math.Cos(angleSec));

                    g.DrawLine(Pens.Red, xc, yc, xs, ys);
                }
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

        private void bGo_Click(object sender, EventArgs e)
        {
            int iSommets=tbSommets.Value;

            gpSauvegarde=new GraphicsPath();

            int zoneX = 248;
            int zoneWidth=ClientSize.Width - zoneX;
            int zoneHeight=ClientSize.Height;

            double xc = zoneX + zoneWidth / 2.0;
            double yc = zoneHeight / 2.0;

            double rayon = Math.Min(zoneWidth, zoneHeight) / 2.5;

            double[] sx = new double[iSommets+1];

            double[] sy = new double[iSommets + 1];

            for (int i =0; i <= iSommets; i++)
            {
                sx[i]= xc + rayon * Math.Cos(2 * Math.PI * i / iSommets);
                sy[i] = yc + rayon * Math.Sin(2 * Math.PI * i / iSommets);
            }

            int iDensite = tbDensites.Value;

            int iProfondeur = tbProfondeur.Value;

            if (iProfondeur <= 0)
                iProfondeur = 1;

            while (true)
            {
                 double distance = Math.Sqrt(
                    Math.Pow(sx[0] - xc, 2) +
                    Math.Pow(sy[0] - yc, 2));

                if (distance <= rayon * iProfondeur / 100.0)
                    break;

                 for (int i = 0; i < iSommets; i++)
                {
                    gpSauvegarde.AddLine(
                        (float)sx[i], (float)sy[i],
                        (float)sx[i + 1], (float)sy[i + 1]);
                }
                 
                for (int i = 0; i < iSommets; i++)
                {
                    sx[i] = sx[i] + (sx[i + 1] - sx[i]) / iDensite;
                    sy[i] = sy[i] + (sy[i + 1] - sy[i]) / iDensite;
                }

                
                sx[iSommets] = sx[0];
                sy[iSommets] = sy[0];
            }
            Invalidate();


        }

        private void timerHorloge_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();
            Invalidate();
        }  
    }
}
