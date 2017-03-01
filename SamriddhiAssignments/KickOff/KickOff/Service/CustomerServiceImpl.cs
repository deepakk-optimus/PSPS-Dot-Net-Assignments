using KickOff.DAL;
using KickOff.Models;
using KickOff.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KickOff.Service
{
    public class CustomerServiceImpl : CustomerService
    {

        

        public Customer findCustomerById(int customerId)
        {
            using (var ctx = new KickOffContext())
            {
                var query = from cu in ctx.Customers where cu.Id == customerId select cu ;
                return query.SingleOrDefault();
                //Customer = ctx.Customers.Find(customerId = Customer.Id);
            }
        }
    }
}