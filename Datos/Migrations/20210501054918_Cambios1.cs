using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class Cambios1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Usuarios_UsuarioIdUsuario",
                table: "Movimientos");

            migrationBuilder.DropIndex(
                name: "IX_Movimientos_UsuarioIdUsuario",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "fechaDeceso",
                table: "Arriendos");

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaDesalojo",
                table: "Arriendos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fechaDesalojo",
                table: "Arriendos");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioIdUsuario",
                table: "Movimientos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaDeceso",
                table: "Arriendos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_UsuarioIdUsuario",
                table: "Movimientos",
                column: "UsuarioIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Usuarios_UsuarioIdUsuario",
                table: "Movimientos",
                column: "UsuarioIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
