using Microsoft.EntityFrameworkCore.Migrations;

namespace AppRetoKirolBet.Data.Migrations
{
    public partial class changetimespent2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RemainingTime",
                table: "WorkPackage",
                newName: "SpentTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SpentTime",
                table: "WorkPackage",
                newName: "RemainingTime");
        }
    }
}
