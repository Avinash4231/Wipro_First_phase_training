using Microsoft.EntityFrameworkCore;
using ProductService.Models;
namespace ProductService.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product>Products { get; set; }
    }
}
