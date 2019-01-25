using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSProject.Data.Migrations
{
    public partial class responsible : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssigneeWP_StatusWP_StatusWPId",
                table: "AssigneeWP");

            migrationBuilder.DropIndex(
                name: "IX_AssigneeWP_StatusWPId",
                table: "AssigneeWP");

            migrationBuilder.DropColumn(
                name: "StatusWPId",
                table: "AssigneeWP");

            migrationBuilder.AddColumn<int>(
                name: "StatusWPId",
                table: "StatusWP",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "_Links",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResponsibleId",
                table: "_Links",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AuthorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Author_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Responsible",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ResponsibleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsible", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responsible_Responsible_ResponsibleId",
                        column: x => x.ResponsibleId,
                        principalTable: "Responsible",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StatusWP_StatusWPId",
                table: "StatusWP",
                column: "StatusWPId");

            migrationBuilder.CreateIndex(
                name: "IX__Links_AuthorId",
                table: "_Links",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX__Links_ResponsibleId",
                table: "_Links",
                column: "ResponsibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_AuthorId",
                table: "Author",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Responsible_ResponsibleId",
                table: "Responsible",
                column: "ResponsibleId");

            migrationBuilder.AddForeignKey(
                name: "FK__Links_Author_AuthorId",
                table: "_Links",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Links_Responsible_ResponsibleId",
                table: "_Links",
                column: "ResponsibleId",
                principalTable: "Responsible",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusWP_StatusWP_StatusWPId",
                table: "StatusWP",
                column: "StatusWPId",
                principalTable: "StatusWP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Links_Author_AuthorId",
                table: "_Links");

            migrationBuilder.DropForeignKey(
                name: "FK__Links_Responsible_ResponsibleId",
                table: "_Links");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusWP_StatusWP_StatusWPId",
                table: "StatusWP");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Responsible");

            migrationBuilder.DropIndex(
                name: "IX_StatusWP_StatusWPId",
                table: "StatusWP");

            migrationBuilder.DropIndex(
                name: "IX__Links_AuthorId",
                table: "_Links");

            migrationBuilder.DropIndex(
                name: "IX__Links_ResponsibleId",
                table: "_Links");

            migrationBuilder.DropColumn(
                name: "StatusWPId",
                table: "StatusWP");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "_Links");

            migrationBuilder.DropColumn(
                name: "ResponsibleId",
                table: "_Links");

            migrationBuilder.AddColumn<int>(
                name: "StatusWPId",
                table: "AssigneeWP",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssigneeWP_StatusWPId",
                table: "AssigneeWP",
                column: "StatusWPId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssigneeWP_StatusWP_StatusWPId",
                table: "AssigneeWP",
                column: "StatusWPId",
                principalTable: "StatusWP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
