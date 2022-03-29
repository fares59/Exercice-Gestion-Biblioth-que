using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Category
    {
        private string titre;
        //private List<Abonne> abonnes = new();

        public string Titre { get => titre; set => titre = value; }

        //public List<Abonne> Abonnes { get => abonnes;}

        public Category()
        {
            this.Titre = "";
        }
        public Category(string _titre)
        {
            this.Titre = _titre;
        }
        public string ToString()
        {
            return "categorie professionnelle : " + titre;
        }
        //public void AddAbonne(Abonne abonne)
        //{
        //    if (!abonnes.Contains(abonne))
        //    {
        //        abonnes.Add(abonne);
        //    }
        //    if (abonne.Category != this)
        //    {
        //        abonne.Category = this;
        //    }
        //}
        //public void RemoveAbonne(Abonne abonne)
        //{
        //    if (abonne != null && abonnes.Contains(abonne))
        //    {
        //        if (abonne.Category == this)
        //        {
        //            abonne.Category = null;
        //        }
        //        abonnes.Remove(abonne);
        //    }
        //}
    }
}
