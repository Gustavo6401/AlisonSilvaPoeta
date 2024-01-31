using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlisonSilvaIdentityUser.Migrations
{
    /// <inheritdoc />
    public partial class RemoverFormaPagamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormaPagamento",
                table: "Compras");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FormaPagamento",
                table: "Compras",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                defaultValue: "");
        }
    }
}
