using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    class Bank
    {
        public Bank(string Name, List<ATM> Atms, List<User> Users)
        {
            this.Name = Name;
            this.Atms = Atms;
            this.Users = Users;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<ATM> Atms { get; set; }
        public List<User> Users { get; set; }

    }
}
