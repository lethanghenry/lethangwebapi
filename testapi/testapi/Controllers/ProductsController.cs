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
    public class ProductsController : ControllerBase
    {
        /// <summary>
        /// Create web ban hang context
        /// </summary>
        private readonly WebBanHangContext _context;

        /// <summary>
        /// Create Controller
        /// </summary>
        /// <param name="context"></param>
        public ProductsController(WebBanHangContext context)
        {
            _context = context;
        }

        /// <summary>
        /// get List Product by search
        /// </summary>
        /// <param name="nameSearchProduct"></param>
        /// <param name="nameSearchProductByCategory"></param>
        /// <param name="sortOrder"></param>
        /// <returns></returns>
        // GET: api/Products
        [HttpGet]
        public  ActionResult<IEnumerable<Product>> GetProducts(string nameSearchProduct, string nameSearchProductByCategory, int? sortOrder)
        {
            var productList = _context.products;
            if (String.IsNullOrEmpty(nameSearchProduct) && String.IsNullOrEmpty(nameSearchProductByCategory) && sortOrder > 6)
            {
                return  productList.ToList();
            }
            if (!String.IsNullOrEmpty(nameSearchProduct))
            {
                return  productList.Where(x => x.nameProduct.Contains(nameSearchProduct)).ToList();
            }
            if (!String.IsNullOrEmpty(nameSearchProductByCategory))
            {
                string idResultCategory = "";
                List<Product> listResult = new List<Product>();
                foreach (var item in _context.categories)
                {
                    if (item.nameCategory.Equals(nameSearchProductByCategory))
                    {
                        idResultCategory = item.idCategory;
                        break;
                    }
                }
                foreach (var item2 in _context.products)
                {
                    if (item2.idCategory.Equals(idResultCategory))
                    {
                        listResult.Add(item2);
                    }
                }
                return listResult.ToList();
            }

            if (sortOrder > 0 && sortOrder < 7)
            {
                var productResult = from m in _context.products select m;
                switch (sortOrder)
                {

                    case 1:
                        productResult = productResult.OrderBy(s => s.nameProduct);
                        break;
                    case 2:
                        productResult = productResult.OrderBy(s => s.idProduct);
                        break;
                    case 3:
                        productResult = productResult.OrderBy(s => s.rateProduct);
                        break;
                    case 4:
                        productResult = productResult.OrderBy(s => s.idProduct);
                        break;
                    case 5:
                        productResult = productResult.OrderBy(s => s.priceProduct);
                        break;
                    case 6:
                        productResult = productResult.OrderByDescending(s => s.priceProduct);
                        break;
                }
                return productResult.ToList();
            }
            return  productList.ToList();

        }

        /// <summary>
        /// Get List Product by Category (4 item)
        /// </summary>
        /// <param name="nameSearchProductByCategory4"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Bycate")]
        public  ActionResult<IEnumerable<Product>> GetProductByCate4(string nameSearchProductByCategory4)
        {
            if (!String.IsNullOrEmpty(nameSearchProductByCategory4))
            {
                string idResultCategory4 = "";
                List<Product> listResult4 = new List<Product>();
                int count = 0;
                foreach (var item in _context.categories)
                {
                    if (item.nameCategory.Equals(nameSearchProductByCategory4))
                    {
                        idResultCategory4 = item.idCategory;
                        break;
                    }
                }

                foreach (var item2 in _context.products)
                {

                    if (item2.idCategory.Equals(idResultCategory4))
                    {
                        count++;
                        if (count < 5)
                        {
                            listResult4.Add(item2);
                        }
                    }
                }
                return listResult4.ToList();
            }
            return null;
        }

        /// <summary>
        /// Get List Product Max
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("max")]
        public  ActionResult<IEnumerable<Product>> GetProductMaxRate()
        {
            return _context.products.Where(pro => pro.rateProduct == 5).ToList();
        }

        /// <summary>
        /// Get Product by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Products/5
        [HttpGet("{id}")]
        public  ActionResult<Product> GetProduct(string id)
        {
            var product =  _context.products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        /// <summary>
        /// Put Product 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        // PUT: api/Products/5
        [HttpPut("{id}")]
        public  IActionResult PutProduct(string id, Product product)
        {
            if (id != product.idProduct)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;
            try
            {
                 _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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
        /// Post product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        // POST: api/Products
        [HttpPost]
        public  ActionResult<Product> PostProduct(Product product)
        {
            _context.products.Add(product);
            try
            {
                 _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProductExists(product.idProduct))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProduct", new { id = product.idProduct }, product);
        }

        /// <summary>
        /// Delete Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public  IActionResult DeleteProduct(string id)
        {
            var product =  _context.products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.products.Remove(product);
             _context.SaveChanges();

            return NoContent();
        }

        /// <summary>
        /// id exists list product 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool ProductExists(string id)
        {
            return _context.products.Any(e => e.idProduct == id);
        }
    }
}
