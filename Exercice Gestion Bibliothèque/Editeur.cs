using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
    internal class Editeur
    {
        private string nom;
        private bool deleted;

        public string Nom { get => nom; set => nom = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
        public Editeur()
        {
            nom = "";
            deleted = false;

        }
        public Editeur(string _nom)
        {
            this.Nom = _nom;
        }
        public string ToString() 
        { 
            return "Nom d'éditeur : " + nom;
        }
    }
}
