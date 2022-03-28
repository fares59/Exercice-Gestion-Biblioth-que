using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
    internal class Mots_cle
    {
        private string mot;
        private bool deleted;
        private List<Livre> livres = new();
        public string Mot { get => mot; set => mot = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
        internal List<Livre> Livres { get => livres; set => livres = value; }

        public Mots_cle()
        {
            mot = "";
            deleted = false;
        }
        public Mots_cle(string _mot, bool _deleted)
        {
            this.mot = _mot;
        }
        
        public string ToString()
        {
            return mot;
        }
        public void AddLivre(Livre livre)
        {
            if (!livres.Contains(livre))
            {
                livres.Add(livre);
            }
            if (!livre.Mots_cle.Contains(this))
            {
                livre.Mots_cle.Add(this) ;
            }
        }
        //public void RemoveLivre(Livre livre)
        //{
        //    if (livre != null && livres.Contains(livre))
        //    {
        //        if (livre.Mots_cle == this)
        //        {
        //            livre.Category = null;
        //        }
        //        livres.Remove(livre);
        //    }
        //}
    }
}
