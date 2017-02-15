using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiCrudOperations.Models
{
    public class Project
    {
       
        public int ProjectId { get; set; }
        //Foreign key
        public int CustomerId { get; set; }
        public int DeliveryContactId { get; set; }
        public int SalesContactId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Risk { get; set; }
        public bool IsSOWSigned { get; set; }
        public bool IsApprove { get; set; }
        //[Required]
        public string DeliveryContactMail { get; set; }
        //[Required]
        public string DeliveryContactName { get; set; }
        //[Required]
        public string CommercialContactMail { get; set; }
        //[Required]
        public string CommercialContactName { get; set; }
        public string VerifiedBy { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? SowStartDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? SowStopDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? CreationDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? ModificationDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual DeliveryContact DeliveryContact { get; set; }
        public virtual SalesContact SalesContact { get; set; }
    }
}