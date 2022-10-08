using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Core.Security
{
    public class CoreDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
       // public CoreDbContext(DbContextOptions options) : base(options)
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {
           
        }

      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgresUser;Password=postgresPW;Host=46.101.98.153;Port=5432;Database=IdentityCore;");
        }

        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
