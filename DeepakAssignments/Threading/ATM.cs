using System;
using System.Collections.Generic;


namespace Threading
{
    class ATM
    {
        public ATM(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<ATM> getAtms(int atmCount)
        {
            List<ATM> AtmList = new List<ATM>();
            for (int i = 1; i <= atmCount; i++)
            {
                AtmList.Add(new ATM(i, "ATM" + i));
            }
            return AtmList;
        }

        public static void doTransaction(string operation, Account account, int transactionAmount, ATM atm)
        {
            Console.WriteLine("Doing {0} operation on account {1} on atm {2}", operation, account.Id, atm.Id);
            lock (typeof(ATM))
            {
                if (operation.Equals("Credit"))
                {
                    doCredit(account, transactionAmount);
                }
                else
                {
                    doDebit(account, transactionAmount);
                }
            }

        }


        private static void doCredit(Account account, int transactionAmount)
        {
            account.balance = account.balance + transactionAmount;
        }

        private static void doDebit(Account account, int transactionAmount)
        {
            if (account.balance < transactionAmount)
            {
                Console.WriteLine("Unable to debit from account {0} due to low balance. Current balance is {1}", account.Id, account.balance);
            }
            else
            {
                account.balance = account.balance - transactionAmount;
            }
        }

    }
}
