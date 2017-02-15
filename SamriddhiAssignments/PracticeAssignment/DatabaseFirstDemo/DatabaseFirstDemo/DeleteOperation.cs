using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class DeleteOperation
    {
        static void Main()
        {
            using (var dbContext = new ModelFirstDemoDBEntities())
            {
                ReadOperation.readDb();
                var student = (from d in dbContext.Students where d.FirstName == "Jinni" select d).Single();
                dbContext.Students.Remove(student);
                dbContext.SaveChanges();
            }
            ReadOperation.readDb();
        }
    }
}
