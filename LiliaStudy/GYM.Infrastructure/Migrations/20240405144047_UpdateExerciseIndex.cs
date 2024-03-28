using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYM.Infrastructure.Migrations
{
    public partial class UpdateExerciseIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UX_GYM_EXERCISE",
                table: "GYM_EXERCISE");

            migrationBuilder.CreateIndex(
                name: "UX_GYM_EXERCISE",
                table: "GYM_EXERCISE",
                columns: new[] { "Name", "ProfileId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UX_GYM_EXERCISE",
                table: "GYM_EXERCISE");

            migrationBuilder.CreateIndex(
                name: "UX_GYM_EXERCISE",
                table: "GYM_EXERCISE",
                column: "Name",
                unique: true);
        }
    }
}
