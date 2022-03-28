using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
    internal class auteur
    {
        private string nom = "";
        private string prenom = "";
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public auteur()
        {
        }

        public auteur(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }



    }
}
