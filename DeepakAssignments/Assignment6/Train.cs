using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Train
    {
        public int id { get; set; }
        public string _name { get; set; }
        public int _number { get; set; }
        public int _availableTickets { get; set; }
        public List<Berth> berths { get; set; }
    }
}
