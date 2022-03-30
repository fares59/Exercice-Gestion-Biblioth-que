using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class Livre : ModelBase<Livre>
    {
        private string titre;
        public string Titre
        {
            get { return titre; }
            set
            {
                if (this.titre != value)
                {
                    this.titre = value;
                }
            }
        }

        private string isbn;
        public string Isbn
        {
            get { return isbn; }
            set
            {
                if (this.isbn != value)
                {
                    this.isbn = value;
                }
            }
        }

        [JsonIgnore]
        private List<Exemplaire> exemplairesList;
        public List<Exemplaire> ExemplairesList
        {
            get
            {
                if (this.exemplairesList == null)
                {
                    this.exemplairesList = Exemplaire.jDA.GetAll(item => item.IdLivre == this.Id);
                }
                return this.exemplairesList;
            }
        }
        public List<Exemplaire> AddExemplaire(Exemplaire exemplaire)
        {
            if (this.ExemplairesList.Find(item => item.Id == exemplaire.Id) == null)
            {
                this.ExemplairesList.Add(exemplaire);
                if (exemplaire.IdLivre != this.Id)
                {
                    exemplaire.Livre = this;
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
                if (exemplaire.Livre.Id == this.Id)
                {
                    exemplaire.Livre = null;
                }
            }
            return this.ExemplairesList;
        }


        [JsonIgnore]
        private List<int>? idAuteurList;
        public List<int> IdAuteurList
        {
            get
            {
                if (this.idAuteurList == null)
                {

                    List<dynamic> ids = jDA.LoadJsonData("auteur_livre").FindAll(item => item.id_livre == this.Id);
                    idAuteurList = new();
                    ids.ForEach(item =>
                    {
                        idAuteurList.Add((int)item.id_auteur);
                    });
                }
                return this.idAuteurList;
            }
        }

        [JsonIgnore]
        private List<Auteur>? auteurList;
        public List<Auteur> AuteurList
        {
            get
            {
                if (this.auteurList == null)
                {
                    this.auteurList = Auteur.jDA.GetAll(item => this.IdAuteurList.Contains(item.Id));
                }
                return this.auteurList;
            }
        }

        public List<Auteur> AddAuteur(Auteur auteur)
        {
            if (this.AuteurList.Find(item => item.Id == auteur.Id) == null)
            {
                this.IdAuteurList.Add(auteur.Id);
                this.AuteurList.Add(auteur);
                auteur.AddLivre(this);
                //TODO persist
            }
            return this.AuteurList;
        }

        public List<Auteur> RemoveAuteur(Auteur auteur)
        {
            int index = this.AuteurList.FindIndex(item => item.Id == auteur.Id);
            if (index >= 0)
            {
                this.IdAuteurList.Remove(auteur.Id);
                this.AuteurList.RemoveAt(index);
                auteur.RemoveLivre(this);
                //TODO persist
            }
            return this.AuteurList;
        }

        [JsonIgnore]
        private List<int>? idThemeList;
        public List<int> IdThemeList
        {
            get
            {
                if (this.idThemeList == null)
                {

                    List<dynamic> ids = jDA.LoadJsonData("auteur_livre").FindAll(item => item.id_livre == this.Id);
                    idThemeList = new();
                    ids.ForEach(item =>
                    {
                        idThemeList.Add((int)item.id_theme);
                    });
                }
                return this.idThemeList;
            }
        }

        [JsonIgnore]
        private List<Theme>? themeList;
        public List<Theme> ThemeList
        {
            get
            {
                if (this.themeList == null)
                {
                    this.themeList = Theme.jDA.GetAll(item => this.IdThemeList.Contains(item.Id));
                }
                return this.themeList;
            }
        }

        public List<Theme> AddTheme(Theme theme)
        {
            if (this.ThemeList.Find(item => item.Id == theme.Id) == null)
            {
                this.IdThemeList.Add(theme.Id);
                this.ThemeList.Add(theme);
                theme.AddLivre(this);
                //TODO persist
            }
            return this.ThemeList;
        }

        public List<Theme> RemoveTheme(Theme theme)
        {
            int index = this.ThemeList.FindIndex(item => item.Id == theme.Id);
            if (index >= 0)
            {
                this.IdThemeList.Remove(theme.Id);
                this.ThemeList.RemoveAt(index);
                theme.RemoveLivre(this);
                //TODO persist
            }
            return this.ThemeList;
        }









        [JsonIgnore]
        private List<int>? idMotcleList;
        public List<int> IdMotcleList
        {
            get
            {
                if (this.idMotcleList == null)
                {

                    List<dynamic> ids = jDA.LoadJsonData("auteur_livre").FindAll(item => item.id_livre == this.Id);
                    idMotcleList = new();
                    ids.ForEach(item =>
                    {
                        idMotcleList.Add((int)item.id_motcle);
                    });
                }
                return this.idMotcleList;
            }
        }

        [JsonIgnore]
        private List<Mot_cle>? motcleList;
        public List<Mot_cle> MotcleList
        {
            get
            {
                if (this.motcleList == null)
                {
                    this.motcleList = Mot_cle.jDA.GetAll(item => this.IdMotcleList.Contains(item.Id));
                }
                return this.MotcleList;
            }
        }





        public List<Mot_cle> AddMotcle(Mot_cle motcle)
        {
            if (this.MotcleList.Find(item => item.Id == motcle.Id) == null)
            {
                this.IdMotcleList.Add(motcle.Id);
                this.MotcleList.Add(motcle);
                motcle.AddLivre(this);
                //TODO persist
            }
            return this.MotcleList;
        }


        public List<Mot_cle> RemoveMotcle(Mot_cle motcle)
        {
            int index = this.ThemeList.FindIndex(item => item.Id == motcle.Id);
            if (index >= 0)
            {
                this.IdMotcleList.Remove(motcle.Id);
                this.MotcleList.RemoveAt(index);
                motcle.RemoveLivre(this);
                //TODO persist
            }
            return this.MotcleList;
        }



    }

}
