using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class Cambios2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arriendos_Apartamentos_IdApartamento",
                table: "Arriendos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartamentos",
                table: "Apartamentos");

            migrationBuilder.DropColumn(
                name: "CodApartamento",
                table: "Apartamentos");

            migrationBuilder.DropColumn(
                name: "Arriendo",
                table: "Apartamentos");

            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "Apartamentos");

            migrationBuilder.DropColumn(
                name: "Identificacion",
                table: "Apartamentos");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Apartamentos");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Apartamentos");

            migrationBuilder.AlterColumn<int>(
                name: "Deposito",
                table: "Apartamentos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdApartamento",
                table: "Apartamentos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Apartamentos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValorApartamento",
                table: "Apartamentos",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arriendos_Apartamentos_IdApartamento",
                table: "Arriendos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartamentos",
                table: "Apartamentos");

            migrationBuilder.DropColumn(
                name: "IdApartamento",
                table: "Apartamentos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Apartamentos");

            migrationBuilder.DropColumn(
                name: "ValorApartamento",
                table: "Apartamentos");

            migrationBuilder.AlterColumn<string>(
                name: "Deposito",
                table: "Apartamentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "CodApartamento",
                table: "Apartamentos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Arriendo",
                table: "Apartamentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FechaIngreso",
                table: "Apartamentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identificacion",
                table: "Apartamentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Apartamentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Apartamentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartamentos",
                table: "Apartamentos",
                column: "CodApartamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Arriendos_Apartamentos_IdApartamento",
                table: "Arriendos",
                column: "IdApartamento",
                principalTable: "Apartamentos",
                principalColumn: "CodApartamento",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
