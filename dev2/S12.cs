using dev2.Classes;
using dev2.Gestion;
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
    public partial class S12 : Form
    {
        public S12()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Personne p = new Personne();
            p.Nom=txtnom.Text;
            p.Age=int.Parse(txtage.Text);
            

            PersonneManager manager = new PersonneManager();
            manager.AjouterPersonne(p);

            MessageBox.Show("Ajout réussi !");
        
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                PersonneManager manager = new PersonneManager();
                manager.SupprimerPersonne(id);

                MessageBox.Show("Suppression réussie !");

                dataGridView1.DataSource = manager.GetAllPersonnes();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne !");
            }
        }

        private void S12_Load(object sender, EventArgs e)
        {
            PersonneManager manager = new PersonneManager();
            dataGridView1.DataSource = manager.GetAllPersonnes();
        }

        private void txtupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Personne p = new Personne();

                p.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                p.Nom = txtnom.Text;
                p.Age = int.Parse(txtage.Text);

                PersonneManager manager = new PersonneManager();
                manager.ModifierPersonne(p);

                MessageBox.Show("Modification réussie !");

                dataGridView1.DataSource = manager.GetAllPersonnes();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtnom.Text = dataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString();
                txtage.Text = dataGridView1.SelectedRows[0].Cells["Age"].Value.ToString();
            }
        }
    }
}
