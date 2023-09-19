using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private ProductDbContext _dbConext;

        public ProductApiController(ProductDbContext dbContext)
        {
            _dbConext = dbContext;
        }

        // Read All
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_dbConext.Product.ToList());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product obj)
        {
            _dbConext.Product.Add(obj);
            _dbConext.SaveChanges();
            return Ok(new { result = "Product details added to the database." });
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Product obj)
        {
            _dbConext.Entry(obj).State = EntityState.Modified;
            _dbConext.SaveChanges();
            return Ok(new { result = "Product details updated to database." });
        }


        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            Product obj = _dbConext.Product.Find(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested Product details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Product obj = _dbConext.Product.Find(id);
            _dbConext.Product.Remove(obj);
            _dbConext.SaveChanges();
            return Ok(new { result = "Product details are deleted from database." });
        }
    }
}
