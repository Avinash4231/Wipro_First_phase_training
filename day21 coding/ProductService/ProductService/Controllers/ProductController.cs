using Microsoft.AspNetCore.Mvc;
using ProductService.Data;
using ProductService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductService.Controllers
{
    [Route("api/shopping/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public ProductController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //fetch all the products from database ---- collection
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _dbContext.Products.ToList();
        }

        //fetch the product by id
        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _dbContext.Products.Where(x=>x.Id ==id).FirstOrDefault();
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            try
            {
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, product);
            }
            catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError);


            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
