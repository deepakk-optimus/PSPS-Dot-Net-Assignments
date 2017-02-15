using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCrudOperations.Models;
using WebApiCrudOperations.Models.DTO;

namespace WebApiCrudOperations.DAL
{
    public interface ICustomerRepository
    {
        ICollection<CustomerDTO> GetAll();
        CustomerDTO GetById(int Id);
        Task<int> Insert(Customer cust);
        void Update(Customer cust);
        void Delete(int Id);
        void Save();
    }
}
