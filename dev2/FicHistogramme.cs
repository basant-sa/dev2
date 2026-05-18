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
    public partial class FicHistogramme : Form
    {
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
    }
}
