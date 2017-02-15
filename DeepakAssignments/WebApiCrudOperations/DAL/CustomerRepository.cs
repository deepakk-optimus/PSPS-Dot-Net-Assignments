using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using WebApiCrudOperations.Models;
using WebApiCrudOperations.Models.DTO;

namespace WebApiCrudOperations.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private WebApiCrudOperationsContext context;

        public CustomerRepository(WebApiCrudOperationsContext context)
        {
            this.context = context;
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<CustomerDTO> GetAll()
        {
            var customers = context.Customers.ToList();
            ICollection<CustomerDTO> custDtoList = new Collection<CustomerDTO>();
            foreach(Customer c in customers)
            {
                ICollection<Project> projectList = c.Projects;
                ICollection<ProjectDTO> projectDtoList = new Collection<ProjectDTO>();
                foreach(Project p in projectList)
                {
                    ProjectDTO projectDto = new ProjectDTO
                    {
                        Id = p.ProjectId,
                        Name = p.Name        
                    };

                    projectDtoList.Add(projectDto);
                }
                CustomerDTO custDto = new CustomerDTO
                {
                    Id = c.CustomerId,
                    Name = c.Name,
                    Category = c.Category,
                    Projects = projectDtoList
                };
                custDtoList.Add(custDto);
            }

            return custDtoList;


        }

        public CustomerDTO GetById(int Id)
        {
            var customer = context.Customers.Find(Id);
            if (customer != null)
            {
                ICollection<Project> projectList = customer.Projects;
                ICollection<ProjectDTO> projectDtoList = new Collection<ProjectDTO>();

                foreach (Project p in projectList)
                {
                    ProjectDTO projectDto = new ProjectDTO
                    {
                        Id = p.ProjectId,
                        Name = p.Name
                    };

                    projectDtoList.Add(projectDto);
                }
                CustomerDTO custDto = new CustomerDTO
                {
                    Id = customer.CustomerId,
                    Name = customer.Name,
                    Category = customer.Category,
                    Projects = projectDtoList
                };

                return custDto;
            }

            return null;
        }

        public async Task<int> Insert(Customer cust)
        {
            context.Customers.Add(cust);

            return await context.SaveChangesAsync();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer cust)
        {
            throw new NotImplementedException();
        }

        

        private bool CustomerExists(int id)
        {
            return context.Customers.Count(e => e.CustomerId == id) > 0;
        }
    }
}