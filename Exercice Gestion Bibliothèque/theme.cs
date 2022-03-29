using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
    internal class Theme
    {
        private string titre = "";

        //List<Livre> livres = new();
        public string Titre { get => titre; set => titre = value; }

        //internal List<Livre> Livres { get => livres; set => livres = value; }
        public Theme()
        {
        }

        public Theme(string titre)
        {
            this.titre = titre;
        }
        public override string ToString()
        {
            string toString = "titre" + titre;

            return toString;
        }

        //public void AddLivre(Livre livre)
        //{
        //    if (!livres.Contains(livre))
        //    {
        //        livres.Add(livre);
        //    }
        //    if (!livre.Themes.Contains(this))
        //    {
        //        livre.Themes.Add(this);
        //    }
        //}
    }
}
