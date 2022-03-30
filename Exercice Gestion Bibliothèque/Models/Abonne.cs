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
        public string Nom {
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
        public string Prenom {
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
        public string Adresse {
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
        public string Telephone {
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
        public string Email {
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
        public DateTime DateAdhesion { 
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
                if(this.categorie == null)
                {
                    categorie = Categorie.jDA.GetById(this.idCategorie);
                }
                return categorie;
            }
            set
            {
                if (this.idCategorie != value?.Id)
                {
                    Categorie?.RemoveAbonne(this);
                    this.idCategorie = value?.Id;
                    this.categorie = null; //need to reset Livre get
                    Categorie?.AddAbonne(this);
                }
            }
        }
        public Abonne()
        {
            nom = "";
            prenom = "";
            email = "";
            telephone = "";
            dateAdhesion = DateTime.Now.ToString("yyyy-MM-dd");

        }
        public Abonne(string _nom,string _prenom, string _telephone, string _email, DateTime _dateAdhesion)
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
