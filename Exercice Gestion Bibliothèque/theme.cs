using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
    internal class theme
    {
        private string titre = "";
        public string Titre { get => titre; set => titre = value; }

        public theme()
        {
        }

        public theme(string titre)
        {
            this.titre = titre;
        }

    }
}
