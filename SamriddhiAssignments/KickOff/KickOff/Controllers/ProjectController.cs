using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using KickOff.DAL;
using KickOff.Models;
using KickOff.ModelView;
using KickOff.Service;
using log4net;
using KickOff.Repository;
using System.Threading.Tasks;

namespace KickOff.Controllers
{
    public class ProjectController : ApiController
    {
        private static readonly ILog logger = log4net.LogManager.GetLogger(typeof(ProjectController));
        private static KickOffContext context = new KickOffContext();
        ProjectService ProjectService = new ProjectServiceImpl(context);

        /*public readonly ProjectService ProjectService;

        public ProjectController(ProjectService service)
        {
            this.ProjectService = service;
        }*/

        /*private ICustomerRepository CustomerRepository;

        public ProjectController(ICustomerRepository repository)
        {
            CustomerRepository = repository;
        }*/




        
        // POST: api/Project
        [ResponseType(typeof(ProjectViewModel))]
        public IHttpActionResult PostProject(ProjectViewModel projectViewModel)
        {
            logger.Info("Application started ");
            /*Test data
            logger.Info("Hello Thanks for use Log4Net,This is info message");
            logger.Debug("Hello Thanks for use Log4Net,This is Debug message");
            logger.Error("Hello Thanks for use Log4Net,This is Error message");
            logger.Warn("Hello Thanks for use Log4Net,This is Warn message");
            logger.Fatal("Hello Thanks for use Log4Net,This is Fatal message");*/
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //TODO : call method to convert modelview to model
            Project project = ProjectService.ProjectViewModelToProjectModel(projectViewModel);
            //project = ProjectService.PersistProject(project);
            ProjectService.Insert(project);
            ProjectViewModel ProjectViewModel = ProjectService.ProjectModelToProjectViewModel(project);
            return CreatedAtRoute("DefaultApi", new { id = project.Id }, ProjectViewModel);
        }

    }
}