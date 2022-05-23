using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Abstract;

namespace YazılımMimarisiProje.Entity.Concrete
{
    public class Flight : ITransportation
    {
        public int Apply(ReservationInformation reservationInformation)
        {
            reservationInformation.ReservationPrice = 450;
            return reservationInformation.ReservationPrice;
        }

       
    }
}
