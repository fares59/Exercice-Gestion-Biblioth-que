using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Editeur : ModelBase<Editeur>
    {
        private string nom;
        public string Nom {
            get { return nom; }
            set
            {
                if (this.nom != value)
                {
                    this.nom = value;
                }
            }
        }
        public Editeur()
        {
        }
        
    }
}
