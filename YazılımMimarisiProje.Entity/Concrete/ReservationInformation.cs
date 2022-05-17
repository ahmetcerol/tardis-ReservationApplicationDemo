using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Abstract;

namespace YazılımMimarisiProje.Entity.Concrete
{
    public class ReservationInformation:IEntity
    {
        public int ReservationId { get; set; }
        public string ReservationAccomodation { get; set; }
        public string ReservationTransportation { get; set; }
        public DateTime ReservationEntranceDate { get; set; }
        public DateTime ReservationQuitDate { get; set; }
        public int ReservationPrice { get; set; }
        public int BookerId { get; set; }
        
    }

}
