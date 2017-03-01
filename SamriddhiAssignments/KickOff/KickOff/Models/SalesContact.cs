using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KickOff.Models
{
    [Table("salescontact_details")]
    public class SalesContact
    {
        public SalesContact()
        {
            Projects = new List<Project>();
        }

        [Key]
        public int Id { get; set; }
        public string SalesPersonName { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}