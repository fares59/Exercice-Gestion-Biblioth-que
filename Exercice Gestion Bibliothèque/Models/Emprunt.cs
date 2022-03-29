using Newtonsoft.Json;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Emprunt : ModelBase<Emprunt>
    {
        [JsonProperty(PropertyName = "date_emprunt")]
        private string? date_emprunt;
        public DateTime Date_emprunt
        {
            get => DateTime.Parse(date_emprunt);
            set
            {
                if (this.date_emprunt != value.ToString("yyyy-MM-dd"))
                {
                    this.date_emprunt = value.ToString("yyyy-MM-dd");
                }
            }
        }

        [JsonProperty(PropertyName = "date_sortie")]
        private string? date_sortie;
        public DateTime Date_sortie
        {
            get => DateTime.Parse(date_sortie);
            set
            {
                if (this.date_sortie != value.ToString("yyyy-MM-dd"))
                {
                    this.date_sortie = value.ToString("yyyy-MM-dd");
                }
            }
        }

        [JsonProperty(PropertyName = "id_exemplaire")]
        private int id_exemplaire;
        public int idexemplaire
        {
            get { return idexemplaire; }
            set
            {
                if (this.idexemplaire != value)
                {
                    this.idexemplaire = value;
                }
            }
        }

        [JsonProperty(PropertyName = "id_abonne")]
        private int id_abonne;
        public int idabonne
        {
            get { return idabonne; }
            set
            {
                if (this.idabonne != value)
                {
                    this.idabonne = value;
                }
            }
        }


        [JsonIgnore]
        private Exemplaire exemplaire;
        public Exemplaire Exemplaire
        {
            get
            {
                if (this.exemplaire == null)
                {
                    exemplaire = Exemplaire.jDA.GetById(this.idexemplaire);
                }
                return exemplaire;
            }
            set
            {
                if (this.idexemplaire != value?.Id)
                {
                    Exemplaire?.RemoveEmprunt(this);
                    this.idexemplaire = (int)(value?.Id);
                    this.exemplaire = null; //need to reset Livre get
                    Exemplaire?.AddEmprunt(this);
                }
            }

        }

    }
}