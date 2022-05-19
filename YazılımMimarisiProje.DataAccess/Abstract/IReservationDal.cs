using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Concrete;

namespace YazılımMimarisiProje.DataAccess.Abstract
{
    public interface IReservationDal:ISqlRepository<ReservationInformation>
    {
        void Add(ReservationInformation reservationInformation,Booker booker);
    }
}
