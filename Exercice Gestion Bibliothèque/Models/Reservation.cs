using Newtonsoft.Json;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Reservation : ModelBase<Reservation>
    {
        [JsonProperty(PropertyName = "date_reservation")]
        private string? dateReservation;
        [JsonIgnore]
        public DateTime DateReservation
        {
            get => DateTime.Parse(dateReservation);
            set
            {
                if (this.dateReservation != value.ToString("yyyy-MM-dd"))
                {
                    this.dateReservation = value.ToString("yyyy-MM-dd");
                    RaisePropertyChanged(() => DateReservation);



                }
            }
        }


        [JsonProperty(PropertyName = "id_editeur")]
        private int? idEditeur;
        [JsonIgnore]
        public int? IdEditeur
        {
            get { return idEditeur; }
            set
            {
                if (this.idEditeur != value)
                {
                    this.idEditeur = value;
                    RaisePropertyChanged(() => IdEditeur);
                }
            }
        }

        [JsonProperty(PropertyName = "id_livre")]
        private int? idLivre;
        [JsonIgnore]
        public int? IdLivre
        {
            get { return idLivre; }
            set
            {
                if (this.idLivre != value)
                {
                    this.idLivre = value;
                    RaisePropertyChanged(() => IdLivre);
                    //TODO persist ?
                }
            }
        }

        [JsonProperty(PropertyName = "id_abonne")]
        private int? idAbonne;
        [JsonIgnore]
        public int? IdAbonne
        {
            get { return idAbonne; }
            set
            {
                if (this.idAbonne != value)
                {
                    this.idAbonne = value;
                    RaisePropertyChanged(() => IdAbonne);
                }
            }
        }


        // relation livre 1=>n
        [JsonIgnore]
        private Livre? livre;
        public Livre Livre
        {
            get
            {
                if (this.livre == null)
                {
                    livre = Livre.jDA.GetById((int)idLivre);
                }
                return livre;
            }
            set
            {
                if (this.idLivre != value?.Id)
                {
                    Livre?.RemoveReservation(this);
                    this.idLivre = value?.Id;
                    this.livre = null; //need to reset Livre get
                    Livre?.AddReservation(this);
                }
            }

        }

        // relation editeur 1=>n
        [JsonIgnore]
        private Editeur? editeur;
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
                    Editeur?.RemoveReservation(this);
                    this.idEditeur = (int)(value?.Id);
                    this.editeur = null; //need to reset Livre get
                    Editeur?.AddReservation(this);
                }
            }
        }

        // relation abonne 1=>n

        [JsonIgnore]
        private Abonne? abonne;
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
                    Abonne?.RemoveReservation(this);
                    this.idAbonne = (int)(value?.Id);
                    this.abonne = null; //need to reset Livre get
                    Abonne?.AddReservation(this);
                }
            }
        }
    }
}


       
