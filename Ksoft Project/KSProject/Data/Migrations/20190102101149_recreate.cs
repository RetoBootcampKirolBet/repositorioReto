using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSProject.Data.Migrations
{
    public partial class recreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmbeddedWPId",
                table: "WorkPackage",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmbeddedUserId",
                table: "User",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmbeddedUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    _linksId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmbeddedUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmbeddedUser__Links__linksId",
                        column: x => x._linksId,
                        principalTable: "_Links",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmbeddedWP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    _linksId = table.Column<int>(nullable: true),
                    DescriptionsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmbeddedWP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmbeddedWP_Description_DescriptionsId",
                        column: x => x.DescriptionsId,
                        principalTable: "Description",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmbeddedWP__Links__linksId",
                        column: x => x._linksId,
                        principalTable: "_Links",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResponseUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<int>(nullable: false),
                    Offset = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    UsersContainerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponseUser_EmbeddedUser_UsersContainerId",
                        column: x => x.UsersContainerId,
                        principalTable: "EmbeddedUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResponseWP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<int>(nullable: false),
                    Offset = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    WorkPackagesContainerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseWP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponseWP_EmbeddedWP_WorkPackagesContainerId",
                        column: x => x.WorkPackagesContainerId,
                        principalTable: "EmbeddedWP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackage_EmbeddedWPId",
                table: "WorkPackage",
                column: "EmbeddedWPId");

            migrationBuilder.CreateIndex(
                name: "IX_User_EmbeddedUserId",
                table: "User",
                column: "EmbeddedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmbeddedUser__linksId",
                table: "EmbeddedUser",
                column: "_linksId");

            migrationBuilder.CreateIndex(
                name: "IX_EmbeddedWP_DescriptionsId",
                table: "EmbeddedWP",
                column: "DescriptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmbeddedWP__linksId",
                table: "EmbeddedWP",
                column: "_linksId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseUser_UsersContainerId",
                table: "ResponseUser",
                column: "UsersContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseWP_WorkPackagesContainerId",
                table: "ResponseWP",
                column: "WorkPackagesContainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_EmbeddedUser_EmbeddedUserId",
                table: "User",
                column: "EmbeddedUserId",
                principalTable: "EmbeddedUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkPackage_EmbeddedWP_EmbeddedWPId",
                table: "WorkPackage",
                column: "EmbeddedWPId",
                principalTable: "EmbeddedWP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_EmbeddedUser_EmbeddedUserId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkPackage_EmbeddedWP_EmbeddedWPId",
                table: "WorkPackage");

            migrationBuilder.DropTable(
                name: "ResponseUser");

            migrationBuilder.DropTable(
                name: "ResponseWP");

            migrationBuilder.DropTable(
                name: "EmbeddedUser");

            migrationBuilder.DropTable(
                name: "EmbeddedWP");

            migrationBuilder.DropIndex(
                name: "IX_WorkPackage_EmbeddedWPId",
                table: "WorkPackage");

            migrationBuilder.DropIndex(
                name: "IX_User_EmbeddedUserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "EmbeddedWPId",
                table: "WorkPackage");

            migrationBuilder.DropColumn(
                name: "EmbeddedUserId",
                table: "User");
        }
    }
}
