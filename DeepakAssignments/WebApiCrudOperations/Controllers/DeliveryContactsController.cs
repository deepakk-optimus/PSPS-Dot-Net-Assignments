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
    public class DeliveryContactsController : ApiController
    {
        private WebApiCrudOperationsContext db = new WebApiCrudOperationsContext();

        // GET: api/DeliveryContacts
        public IQueryable<DeliveryContact> GetDeliveryContacts()
        {
            return db.DeliveryContacts;
        }

        // GET: api/DeliveryContacts/5
        [ResponseType(typeof(DeliveryContact))]
        public async Task<IHttpActionResult> GetDeliveryContact(int id)
        {
            DeliveryContact deliveryContact = await db.DeliveryContacts.FindAsync(id);
            if (deliveryContact == null)
            {
                return NotFound();
            }

            return Ok(deliveryContact);
        }

        // PUT: api/DeliveryContacts/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDeliveryContact(int id, DeliveryContact deliveryContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != deliveryContact.DeliveryContactId)
            {
                return BadRequest();
            }

            db.Entry(deliveryContact).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryContactExists(id))
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

        // POST: api/DeliveryContacts
        [ResponseType(typeof(DeliveryContact))]
        public async Task<IHttpActionResult> PostDeliveryContact(DeliveryContact deliveryContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DeliveryContacts.Add(deliveryContact);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = deliveryContact.DeliveryContactId }, deliveryContact);
        }

        // DELETE: api/DeliveryContacts/5
        [ResponseType(typeof(DeliveryContact))]
        public async Task<IHttpActionResult> DeleteDeliveryContact(int id)
        {
            DeliveryContact deliveryContact = await db.DeliveryContacts.FindAsync(id);
            if (deliveryContact == null)
            {
                return NotFound();
            }

            db.DeliveryContacts.Remove(deliveryContact);
            await db.SaveChangesAsync();

            return Ok(deliveryContact);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DeliveryContactExists(int id)
        {
            return db.DeliveryContacts.Count(e => e.DeliveryContactId == id) > 0;
        }
    }
}