using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
    internal class Exemplaire
    {
        private string date_achat = "";
        private string emplacement = "";


        public DateTime  Date_achat { get => DateTime.Parse(date_achat); set => date_achat = value.ToString("yyyy-MM-dd"); }
        public string Emplacement { get => emplacement; set => emplacement = value; }



        public string ToString()
        {
            return "Achat  le : " + date_achat + emplacement + " emplacement : " ;
        }
    }

   


}

