using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApis;

namespace WebApis.Controllers
{
    public class tablesController : ApiController
    {
        private hd_emenuEntities db = new hd_emenuEntities();

        // GET: api/tables
        /// <summary>
        /// Get the list of all the tables in the restaurant
        /// </summary>
        /// <returns></returns>
        public dynamic Gettables()
        {
            return new { table = db.sp_table_readAll() };
        }

        // POST: api/tables
        /// <summary>
        /// Get the table details that matches the table number and password
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        [ResponseType(typeof(table))]
        public dynamic Posttable(table table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(new { table = db.sp_table_readByTableNumberAndPassword(table.table_number, table.table_password) } );
        }

        /*
        // GET: api/tables/5
        [ResponseType(typeof(table))]
        public IHttpActionResult Gettable(int id)
        {
            table table = db.tables.Find(id);
            if (table == null)
            {
                return NotFound();
            }

            return Ok(table);
        }

        // PUT: api/tables/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttable(int id, table table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != table.table_id)
            {
                return BadRequest();
            }

            db.Entry(table).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tableExists(id))
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

        

        // DELETE: api/tables/5
        [ResponseType(typeof(table))]
        public IHttpActionResult Deletetable(int id)
        {
            table table = db.tables.Find(id);
            if (table == null)
            {
                return NotFound();
            }

            db.tables.Remove(table);
            db.SaveChanges();

            return Ok(table);
        }
         */

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tableExists(int id)
        {
            return db.tables.Count(e => e.table_id == id) > 0;
        }
    }
}