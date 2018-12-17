using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppRetoKirolBet.Data.Migrations
{
    public partial class customfield : Migration
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
                name: "CustomField1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sprint = table.Column<string>(nullable: true),
                    CustomField1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomField1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomField1_CustomField1_CustomField1Id",
                        column: x => x.CustomField1Id,
                        principalTable: "CustomField1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomField2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KsoftProject = table.Column<string>(nullable: true),
                    CustomField2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomField2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomField2_CustomField2_CustomField2Id",
                        column: x => x.CustomField2Id,
                        principalTable: "CustomField2",
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
                name: "IX_CustomField1_CustomField1Id",
                table: "CustomField1",
                column: "CustomField1Id");

            migrationBuilder.CreateIndex(
                name: "IX_CustomField2_CustomField2Id",
                table: "CustomField2",
                column: "CustomField2Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Links_CustomField1_CustomField1Id",
                table: "_Links",
                column: "CustomField1Id",
                principalTable: "CustomField1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Links_CustomField2_CustomField2Id",
                table: "_Links",
                column: "CustomField2Id",
                principalTable: "CustomField2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Links_CustomField1_CustomField1Id",
                table: "_Links");

            migrationBuilder.DropForeignKey(
                name: "FK__Links_CustomField2_CustomField2Id",
                table: "_Links");

            migrationBuilder.DropTable(
                name: "CustomField1");

            migrationBuilder.DropTable(
                name: "CustomField2");

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
