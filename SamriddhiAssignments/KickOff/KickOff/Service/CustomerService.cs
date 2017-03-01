using KickOff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickOff.Service
{
    interface CustomerService
    {
        Customer findCustomerById(int customerId);
    }
}
