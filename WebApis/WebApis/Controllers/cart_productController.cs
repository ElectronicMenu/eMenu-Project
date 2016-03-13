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
    public class cart_productController : ApiController
    {
        private hd_emenuEntities db = new hd_emenuEntities();

        //// GET: api/cart_product
        //public IQueryable<cart_product> Getcart_product()
        //{
        //    return db.cart_product;
        //}

        //// GET: api/cart_product/5
        //[ResponseType(typeof(cart_product))]
        //public async Task<IHttpActionResult> Getcart_product(int id)
        //{
        //    cart_product cart_product = await db.cart_product.FindAsync(id);
        //    if (cart_product == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(cart_product);
        //}

        // GET: api/cart_product/5
        /// <summary>
        /// Get the list of all the products for a particulat cart based on the language selected
        /// </summary>
        /// <param name="cart_id"></param>
        /// <param name="language_id"></param>
        /// <returns></returns>
        [ResponseType(typeof(cart_product))]
        public dynamic Getcart_product(int cart_id, int language_id)
        {
            return new { cart_product = db.sp_cart_product_product_readByCartIDAndLanguageID(cart_id, language_id) };
        }

        // PUT: api/cart_product/5
        /// <summary>
        /// Update cart by using cart id, product id, and quantity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cart_product"></param>
        /// <returns></returns>
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putcart_product(int id, cart_product cart_product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cart_product.cart_id)
            {
                return BadRequest();
            }

            return Ok( db.sp_cart_product_updateByCartIDAndProductID(id, cart_product.product_id, cart_product.quantity) );

        }

        // POST: api/cart_product
        /// <summary>
        /// Insert a new product into the cart using cart id, product id, and quantity
        /// </summary>
        /// <param name="cart_product"></param>
        /// <returns></returns>
        [ResponseType(typeof(cart_product))]
        public async Task<IHttpActionResult> Postcart_product(cart_product cart_product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sp_cart_product_insert(cart_product.cart_id, cart_product.product_id, cart_product.quantity);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (cart_productExists(cart_product.cart_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cart_product.cart_id }, cart_product);
        }

        // DELETE: api/cart_product/5
        /// <summary>
        /// Delete product from the cart
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(cart_product))]
        public async Task<IHttpActionResult> Deletecart_product(int id)
        {
            cart_product cart_product = await db.cart_product.FindAsync(id);
            if (cart_product == null)
            {
                return NotFound();
            }

            db.cart_product.Remove(cart_product);
            await db.SaveChangesAsync();

            return Ok(cart_product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool cart_productExists(int id)
        {
            return db.cart_product.Count(e => e.cart_id == id) > 0;
        }
    }
}