using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class arriend1o : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arriendos_Apartamentoss_IdApartamento",
                table: "Arriendos");

            migrationBuilder.DropForeignKey(
                name: "FK_Arriendos_Movimientos_IdMovimiento",
                table: "Arriendos");

            migrationBuilder.DropIndex(
                name: "IX_Arriendos_IdApartamento",
                table: "Arriendos");

            migrationBuilder.DropIndex(
                name: "IX_Arriendos_IdMovimiento",
                table: "Arriendos");

            migrationBuilder.DropColumn(
                name: "IdMovimiento",
                table: "Arriendos");

            migrationBuilder.AlterColumn<string>(
                name: "IdApartamento",
                table: "Arriendos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovimientoIdMovimiento",
                table: "Arriendos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Total",
                table: "Arriendos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Arriendos_MovimientoIdMovimiento",
                table: "Arriendos",
                column: "MovimientoIdMovimiento");

            migrationBuilder.AddForeignKey(
                name: "FK_Arriendos_Movimientos_MovimientoIdMovimiento",
                table: "Arriendos",
                column: "MovimientoIdMovimiento",
                principalTable: "Movimientos",
                principalColumn: "IdMovimiento",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arriendos_Movimientos_MovimientoIdMovimiento",
                table: "Arriendos");

            migrationBuilder.DropIndex(
                name: "IX_Arriendos_MovimientoIdMovimiento",
                table: "Arriendos");

            migrationBuilder.DropColumn(
                name: "MovimientoIdMovimiento",
                table: "Arriendos");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Arriendos");

            migrationBuilder.AlterColumn<string>(
                name: "IdApartamento",
                table: "Arriendos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdMovimiento",
                table: "Arriendos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arriendos_IdApartamento",
                table: "Arriendos",
                column: "IdApartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Arriendos_IdMovimiento",
                table: "Arriendos",
                column: "IdMovimiento");

            migrationBuilder.AddForeignKey(
                name: "FK_Arriendos_Apartamentoss_IdApartamento",
                table: "Arriendos",
                column: "IdApartamento",
                principalTable: "Apartamentoss",
                principalColumn: "IdApartamento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Arriendos_Movimientos_IdMovimiento",
                table: "Arriendos",
                column: "IdMovimiento",
                principalTable: "Movimientos",
                principalColumn: "IdMovimiento",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
