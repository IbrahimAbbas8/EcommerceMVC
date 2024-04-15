using IEcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace IEcommerceMVC.Data.DataBaseContexts
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
