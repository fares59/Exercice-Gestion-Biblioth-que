using Newtonsoft.Json;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Reservation : ModelBase<Reservation>
    {
        [JsonProperty(PropertyName = "date_reservation")]
        private string? date_reservation;
        public DateTime Date_reservation
        {
            get => DateTime.Parse(date_reservation);
            set
            {
                if (this.date_reservation != value.ToString("yyyy-MM-dd"))
                {
                    this.date_reservation = value.ToString("yyyy-MM-dd");
                }
            }
        }


        [JsonProperty(PropertyName = "id_editeur")]
        private int id_editeur;
        public int idediteur
        {
            get { return idediteur; }
            set
            {
                if (this.idediteur != value)
                {
                    this.idediteur = value;
                }
            }
        }

        [JsonProperty(PropertyName = "id_livre")]
        private int id_livre;
        public int idlivre
        {
            get { return idlivre; }
            set
            {
                if (this.idlivre != value)
                {
                    this.idlivre = value;
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

        public List<Editeur> AddEditeur(Editeur editeur)
        {
            if (this.EditeurList.Find(item => item.Id == editeur.Id) == null)
            {
                this.IdEditeurList.Add(editeur.Id);
                this.EditeurList.Add(editeur);
                editeur.AddReservation(this);
                //TODO persist
            }
            return this.AuteurList;
        }

        public List<Auteur> RemoveEditeur(Auteur auteur)
        {
            int index = this.EditeurList.FindIndex(item => item.Id == auteur.Id);
            if (index >= 0)
            {
                this.IdEditeurList.Remove(auteur.Id);
                this.EditeurList.RemoveAt(index);
                auteur.RemoveLivre(this);
                //TODO persist
            }
            return this.AuteurList;





        }
}