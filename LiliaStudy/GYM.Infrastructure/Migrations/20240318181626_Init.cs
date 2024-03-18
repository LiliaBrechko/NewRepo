using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYM.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GYM_EXERCISE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GYM_EXERCISE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GYM_TRAINING_SESSION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GYM_TRAINING_SESSION", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GYM_SET",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Reps = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<double>(type: "REAL", nullable: false),
                    ExerciseId = table.Column<int>(type: "INTEGER", nullable: false),
                    TrainingSessionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GYM_SET", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GYM_SET_GYM_EXERCISE_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "GYM_EXERCISE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GYM_SET_GYM_TRAINING_SESSION_TrainingSessionId",
                        column: x => x.TrainingSessionId,
                        principalTable: "GYM_TRAINING_SESSION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "UX_GYM_EXERCISE",
                table: "GYM_EXERCISE",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GYM_SET_ExerciseId",
                table: "GYM_SET",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_GYM_SET_TrainingSessionId",
                table: "GYM_SET",
                column: "TrainingSessionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GYM_SET");

            migrationBuilder.DropTable(
                name: "GYM_EXERCISE");

            migrationBuilder.DropTable(
                name: "GYM_TRAINING_SESSION");
        }
    }
}
