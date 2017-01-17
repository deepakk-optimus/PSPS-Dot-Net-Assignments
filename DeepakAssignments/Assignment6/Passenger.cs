using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Passenger
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public List<Ticket> tickets { get; set; }
    }
}
