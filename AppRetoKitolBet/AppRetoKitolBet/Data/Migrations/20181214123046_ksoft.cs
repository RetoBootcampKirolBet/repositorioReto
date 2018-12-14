using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppRetoKirolBet.Data.Migrations
{
    public partial class ksoft : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomField1Id",
                table: "_Links",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomField2Id",
                table: "_Links",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomField1WP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sprint = table.Column<string>(nullable: true),
                    CustomField1WPId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomField1WP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomField1WP_CustomField1WP_CustomField1WPId",
                        column: x => x.CustomField1WPId,
                        principalTable: "CustomField1WP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomField2WP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KsoftProject = table.Column<string>(nullable: true),
                    CustomField2WPId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomField2WP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomField2WP_CustomField2WP_CustomField2WPId",
                        column: x => x.CustomField2WPId,
                        principalTable: "CustomField2WP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX__Links_CustomField1Id",
                table: "_Links",
                column: "CustomField1Id");

            migrationBuilder.CreateIndex(
                name: "IX__Links_CustomField2Id",
                table: "_Links",
                column: "CustomField2Id");

            migrationBuilder.CreateIndex(
                name: "IX_CustomField1WP_CustomField1WPId",
                table: "CustomField1WP",
                column: "CustomField1WPId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomField2WP_CustomField2WPId",
                table: "CustomField2WP",
                column: "CustomField2WPId");

            migrationBuilder.AddForeignKey(
                name: "FK__Links_CustomField1WP_CustomField1Id",
                table: "_Links",
                column: "CustomField1Id",
                principalTable: "CustomField1WP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Links_CustomField2WP_CustomField2Id",
                table: "_Links",
                column: "CustomField2Id",
                principalTable: "CustomField2WP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Links_CustomField1WP_CustomField1Id",
                table: "_Links");

            migrationBuilder.DropForeignKey(
                name: "FK__Links_CustomField2WP_CustomField2Id",
                table: "_Links");

            migrationBuilder.DropTable(
                name: "CustomField1WP");

            migrationBuilder.DropTable(
                name: "CustomField2WP");

            migrationBuilder.DropIndex(
                name: "IX__Links_CustomField1Id",
                table: "_Links");

            migrationBuilder.DropIndex(
                name: "IX__Links_CustomField2Id",
                table: "_Links");

            migrationBuilder.DropColumn(
                name: "CustomField1Id",
                table: "_Links");

            migrationBuilder.DropColumn(
                name: "CustomField2Id",
                table: "_Links");
        }
    }
}
