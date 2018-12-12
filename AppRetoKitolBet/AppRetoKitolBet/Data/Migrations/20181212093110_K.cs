using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppRetoKitolBet.Data.Migrations
{
    public partial class K : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Links_Assignee_AssigneeId",
                table: "_Links");

            migrationBuilder.DropForeignKey(
                name: "FK__Links_Status_StatusId",
                table: "_Links");

            migrationBuilder.DropForeignKey(
                name: "FK__Links_Type_TypeId",
                table: "_Links");

            migrationBuilder.DropTable(
                name: "Assignee");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.CreateTable(
                name: "AssigneeWP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AssigneeWPId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssigneeWP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssigneeWP_AssigneeWP_AssigneeWPId",
                        column: x => x.AssigneeWPId,
                        principalTable: "AssigneeWP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StatusWP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Estado = table.Column<string>(nullable: true),
                    StatusWPId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusWP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusWP_StatusWP_StatusWPId",
                        column: x => x.StatusWPId,
                        principalTable: "StatusWP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypeWP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: true),
                    TypeWPId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeWP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeWP_TypeWP_TypeWPId",
                        column: x => x.TypeWPId,
                        principalTable: "TypeWP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssigneeWP_AssigneeWPId",
                table: "AssigneeWP",
                column: "AssigneeWPId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusWP_StatusWPId",
                table: "StatusWP",
                column: "StatusWPId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeWP_TypeWPId",
                table: "TypeWP",
                column: "TypeWPId");

            migrationBuilder.AddForeignKey(
                name: "FK__Links_AssigneeWP_AssigneeId",
                table: "_Links",
                column: "AssigneeId",
                principalTable: "AssigneeWP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Links_StatusWP_StatusId",
                table: "_Links",
                column: "StatusId",
                principalTable: "StatusWP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Links_TypeWP_TypeId",
                table: "_Links",
                column: "TypeId",
                principalTable: "TypeWP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Links_AssigneeWP_AssigneeId",
                table: "_Links");

            migrationBuilder.DropForeignKey(
                name: "FK__Links_StatusWP_StatusId",
                table: "_Links");

            migrationBuilder.DropForeignKey(
                name: "FK__Links_TypeWP_TypeId",
                table: "_Links");

            migrationBuilder.DropTable(
                name: "AssigneeWP");

            migrationBuilder.DropTable(
                name: "StatusWP");

            migrationBuilder.DropTable(
                name: "TypeWP");

            migrationBuilder.CreateTable(
                name: "Assignee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssigneeId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignee_Assignee_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "Assignee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Estado = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Status_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Type_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignee_AssigneeId",
                table: "Assignee",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Status_StatusId",
                table: "Status",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Type_TypeId",
                table: "Type",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK__Links_Assignee_AssigneeId",
                table: "_Links",
                column: "AssigneeId",
                principalTable: "Assignee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Links_Status_StatusId",
                table: "_Links",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Links_Type_TypeId",
                table: "_Links",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
