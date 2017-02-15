using log4net;
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
using WebApiCrudOperations.Models;
using WebApiCrudOperations.Models.DTO;

namespace WebApiCrudOperations.Controllers
{
    public class CustomersController : ApiController
    {
        private static log4net.ILog Log { get; set; }
        ILog log = log4net.LogManager.GetLogger(typeof(CustomersController));

        public readonly ICustomerRepository customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        // GET: api/Customers
        public ICollection<CustomerDTO> GetCustomers()
        {
            //customerRepository.GetAll();
            log.Info("Getting all Customers");
            log.Error("Error in getting customers form db");
            return customerRepository.GetAll();
        }

      // GET: api/Customers/5
        [ResponseType(typeof(CustomerDTO))]
        public HttpResponseMessage GetCustomer(int id)
        {
            CustomerDTO customerDTO = customerRepository.GetById(id);
            if (customerDTO == null)
            {
                string message = string.Format("No Customer found with ID = {0}", id);
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }
            return Request.CreateResponse(HttpStatusCode.OK, customerDTO);
        }
        
     /* // PUT: api/Customers/5
      [ResponseType(typeof(void))]
      public async Task<IHttpActionResult> PutCustomer(int id, Customer customer)
      {
          if (!ModelState.IsValid)
          {
              return BadRequest(ModelState);
          }

          if (id != customer.CustomerId)
          {
              return BadRequest();
          }

          db.Entry(customer).State = EntityState.Modified;

          try
          {
              await db.SaveChangesAsync();
          }
          catch (DbUpdateConcurrencyException)
          {
              if (!CustomerExists(id))
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
      // POST: api/Customers
      [ResponseType(typeof(Customer))]
      public async Task<IHttpActionResult> PostCustomer(Customer customer)
      {
          if (!ModelState.IsValid)
          {
              return BadRequest(ModelState);
          }

          await customerRepository.Insert(customer);

          return CreatedAtRoute("DefaultApi", new { id = customer.CustomerId }, customer);
      }
        /*
      // DELETE: api/Customers/5
      [ResponseType(typeof(Customer))]
      public async Task<IHttpActionResult> DeleteCustomer(int id)
      {
          Customer customer = await db.Customers.FindAsync(id);
          if (customer == null)
          {
              return NotFound();
          }

          db.Customers.Remove(customer);
          await db.SaveChangesAsync();

          return Ok(customer);
      }
      */
      

     
    }
}