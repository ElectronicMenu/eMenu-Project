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
    public class languagesController : ApiController
    {
        private hd_emenuEntities db = new hd_emenuEntities();

        // GET: api/languages
        /// <summary>
        /// Get the list of all the languages
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public dynamic Getlanguages()
        {
            return new { language = db.sp_language_readAll() };
        }

        // GET: api/languages
        /// <summary>
        /// Get the list of all the languages which are set active
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public dynamic Getlanguages(bool active)
        {
            return new { language = db.sp_language_readAllActive() };
        }

        // GET: api/languages/5
        /// <summary>
        /// Get the language details that matches the id
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        [ResponseType(typeof(language))]
        public async Task<IHttpActionResult> Getlanguage(int id)
        {
            language language = await db.languages.FindAsync(id);
            if (language == null)
            {
                return NotFound();
            }

            return Ok(new { language = db.sp_language_readByID(id) } );
        }

        //// PUT: api/languages/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> Putlanguage(int id, language language)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != language.language_id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(language).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!languageExists(id))
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

        //// POST: api/languages
        //[ResponseType(typeof(language))]
        //public async Task<IHttpActionResult> Postlanguage(language language)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.languages.Add(language);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = language.language_id }, language);
        //}

        //// DELETE: api/languages/5
        //[ResponseType(typeof(language))]
        //public async Task<IHttpActionResult> Deletelanguage(int id)
        //{
        //    language language = await db.languages.FindAsync(id);
        //    if (language == null)
        //    {
        //        return NotFound();
        //    }

        //    db.languages.Remove(language);
        //    await db.SaveChangesAsync();

        //    return Ok(language);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool languageExists(int id)
        {
            return db.languages.Count(e => e.language_id == id) > 0;
        }
    }
}