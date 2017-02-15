using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCrudOperations.Models.DTO
{
    public class ProjectDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CustomerName { get; set; }
        public string SalesContactName { get; set; }
        public string DeliveryContactName { get; set; }
        public string Summary { get; set; }
        public string Risk { get; set; }
        public bool IsSOWSigned { get; set; }
        public bool IsApprove { get; set; }
    }
}