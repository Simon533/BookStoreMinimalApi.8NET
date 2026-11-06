using BookStoreMinimalApi.AppContext;
using BookStoreMinimalApi.Interfaces;
using BookStoreMinimalApi.Services;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace bookapi_minimal.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddApplicationServices(this IHostApplicationBuilder builder)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            if (builder.Configuration == null) throw new ArgumentNullException(nameof(builder.Configuration));

            // Adding the database context
            builder.Services.AddDbContext<ApplicationContext>(configure =>
            {
                configure.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
            });

            // Adding validators from the current assembly
            builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            builder.Services.AddScoped<IBookService, BookService>();
            builder.Services.AddProblemDetails();
        }
    }
}