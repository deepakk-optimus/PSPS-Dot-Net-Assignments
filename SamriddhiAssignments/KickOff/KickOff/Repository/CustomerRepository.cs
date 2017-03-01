using KickOff.DAL;
using KickOff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KickOff.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private KickOffContext DbContext;

        public CustomerRepository(KickOffContext context)
        {
            this.DbContext = context;
        }

        public Customer GetCustomer(Int32? id)
        {
            //return DbContext.Customers.Find(id);
            return DbContext.Set<Customer>().FirstOrDefault(customer => customer.Id == id);
        }

        public Customer AddCustomer(Customer customer)
        {
            DbContext.Customers.Add(customer);
            DbContext.SaveChanges();
            return customer;
        }

        public ICollection<Customer> GetCustomers()
        {
            return DbContext.Customers.ToList();
        }
    }
}