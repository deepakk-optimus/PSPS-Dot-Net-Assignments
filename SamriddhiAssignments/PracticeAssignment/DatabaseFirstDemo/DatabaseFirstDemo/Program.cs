using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new ModelFirstDemoDBEntities())
            {

                var query = from b in db.Students
                            orderby b.FirstName
                            select b;

                Console.WriteLine("All All student in the database:");

                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
