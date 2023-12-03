using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseClassLibraryMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddedProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ProductName", "ProductPrice" },
                values: new object[] { "Frozen Pizza", 4.99f });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ProductName", "ProductPrice" },
                values: new object[] { "Hammer and Nails", 9.99f });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ProductName", "ProductPrice" },
                values: new object[] { "Forklift", 3999.99f });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ProductName", "ProductPrice" },
                values: new object[] { "Microwave", 299.99f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ProductName", "ProductPrice" },
                values: new object[] { "Cheese Pizza", 9.99f });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ProductName", "ProductPrice" },
                values: new object[] { "Pepperoni Pizza", 12.99f });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ProductName", "ProductPrice" },
                values: new object[] { "Bread Sticks", 4.99f });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ProductName", "ProductPrice" },
                values: new object[] { "Salad", 2.99f });
        }
    }
}
