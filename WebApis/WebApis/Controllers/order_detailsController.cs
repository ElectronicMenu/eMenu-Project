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
using WebApis;

namespace WebApis.Controllers
{
    public class order_detailsController : ApiController
    {
        private hd_emenuEntities db = new hd_emenuEntities();

        //// GET: api/order_details
        //public IQueryable<order_details> Getorder_details()
        //{
        //    return db.order_details;
        //}

        // GET: api/order_details/5
        /// <summary>
        /// Get the order details for a particular order using the order id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(order_details))]
        public async Task<IHttpActionResult> Getorder_details(int id)
        {
            order_details order_details = await db.order_details.FindAsync(id);
            if (order_details == null)
            {
                return NotFound();
            }

            return Ok(new { order_details = order_details });
        }

        //// PUT: api/order_details/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> Putorder_details(int id, order_details order_details)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != order_details.order_id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(order_details).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!order_detailsExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/order_details
        /// <summary>
        /// Insert into order_details using cart_id and order_id
        /// </summary>
        /// <param name="cart_id"></param>
        /// <param name="order_id"></param>
        /// <returns></returns>
        [ResponseType(typeof(order_details))]
        public dynamic Postorder_details(int cart_id, int order_id)
        {
            return Ok(new { order = db.sp_order_details_insertByCartIDAndOrderID(cart_id, order_id) });
        }

        //// DELETE: api/order_details/5
        //[ResponseType(typeof(order_details))]
        //public async Task<IHttpActionResult> Deleteorder_details(int id)
        //{
        //    order_details order_details = await db.order_details.FindAsync(id);
        //    if (order_details == null)
        //    {
        //        return NotFound();
        //    }

        //    db.order_details.Remove(order_details);
        //    await db.SaveChangesAsync();

        //    return Ok(order_details);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool order_detailsExists(int id)
        //{
        //    return db.order_details.Count(e => e.order_id == id) > 0;
        //}
    }
}