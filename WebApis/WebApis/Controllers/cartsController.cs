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
    public class cartsController : ApiController
    {
        private hd_emenuEntities db = new hd_emenuEntities();

        //// GET: api/carts
        //public IQueryable<cart> Getcarts()
        //{
        //    return db.carts;
        //}

        //// GET: api/carts/5
        //[ResponseType(typeof(cart))]
        //public async Task<IHttpActionResult> Getcart(int id)
        //{
        //    cart cart = await db.carts.FindAsync(id);
        //    if (cart == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(cart);
        //}

        // GET: api/carts?table_id={table_id}&user_id={user_id}
        /// <summary>
        /// Get the cart details based on table id and user id 
        /// </summary>
        /// <param name="table_id"></param>
        /// <param name="user_id"></param>
        /// <returns></returns>
        [ResponseType(typeof(cart))]
        public dynamic Getcart(int table_id)
        {
            return new { cart = db.sp_cart_readByTableID(table_id) };
        }

        //// POST: api/carts?table_id={table_id}&user_id={user_id}
        ///// <summary>
        /////  Insert into cart using table id and user id and return the result of the last inserted row
        ///// </summary>
        ///// <param name="table_id"></param>
        ///// <param name="user_id"></param>
        ///// <returns></returns>
        //[ResponseType(typeof(cart))]
        //public dynamic Insertcart(int table_id, int user_id)
        //{
        //    return new { cart = db.sp_cart_insert(table_id,user_id) };
        //}
        
        //// PUT: api/carts/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> Putcart(int id, cart cart)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != cart.cart_id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(cart).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!cartExists(id))
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

        // POST: api/carts
        /// <summary>
        /// Insert into cart using table id and return the result of the last inserted row
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        [ResponseType(typeof(cart))]
        public async Task<IHttpActionResult> Postcart(cart cart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.carts.Add(cart);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cart.cart_id }, cart);
        }

        // DELETE: api/carts/5
        /// <summary>
        /// Delete the Cart based on the cart_id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(cart))]
        public async Task<IHttpActionResult> Deletecart(int id)
        {
            cart cart = await db.carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }

            db.carts.Remove(cart);
            await db.SaveChangesAsync();

            return Ok(cart);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool cartExists(int id)
        {
            return db.carts.Count(e => e.cart_id == id) > 0;
        }
    }
}