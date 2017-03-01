using KickOff.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace KickOff.DAL
{
    public class KickOffContext : DbContext
    {
        public KickOffContext() : base("name=KickOffContext")
        {
            Database.SetInitializer<KickOffContext>(new DropCreateDatabaseIfModelChanges<KickOffContext>());
            //Disable initializer   Database.SetInitializer<KickOffContext>(null);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<DeliveryContact> DeliveryContacts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<SalesContact> SalesContacts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}