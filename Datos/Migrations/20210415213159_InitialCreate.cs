using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apartamentos",
                columns: table => new
                {
                    CodApartamento = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Identificacion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Arriendo = table.Column<string>(nullable: true),
                    Deposito = table.Column<string>(nullable: true),
                    FechaIngreso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartamentos", x => x.CodApartamento);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartamentos");
        }
    }
}
