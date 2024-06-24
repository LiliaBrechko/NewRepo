using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalClinic.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addCKdateofbirth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "Patient_DateOfBirth",
                table: "Patients",
                sql: "DateOfBirth < CURRENT_TIMESTAMP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "Patient_DateOfBirth",
                table: "Patients");
        }
    }
}
