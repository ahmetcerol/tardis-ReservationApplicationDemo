using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Concrete;

namespace YazılımMimarisiProje.Entity.Abstract
{
  public abstract class IReservationBuilder
 
  {
        protected ReservationInformation reservationInformation;
        public ReservationInformation ReservationInformation
        {
            get { return reservationInformation; }
        }
        
        public abstract string SetAccomodation();
        public abstract string SetTransportation();
        public abstract DateTime SetEntranceDate();
        public abstract DateTime SetQuitDate();
        public abstract int SetPrice();

        protected Booker booker;
        public Booker Booker
        {
            get { return booker; }
        }

        public abstract string SetBookerName();
        public abstract string SetBookerSurname();
        public abstract string SetBookerEmail();

        public abstract int SetBookerPhoneNumber();


    }
}
