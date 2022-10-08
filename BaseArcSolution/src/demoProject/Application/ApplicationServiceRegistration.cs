using Application.Features.Category.Rules;
using Core.Security.Entities;
using Core.Security.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ApplicationServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<CategoryBusinessRules>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(typeof(ApplicationServiceRegistration));
            //services.AddIdentity<AppUser, AppRole>(options =>
            //{
            //    options.User.RequireUniqueEmail = false;
            //});

        }
    }
}
