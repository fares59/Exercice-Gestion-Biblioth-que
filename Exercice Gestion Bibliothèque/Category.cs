using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
    internal class Category
    {
        private string titre;
        private bool deleted;

        public string Titre { get => titre; set => titre = value; }
        public bool Deleted { get => deleted; set => deleted = value; }

        public Category()
        {
            this.Titre = "";
            this.Deleted = false;
        }
        public Category(string _titre)
        {
            this.Titre = _titre;
        }

        
    }
}
