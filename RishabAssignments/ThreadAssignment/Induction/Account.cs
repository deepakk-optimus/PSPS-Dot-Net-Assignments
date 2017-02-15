using System;
using System.Collections;
using System.Threading;

namespace Induction
{
    class Account
    {
        private int accountId;

        private double accountBalance;

        private String executionSequence;

        private static ArrayList atms = Bank.Instance.ATMs;

        public int currentExecution = 0;

        public int AccountId
        {
            get
            {
                return accountId;
            }

            set
            {
                accountId = value;
            }
        }

        public double AccountBalance
        {
            get
            {
                return accountBalance;
            }

            set
            {
                accountBalance = value;
            }
        }

        public String ExecutionSequence
        {
            get
            {
                return executionSequence;
            }

            set
            {
                executionSequence = value;
            }
        }

        public void PerformTransactions()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            while (true)
            {
                if (this.currentExecution >= 3)
                    break;

                foreach (ATM atm in atms)
                {
                    if (this.currentExecution < 3)
                        lock (atm)
                        {
                            
                            //this.rwl.AcquireWriterLock(100);
                            Console.WriteLine("ATM id {0} performed {1} operation on Account {2}", atm.AtmId, (currentExecution + 1), this.AccountId);
                            char operation = this.ExecutionSequence.ToCharArray()[currentExecution];
                            if (operation == '0')
                            {
                                PerformDebit();
                            }
                            else
                            {
                                PerformCredit();
                            }

                            currentExecution++;
                            ATM.totalTransaction++;
                            //Thread.Sleep(1000);
                            //atm.Rwl.ReleaseReaderLock();
                            // break;

                        }
                }


            }
        }

        public void PerformCredit()
        {
            this.accountBalance += OptimusBankSimulation.TransactionAmount;
            Console.WriteLine("Account {0} credited with current balance Rs. {1}", this.AccountId, this.AccountBalance);
        }

        public void PerformDebit()
        {
            if (this.accountBalance - OptimusBankSimulation.TransactionAmount >= 0)
            {
                this.accountBalance -= OptimusBankSimulation.TransactionAmount;

                Console.WriteLine("Account {0} debited with current balance Rs. {1}", this.AccountId, this.AccountBalance);

            }
            else
            {
                Console.WriteLine("Account {0} cannot be debited", this.AccountId);
            }
        }



    }
}

