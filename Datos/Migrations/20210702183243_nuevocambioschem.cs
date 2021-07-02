using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class nuevocambioschem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arriendos_Clientes_IdCliente",
                table: "Arriendos");

            migrationBuilder.DropForeignKey(
                name: "FK_Arriendos_Movimientos_MovimientoIdMovimiento",
                table: "Arriendos");

            migrationBuilder.DropIndex(
                name: "IX_Arriendos_IdCliente",
                table: "Arriendos");

            migrationBuilder.DropIndex(
                name: "IX_Arriendos_MovimientoIdMovimiento",
                table: "Arriendos");

            migrationBuilder.DropColumn(
                name: "MovimientoIdMovimiento",
                table: "Arriendos");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Arriendos",
                newName: "idCliente");

            migrationBuilder.RenameColumn(
                name: "IdApartamento",
                table: "Arriendos",
                newName: "idApartamento");

            migrationBuilder.RenameColumn(
                name: "IdArriendo",
                table: "Arriendos",
                newName: "idArriendo");

            migrationBuilder.AlterColumn<string>(
                name: "idCliente",
                table: "Arriendos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idCliente",
                table: "Arriendos",
                newName: "IdCliente");

            migrationBuilder.RenameColumn(
                name: "idApartamento",
                table: "Arriendos",
                newName: "IdApartamento");

            migrationBuilder.RenameColumn(
                name: "idArriendo",
                table: "Arriendos",
                newName: "IdArriendo");

            migrationBuilder.AlterColumn<string>(
                name: "IdCliente",
                table: "Arriendos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovimientoIdMovimiento",
                table: "Arriendos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arriendos_IdCliente",
                table: "Arriendos",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Arriendos_MovimientoIdMovimiento",
                table: "Arriendos",
                column: "MovimientoIdMovimiento");

            migrationBuilder.AddForeignKey(
                name: "FK_Arriendos_Clientes_IdCliente",
                table: "Arriendos",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Arriendos_Movimientos_MovimientoIdMovimiento",
                table: "Arriendos",
                column: "MovimientoIdMovimiento",
                principalTable: "Movimientos",
                principalColumn: "IdMovimiento",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
