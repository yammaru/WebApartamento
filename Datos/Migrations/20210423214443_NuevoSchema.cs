using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class NuevoSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Movimientos",
                columns: table => new
                {
                    IdMovimiento = table.Column<string>(nullable: false),
                    valor = table.Column<int>(nullable: false),
                    Detalle = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    IdUsuario = table.Column<string>(nullable: true),
                    UsuarioIdUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos", x => x.IdMovimiento);
                    table.ForeignKey(
                        name: "FK_Movimientos_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Arriendos",
                columns: table => new
                {
                    IdArriendo = table.Column<string>(nullable: false),
                    fechaIngreso = table.Column<DateTime>(nullable: false),
                    fechaDeceso = table.Column<DateTime>(nullable: false),
                    IdCliente = table.Column<string>(nullable: true),
                    IdApartamento = table.Column<string>(nullable: true),
                    IdMovimiento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arriendos", x => x.IdArriendo);
                    table.ForeignKey(
                        name: "FK_Arriendos_Apartamentos_IdApartamento",
                        column: x => x.IdApartamento,
                        principalTable: "Apartamentos",
                        principalColumn: "CodApartamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Arriendos_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Arriendos_Movimientos_IdMovimiento",
                        column: x => x.IdMovimiento,
                        principalTable: "Movimientos",
                        principalColumn: "IdMovimiento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arriendos_IdApartamento",
                table: "Arriendos",
                column: "IdApartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Arriendos_IdCliente",
                table: "Arriendos",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Arriendos_IdMovimiento",
                table: "Arriendos",
                column: "IdMovimiento");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_UsuarioIdUsuario",
                table: "Movimientos",
                column: "UsuarioIdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arriendos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Movimientos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
