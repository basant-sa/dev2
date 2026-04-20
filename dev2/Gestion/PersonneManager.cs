using dev2.Acces;
using dev2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev2.Gestion
{
    public class PersonneManager
    {

        PersonneDAL dal = new PersonneDAL();

        public List<Personne> GetAllPersonnes()
        {
            return dal.GetAll();
        }

        public void AjouterPersonne(Personne p)
        {
            dal.Ajouter(p);
        }

        public void SupprimerPersonne(int id)
        {
            dal.Supprimer(id);
        }

        public void ModifierPersonne(Personne p)
        {
            dal.Modifier(p);
        }
    }
}
