using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CoreDbContext>
    {
        public CoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CoreDbContext>();
            var connectionString = "User ID = postgresUser; Password = postgresPW; Host = 46.101.98.153; Port = 5432; Database = IdentityCore; ";
            builder.UseNpgsql(connectionString);
            return new CoreDbContext(builder.Options);
        }
    }
}
