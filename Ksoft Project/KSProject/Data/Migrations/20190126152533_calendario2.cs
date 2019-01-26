using Microsoft.EntityFrameworkCore.Migrations;

namespace KSProject.Data.Migrations
{
    public partial class calendario2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Persona",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Persona");
        }
    }
}
