using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KickOff.Models
{
    [Table("deliverycontact_details")]
    public class DeliveryContact
    {
        public DeliveryContact()
        {
            Projects = new List<Project>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("deliveryContactName")]
        public string DeliveryContactName { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        [Column("status")]
        public string Status { get; set; }
    }
}