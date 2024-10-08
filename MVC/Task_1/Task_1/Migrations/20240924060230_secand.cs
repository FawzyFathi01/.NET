using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_1.Migrations
{
    /// <inheritdoc />
    public partial class secand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employee_EmployeeId",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Department",
                newName: "ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_EmployeeId",
                table: "Department",
                newName: "IX_Department_ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employee_ManagerId",
                table: "Department",
                column: "ManagerId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employee_ManagerId",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "Department",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_ManagerId",
                table: "Department",
                newName: "IX_Department_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employee_EmployeeId",
                table: "Department",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
