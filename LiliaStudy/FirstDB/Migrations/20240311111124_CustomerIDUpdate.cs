using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstDB.Migrations
{
    public partial class CustomerIDUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "Customer_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Customer_id",
                table: "Customers",
                newName: "Id");
        }
    }
}
