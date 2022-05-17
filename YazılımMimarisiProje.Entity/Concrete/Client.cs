using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Abstract;

namespace YazılımMimarisiProje.Entity.Concrete
{
   public class Client
    {
        ReservationFactory ReservationFactory;
        ITransportation transportation;
        IAccomodation accomodation;

        public Client(ReservationFactory reservationFactory)
        {
            ReservationFactory = reservationFactory;
            transportation = reservationFactory.GetTransportation();
            accomodation = reservationFactory.GetAccomodation();
        }

        public string ReservationTransportation(ReservationInformation reservationInformation)
        {
            return transportation.Apply(reservationInformation);
        }

        public string ReservationAccomodation(ReservationInformation reservationInformation)
        {
            return accomodation.Apply(reservationInformation);
        }
    }
}
