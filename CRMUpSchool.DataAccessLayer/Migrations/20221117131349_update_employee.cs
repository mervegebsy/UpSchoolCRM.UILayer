using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMUpSchool.DataAccessLayer.Migrations
{
    public partial class update_employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeMail",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeMail",
                table: "Employees");
        }
    }
}
