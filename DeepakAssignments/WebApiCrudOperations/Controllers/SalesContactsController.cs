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
using WebApiCrudOperations.Models;

namespace WebApiCrudOperations.Controllers
{
    public class SalesContactsController : ApiController
    {
        private WebApiCrudOperationsContext db = new WebApiCrudOperationsContext();

        // GET: api/SalesContacts
        public IQueryable<SalesContact> GetSalesContacts()
        {
            return db.SalesContacts;
        }

        // GET: api/SalesContacts/5
        [ResponseType(typeof(SalesContact))]
        public async Task<IHttpActionResult> GetSalesContact(int id)
        {
            SalesContact salesContact = await db.SalesContacts.FindAsync(id);
            if (salesContact == null)
            {
                return NotFound();
            }

            return Ok(salesContact);
        }

        // PUT: api/SalesContacts/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSalesContact(int id, SalesContact salesContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != salesContact.SalesContactId)
            {
                return BadRequest();
            }

            db.Entry(salesContact).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesContactExists(id))
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

        // POST: api/SalesContacts
        [ResponseType(typeof(SalesContact))]
        public async Task<IHttpActionResult> PostSalesContact(SalesContact salesContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SalesContacts.Add(salesContact);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = salesContact.SalesContactId }, salesContact);
        }

        // DELETE: api/SalesContacts/5
        [ResponseType(typeof(SalesContact))]
        public async Task<IHttpActionResult> DeleteSalesContact(int id)
        {
            SalesContact salesContact = await db.SalesContacts.FindAsync(id);
            if (salesContact == null)
            {
                return NotFound();
            }

            db.SalesContacts.Remove(salesContact);
            await db.SaveChangesAsync();

            return Ok(salesContact);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SalesContactExists(int id)
        {
            return db.SalesContacts.Count(e => e.SalesContactId == id) > 0;
        }
    }
}