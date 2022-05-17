using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Abstract;

namespace YazılımMimarisiProje.Entity.Concrete
{
    public class Tent : IAccomodation
    {
        public string Apply(ReservationInformation reservationInformation)
        {
            reservationInformation.ReservationAccomodation = "Tent";
            return reservationInformation.ReservationAccomodation;
        }
    }
}
