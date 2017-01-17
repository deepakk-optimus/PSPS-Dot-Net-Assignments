using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket _ticket = new Ticket();
            _ticket._id = 123;
            _ticket._status = "Confirmed";

            Passenger _passenger = new Passenger();
            _passenger._id = 1;
            _passenger._name = "Deepak";
            _ticket._owner = _passenger;


            Train train = new Train();

           // _passenger.tickets= 
        }
    }
}
