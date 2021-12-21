using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testapi.Data;
using testapi.Models;

namespace testapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProductsController : ControllerBase
    {
        /// <summary>
        /// Create Web Ban Hang Context
        /// </summary>
        private readonly WebBanHangContext _context;

        public UserProductsController(WebBanHangContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all List User Product and by name search
        /// </summary>
        /// <param name="nameSearchUserProduct"></param>
        /// <returns></returns>
        // GET: api/UserProducts
        [HttpGet]
        public  ActionResult<IEnumerable<UserProduct>> GetUserProducts(string nameSearchUserProduct)
        {
            var UserProductsList = _context.userProducts;
            if (String.IsNullOrEmpty(nameSearchUserProduct))
            {
                return  UserProductsList.ToList();
            }

            return  UserProductsList.Where(x => x.nameUser.Contains(nameSearchUserProduct)).ToList();
        }

        /// <summary>
        /// Get UserProducts by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/UserProducts/5
        [HttpGet("{id}")]
        public  ActionResult<UserProduct> GetUserProduct(string id)
        {
            var userProduct =  _context.userProducts.Find(id);

            if (userProduct == null)
            {
                return NotFound();
            }

            return userProduct;
        }

        /// <summary>
        /// Edit UserProducts by Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userProduct"></param>
        /// <returns></returns>
        // PUT: api/UserProducts/5
        [HttpPut("{id}")]
        public  IActionResult PutUserProduct(string id, UserProduct userProduct)
        {
            if (id != userProduct.idUser)
            {
                return BadRequest();
            }

            _context.Entry(userProduct).State = EntityState.Modified;

            try
            {
                 _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        /// <summary>
        /// Add UserProducts
        /// </summary>
        /// <param name="userProduct"></param>
        /// <returns></returns>
        // POST: api/UserProducts
        [HttpPost]
        public  ActionResult<UserProduct> PostUserProduct(UserProduct userProduct)
        {
            _context.userProducts.Add(userProduct);
            try
            {
                 _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (UserProductExists(userProduct.idUser))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserProduct", new { id = userProduct.idUser }, userProduct);
        }

        /// <summary>
        /// Delete Product by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE: api/UserProducts/5
        [HttpDelete("{id}")]
        public  IActionResult DeleteUserProduct(string id)
        {
            var userProduct =  _context.userProducts.Find(id);
            if (userProduct == null)
            {
                return NotFound();
            }
            _context.userProducts.Remove(userProduct);
             _context.SaveChanges();
            return NoContent();
        }

        /// <summary>
        /// id exists list userproduct 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool UserProductExists(string id)
        {
            return _context.userProducts.Any(e => e.idUser == id);
        }
    }
}
