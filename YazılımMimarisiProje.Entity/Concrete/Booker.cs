using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.Entity.Abstract;

namespace YazılımMimarisiProje.Entity.Concrete
{
    public class Booker:IEntity
    {
        public int BookerId { get; set; }
        public string BookerName { get; set; }
        public string BookerSurname { get; set; }
        public string BookerEmail { get; set; }
        public int BookerTcNo { get; set; }
        public int BookerPhoneNumber { get; set; }
    }
}
