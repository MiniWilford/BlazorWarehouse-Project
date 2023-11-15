using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseClassLibraryMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddedCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "City", "CompanyName", "PostalCode", "State" },
                values: new object[] { 1, "123 Main St", "New York", "Rust Tools", "1235", "Maine" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 1);
        }
    }
}
