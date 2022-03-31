using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Abonne : ModelBase<Abonne>
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set
            {
                if (this.nom != value)
                {
                    this.nom = value;
                }
            }
        }

        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set
            {
                if (this.prenom != value)
                {
                    this.prenom = value;
                }
            }
        }
        private string adresse;
        public string Adresse
        {
            get { return adresse; }
            set
            {
                if (this.adresse != value)
                {
                    this.adresse = value;
                }
            }
        }
        private string telephone;
        public string Telephone
        {
            get { return telephone; }
            set
            {
                if (this.telephone != value)
                {
                    this.telephone = value;
                }
            }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (this.email != value)
                {
                    this.email = value;
                }
            }
        }

        [JsonProperty(PropertyName = "date_adhesion")]
        private string dateAdhesion;
        public DateTime DateAdhesion
        {
            get => DateTime.Parse(dateAdhesion);
            set
            {
                if (this.dateAdhesion != value.ToString("yyyy-MM-dd"))
                {
                    this.dateAdhesion = value.ToString("yyyy-MM-dd");
                }
            }
        }

        [JsonProperty(PropertyName = "id_categorie")]
        private int? idCategorie;
        public int? IdCategorie
        {
            get { return idCategorie; }
            set
            {
                if (this.idCategorie != value)
                {
                    this.idCategorie = value;
                    //persist
                }
            }
        }

        [JsonIgnore]
        private Categorie categorie;
        public Categorie Categorie
        {
            get
            {
                if (this.categorie == null)
                {
                    categorie = Categorie.jDA.GetById((int)idCategorie);
                }
                return categorie;
            }
            set
            {
                if (this.idCategorie != value?.Id)
                {
                    Categorie?.RemoveAbonne(this); //supprimer l'article de cetteCategory
                    this.idCategorie = value?.Id;
                    this.categorie = null; 
                    Categorie?.AddAbonne(this); // ajouter l'article à ctte category
                }
            }
        }

        // relation Emprunt 1=>n

        [JsonIgnore]
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
        }

        // relation Reservation n=>1

        [JsonIgnore]
        private List<Reservation> reservationList;
        public List<Reservation> ReservationList
        {
            get
            {
                if (this.reservationList == null)
                {
                    this.reservationList = Reservation.jDA.GetAll(item => item.IdAbonne == this.Id);
                }
                return this.reservationList;
            }
        }

        public List<Reservation> AddReservation(Reservation reservation)
        {
            if (this.ReservationList.Find(item => item.Id == reservation.Id) == null)
            {
                this.ReservationList.Add(reservation);
                if (reservation.IdAbonne != this.Id)
                {
                    reservation.Abonne = this;
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
                if (reservation.Abonne.Id == this.Id)
                {
                    reservation.Abonne = null;
                }
            }
            return this.ReservationList;
        }


        public Abonne()
        {
            nom = "";
            prenom = "";
            email = "";
            telephone = "";
            dateAdhesion = DateTime.Now.ToString("yyyy-MM-dd");

        }
        public Abonne(string _nom, string _prenom, string _telephone, string _email, DateTime _dateAdhesion)
        {
            this.nom = _nom;
            this.prenom = _prenom;
            this.telephone = _telephone;
            this.email = _email;
            this.dateAdhesion = _dateAdhesion.ToString("yyyy-MM-dd");
        }

        public string ToString()
        {
            return "Nom : " + nom + " prenom : " + prenom + " email : " + email;
        }
    }
}
