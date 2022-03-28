using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
    internal class Auteur
    {
        private string nom = "";
        private string prenom = "";
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public Auteur()
        {
        }

        public Auteur(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public void toString {
               
        }


    }
}
