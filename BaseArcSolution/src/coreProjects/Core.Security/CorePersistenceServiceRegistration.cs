using Core.Security.Entities;
using Core.Security.JWT;
using Core.Security.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Security
{
    public static class CorePersistenceServiceRegistration
    {
        public static void AddCorePersistenceServices(this IServiceCollection services,
                                                                IConfiguration configuration)
        {
            services.AddScoped<ITokenHandler, TokenHandler>();
            services.AddDbContext<CoreDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DemoProjectIdentityPostgreSQL")));
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<CoreDbContext>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
