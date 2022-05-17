using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Concrete;

namespace YazılımMimarisiProje.Entity.Abstract
{
    public class ConcreteFactoryA : ReservationFactory
    {
        public IAccomodation GetAccomodation()
        {
            return new Tent();
        }

        public ITransportation GetTransportation()
        {
            return new Bus();
        }
    }
}
