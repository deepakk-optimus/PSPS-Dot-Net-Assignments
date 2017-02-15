using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using WebApiCrudOperations.Helpers;
using WebApiCrudOperations.Models;
using WebApiCrudOperations.Models.DTO;

namespace WebApiCrudOperations.DAL
{
    public class ProjectRepository : IProjectRepository, IDisposable
    {
        private WebApiCrudOperationsContext context;
       
        public ProjectRepository(WebApiCrudOperationsContext context)
        {
            this.context = context;
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProjectDTO> GetAll()
        {
            var projects = from pro in context.Projects
                           select new ProjectDTO()
                           {
                               Id = pro.ProjectId,
                               Name = pro.Name
                           };
            return projects;
        }


        public ProjectDetailDTO GetById(int Id)
        {
            var project =  context.Projects.Select(b =>
             new ProjectDetailDTO()
             {
                 Id = b.ProjectId,
                 Name = b.Name,
                 CustomerName = b.Customer.Name,
                 SalesContactName = b.SalesContact.Name,
                 DeliveryContactName = b.DeliveryContact.Name,
                 Summary = b.Summary,
                 Risk = b.Risk,
                 IsSOWSigned = b.IsSOWSigned,
                 IsApprove = b.IsApprove
             }).SingleOrDefault(b => b.Id == Id);

            return project;

        }

        public async Task<int> Insert(Project project)
        {
            context.Projects.Add(project);
    
            return await context.SaveChangesAsync();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Project projectj)
        {
            throw new NotImplementedException();
        }
    }
}