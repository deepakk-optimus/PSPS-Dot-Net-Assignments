using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiCrudOperations.Models
{
    public class Customer
    {
        public Customer()
        {
            IsActive = true;
        }

        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? CreationDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? ModificationDate { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}