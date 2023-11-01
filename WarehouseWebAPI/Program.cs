using Microsoft.EntityFrameworkCore;
using WarehouseClassLibraryMVC.Data;

namespace WarehouseWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // DB context
            builder.Services.AddDbContext<WarehouseContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("WarehouseDB"));
            });

            builder.Services.AddControllers();

            /*
            // TODO: CORS requirements, implement later
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CorsAllowAll",
                    policy =>
                    {
                        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                    });
            });

            */

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}