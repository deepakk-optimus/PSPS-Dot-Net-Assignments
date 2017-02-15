using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemoCodeFirst.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual AddressViewModel Address { get; set; }
        public virtual StandardViewModel Standard { get; set; }
    }
}