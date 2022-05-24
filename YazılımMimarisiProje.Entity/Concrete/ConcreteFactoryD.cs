using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Concrete;

namespace YazılımMimarisiProje.Entity.Abstract
{
    public class ConcreteFactoryD : ReservationFactory
    {
        public IAccomodation GetAccomodation()
        {
            return new Hotel();
        }

        public ITransportation GetTransportation()
        {
            return new Flight();
        }
    }
}
