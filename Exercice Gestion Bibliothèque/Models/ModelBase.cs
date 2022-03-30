using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class ModelBase<T> : INotifyPropertyChanged where T : ModelBase<T>
    {

        [JsonProperty(PropertyName = "id")]
        protected int id;
        [JsonIgnore]
        public int Id
        {
            get => id;
            set
            {
                if (this.id != value)
                {
                    this.id = value;
                    RaisePropertyChanged(() => Id);
                }
            }
        }
        [JsonProperty(PropertyName = "deleted")]
        protected bool deleted = false;
        [JsonIgnore]
        public bool Deleted
        {
            get => deleted;
            set
            {
                if (this.deleted != value)
                {
                    this.deleted = value;
                    RaisePropertyChanged(() => Deleted);
                }
            }
        }

        //DAL
        public static readonly DAL.JsonDataAcces<T> jDA = new DAL.JsonDataAcces<T>(); // Data Access Layer permet de faire la jonction entre les composants de l'interface et les données

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler? PropertyChanged; // définition de l'objet
        public void RaisePropertyChanged<M>(Expression<Func<M>> action) //where M : ModelBase<M> M correspond à une convention qui fait référence au models
        {
            MemberExpression expression = (MemberExpression)action.Body; // correspond à la rcupération de l'expression
            string propertyName = expression.Member.Name;
            if (PropertyChanged != null) // si il exister un composant la condition se déclenche 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); // le changement de propriété 
            }
            jDA.Persist((T)this); //permet de save à chaque action donc chaque changement d'état
        }

        #endregion
    }
}
