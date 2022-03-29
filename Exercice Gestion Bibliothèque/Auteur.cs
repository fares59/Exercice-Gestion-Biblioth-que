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

        //List<Livre> livres = new ();
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        //internal List<Livre> Livres { get => livres; set => livres = value; }
        public Auteur(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public override string ToString()
        {
            string tostring = "nom" + nom + "prenom" + prenom;

            return tostring;
        }

        //public void AddLivre(Livre livre)
        //{
        //    if (!livres.Contains(livre))
        //    {
        //        livres.Add(livre);
        //    }
        //    if (!livre.Auteurs.Contains(this))
        //    {
        //        livre.Auteurs.Add(this);
        //    }
        //}

    }
}
