using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class ReadOperation
    {
        static internal void readDb()
        {
            using (var dbContext = new ModelFirstDemoDBEntities())
            {
                var student = (from d in dbContext.Students select d);

                Console.WriteLine("All student in the database:");

                foreach (var item in student)
                {
                    Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName + " " + item.EnrollmentId);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
        
}
