using Microsoft.AspNetCore.Mvc;
using ProductApi.Data;
using ProductApi.Models;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        // GET all products
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var products = _context.Products.ToList();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET product by id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var product = _context.Products.Find(id);

                if (product == null)
                    return NotFound("Product not found");

                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST add product
        [HttpPost]
        public IActionResult Add(Product product)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(product.Name) || product.Price <= 0)
                    return BadRequest("Invalid product data");

                _context.Products.Add(product);
                _context.SaveChanges();

                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT update product
        [HttpPut("{id}")]
        public IActionResult Update(int id, Product updated)
        {
            try
            {
                var product = _context.Products.Find(id);

                if (product == null)
                    return NotFound("Product not found");

                product.Name = updated.Name;
                product.Category = updated.Category;
                product.Price = updated.Price;
                product.Stock = updated.Stock;

                _context.SaveChanges();

                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE product
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var product = _context.Products.Find(id);

                if (product == null)
                    return NotFound("Product not found");

                _context.Products.Remove(product);
                _context.SaveChanges();

                return Ok("Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("category/{category}")]

                // GET products by category
public IActionResult GetByCategory(string category)
{
    try
    {
        var products = _context.Products
            .Where(p => p.Category.ToLower() == category.ToLower())
            .ToList();

        if (products.Count == 0)
            return NotFound("No products found in this category");

        return Ok(products);
    }
    catch (Exception ex)
    {
        return StatusCode(500, ex.Message);
    }
}
[HttpGet("sort")]
public IActionResult SortByPrice(string order = "asc")
{
    try
    {
        var products = order.ToLower() == "desc"
            ? _context.Products.OrderByDescending(p => p.Price).ToList()
            : _context.Products.OrderBy(p => p.Price).ToList();

        return Ok(products);
    }
    catch (Exception ex)
    {
        return StatusCode(500, ex.Message);
    }
}
}
}