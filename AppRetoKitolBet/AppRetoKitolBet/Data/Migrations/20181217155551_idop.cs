using Microsoft.EntityFrameworkCore.Migrations;

namespace AppRetoKirolBet.Data.Migrations
{
    public partial class idop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdWPOpenProject",
                table: "WorkPackage",
                newName: "IdOP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdOP",
                table: "WorkPackage",
                newName: "IdWPOpenProject");
        }
    }
}
