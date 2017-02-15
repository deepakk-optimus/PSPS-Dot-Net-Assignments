using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCrudOperations.Models;
using WebApiCrudOperations.Models.DTO;

namespace WebApiCrudOperations.DAL
{
    public interface IProjectRepository : IDisposable
    {
        IQueryable<ProjectDTO> GetAll();
        ProjectDetailDTO GetById(int Id);
        Task<int> Insert(Project project);
        void Update(Project projectj);
        void Delete(int Id);
        void Save();
    }
}
