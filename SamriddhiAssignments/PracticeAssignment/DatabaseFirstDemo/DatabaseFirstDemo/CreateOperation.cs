using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class CreateOperation
    {
        static void Main(string[] args)
        {
            var student1 = new Student
            {
                Id = 2,
                FirstName = "Jinni",
                LastName = ".",
                EnrollmentId = ""
            };

            ReadOperation.readDb();

            using (var dbContext = new ModelFirstDemoDBEntities())
            {
                dbContext.Students.Add(student1);
                dbContext.SaveChanges();
            }

            ReadOperation.readDb();
        }
    }
}
