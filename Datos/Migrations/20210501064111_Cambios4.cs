using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class Cambios4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arriendos_Apartamentos_IdApartamento",
                table: "Arriendos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartamentos",
                table: "Apartamentos");

            migrationBuilder.RenameTable(
                name: "Apartamentos",
                newName: "Apartamentoss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartamentoss",
                table: "Apartamentoss",
                column: "IdApartamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Arriendos_Apartamentoss_IdApartamento",
                table: "Arriendos",
                column: "IdApartamento",
                principalTable: "Apartamentoss",
                principalColumn: "IdApartamento",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arriendos_Apartamentoss_IdApartamento",
                table: "Arriendos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartamentoss",
                table: "Apartamentoss");

            migrationBuilder.RenameTable(
                name: "Apartamentoss",
                newName: "Apartamentos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartamentos",
                table: "Apartamentos",
                column: "IdApartamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Arriendos_Apartamentos_IdApartamento",
                table: "Arriendos",
                column: "IdApartamento",
                principalTable: "Apartamentos",
                principalColumn: "IdApartamento",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
