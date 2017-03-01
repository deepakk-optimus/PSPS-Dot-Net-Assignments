using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemoCodeFirst.DAL;
using WebApiDemoCodeFirst.Models;

namespace WebApiDemoCodeFirst.Controllers
{
    public class StudentController : ApiController
    {
        public StudentController()
        {
        }

        private List<StudentViewModel> students;

        public IHttpActionResult GetAllStudents()
        {
            using (var ctx = new WebApiCodeFirstContext())
            {
                var ptx = ctx.Students;
                students = ptx.ToList();
             }

            if (students.Count == 0)
            {
                return NotFound();
            }

            return Ok(students);
        }

        public IHttpActionResult GetStudentById(int id)
        {
            StudentViewModel student = null;

            using (var ctx = new WebApiCodeFirstContext())
            {
                student = ctx.Students
                    .Where(s => s.Id == id)
                    .Select(s => new StudentViewModel()
                    {
                        Id = s.Id,
                        FirstName = s.FirstName,
                        LastName = s.LastName
                    }).FirstOrDefault<StudentViewModel>();
            }

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        public IHttpActionResult PostNewStudent(StudentViewModel student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var ctx = new WebApiCodeFirstContext())
            {
                ctx.Students.Add(new StudentViewModel()
                {
                    Id= student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName
                });

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
