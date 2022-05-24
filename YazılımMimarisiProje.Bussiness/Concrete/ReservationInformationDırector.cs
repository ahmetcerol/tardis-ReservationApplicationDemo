using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Abstract;

namespace YazılımMimarisiProje.Entity.Concrete
{
    public class ReservationInformationDırector
    {
        public void Uret(IReservationBuilder reservationBuilder) 
        {
            reservationBuilder.SetAccomodation();
            reservationBuilder.SetTransportation();
            reservationBuilder.SetEntranceDate();
            reservationBuilder.SetQuitDate();
            reservationBuilder.SetPrice();
            reservationBuilder.SetBookerName();
            reservationBuilder.SetBookerSurname();
            reservationBuilder.SetBookerEmail();
            reservationBuilder.SetBookerPhoneNumber();
        }
    }
}
