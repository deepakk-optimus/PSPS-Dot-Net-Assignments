using KickOff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickOff.Repository
{
    public interface ICustomerRepository
    {
        //IEnumerable<Customer> GetProducts(String name);
        ICollection<Customer> GetCustomers();
        Customer GetCustomer(Int32? id);

        Customer AddCustomer(Customer customer);

        //Customer UpdateCustomer(Int32? id, Customer changes);

        //Customer DeleteCustomer(Int32? id);
    }
}
