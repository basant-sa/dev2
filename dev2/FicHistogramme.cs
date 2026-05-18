using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace dev2
{
    public partial class FicHistogramme : Form
    {
        ArrayList alData = new ArrayList();
        Random rnd = new Random();
        public FicHistogramme()
        {
            InitializeComponent();
        }

        public class MonPoint
        {
            private int x;
            private int y;

            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public MonPoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public override string ToString()
            {
                return "(" + x + ", " + y + ")";
            }
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            alData.Clear();
            lbMonPoint.Items.Clear();

            int nbPoints = rnd.Next(5,30); 

            int currentX = 0;

            for (int i = 0; i < nbPoints; i++)
            {
                currentX += rnd.Next(1,11);
                int y = rnd.Next(-100,101);

                MonPoint p = new MonPoint(currentX, y);

                alData.Add(p);
                lbMonPoint.Items.Add(p);


            }
        }

        private void bDessiner_Click(object sender, EventArgs e)
        {
            pDessin.Invalidate();
        }

        private void pDessin_Paint(object sender, PaintEventArgs e)
        {
            if (alData.Count == 0) return;

            Graphics g = e.Graphics;

            
            int W = pDessin.ClientSize.Width;
            int H = pDessin.ClientSize.Height;

            MonPoint last = (MonPoint)alData[alData.Count - 1];
            int maxX = last.X;
            if (maxX == 0) maxX = 1;   

            int baseline = H / 2;
            g.DrawLine(Pens.Gray, 0, baseline, W, baseline);

            Pen pen = new Pen(Color.Blue, 2);

            for (int i = 0; i < alData.Count; i++)
            {
                MonPoint p = (MonPoint)alData[i];

                int screenX = (int)((double)p.X / maxX * W);
                int screenY = (int)(baseline - ((double)p.Y / 100.0) * baseline);

                g.DrawLine(pen, screenX, baseline, screenX, screenY);
            }

            pen.Dispose();
        }
    }
}
