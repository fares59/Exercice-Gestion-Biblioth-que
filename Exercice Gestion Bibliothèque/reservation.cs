using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_Bibliothèque
{
    public class Reservation

    {
        private string date_reservation;
        private bool deleted;

        public DateTime Date_reservation { get => DateTime.Parse(date_reservation); set => date_reservation = value.ToString("yyyy-MM-dd"); }
        public bool Deleted { get => deleted; set => deleted = value; }


        public Reservation()
        { }
    }
}
