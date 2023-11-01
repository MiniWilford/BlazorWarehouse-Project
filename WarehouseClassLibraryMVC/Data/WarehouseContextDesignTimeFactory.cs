using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseClassLibraryMVC.Data
{
    internal class WarehouseContextDesignTimeFactory : IDesignTimeDbContextFactory<WarehouseContext>
    {
        // Implemented Interface Method 
        public WarehouseContext CreateDbContext(string[] args)
        {
            var configureation = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<WarehouseContext>();

            optionsBuilder.UseSqlServer(configureation.GetConnectionString("WarehouseDB"));

            return new WarehouseContext(optionsBuilder.Options);
        }
    }
}
