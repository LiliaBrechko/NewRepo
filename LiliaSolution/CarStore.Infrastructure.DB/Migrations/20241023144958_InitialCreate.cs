using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarStore.Infrastructure.DB.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    InitialPrice_Amount = table.Column<double>(type: "REAL", nullable: false),
                    InitialPrice_Currency = table.Column<int>(type: "INTEGER", nullable: false),
                    Mark = table.Column<int>(type: "INTEGER", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DomainEvent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    OccurredOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CarId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomainEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DomainEvent_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DomainEvent_CarId",
                table: "DomainEvent",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DomainEvent");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
