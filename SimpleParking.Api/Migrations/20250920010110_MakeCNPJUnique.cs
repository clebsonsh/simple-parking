using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleParking.Api.Migrations
{
    /// <inheritdoc />
    public partial class MakeCNPJUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Establishments_Cnpj",
                table: "Establishments",
                column: "Cnpj",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Establishments_Cnpj",
                table: "Establishments");
        }
    }
}
