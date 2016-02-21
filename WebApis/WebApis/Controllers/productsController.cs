﻿using System;
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
    public class productsController : ApiController
    {
        private hd_emenuEntities db = new hd_emenuEntities();

        //// GET: api/products
        //public IQueryable<product> Getproducts()
        //{
        //    return db.products;
        //}

        // GET: api/products?category_id={category_id}&language_id={language_id}
        /// <summary>
        /// Get the list of all active products based on the category ID and language ID
        /// </summary>
        /// <param name="category_id"></param>
        /// <param name="language_id"></param>
        /// <returns></returns>
        public dynamic Getproducts(int category_id, int language_id)
        {
            return new { product = db.sp_product_readAllActiveByCategoryIDAndLanguageID(category_id, language_id) };
        }

        //// GET: api/products/5
        //[ResponseType(typeof(product))]
        //public async Task<IHttpActionResult> Getproduct(int id)
        //{
        //    product product = await db.products.FindAsync(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(product);
        //}

        // GET: api/products?product_id={product_id}&language_id={language_id}
        /// <summary>
        /// Get the product details based on product ID and language ID
        /// </summary>
        /// <param name="product_id"></param>
        /// <param name="language_id"></param>
        /// <returns></returns>
        [ResponseType(typeof(product))]
        public dynamic Getproduct(int product_id, int language_id)
        {
            return new { product = db.sp_product_readByProductIDAndLanguageID(product_id, language_id) };
        }

        //// PUT: api/products/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> Putproduct(int id, product product)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != product.product_id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(product).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!productExists(id))
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

        //// POST: api/products
        //[ResponseType(typeof(product))]
        //public async Task<IHttpActionResult> Postproduct(product product)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.products.Add(product);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = product.product_id }, product);
        //}

        //// DELETE: api/products/5
        //[ResponseType(typeof(product))]
        //public async Task<IHttpActionResult> Deleteproduct(int id)
        //{
        //    product product = await db.products.FindAsync(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    db.products.Remove(product);
        //    await db.SaveChangesAsync();

        //    return Ok(product);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool productExists(int id)
        {
            return db.products.Count(e => e.product_id == id) > 0;
        }
    }
}