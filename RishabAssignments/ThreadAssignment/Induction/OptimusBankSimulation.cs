using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Induction
{
    class OptimusBankSimulation
    {
        private static Bank bank = Bank.Instance;
        private static double transactionAmount;

        public static double TransactionAmount
        {
            get
            {
                return transactionAmount;
            }
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Optimus Bank\n\nEnter number of ATM's provided by Bank: ");
            int numAtms = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter number of Account's: ");
            int numAccounts = int.Parse(Console.ReadLine());

            ArrayList atms = new ArrayList();

            int count = 1;

            for (count = 1; count <= numAtms; count++)
            {
                ATM atm = new ATM();
                atm.AtmId = count;
                atms.Add(atm);
            }

            bank.ATMs = atms;

            ArrayList accounts = new ArrayList();

            count = 1;

            while (true)
            {

                Console.WriteLine("Enter Account no of holder {0} : ", count);
                int accountId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Balance of holder {0} : ", count);
                double balance = Double.Parse(Console.ReadLine());

                if (balance < 0 || accountId < 0)
                    continue;

                Account account = new Account();
                account.AccountId = accountId;
                account.AccountBalance = balance;

                String random = RandomSequenceGenerator();

                String operationSequence = "";
                for (int parse = 0; parse < 3; parse++)
                {

                    if (random.ToCharArray()[parse] == '0')
                    {
                        operationSequence += "Debit ";
                    }
                    else
                    {
                        operationSequence += "Credit ";
                    }
                }

                Console.WriteLine("Random Operation for Account {0} is {1}", accountId, operationSequence);
                //generate random operation sequence for account
                account.ExecutionSequence = random;

                accounts.Add(account);
                count++;
                if (count > numAccounts)
                {
                    break;
                }
            }

            bank.Accounts = accounts;

            Console.WriteLine("Enter Transaction amount: ");
            transactionAmount = Double.Parse(Console.ReadLine());

            foreach(Account account in accounts)
            {
                Thread thread = new Thread(account.PerformTransactions);
                thread.Start();
            }

            while (true)
            {

                if (ATM.totalTransaction == (numAccounts*3))
                {
                    Console.WriteLine("\n\nFinal Balance\n\n");

                    foreach (Account account in accounts)
                    {
                        Console.WriteLine("Account No: {0} has Balance: {1}", account.AccountId, account.AccountBalance);
                    }
                    break;
                }
            }

            Console.ReadKey();
        }

        private static String RandomSequenceGenerator()
        {
            String sequence = "";
            Random random = new Random();

            for (int count = 0; count < 3; count++)
            {
                sequence += random.Next(2);
            }

            return sequence;
        }


        
    }
}
