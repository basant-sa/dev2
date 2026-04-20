using dev2.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dev2.Acces
{
    public class PersonneDAL
    {
        string cnx = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;
        public List<Personne> GetAll()
        {
            List<Personne> list = new List<Personne>();

            using (SqlConnection con = new SqlConnection(cnx))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Personne", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Personne p = new Personne();
                    p.Id = (int)dr["Id"];
                    p.Nom = dr["Nom"].ToString();
                    p.Age = (int)dr["Age"];

                    list.Add(p);
                }
            }
            return list;
        }

        public void Ajouter(Personne p)
        {
            using (SqlConnection con = new SqlConnection(cnx))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Personne (Nom, Age) VALUES (@Nom, @Age)", con);

                cmd.Parameters.AddWithValue("@Nom", p.Nom);
                cmd.Parameters.AddWithValue("@Age", p.Age);

                cmd.ExecuteNonQuery();
            }
        }


        public void Supprimer(int id)
        {
            using (SqlConnection con = new SqlConnection(cnx))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Personne WHERE Id = @Id", con);

                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void Modifier(Personne p)
        {
            using (SqlConnection con = new SqlConnection(cnx))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Personne SET Nom = @Nom, Age = @Age WHERE Id = @Id", con);

                cmd.Parameters.AddWithValue("@Id", p.Id);
                cmd.Parameters.AddWithValue("@Nom", p.Nom);
                cmd.Parameters.AddWithValue("@Age", p.Age);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
