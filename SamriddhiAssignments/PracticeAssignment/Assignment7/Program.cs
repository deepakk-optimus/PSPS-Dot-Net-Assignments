using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class SavingsAccount
    {

        public double currBalance;

        public static double currInterestRate = 0.04;

        public SavingsAccount(double balance) { currBalance = balance; }

        public static void SetInterestRate(double newRate) { currInterestRate = newRate; }

        public static double GetInterestRate() { return currInterestRate; }

        public void SetInterestRateObj(double newRate) { currInterestRate = newRate; }

        public double GetInterestRateObj() { return currInterestRate; }

        static void Main(string[] args)

        {

            SavingsAccount s1 = new SavingsAccount(50);

            SavingsAccount s2 = new SavingsAccount(100);

            Console.WriteLine("Interest Rate is: {0}",

            s1.GetInterestRateObj());

            s2.SetInterestRateObj(0.08);

            Console.WriteLine("Interest Rate is: {0}",

            s1.GetInterestRateObj());

            SavingsAccount s3 = new SavingsAccount(10000.75);

            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            Console.ReadKey();

        }

    }

}
