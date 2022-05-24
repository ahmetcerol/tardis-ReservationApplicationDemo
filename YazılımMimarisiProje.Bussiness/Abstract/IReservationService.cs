using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Concrete;

namespace YazılımMimarisiProje.Bussiness.Abstract
{
   public  interface IReservationService
    {
        List<ReservationInformation> GetAll();
        List<ReservationInformation> GetUserInformation(string BookerEmail);
        void Delete(string ReservationEmail);
        void Add(ReservationInformation reservationInformation, Booker booker);
        List<Booker> GetReservationInformation(string BookerEmail);
    }
}
