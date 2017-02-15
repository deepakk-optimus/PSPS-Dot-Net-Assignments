using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiCrudOperations.DAL;
using WebApiCrudOperations.Helpers;
using WebApiCrudOperations.Models;
using WebApiCrudOperations.Models.DTO;

namespace WebApiCrudOperations.Controllers
{
    
    public class ProjectsController : ApiController
    {
        public readonly IProjectRepository projectRepository;

        public ProjectsController(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        // GET: api/Projects
        public HttpResponseMessage GetProjects()
        {
            var projects = projectRepository.GetAll();
            if (projects.Count() == 0)
            {
                string message = string.Format("No Project found");
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }
            return Request.CreateResponse(HttpStatusCode.OK, projects);
        }


        // GET: api/Projects/5
        [ResponseType(typeof(ProjectDetailDTO))]
        public HttpResponseMessage GetProject([FromUri] int id)
        {
            var project = projectRepository.GetById(id);
            if (project == null)
            {
                string message = string.Format("No Project found with ID = {0}", id);
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }

            return Request.CreateResponse(HttpStatusCode.OK, project); 
        }
        /*
        // PUT: api/Projects/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProject(int id, Project project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != project.ProjectId)
            {
                return BadRequest();
            }

            db.Entry(project).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        */
        // POST: api/Projects
        [ResponseType(typeof(Project))]
        public async Task<IHttpActionResult> PostProject(Project project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await projectRepository.Insert(project);
            var projectDto = projectRepository.GetById(project.ProjectId);
            Email.SendEmail(projectDto);
            return CreatedAtRoute("DefaultApi", new { id = project.ProjectId }, project);
        }
        /*
        // DELETE: api/Projects/5
        [ResponseType(typeof(Project))]
        public async Task<IHttpActionResult> DeleteProject(int id)
        {
            Project project = await db.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }

            db.Projects.Remove(project);
            await db.SaveChangesAsync();

            return Ok(project);
        }
       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProjectExists(int id)
        {
            return db.Projects.Count(e => e.ProjectId == id) > 0;
        }
         
         private async Task<ProjectDetailDTO> getProject(int id)
        {
            return await projectRepository.GetById(id);
        }*/
    }
}