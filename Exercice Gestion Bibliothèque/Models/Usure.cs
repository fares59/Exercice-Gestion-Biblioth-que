using Newtonsoft.Json;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Usure : ModelBase<Usure>
    {
        private string etat;
        public string Etat
        {
            get { return etat; }
            set
            {
                if (this.etat != value)
                {
                    this.etat = value;
                }
            }
        }

        // relation exemplaire n=>1

        [JsonIgnore]
        private List<Exemplaire> exemplaireList;
        public List<Exemplaire> ExemplaireList
        {
            get
            {
                if (this.exemplaireList == null)
                {
                    this.exemplaireList = Exemplaire.jDA.GetAll(item => item.IdUsure == this.Id);
                }
                return this.exemplaireList;
            }
        }
        public List<Exemplaire> AddExemplaire(Exemplaire Exemplaire)
        {
            if (this.exemplaireList.Find(item => item.Id == Exemplaire.Id) == null)
            {
                this.exemplaireList.Add(Exemplaire);
                if (Exemplaire.IdUsure != this.Id)
                {
                    Exemplaire.Usure = this;
                }
            }
            return this.exemplaireList;
        }

        public List<Exemplaire> RemoveExemplaire(Exemplaire Exemplaire)
        {
            int index = this.exemplaireList.FindIndex(item => item.Id == Exemplaire.Id);
            if (index >= 0)
            {
                this.exemplaireList.RemoveAt(index);
                if (Exemplaire.Usure.Id == this.Id)
                {
                    Exemplaire.Usure = null;
                }
            }
            return this.exemplaireList;
        }
    }
}

