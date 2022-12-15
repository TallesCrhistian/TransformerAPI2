using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using TransformerAPI2.Data.Context;

namespace TransformerAPI2.API
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDataBase(this IServiceCollection services, IConfiguration iConfiguration)
        {
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(iConfiguration.GetConnectionString("DefaultConnection")));

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ITransformerServices, TransformerServices>();
            services.AddScoped<ITestServices, TestServices>();

            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<ITransformerBusiness, TransformerBusiness>();
            services.AddScoped<ITestBusiness, TestBusiness>();

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ITransformerRepository, TransformerRepository>();
            services.AddTransient<ITestRepository, TestRepository>();

            return services;
        }

        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TransformerAPI2.API", Version = "v1" });

                c.OperationFilter<SecurityRequirementsOperationFilter>();
            });
            return services;
        }
    }
}