using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Berth
    {
        public int id { get; set; }
        public string _name { get; set; }
        public int number { get; set; }
        public Passenger _owner { get; set; }
    }
}
