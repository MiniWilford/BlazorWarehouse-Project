using Microsoft.EntityFrameworkCore;
using WarehouseClassLibraryMVC.Entities;

namespace WarehouseClassLibraryMVC.Data
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options) : base(options)
        {

        }

        //Dbsets
        public DbSet<Companies> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }


        // Seeding Values in DB
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(

                new Product { ProductId = 1, ProductName = "Cheese Pizza", ProductPrice = 9.99f },
                new Product { ProductId = 2, ProductName = "Pepperoni Pizza", ProductPrice = 12.99f },
                new Product { ProductId = 3, ProductName = "Bread Sticks", ProductPrice = 4.99f },
                new Product { ProductId = 4, ProductName = "Salad", ProductPrice = 2.99f }
                );

            modelBuilder.Entity<Manager>().HasData(

                new Manager { ManagerId = 1, FirstName = "Kyle", LastName = "DeJarnett", Title = "Owner" },
                new Manager { ManagerId = 2, FirstName = "Justin", LastName = "Smith", Title = "Assistant Manager" }
                );

            //modelBuilder.Entity<Employee>().HasData(
            //  new Employee { EmployeeId = 1, FirstName = "KJ", LastName="DeJarnett",  }
            //);
        }

    }
}
