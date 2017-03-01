using KickOff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KickOff.DAL
{
    public class KickOffInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<KickOffContext>
    {
        protected override void Seed(KickOffContext context)
        {
            var customers = new List<Customer>
            {
                new Customer { Id=1, CustomerName="MonkeyMedia", CustomerCategory= "TNM", CustStatus="Archive" }
            };
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
        }
    }
}