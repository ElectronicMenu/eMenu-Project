using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApis.Models;

namespace WebApis.Controllers
{
    public class user_cartController : ApiController
    {
        private hd_emenuEntities db = new hd_emenuEntities();

        // GET: api/user_cart?user_id={user_id}&cart_id={cart_id}
        /// <summary>
        /// Get user_cart by user_id and cart_id
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="cart_id"></param>
        /// <returns></returns>
        public dynamic Getuser_cart(int user_id, int cart_id)
        {
            return new { User_Cart = db.sp_user_cart_readByUserIDAndCartID(user_id,cart_id) };
        }

        // POST: api/user_cart?user_id={user_id}&cart_id={cart_id}
        /// <summary>
        /// Insert into cart using user_id and cart_id
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="cart_id"></param>
        /// <returns></returns>
        [ResponseType(typeof(User_CartModel))]
        public dynamic Postuser_cart(int user_id, int cart_id)
        {
            try
            {
                 var result = db.sp_user_cart_insert(user_id, cart_id);
                 if (result == 1)
                     return true;
                 else
                     return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
