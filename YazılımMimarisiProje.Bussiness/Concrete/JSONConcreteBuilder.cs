using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Abstract;

namespace YazılımMimarisiProje.Entity.Concrete
{
    public class JSONConcreteBuilder : IReservationBuilder
    {
        
        public JSONConcreteBuilder(ReservationInformation reservation, Booker _booker)
        {
            reservationInformation = new ReservationInformation();
            reservationInformation.ReservationAccomodation = reservation.ReservationAccomodation;
            reservationInformation.ReservationEntranceDate = reservation.ReservationEntranceDate;
            reservationInformation.ReservationPrice = reservation.ReservationPrice;
            reservationInformation.ReservationQuitDate = reservation.ReservationQuitDate;
            reservationInformation.ReservationTransportation = reservation.ReservationTransportation;
            booker = new Booker();
            booker.BookerName = _booker.BookerName;
            booker.BookerSurname = _booker.BookerSurname;
            booker.BookerEmail = _booker.BookerEmail;
            booker.BookerPhoneNumber = _booker.BookerPhoneNumber;

        }

        public override string SetAccomodation()
        {
            return reservationInformation.ReservationAccomodation;
        }

        public override string SetBookerEmail()
        {
            return booker.BookerEmail;
        }

        public override string SetBookerName()
        {
            return booker.BookerName;
        }

        public override int SetBookerPhoneNumber()
        {
            return booker.BookerPhoneNumber;
        }

        public override string SetBookerSurname()
        {
            return booker.BookerSurname;
        }

        public override DateTime SetEntranceDate()
        {
            return  reservationInformation.ReservationEntranceDate;
        }

        public override int SetPrice()
        {
            return reservationInformation.ReservationPrice;
        }

        public override DateTime SetQuitDate()
        {
            return reservationInformation.ReservationQuitDate;
        }

        public override string SetTransportation()
        {
            return reservationInformation.ReservationTransportation;
        }

    }
}
