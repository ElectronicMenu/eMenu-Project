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
    public class taxesController : ApiController
    {
        private hd_emenuEntities db = new hd_emenuEntities();

        // GET: api/taxes
        /// <summary>
        /// Get all the taxes from the taxes table
        /// </summary>
        /// <returns></returns>
        public dynamic Gettaxes()
        {
            return new { tax = db.sp_tax_readAll() };
        }

        // GET: api/taxes/5
        /// <summary>
        /// Get the tax details using the tax id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(tax))]
        public dynamic Gettax(int id)
        {
            return new { tax = db.sp_tax_readById(id) };
        }

        //// PUT: api/taxes/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> Puttax(int id, tax tax)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != tax.tax_id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(tax).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!taxExists(id))
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

        //// POST: api/taxes
        //[ResponseType(typeof(tax))]
        //public async Task<IHttpActionResult> Posttax(tax tax)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.taxes.Add(tax);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = tax.tax_id }, tax);
        //}

        //// DELETE: api/taxes/5
        //[ResponseType(typeof(tax))]
        //public async Task<IHttpActionResult> Deletetax(int id)
        //{
        //    tax tax = await db.taxes.FindAsync(id);
        //    if (tax == null)
        //    {
        //        return NotFound();
        //    }

        //    db.taxes.Remove(tax);
        //    await db.SaveChangesAsync();

        //    return Ok(tax);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool taxExists(int id)
        //{
        //    return db.taxes.Count(e => e.tax_id == id) > 0;
        //}
    }
}