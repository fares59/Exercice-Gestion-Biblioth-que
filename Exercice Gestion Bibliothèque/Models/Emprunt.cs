using Newtonsoft.Json;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Emprunt : ModelBase<Emprunt>
    {
        [JsonProperty(PropertyName = "date_emprunt")]
        private string? dateEmprunt;
        public DateTime DateEmprunt
        {
            get => DateTime.Parse(dateEmprunt);
            set
            {
                if (this.dateEmprunt != value.ToString("yyyy-MM-dd"))
                {
                    this.dateEmprunt = value.ToString("yyyy-MM-dd");
                }
            }

        }

        [JsonProperty(PropertyName = "date_sortie")]
        private string? dateSortie;
        public DateTime DateSortie
        {
            get => DateTime.Parse(dateSortie);
            set
            {
                if (this.dateSortie != value.ToString("yyyy-MM-dd"))
                {
                    this.dateSortie = value.ToString("yyyy-MM-dd");
                }
            }
        }

        [JsonProperty(PropertyName = "id_exemplaire")]
        private int? idExemplaire;
        public int? IdExemplaire
        {
            get { return idExemplaire; }
            set
            {
                if (this.idExemplaire != value)
                {
                    this.idExemplaire = value;
                }
            }
        }

        [JsonProperty(PropertyName = "id_abonne")]
        private int? idAbonne;
        public int? IdAbonne
        {
            get { return idAbonne; }
            set
            {
                if (this.idAbonne != value)
                {
                    this.idAbonne = value;
                }
            }
        }

        // relation Exemplaire 1=>n

        [JsonIgnore]
        private Exemplaire exemplaire;
        public Exemplaire Exemplaire
        {
            get
            {
                if (this.exemplaire == null)
                {
                    exemplaire = Exemplaire.jDA.GetById((int)idExemplaire);
                }
                return exemplaire;
            }
            set
            {
                if (this.idExemplaire != value?.Id)
                {
                    Exemplaire?.RemoveEmprunt(this);
                    this.idExemplaire = (int)(value?.Id);
                    this.exemplaire = null; //need to reset Livre get
                    Exemplaire?.AddEmprunt(this);
                }
            }

        }

        // relation Abonne 1=>n

        [JsonIgnore]
        private Abonne abonne;
        public Abonne Abonne
        {
            get
            {
                if (this.abonne == null)
                {
                    abonne = Abonne.jDA.GetById((int)idAbonne);
                }
                return abonne;
            }
            set
            {
                if (this.idAbonne != value?.Id)
                {
                    Abonne?.RemoveEmprunt(this);
                    this.idAbonne = (int)(value?.Id);
                    this.abonne = null; //need to reset Livre get
                    Abonne?.AddEmprunt(this);
                }
            }

        }

        // Deuxième partie de la relation
        /*[JsonIgnore]
        private List<Emprunt> empruntList;
        public List<Emprunt> EmpruntList
        {
            get
            {
                if (this.empruntList == null)
                {
                    this.empruntList = Emprunt.jDA.GetAll(item => item.IdAbonne == this.Id);
                }
                return this.empruntList;
            }
        }
        public List<Emprunt> AddEmprunt(Emprunt emprunt)
        {
            if (this.EmpruntList.Find(item => item.Id == emprunt.Id) == null)
            {
                this.EmpruntList.Add(emprunt);
                if (emprunt.Abonne.Id != this.Id)
                {
                    emprunt.Abonne = this;
                }
            }
            return this.EmpruntList;
        }

        public List<Emprunt> RemoveEmprunt(Emprunt emprunt)
        {
            int index = this.EmpruntList.FindIndex(item => item.Id == emprunt.Id);
            if (index >= 0)
            {
                this.EmpruntList.RemoveAt(index);
                if (emprunt.Abonne.Id == this.Id)
                {
                    emprunt.Abonne = null;
                }
            }
            return this.EmpruntList;
        }*/


    }
}
