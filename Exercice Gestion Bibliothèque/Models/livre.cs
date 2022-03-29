using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque.Models
{
    public class Livre
    {
        private string titre = "";
        private int isbc = 0;

        public string Titre1 { get => titre; set => titre = value; }
        public int Isbc { get => isbc; set => isbc = value; }
        public Livre(string titre, int iSBC)
        {
            Titre1 = titre;
            Isbc = iSBC;
        }
        public override string ToString()
        {
            string ToString = "le titre du livre " + Titre1 + "l'isbc correspondant " + Isbc;
            return ToString;
        } 
    }


}
