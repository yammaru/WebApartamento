using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class password : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contraseña",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Usuarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Contraseña",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
