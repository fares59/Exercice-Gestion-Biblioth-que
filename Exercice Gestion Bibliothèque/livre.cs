﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
    internal class livre
    {
        private string titre = "";
        private int ISBC = 0;

        public string Titre { get => titre; set => titre = value; }
        public int ISBC1 { get => ISBC; set => ISBC = value; }

        public livre()
        {
          
        }

        public livre(string titre, int iSBC)
        {
            this.titre = titre;
            this.ISBC = iSBC;
        }
    }


}
