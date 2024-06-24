using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalClinic.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddConclusion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recomendation",
                table: "Appointments");

            migrationBuilder.AlterColumn<int>(
                name: "Specialization",
                table: "Doctors",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Сonclusions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppoinmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Recomendation = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Сonclusions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Сonclusions_Appointments_AppoinmentId",
                        column: x => x.AppoinmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Сonclusions_AppoinmentId",
                table: "Сonclusions",
                column: "AppoinmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Сonclusions");

            migrationBuilder.AlterColumn<string>(
                name: "Specialization",
                table: "Doctors",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Recomendation",
                table: "Appointments",
                type: "TEXT",
                nullable: true);
        }
    }
}
