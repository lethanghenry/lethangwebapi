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
    public class CategoriesController : ControllerBase
    {
        /// <summary>
        /// Create Web Context
        /// </summary>
        private readonly WebBanHangContext _context;

        /// <summary>
        /// Create controller Categories
        /// </summary>
        /// <param name="context"></param>
        public CategoriesController(WebBanHangContext context)
        {
            _context = context;
        }

        /// <summary>
        /// get all list Categories and by name search Category
        /// </summary>
        /// <param name="nameSearchCategory"></param>
        /// <returns></returns>
        // GET: api/Categories
        [HttpGet]
        public  ActionResult<IEnumerable<Category>> Getcactegories(string nameSearchCategory)
        {
            var categoriesList = _context.categories;
            if (String.IsNullOrEmpty(nameSearchCategory))
            {
                return  categoriesList.ToList();
            }

            return  categoriesList.Where(x => x.nameCategory.Contains(nameSearchCategory)).ToList();
        }

        /// <summary>
        /// get Category by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Categories/5
        [HttpGet("{id}")]
        public  ActionResult<Category> GetCategory(string id)
        {
            var category =  _context.categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        /// <summary>
        /// Edit Category by Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public IActionResult PutCategory(string id, Category category)
        {
            if (id != category.idCategory)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                 _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
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
        /// Add category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        // POST: api/Categories
        [HttpPost]
        public  ActionResult<Category> PostCategory(Category category)
        {
            _context.categories.Add(category);
            try
            {
                 _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CategoryExists(category.idCategory))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCategory", new { id = category.idCategory }, category);
        }

        /// <summary>
        /// Delete Category By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public  IActionResult DeleteCategory(string id)
        {
            var category =  _context.categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.categories.Remove(category);
             _context.SaveChanges();

            return NoContent();
        }

        /// <summary>
        /// id exists list categories 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool CategoryExists(string id)
        {
            return _context.categories.Any(e => e.idCategory == id);
        }
    }
}
