using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCrudOperations.Models.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public ICollection<ProjectDTO> Projects { get; set; }
    }
}