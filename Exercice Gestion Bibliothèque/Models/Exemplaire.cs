using Newtonsoft.Json;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Exemplaire : ModelBase<Exemplaire>
    {
        [JsonProperty(PropertyName = "date_achat")]
        private string dateAchat;
        public DateTime DateAchat
        {
            get => DateTime.Parse(dateAchat);
            set
            {
                if (this.dateAchat != value.ToString("yyyy-MM-dd"))
                {
                    this.dateAchat = value.ToString("yyyy-MM-dd");
                }
            }
        }

        private string emplacement;
        public string Emplacement
        {
            get { return emplacement; }
            set
            {
                if (this.emplacement != value)
                {
                    this.emplacement = value;
                }
            }
        }

        [JsonProperty(PropertyName = "id_livre")]
        private int idLivre;
        public int IdLivre
        {
            get { return idLivre; }
            set
            {
                if (this.idLivre != value)
                {
                    this.idLivre = value;
                }
            }
        }

        [JsonIgnore]
        private Livre livre;
        public Livre Livre
        {
            get
            {
                if (this.livre == null)
                {
                    livre = Livre.jDA.GetById(this.idLivre);
                }
                return livre;
            }
            set
            {
                if (this.idLivre != value?.Id)
                {
                    Livre?.RemoveExemplaire(this);
                    this.idLivre = (int)(value?.Id);
                    this.livre = null; //need to reset Livre get
                    Livre?.AddExemplaire(this);
                }
            }
        }

            [JsonProperty(PropertyName = "id_usure")]
        private int idUsure;
        public int IdUsure
        {
            get { return idUsure; }
            set
            {
                if (this.idUsure != value)
                {
                    this.idUsure = value;
                }
            }
        }

        [JsonProperty(PropertyName = "id_editeur")]
        private int idEditeur;
        public int IdEditeur
        {
            get { return idEditeur; }
            set
            {
                if (this.idEditeur != value)
                {
                    this.idEditeur = value;
                }
            }
        }



        public List<Emprunt> AddEmprunt(Emprunt emprunt)
        {
            if (this.EmpruntList.Find(item => item.Id == emprunt.Id) == null)
            {
                this.EmpruntList.Add(emprunt);
                if (emprunt.IdLivre != this.Id)
                {
                    emprunt.Livre = this;
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
                if (emprunt.Emprunt.Id == this.Id)
                {
                    emprunt.Livre = null;
                }
            }
            return this.EmpruntList;
        }

    }

}

