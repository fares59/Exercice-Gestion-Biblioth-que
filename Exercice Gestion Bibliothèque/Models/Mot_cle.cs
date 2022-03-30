using Newtonsoft.Json;


namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Mot_cle : ModelBase<Mot_cle>
    {
        [JsonProperty(PropertyName = "mot")]
        private string mot;
        [JsonIgnore]
        public string Mot
        {
            get { return mot; }
            set
            {
                if (this.mot != value)
                {
                    this.mot = value;
                    RaisePropertyChanged(() => mot);
                }
            }
        }

        [JsonIgnore]
        private List<int>? idLivreList;
        [JsonIgnore]
        public List<int> IdLivreList
        {
            get
            {
                if (this.idLivreList == null)
                {

                    List<dynamic> ids = jDA.LoadJsonData("motcle_livre").FindAll(item => item.id_theme == this.Id);
                    idLivreList = new();
                    ids.ForEach(item =>
                    {
                        idLivreList.Add((int)item.id_livre);
                    });
                }
                return this.idLivreList;
            }
        }

        [JsonIgnore]
        private List<Livre>? livreList;
        [JsonIgnore]
        public List<Livre> LivreList
        {
            get
            {
                if (this.livreList == null)
                {
                    this.livreList = Livre.jDA.GetAll(item => this.IdLivreList.Contains(item.Id));
                }
                return this.livreList;
            }
        }

        public List<Livre> AddLivre(Livre livre)
        {
            if (this.LivreList.Find(item => item.Id == livre.Id) == null)
            {
                this.IdLivreList.Add(livre.Id);
                this.LivreList.Add(livre);
                livre.AddMotcle(this);
                //TODO persist 
            }
            return this.LivreList;
        }

        public List<Livre> RemoveLivre(Livre livre)
        {
            int index = this.LivreList.FindIndex(item => item.Id == livre.Id);
            if (index >= 0)
            {
                this.IdLivreList.Remove(livre.Id);
                this.LivreList.RemoveAt(index);
                livre.RemoveMotcle(this);
                //TODO persist
            }
            return this.LivreList;
        }
        //public void AddLivre(Livre livre)
        //{
        //    if (!livres.Contains(livre))
        //    {
        //        livres.Add(livre);
        //    }
        //    if (!livre.Mot_cle.Contains(this))
        //    {
        //        livre.Mot_cle.Add(this);
        //    }
        //}
        //public void RemoveLivre(Livre livre)
        //{
        //    if (livre != null && livres.Contains(livre))
        //    {
        //        if (livre.Mots_cle == this)
        //        {
        //            livre.Category = null;
        //        }
        //        livres.Remove(livre);
        //    }
        //}
    }
}
