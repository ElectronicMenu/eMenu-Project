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
    public class categoriesController : ApiController
    {
        private hd_emenuEntities db = new hd_emenuEntities();

        // GET: api/categories
        /// <summary>
        /// Get the list of all the categories
        /// </summary>
        /// <returns></returns>
        public dynamic Getcategories()
        {
            return new { category = db.sp_category_category_language_readAll() };
        }

        // GET: api/categories?language_id={language_id}
        /// <summary>
        /// Get the list of all the categories based on the language ID
        /// </summary>
        /// <param name="language_id"></param>
        /// <returns></returns>
        public dynamic Getcategories(int language_id)
        {
            return new { category = db.sp_category_category_language_readAllByLangguageID(language_id) };
        }

        // GET: api/categories/5
        /// <summary>
        ///  Get the category details that matches the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(category))]
        public dynamic Getcategory(int id)
        {
            return Ok(new { category = db.sp_category_category_language_readByCategoryID(id) });
        }

        // GET: api/categories?category_id={category_id}&language_id={language_id}
        /// <summary>
        ///  Get the category details that matches the category id and language id
        /// </summary>
        /// <param name="category_id"></param>
        /// <param name="language_id"></param>
        /// <returns></returns>
        [ResponseType(typeof(category))]
        public dynamic Getcategory(int category_id, int language_id )
        {
            return Ok(new { category = db.sp_category_category_language_readByCategoryIDAndLanguageID(category_id, language_id) });
        }

        //// PUT: api/categories/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> Putcategory(int id, category category)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != category.category_id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(category).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!categoryExists(id))
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

        //// POST: api/categories
        //[ResponseType(typeof(category))]
        //public async Task<IHttpActionResult> Postcategory(category category)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.categories.Add(category);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = category.category_id }, category);
        //}

        //// DELETE: api/categories/5
        //[ResponseType(typeof(category))]
        //public async Task<IHttpActionResult> Deletecategory(int id)
        //{
        //    category category = await db.categories.FindAsync(id);
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }

        //    db.categories.Remove(category);
        //    await db.SaveChangesAsync();

        //    return Ok(category);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool categoryExists(int id)
        {
            return db.categories.Count(e => e.category_id == id) > 0;
        }
    }
}