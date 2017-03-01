using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KickOff.Models
{
    [Table("customer_details")]
    public class Customer
    {
        public Customer()
        {
            Projects = new List<Project>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        public string CustomerName { get; set; }
        public string CustomerCategory { get; set; }
        public string CustStatus { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        public string CustomerCreationDate { get; set; }
        public string CustomerModificationDate { get; set; }
    }
}