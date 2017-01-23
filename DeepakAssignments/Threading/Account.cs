using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    class Account
    {
        public Account(int Id, int balance)
        {
            this.Id = Id;
            this.balance = balance;
            this.Operations = getOperations();
        }
        public int Id { get; set; }
        public int balance { get; set; }
        public Queue<string> Operations { get; set; }

        private Queue<string> getOperations()
        {
            Random random = new Random();
            Queue<string> operationsList = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                int num = random.Next(0, 2);
                Console.WriteLine(num);
                Operations operations = (Operations)num;
                operationsList.Enqueue(operations.ToString());
            }

            return operationsList;

        }

    }
}
