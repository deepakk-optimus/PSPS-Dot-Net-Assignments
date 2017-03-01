using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KickOff.Models
{
    [Table("project_details")]
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectIdentificationNumber { get; set; }
        public string ProjectSummary { get; set; }
        public string ProjectRisk { get; set; }
        public string PotentialOpportunity { get; set; }

        public int CustomerId { get; set; }
        public int SalesContactId { get; set; }
        public int DeliveryContactId { get; set; }
        
        public string NatureOfProject { get; set; }
        public string PaymentTerms { get; set; }
        public string SowDolar { get; set; }
        public string HourlyBillingRate { get; set; }
        public bool IsSowSigned { get; set; }
        public bool Approve { get; set; }
        public string SowCopy { get; set; }
        public string DeliveryContactName { get; set; }
        public string DeliveryContactMail { get; set; }
        public string CommercialContact { get; set; }
        public string CommercialContactMail { get; set; }
        public string InvoiceContactName { get; set; }
        public string InvoiceContactMail { get; set; }
        public string SResponse { get; set; }
        public string VerifiedBy { get; set; }
        public string SowStopDate { get; set; }
        public string SowApprovalDate { get; set; }
        public string SowStartDate { get; set; }
        public string ProjectCreationDate { get; set; }
        public string ProjectModificationDate { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("SalesContactId")]
        public virtual SalesContact SalesContact { get; set; }
        [ForeignKey("DeliveryContactId")]
        public virtual DeliveryContact DeliveryContact { get; set; }
    }
}