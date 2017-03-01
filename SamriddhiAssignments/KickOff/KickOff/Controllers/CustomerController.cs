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
using KickOff.Repository;
using KickOff.Authentication;
using log4net;
using KickOff.ExceptionHandle;

namespace KickOff.Controllers
{
    /// <summary>
    /// Customer Controller comments
    /// </summary>
    //[KickOffAuthentication] //- for Authentication
    public class CustomerController : ApiController
    {
        private static readonly ILog logger = log4net.LogManager.GetLogger(typeof(CustomerController));

        private ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Add customer to database
        /// </summary>
        /// <param name="customerModelView"></param>
        /// <returns></returns>
        // POST: api/Customer
        [ResponseType(typeof(CustomerModelView))]
        public IHttpActionResult PostCustomer(CustomerModelView customerModelView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var customer = CustomerViewModelMapper.ToEntity(customerModelView);
            _repository.AddCustomer(customer);
            

            CustomerModelView cust = CustomerViewModelMapper.ToViewModel(customer);

            return CreatedAtRoute("DefaultApi", new { id = cust.Id }, cust);
        }

        /// <summary>
        /// Retrieve Customer from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Customer/5
        [ResponseType(typeof(CustomerModelView))]
        //[MethodExceptionHandlingFilter]
        public IHttpActionResult GetCustomer(string id)
        {
            int custId;
            Int32.TryParse(id, out custId);

            if (!Int32.TryParse(id, out custId))
            {
                //throw new Exception();
                throw new KickOffException() { ErrorDescription = "Invalid customer Id" , ErrorCode = "40001"};
            }
            Customer customer = _repository.GetCustomer(custId);
            
            if (customer == null)
            {
                return NotFound();
            }
            CustomerModelView cust = CustomerViewModelMapper.ToViewModel(customer);
            
            return Ok(cust);
        }

        /// <summary>
        /// Get All Customers
        /// </summary>
        /// <returns></returns>
        // GET: api/Customer
        //[KickOffAuthentication] - used for authorization on this call 
        [KickOffAuthentication(true)]
        public ICollection<CustomerModelView> GetCustomers()
        {
            logger.Info("Getting all customers");
            var dbCustomers = _repository.GetCustomers();
            List<CustomerModelView> CustomerModelViews = new List<CustomerModelView>();
            foreach(var cust in dbCustomers)
            {
                CustomerModelViews.Add(cust.ToViewModel());
            }
            logger.Info("all customers retrieved");
            return CustomerModelViews;
            //return DateTime.Now.ToString();
        }


        /*private KickOffContext db = new KickOffContext();

        // GET: api/Customer
        public IQueryable<Customer> GetCustomers()
        {
            return db.Customers;
        }

        // GET: api/Customer/5
        [ResponseType(typeof(Customer))]
        public IHttpActionResult GetCustomer(int id)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: api/Customer/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customer.Id)
            {
                return BadRequest();
            }

            db.Entry(customer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
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

        // POST: api/Customer
        [ResponseType(typeof(Customer))]
        public IHttpActionResult PostCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Customers.Add(customer);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = customer.Id }, customer);
        }

        // DELETE: api/Customer/5
        [ResponseType(typeof(Customer))]
        public IHttpActionResult DeleteCustomer(int id)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            db.Customers.Remove(customer);
            db.SaveChanges();

            return Ok(customer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CustomerExists(int id)
        {
            return db.Customers.Count(e => e.Id == id) > 0;
        }*/
    }
}