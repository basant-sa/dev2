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
    public partial class S14 : Form
    {
        public S14()
        {
            InitializeComponent();
        }
        double AireTrapeze(double f1, double f2, double h)
        {
            return (f1 + f2) * h / 2;
        }

        double fPolynome(double x)
        {
            return x * x + 2;
        }

        double fTrigo(double x)
        {
            return Math.Sin(x);
        }

        delegate double fctAIntegrer(double x);

        double IntegrationTrapeze(fctAIntegrer f, double a, double b, int n)
        {
            double h = (b - a) / n;
            double somme = 0;

            for (int i = 0; i < n; i++)
            {
                double x1 = a + i * h;
                double x2 = x1 + h;

                somme += AireTrapeze(f(x1), f(x2), h);
            }

            return somme;
        }

        private void Polynome_Click(object sender, EventArgs e)
        {
            lbResultats.Items.Clear();

            double a = double.Parse(tbGauche.Text);
            double b = double.Parse(tbDroite.Text);
            int n = int.Parse(tbNbInt.Text);

            for (int i = 0; i < 5; i++)
            {
                double h = (b - a) / n;
                double somme = 0;

                for (int j = 0; j < n; j++)
                {
                    double x1 = a + j * h;
                    double x2 = x1 + h;

                    double f1 = x1 * x1 + 2;
                    double f2 = x2 * x2 + 2;

                    somme += AireTrapeze(f1, f2, h);
                }

                lbResultats.Items.Add("Nb Int: " + n + " => " + somme);

                n *= 2;
            }
        }

        private void Trigonométrique_Click(object sender, EventArgs e)
        {
            lbResultats.Items.Clear();

            double a = double.Parse(tbGauche.Text);
            double b = double.Parse(tbDroite.Text);
            int n = int.Parse(tbNbInt.Text);

            for (int i = 0; i < 5; i++)
            {
                double h = (b - a) / n;
                double somme = 0;

                for (int j = 0; j < n; j++)
                {
                    double x1 = a + j * h;
                    double x2 = x1 + h;

                    double f1 = Math.Sin(x1);
                    double f2 = Math.Sin(x2);

                    somme += AireTrapeze(f1, f2, h);
                }

                lbResultats.Items.Add("Nb Int: " + n + " => " + somme);

                n *= 2;
            }
        }

        private void Idem_Pointeur_Click(object sender, EventArgs e)
        {
            lbResultats.Items.Clear();

            double a = double.Parse(tbGauche.Text);
            double b = double.Parse(tbDroite.Text);
            int n = int.Parse(tbNbInt.Text);

            for (int i = 0; i < 5; i++)
            {
                double res = IntegrationTrapeze(fPolynome, a, b, n);

                lbResultats.Items.Add("Nb Int: " + n + " => " + res);

                n *= 2;
            }
        }

        private void IdemPointeur_Click(object sender, EventArgs e)
        {
            lbResultats.Items.Clear();

            double a = double.Parse(tbGauche.Text);
            double b = double.Parse(tbDroite.Text);
            int n = int.Parse(tbNbInt.Text);

            for (int i = 0; i < 5; i++)
            {
                double res = IntegrationTrapeze(fTrigo, a, b, n);

                lbResultats.Items.Add("Nb Int: " + n + " => " + res);

                n *= 2;
            }
        }
    }
}
