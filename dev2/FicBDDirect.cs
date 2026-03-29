using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace dev2
{
    public partial class FicBDDirect : Form
    {

        string connectionString = "Data Source=S10.db;Version=3;";
        public FicBDDirect()
        {
            InitializeComponent();
        }

        private void bConsulter_Click(object sender, EventArgs e)
        {
            lbConsole.Items.Clear();


            using (SQLiteConnection conn = new SQLiteConnection(connectionString)) 
            { 
                conn.Open();

                string query = "SELECT * FROM Client";
                SQLiteCommand cmd =new SQLiteCommand(query, conn);

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string prenom = reader["Prenom"].ToString();
                    string nom = reader["NOM"].ToString();
                    string num = reader["NumCli"].ToString();

                    lbConsole.Items.Add(prenom + " " + nom + " (" + num + ")");

                }

            }

        }

        private void bDenombrer_Click(object sender, EventArgs e)
        {
            lbConsole.Items.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Client";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                lbConsole.Items.Add("Nombre de clients : " + count);
            }
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Client (NOM, Prenom) VALUES (@nom, @prenom)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@nom", tbNom.Text);
                cmd.Parameters.AddWithValue("@prenom", tbPrenom.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Client ajouté !");
        }
    }
}
