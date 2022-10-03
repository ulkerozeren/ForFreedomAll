using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Contexts
{
    //public class BaseDbContext : IdentityDbContext<AppUser, AppRole, string>
    public class BaseDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public BaseDbContext(DbContextOptions options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
