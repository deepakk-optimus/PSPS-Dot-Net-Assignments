using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ModelFirstDemoDBContext())
            {
                // Create and save a new Student

                Console.Write("Enter a name for a new Student: ");
                var firstName = Console.ReadLine();

                Console.Write("Enter a last name for a new Student: ");
                var lastName = Console.ReadLine();

                var student = new Student
                {
                    Id = 1,
                    FirstName = firstName,
                    LastName = lastName,
                    EnrollmentId = "1"
                };

                db.Students.Add(student);
                db.SaveChanges();

                var query = from b in db.Students
                            orderby b.FirstName
                            select b;

                Console.WriteLine("All student in the database:");

                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
