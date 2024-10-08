using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_1.Migrations
{
    /// <inheritdoc />
    public partial class SetNullDeptIdOnDepartmentDelete01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DeptID",
                table: "Employee");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DeptID",
                table: "Employee",
                column: "DeptID",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DeptID",
                table: "Employee");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DeptID",
                table: "Employee",
                column: "DeptID",
                principalTable: "Department",
                principalColumn: "Id");
        }
    }
}
