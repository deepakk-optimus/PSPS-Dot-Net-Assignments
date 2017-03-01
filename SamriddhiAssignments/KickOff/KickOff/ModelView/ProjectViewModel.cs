using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KickOff.ModelView
{
    public class ProjectViewModel
    {
        public string Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectIdentificationNumber { get; set; }
        public string ProjectSummary { get; set; }
        public string ProjectRisk { get; set; }
        public string PotentialOpportunity { get; set; }

        public string CustomerId { get; set; }
        public string SalesContactId { get; set; }
        public string DeliveryContactId { get; set; }

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

    }
}