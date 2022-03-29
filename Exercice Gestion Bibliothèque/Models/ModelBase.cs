using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque.Models
{
    internal class ModelBase<T> where T : ModelBase<T>
    {
        private int id;
        public int Id
        {
            get => id;
            set
            {
                if (this.id != value)
                {
                    this.id = value;
                }
            }
        }
        private bool deleted = false;
        public bool Deleted
        {
            get => deleted;
            set
            {
                if (this.deleted != value)
                {
                    this.deleted = value;
                }
            }
        }

        //DAL
        public static DAL.JsonDataAcces<T> jDA = new DAL.JsonDataAcces<T>();


    }
}
