using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Abstract;

namespace YazılımMimarisiProje.Entity.Concrete
{
    public class Bus : ITransportation
    {
        public int Apply(ReservationInformation reservationInformation)
        {
            
            reservationInformation.ReservationPrice = 150;
            return reservationInformation.ReservationPrice;
        }
    }
}
