using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KickOff.Models
{
    [Table("user_profile")]
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}