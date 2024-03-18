using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYM.Infrastructure.Migrations
{
    public partial class AddWeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GYM_BODY_WEIGHT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Weight = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GYM_BODY_WEIGHT", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GYM_BODY_WEIGHT");
        }
    }
}
