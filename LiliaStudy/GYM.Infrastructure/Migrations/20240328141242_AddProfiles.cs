using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYM.Infrastructure.Migrations
{
    public partial class AddProfiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "GYM_TRAINING_SESSION",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "GYM_EXERCISE",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "GYM_BODY_WEIGHT",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GYM_PROFILE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GYM_PROFILE", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GYM_TRAINING_SESSION_ProfileId",
                table: "GYM_TRAINING_SESSION",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_GYM_EXERCISE_ProfileId",
                table: "GYM_EXERCISE",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_GYM_BODY_WEIGHT_ProfileId",
                table: "GYM_BODY_WEIGHT",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "UX_GYM_PROFILE",
                table: "GYM_PROFILE",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GYM_BODY_WEIGHT_GYM_PROFILE_ProfileId",
                table: "GYM_BODY_WEIGHT",
                column: "ProfileId",
                principalTable: "GYM_PROFILE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GYM_EXERCISE_GYM_PROFILE_ProfileId",
                table: "GYM_EXERCISE",
                column: "ProfileId",
                principalTable: "GYM_PROFILE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GYM_TRAINING_SESSION_GYM_PROFILE_ProfileId",
                table: "GYM_TRAINING_SESSION",
                column: "ProfileId",
                principalTable: "GYM_PROFILE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GYM_BODY_WEIGHT_GYM_PROFILE_ProfileId",
                table: "GYM_BODY_WEIGHT");

            migrationBuilder.DropForeignKey(
                name: "FK_GYM_EXERCISE_GYM_PROFILE_ProfileId",
                table: "GYM_EXERCISE");

            migrationBuilder.DropForeignKey(
                name: "FK_GYM_TRAINING_SESSION_GYM_PROFILE_ProfileId",
                table: "GYM_TRAINING_SESSION");

            migrationBuilder.DropTable(
                name: "GYM_PROFILE");

            migrationBuilder.DropIndex(
                name: "IX_GYM_TRAINING_SESSION_ProfileId",
                table: "GYM_TRAINING_SESSION");

            migrationBuilder.DropIndex(
                name: "IX_GYM_EXERCISE_ProfileId",
                table: "GYM_EXERCISE");

            migrationBuilder.DropIndex(
                name: "IX_GYM_BODY_WEIGHT_ProfileId",
                table: "GYM_BODY_WEIGHT");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "GYM_TRAINING_SESSION");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "GYM_EXERCISE");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "GYM_BODY_WEIGHT");
        }
    }
}
