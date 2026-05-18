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
    }
}
