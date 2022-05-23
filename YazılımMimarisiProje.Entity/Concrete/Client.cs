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
        public void Main()
        {
            // The client code can work with any concrete factory class.
            ClientMethod(new ConcreteFactoryA());
            ClientMethod(new ConcreteFactoryB());
            ClientMethod(new ConcreteFactoryC());
            ClientMethod(new ConcreteFactoryD());
        }

        public void ClientMethod(ReservationFactory factory)
        {
            var Hotel = factory.GetAccomodation();
            var Flight = factory.GetTransportation();
            var Tent = factory.GetAccomodation();
            var Bus = factory.GetTransportation();
        }
    }
}
