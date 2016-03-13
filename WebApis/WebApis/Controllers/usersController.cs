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
    public class usersController : ApiController
    {
        private hd_emenuEntities db = new hd_emenuEntities();

        //// GET: api/users
        //public IQueryable<user> Getusers()
        //{
        //    return db.users;
        //}

        //// GET: api/users/5
        //[ResponseType(typeof(user))]
        //public async Task<IHttpActionResult> Getuser(int id)
        //{
        //    user user = await db.users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(user);
        //}

        //// PUT: api/users/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> Putuser(int id, user user)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != user.user_id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(user).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!userExists(id))
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

        // POST: api/users
        /// <summary>
        /// Insert new user into user table 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [ResponseType(typeof(user))]
        public dynamic Postuser(user user)
        {
            try
            {
                var result = db.sp_user_insert(user.user_username, user.user_password, user.user_first_name, user.user_last_name,
                                  user.user_gender, user.user_email, user.user_phone, "111", user.user_date_of_birth, user.country_id);
                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        // PUT: api/users/
        /// <summary>
        /// Get the user details using username and password
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPut]
        [ResponseType(typeof(user))]
        public dynamic Getuser(user user)
        {
            return new { user = db.sp_user_readByUsernameAndPassword(user.user_username, user.user_password) };
        }

        //// DELETE: api/users/5
        //[ResponseType(typeof(user))]
        //public async Task<IHttpActionResult> Deleteuser(int id)
        //{
        //    user user = await db.users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    db.users.Remove(user);
        //    await db.SaveChangesAsync();

        //    return Ok(user);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool userExists(int id)
        {
            return db.users.Count(e => e.user_id == id) > 0;
        }
    }
}