using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppRetoKitolBet.Data.Migrations
{
    public partial class KirolBet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assignee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AssigneeId = table.Column<int>(nullable: true)
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
                name: "Description",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Raw = table.Column<string>(nullable: true),
                    DescriptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Description_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Description",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Priority",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    PriorityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priority", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Priority_Priority_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priority",
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

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUserOpenProject = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_Links",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssigneeId = table.Column<int>(nullable: true),
                    TypeId = table.Column<int>(nullable: true),
                    StatusId = table.Column<int>(nullable: true),
                    PriorityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Links_Assignee_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "Assignee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Links_Priority_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Links_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Links_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkPackage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdWPOpenProject = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    EstimatedTime = table.Column<string>(nullable: true),
                    RemainingTime = table.Column<string>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    DueDate = table.Column<string>(nullable: true),
                    _LinksId = table.Column<int>(nullable: true),
                    DescriptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPackage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkPackage_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Description",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkPackage__Links__LinksId",
                        column: x => x._LinksId,
                        principalTable: "_Links",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserWorkPackage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    WorkPackageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWorkPackage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserWorkPackage_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWorkPackage_WorkPackage_WorkPackageId",
                        column: x => x.WorkPackageId,
                        principalTable: "WorkPackage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX__Links_AssigneeId",
                table: "_Links",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX__Links_PriorityId",
                table: "_Links",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX__Links_StatusId",
                table: "_Links",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX__Links_TypeId",
                table: "_Links",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignee_AssigneeId",
                table: "Assignee",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Description_DescriptionId",
                table: "Description",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Priority_PriorityId",
                table: "Priority",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Status_StatusId",
                table: "Status",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Type_TypeId",
                table: "Type",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWorkPackage_UserId",
                table: "UserWorkPackage",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWorkPackage_WorkPackageId",
                table: "UserWorkPackage",
                column: "WorkPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackage_DescriptionId",
                table: "WorkPackage",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackage__LinksId",
                table: "WorkPackage",
                column: "_LinksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserWorkPackage");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "WorkPackage");

            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.DropTable(
                name: "_Links");

            migrationBuilder.DropTable(
                name: "Assignee");

            migrationBuilder.DropTable(
                name: "Priority");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Type");
        }
    }
}
