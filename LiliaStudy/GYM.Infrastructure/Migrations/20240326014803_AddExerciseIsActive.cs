using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYM.Infrastructure.Migrations
{
    public partial class AddExerciseIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "GYM_EXERCISE",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "GYM_EXERCISE");
        }
    }
}
