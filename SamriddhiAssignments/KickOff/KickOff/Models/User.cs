using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KickOff.Models
{
    [Table("users")]
    public class User
    {
        public User()
        {
            UserProfiles = new HashSet<UserProfile>();
        }

        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool State { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
