using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class UpdateOperation
    {
        static void Main(string[] args)
        {
            ReadOperation.readDb();

            using (var dbContext = new ModelFirstDemoDBEntities())
            {
                var student = (from d in dbContext.Students where d.FirstName == "Harry" select d).Single();
                student.LastName = "Potter";
                dbContext.SaveChanges();
            }
            ReadOperation.readDb();
        }
    }
}
