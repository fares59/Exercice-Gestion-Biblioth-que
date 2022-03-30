using Newtonsoft.Json;


namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Theme : ModelBase<Theme>
    {
        [JsonProperty(PropertyName = "titre")]
        private string titre;
        [JsonIgnore]
        public string Titre
        {
            get { return titre; }
            set
            {
                if (this.titre != value)
                {
                    this.titre = value;
                    RaisePropertyChanged(() => Titre);
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

                    List<dynamic> ids = jDA.LoadJsonData("theme_livre").FindAll(item => item.id_theme == this.Id);
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
                livre.AddTheme(this);
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
                livre.RemoveTheme(this);
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
        //    if (!livre.Themes.Contains(this))
        //    {
        //        livre.Themes.Add(this);
        //    }
        //}
    }
}
