using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Abonne
    {
        private string nom;
        private string prenom;
        private string adresse;
        private string telephone;
        private string email;
        private string date_adhesion;
        //private DateTime date_adhesion;
        //private Category? category;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value;}
        public string Adresse { get => adresse; set => adresse = value;}
        public string Telephone { get => telephone; set => telephone = value;}
        public string Email { get => email; set => email = value;}
        public DateTime Date_adhesion { get => DateTime.Parse(date_adhesion); set => date_adhesion = value.ToString("yyyy-MM-dd");}
        //internal Category? Category
        //{
        //    get => category;
        //    set
        //    {
        //        if (category != value)
        //        {
        //            category?.RemoveAbonne(this); //supprimer l'article de cetteCategory
        //            category = value;
        //            category?.AddAbonne(this); // ajouter l'article à ctte category
        //        }
        //    }
        //}
        public Abonne()
        {
            nom = "";
            prenom = "";
            email = "";
            telephone = "";
            date_adhesion = DateTime.Now.ToString("yyyy-MM-dd");

        }
        public Abonne(string _nom,string _prenom, string _telephone, string _email, DateTime _date_adhesion)
        {
            this.nom = _nom;
            this.prenom = _prenom;
            this.telephone = _telephone;
            this.email = _email;
            this.date_adhesion = _date_adhesion.ToString("yyyy-MM-dd");
        }
        
        public string ToString()
        {
            return "Nom : " + nom + " prenom : " + prenom + " email : " + email;
        }

    }
}
