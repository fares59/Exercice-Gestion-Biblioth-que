using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Categorie : ModelBase<Categorie>
    {
        private string titre;
        public string Titre {
            get { return titre; }
            set
            {
                if (this.titre != value)
                {
                    this.titre = value;
                }
            }
        }

        [JsonIgnore]
        private List<Abonne> abonnesList;
        public List<Abonne> AbonnesList
        {
            get
            {
                if (this.abonnesList == null)
                {
                    this.abonnesList = Abonne.jDA.GetAll(item => item.IdCategorie == this.Id);
                }
                return this.abonnesList;
            }
        }
        public List<Abonne> AddAbonne(Abonne Abonne)
        {
            if (this.abonnesList.Find(item => item.Id == Abonne.Id) == null)
            {
                this.abonnesList.Add(Abonne);
                if (Abonne.Categorie.Id != this.Id)
                {
                    Abonne.Categorie = this;
                }
            }
            return this.abonnesList;
        }

        public List<Abonne> RemoveAbonne(Abonne Abonne)
        {
            int index = this.abonnesList.FindIndex(item => item.Id == Abonne.Id);
            if (index >= 0)
            {
                this.abonnesList.RemoveAt(index);
                if (Abonne.Categorie.Id == this.Id)
                {
                    Abonne.Categorie = null;
                }
            }
            return this.abonnesList;
        }

        public Categorie()
        {
            this.Titre = "";
        }
        public Categorie(string _titre)
        {
            this.Titre = _titre;
        }
        public string ToString()
        {
            return "categorie professionnelle : " + titre;
        }
    }
}
