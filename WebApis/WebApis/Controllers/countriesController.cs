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
    public class countriesController : ApiController
    {
        private hd_emenuEntities db = new hd_emenuEntities();

        // GET: api/countries
        /// <summary>
        /// Get the list of all the countries
        /// </summary>
        /// <returns></returns>
        public dynamic Getcountries()
        {
            return new { country = db.sp_Country_readAll() };
        }

        // GET: api/countries/5
        /// <summary>
        /// Get the details of the country using the country id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(country))]
        public dynamic Getcountry(int id)
        {
            return new { country = db.sp_country_readById(id) };
        }

        //// PUT: api/countries/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> Putcountry(int id, country country)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != country.country_id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(country).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!countryExists(id))
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

        //// POST: api/countries
        //[ResponseType(typeof(country))]
        //public async Task<IHttpActionResult> Postcountry(country country)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.countries.Add(country);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = country.country_id }, country);
        //}

        //// DELETE: api/countries/5
        //[ResponseType(typeof(country))]
        //public async Task<IHttpActionResult> Deletecountry(int id)
        //{
        //    country country = await db.countries.FindAsync(id);
        //    if (country == null)
        //    {
        //        return NotFound();
        //    }

        //    db.countries.Remove(country);
        //    await db.SaveChangesAsync();

        //    return Ok(country);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool countryExists(int id)
        //{
        //    return db.countries.Count(e => e.country_id == id) > 0;
        //}
    }
}