using Microsoft.EntityFrameworkCore.Migrations;

namespace KSProject.Data.Migrations
{
    public partial class nombre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Oporrak",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Dedication",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Calendario",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Oporrak");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Dedication");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Calendario");
        }
    }
}
