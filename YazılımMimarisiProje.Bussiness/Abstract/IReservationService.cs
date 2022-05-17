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
        void Add(ReservationInformation reservationInformation);
        void Delete(string ReservationEmail);
    }
}
