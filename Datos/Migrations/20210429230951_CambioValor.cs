using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class CambioValor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "valor",
                table: "Movimientos",
                newName: "Valor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Movimientos",
                newName: "valor");
        }
    }
}
