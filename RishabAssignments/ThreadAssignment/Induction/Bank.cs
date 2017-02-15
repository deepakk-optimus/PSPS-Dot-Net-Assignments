using System.Collections.Generic;
using System.Collections;

namespace Induction
{
    public sealed class Bank
    {
        private ArrayList atms;
        private ArrayList accounts;

        private static Bank instance = null;
        private static readonly object padlock = new object();

        //Private constructor for thread safe singleton
        private Bank()
        {

        }

        public static Bank Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Bank();
                    }
                    return instance;
                }
            }
        }


        public ArrayList ATMs
        {
            get
            {
                return atms;
            }

            set
            {
                atms = value;
            }
        }

        public ArrayList Accounts
        {
            get
            {
                return accounts;
            }

            set
            {
                accounts = value;
            }
        }
    }
}
