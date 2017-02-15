using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCrudOperations.Models
{
    public class SalesContact
    {
        public int SalesContactId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}