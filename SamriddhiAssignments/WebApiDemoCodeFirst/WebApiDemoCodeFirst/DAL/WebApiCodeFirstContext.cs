using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiDemoCodeFirst.Models;

namespace WebApiDemoCodeFirst.DAL
{
    public class WebApiCodeFirstContext : DbContext
    {
        public WebApiCodeFirstContext() : base()
        {

        }

        public DbSet<AddressViewModel> Address { get; set; }
        public DbSet<StandardViewModel> Standards { get; set; }
        public DbSet<StudentViewModel> Students { get; set; }
    }

}