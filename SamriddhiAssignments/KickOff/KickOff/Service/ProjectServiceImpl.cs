using KickOff.DAL;
using KickOff.Models;
using KickOff.ModelView;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace KickOff.Service
{
    public class ProjectServiceImpl : ProjectService
    {
        private static readonly ILog logger = log4net.LogManager.GetLogger("ErrorLog");

        private KickOffContext context;

        public ProjectServiceImpl(KickOffContext context)
        {
            this.context = context;
        }

        public Project ProjectViewModelToProjectModel(ProjectViewModel projectViewModel)
        {
            Project result = new Project();
            result.ProjectName = projectViewModel.ProjectName;

            result.ProjectIdentificationNumber = null;
            result.ProjectSummary = null;
            result.ProjectRisk = null;
            result.PotentialOpportunity = null;
            
            
            CustomerService CustomerService = new CustomerServiceImpl();
            string CustomerId = projectViewModel.CustomerId;
            int custId;


            //TODO: see how parsing and validating field can be done in view model
            if (Int32.TryParse(CustomerId, out custId))
            {
                if (CustomerId != null)
                {
                    result.Customer = CustomerService.findCustomerById(custId);
                }
            }
            result.SalesContact = null;
            result.DeliveryContact = null;
            result.NatureOfProject = null;
            result.PaymentTerms = null;
            result.SowDolar = null;
            result.HourlyBillingRate = null;
            result.IsSowSigned = false;
            result.Approve = false;
            result.SowCopy = null;
            result.DeliveryContactName = null;
            result.DeliveryContactMail = null;
            result.CommercialContact = null;
            result.CommercialContactMail = null;
            result.InvoiceContactName = null;
            result.InvoiceContactMail = null;
            result.SResponse = null;
            result.VerifiedBy = null;
            result.SowStopDate = null;
            result.SowApprovalDate = null;
            result.SowStartDate = null;
            result.ProjectCreationDate = null;
            result.ProjectModificationDate = null;

            //add other fields to result
            return result;
        }

        public ProjectViewModel ProjectModelToProjectViewModel(Project project)
        {
            ProjectViewModel ProjectViewModel = new ProjectViewModel();

            //project = findProject(project.Id);

            ProjectViewModel.Id = project.Id.ToString();
            ProjectViewModel.ProjectName = project.ProjectName;
            ProjectViewModel.CustomerId = (project.CustomerId).ToString();
            return ProjectViewModel;
        }

        public async Task<int> Insert(Project project)
        {
            context.Projects.Add(project);

            return await context.SaveChangesAsync();
        }

        public Project PersistProject(Project project)
        {
            using (var ctx = new KickOffContext())
            {
                ctx.Set<Project>().Add(project);
                /*ctx.Projects.Add(project);

                try
                {
                    ctx.SaveChanges();
                }
                catch (DbUpdateException exception)
                {
                    logger.Error(exception.Message);
                }
                catch (DbEntityValidationException ex)
                {
                    logger.Error(ex.Message);

                    StringBuilder sb = new StringBuilder();

                    foreach (var failure in ex.EntityValidationErrors)
                    {
                        sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                        foreach (var error in failure.ValidationErrors)
                        {
                            sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                            sb.AppendLine();
                        }
                    }

                    throw new DbEntityValidationException(
                        "Entity Validation Failed - errors follow:\n" +
                        sb.ToString(), ex
                    ); // Add the original exception as the innerException
                }*/
            }
             return project;
         }

        /*private bool ProjectExists(string id)
        {
            return db.Projects.Count(e => e.Id == id) > 0;
        }*/
    }
}