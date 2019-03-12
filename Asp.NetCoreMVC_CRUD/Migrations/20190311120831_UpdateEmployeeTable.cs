using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.NetCoreMVC_CRUD.Migrations
{
    public partial class UpdateEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "varchar (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "varchar",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (50)");
        }
    }
}
