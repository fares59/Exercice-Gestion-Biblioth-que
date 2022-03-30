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
                    RaisePropertyChanged(() => DateAchat);
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

        // relation livre 1=>n

        [JsonIgnore]
        private Livre livre;
        public Livre Livre
        {
            get
            {
                if (this.livre == null)
                {
                    livre = Livre.jDA.GetById(idLivre);
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

        // relation usure 1=>n

        [JsonIgnore]
        private Usure usure;
        public Usure Usure
        {
            get
            {
                if (this.usure == null)
                {
                    usure = Usure.jDA.GetById(this.idUsure);
                }
                return usure;
            }
            set
            {
                if (this.idUsure != value?.Id)
                {
                    Usure?.RemoveExemplaire(this);
                    this.idUsure = (int)(value?.Id);
                    this.usure = null; //need to reset Livre get
                    Usure?.AddExemplaire(this);
                }
            }
        }


        // relation editeur 1=>n

        [JsonIgnore]
        private Editeur editeur;
        public Editeur Editeur
        {
            get
            {
                if (this.editeur == null)
                {
                    editeur = Editeur.jDA.GetById((int)idEditeur);
                }
                return editeur;
            }
            set
            {
                if (this.idEditeur != value?.Id)
                {
                    Editeur?.RemoveExemplaire(this);
                    this.idEditeur = (int)(value?.Id);
                    this.editeur = null; //need to reset Livre get
                    Editeur?.AddExemplaire(this);
                }
            }
        }


        // relation Emprunt n=>1

        [JsonIgnore]
        private List<Emprunt> empruntList;
        public List<Emprunt> EmpruntList
        {
            get
            {
                if (this.empruntList == null)
                {
                    this.empruntList = Emprunt.jDA.GetAll(item => item.IdExemplaire == this.Id);
                }
                return this.empruntList;
            }
        }
        public List<Emprunt> AddEmprunt(Emprunt emprunt)
        {
            if (this.EmpruntList.Find(item => item.Id == emprunt.Id) == null)
            {
                this.EmpruntList.Add(emprunt);
                if (emprunt.Exemplaire.Id != this.Id)
                {
                    emprunt.Exemplaire = this;
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
                if (emprunt.Exemplaire.Id == this.Id)
                {
                    emprunt.Exemplaire = null;
                }
            }
            return this.EmpruntList;
        }




    }
}

