using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseClassLibraryMVC.Migrations
{
    /// <inheritdoc />
    public partial class UpdateManager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Employees_EmployeeId",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Managers_EmployeeId",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Managers");

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Managers_ManagerId",
                table: "Employees",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Managers_ManagerId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Managers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "ManagerId",
                keyValue: 1,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "ManagerId",
                keyValue: 2,
                column: "EmployeeId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Managers_EmployeeId",
                table: "Managers",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Employees_EmployeeId",
                table: "Managers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
