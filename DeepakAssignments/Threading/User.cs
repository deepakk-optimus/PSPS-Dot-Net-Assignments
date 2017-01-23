using System;
using System.Collections.Generic;


namespace Threading
{
    class User
    {
        public User(int Id, string Name, Account Account)
        {
            this.Id = Id;
            this.Name = Name;
            this.Account = Account;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Account Account { get; set; }

        public static List<User> getUsers(int usersCount, int balance)
        {
            List<User> UsersList = new List<User>();

            for (int i = 1; i <= usersCount; i++)
            {
                Account account = new Account(i, balance);
                UsersList.Add(new User(i, "User" + i, account));
            }

            return UsersList;
        }
    }
}
