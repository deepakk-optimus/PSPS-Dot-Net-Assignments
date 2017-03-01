using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KickOff.ModelView
{
    /// <summary>
    /// Displaying Customer Model View Comments
    /// </summary>
    public class CustomerModelView
    {
        [Required]
        public int Id { get; set; }

        public string CustomerName { get; set; }
        public string CustomerCategory { get; set; }
        public string Status { get; set; }
       
        public virtual ICollection<ProjectViewModel> Projects { get; set; }
        public string CustomerCreationDate { get; set; }
        public string CustomerModificationDate { get; set; }
    }
}