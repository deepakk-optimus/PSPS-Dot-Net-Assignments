using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemoCodeFirst.Models
{
    public class StandardViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<StudentViewModel> Students { get; set; }
    }
}