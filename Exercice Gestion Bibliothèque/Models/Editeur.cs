using Newtonsoft.Json;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Editeur : ModelBase<Editeur>
    {
        private string? nom;
        public string Nom
        {
            get { return nom; }
            set
            {
                if (this.nom != value)
                {
                    this.nom = value;
                    RaisePropertyChanged(() => Nom);
                }
            }
        }

        // relation reservation 1=>n

        [JsonIgnore]
        private List<Reservation> reservationList;
        public List<Reservation> ReservationList
        {
            get
            {
                if (this.reservationList == null)
                {
                    this.reservationList = Reservation.jDA.GetAll(item => item.IdEditeur == this.Id);
                }
                return this.reservationList;
            }
        }

        public List<Reservation> AddReservation(Reservation reservation)
        {
            if (this.ReservationList.Find(item => item.Id == reservation.Id) == null)
            {
                this.ReservationList.Add(reservation);
                if (reservation.IdEditeur != this.Id)
                {
                    reservation.Editeur = this;
                }
            }
            return this.ReservationList;
        }

            public List<Reservation> RemoveReservation(Reservation reservation)
        {
            int index = this.ReservationList.FindIndex(item => item.Id == reservation.Id);
            if (index >= 0)
            {
                this.ReservationList.RemoveAt(index);
                if (reservation.Editeur.Id == this.Id)
                {
                    reservation.Editeur = null;
                }
            }
            return this.ReservationList;
        }


        // relation exemplaire 1=>n

        [JsonIgnore]
        private List<Exemplaire> exemplairesList;
        public List<Exemplaire> ExemplairesList
        {
            get
            {
                if (this.exemplairesList == null)
                {
                    this.exemplairesList = Exemplaire.jDA.GetAll(item => item.IdEditeur == this.Id);
                }
                return this.exemplairesList;
            }
        }
        public List<Exemplaire> AddExemplaire(Exemplaire exemplaire)
        {
            if (this.ExemplairesList.Find(item => item.Id == exemplaire.Id) == null)
            {
                this.ExemplairesList.Add(exemplaire);
                if (exemplaire.IdEditeur != this.Id)
                {
                    exemplaire.Editeur = this;
                }
            }
            return this.ExemplairesList;
        }

        public List<Exemplaire> RemoveExemplaire(Exemplaire exemplaire)
        {
            int index = this.ExemplairesList.FindIndex(item => item.Id == exemplaire.Id);
            if (index >= 0)
            {
                this.ExemplairesList.RemoveAt(index);
                if (exemplaire.Editeur.Id == this.Id)
                {
                    exemplaire.Editeur = null;
                }
            }
            return this.ExemplairesList;
        }
    }
}
