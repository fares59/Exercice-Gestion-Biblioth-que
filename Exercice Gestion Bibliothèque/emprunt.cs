using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
   public class Emprunt // Protected pour sécuriser l'accès à la classe 
   {
            // Initialisation des variables
            private string date_emprunt;
            private string date_sortie;
            private bool deleted = false;

        public DateTime Date_emprunt { get => DateTime.Parse(date_emprunt); set => date_emprunt = value.ToString("yyyy-MM-dd"); }
        public DateTime Date_sortie { get => DateTime.Parse(date_sortie); set => date_sortie = value.ToString("yyyy-MM-dd"); }
        public bool Deleted { get; set; } = false;



        public  Emprunt(string emprunt, string sortie)
            {
                date_emprunt = emprunt;
                date_sortie = sortie;

                
            }

        public Emprunt() { }


        public override string ToString()
        {
            string toString = "Le livre a été emprunté le " + date_sortie +
                "il a été retourné le " + date_emprunt
                ;

            return toString;
        }
   }
}
