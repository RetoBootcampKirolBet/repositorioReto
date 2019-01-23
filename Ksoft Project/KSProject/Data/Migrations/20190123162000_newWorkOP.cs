using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSProject.Data.Migrations
{
    public partial class newWorkOP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Links_CustomField3_CustomField3Id",
                table: "_Links");

            migrationBuilder.DropForeignKey(
                name: "FK__Links_CustomField4_CustomField4Id",
                table: "_Links");

            migrationBuilder.DropTable(
                name: "CustomField3");

            migrationBuilder.DropTable(
                name: "CustomField4");

            migrationBuilder.RenameColumn(
                name: "CustomField4Id",
                table: "_Links",
                newName: "CustomField2Id");

            migrationBuilder.RenameColumn(
                name: "CustomField3Id",
                table: "_Links",
                newName: "CustomField1Id");

            migrationBuilder.RenameIndex(
                name: "IX__Links_CustomField4Id",
                table: "_Links",
                newName: "IX__Links_CustomField2Id");

            migrationBuilder.RenameIndex(
                name: "IX__Links_CustomField3Id",
                table: "_Links",
                newName: "IX__Links_CustomField1Id");

            migrationBuilder.CreateTable(
                name: "CustomField1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KsoftProject = table.Column<string>(nullable: true),
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
                    Sprint = table.Column<string>(nullable: true),
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

            migrationBuilder.RenameColumn(
                name: "CustomField2Id",
                table: "_Links",
                newName: "CustomField4Id");

            migrationBuilder.RenameColumn(
                name: "CustomField1Id",
                table: "_Links",
                newName: "CustomField3Id");

            migrationBuilder.RenameIndex(
                name: "IX__Links_CustomField2Id",
                table: "_Links",
                newName: "IX__Links_CustomField4Id");

            migrationBuilder.RenameIndex(
                name: "IX__Links_CustomField1Id",
                table: "_Links",
                newName: "IX__Links_CustomField3Id");

            migrationBuilder.CreateTable(
                name: "CustomField3",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomField3Id = table.Column<int>(nullable: true),
                    Sprint = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomField3", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomField3_CustomField3_CustomField3Id",
                        column: x => x.CustomField3Id,
                        principalTable: "CustomField3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomField4",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomField4Id = table.Column<int>(nullable: true),
                    KsoftProject = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomField4", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomField4_CustomField4_CustomField4Id",
                        column: x => x.CustomField4Id,
                        principalTable: "CustomField4",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomField3_CustomField3Id",
                table: "CustomField3",
                column: "CustomField3Id");

            migrationBuilder.CreateIndex(
                name: "IX_CustomField4_CustomField4Id",
                table: "CustomField4",
                column: "CustomField4Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Links_CustomField3_CustomField3Id",
                table: "_Links",
                column: "CustomField3Id",
                principalTable: "CustomField3",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Links_CustomField4_CustomField4Id",
                table: "_Links",
                column: "CustomField4Id",
                principalTable: "CustomField4",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
