using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static Bank bank = null;
        static Random random = new Random();
        static int transactionAmount;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of Bank");
            var BankName = Console.ReadLine();

            Console.WriteLine("Enter the number of Atm");
            string inputAtmCount = Console.ReadLine();
            int AtmCount = Convert.ToInt32(inputAtmCount);
           
            Console.WriteLine("Enter the number of Users");
            string inputUsersCount = Console.ReadLine();
            int UsersCount = Convert.ToInt32(inputUsersCount);

            Console.WriteLine("Enter the initial balance for each account");
            string inputBalance = Console.ReadLine();
            int balance = Convert.ToInt32(inputBalance);

            List<ATM> AtmList = ATM.getAtms(AtmCount);
            List<User> UsersList = User.getUsers(UsersCount, balance);

           foreach(User user in UsersList)
            {
                Queue<string> operations = user.Account.Operations;
                Console.WriteLine(user.Name);
                foreach(string o in operations)
                {
                    Console.Write(o+",");
                    
                }
                Console.WriteLine();
            }
           

            bank = new Bank(BankName, AtmList, UsersList);

            Console.WriteLine("Enter the transaction amount");
            string inputTransactionAmount = Console.ReadLine();
            transactionAmount = Convert.ToInt32(inputTransactionAmount);
           
            Parallel.ForEach(bank.Atms, (currentAtm) =>
            {
                Program p = new Program();
                p.Run(currentAtm);
            });
           
            foreach (User user in UsersList)
            {
                Console.WriteLine("Balance for account {0} is {1}",user.Account.Id, user.Account.balance);
            }
            Console.ReadKey();
        }

        public void Run(Object atm)
        {
            List<User> AccountList = bank.Users;
      
                for (int i = 0; i < AccountList.Count; i++)
                {
                    User user = AccountList[i];
                    Queue<string> operations = user.Account.Operations;
                    while (operations.Any())
                    {
                       string operation = operations.Dequeue();
                       ATM.doTransaction(operation, user.Account, transactionAmount,(ATM)atm);
                      
                    }
                }     
            
        }    
    }  
}
