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
    public class ordersController : ApiController
    {
        private hd_emenuEntities db = new hd_emenuEntities();

        //// GET: api/orders
        ///// <summary>
        ///// Get the list of all the orders
        ///// </summary>
        ///// <returns></returns>
        //public dynamic Getorders()
        //{
        //    return new { order = db.orders };
        //}

        // GET: api/orders/5
        /// <summary>
        /// Get the order details using order id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(order))]
        public dynamic Getorder(int id)
        {
            order order = db.orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(new { order = order });
        }

        //// PUT: api/orders/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> Putorder(int id, order order)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != order.order_id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(order).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!orderExists(id))
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

        // POST: api/orders
        /// <summary>
        /// Insert into order table using user_id and table_id
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [ResponseType(typeof(order))]
        public dynamic Postorder(order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(new { order = db.sp_order_insertByUserIDAndTableID(order.user_id, order.table_id) });
        }

        //// DELETE: api/orders/5
        //[ResponseType(typeof(order))]
        //public async Task<IHttpActionResult> Deleteorder(int id)
        //{
        //    order order = await db.orders.FindAsync(id);
        //    if (order == null)
        //    {
        //        return NotFound();
        //    }

        //    db.orders.Remove(order);
        //    await db.SaveChangesAsync();

        //    return Ok(order);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool orderExists(int id)
        //{
        //    return db.orders.Count(e => e.order_id == id) > 0;
        //}
    }
}