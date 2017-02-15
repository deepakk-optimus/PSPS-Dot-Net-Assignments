using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiCrudOperations.Models
{
    public class WebApiCrudOperationsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public WebApiCrudOperationsContext() : base("name=WebApiCrudOperationsContext")
        {
            Database.SetInitializer<WebApiCrudOperationsContext>(new DropCreateDatabaseIfModelChanges<WebApiCrudOperationsContext>());
        }

        public System.Data.Entity.DbSet<WebApiCrudOperations.Models.Project> Projects { get; set; }

        public System.Data.Entity.DbSet<WebApiCrudOperations.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<WebApiCrudOperations.Models.DeliveryContact> DeliveryContacts { get; set; }

        public System.Data.Entity.DbSet<WebApiCrudOperations.Models.SalesContact> SalesContacts { get; set; }
    }
}
