using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
    internal class Usure
    {
        private string etat;

        public Usure()
    { 
        etat = "";
    }

    public Usure(string _etat)
    {
        this.etat = _etat;
    }

    public string ToString()
    {
        return "Usure : " + etat ;

    }
}
}

