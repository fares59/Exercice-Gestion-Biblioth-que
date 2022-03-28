using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
    internal class Abonne
    {
        private string nom;
        private string prenom;
        private string adresse;
        private string telephone;
        private string email;
        private bool deleted;
        private DateTime date_adhesion;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value;}
        public string Adresse { get => adresse; set => adresse = value;}
        public string Telephone { get => telephone; set => telephone = value;}
        public string Email { get => email; set => email = value;}
        public bool Deleted { get => deleted; set => deleted = value; }
        public DateTime Date_adhesion { get => date_adhesion; set => date_adhesion = value;}

        public Abonne()
        {
            nom = "";
            prenom = "";
            email = "";
            telephone = "";
            deleted = false;
            date_adhesion = DateTime.Now;

        }
        public Abonne(string _nom,string _prenom, string _telephone, string _email, DateTime _date_adhesion)
        {
            this.nom = _nom;
            this.prenom = _prenom;
            this.telephone = _telephone;
            this.email = _email;
            this.date_adhesion = _date_adhesion;
        }
        
        public string ToString()
        {
            return "Nom : " + nom + " prenom : " + prenom + " email : " + email;
        }


    }
}
