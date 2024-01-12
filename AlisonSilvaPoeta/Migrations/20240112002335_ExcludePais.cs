using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlisonSilvaPoeta.Migrations
{
    /// <inheritdoc />
    public partial class ExcludePais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Endereco");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Endereco",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                defaultValue: "");
        }
    }
}
