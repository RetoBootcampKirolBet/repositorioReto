using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppRetoKirolBet.Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "StatusWP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusWP", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "AssigneeWP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AssigneeWPId = table.Column<int>(nullable: true),
                    StatusWPId = table.Column<int>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_AssigneeWP_StatusWP_StatusWPId",
                        column: x => x.StatusWPId,
                        principalTable: "StatusWP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK__Links_AssigneeWP_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "AssigneeWP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Links_Priority_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Links_StatusWP_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusWP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Links_TypeWP_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypeWP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    EmbeddedUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_EmbeddedUser_EmbeddedUserId",
                        column: x => x.EmbeddedUserId,
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
                    DescriptionId = table.Column<int>(nullable: true),
                    EmbeddedWPId = table.Column<int>(nullable: true)
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
                        name: "FK_WorkPackage_EmbeddedWP_EmbeddedWPId",
                        column: x => x.EmbeddedWPId,
                        principalTable: "EmbeddedWP",
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
                name: "IX_AssigneeWP_AssigneeWPId",
                table: "AssigneeWP",
                column: "AssigneeWPId");

            migrationBuilder.CreateIndex(
                name: "IX_AssigneeWP_StatusWPId",
                table: "AssigneeWP",
                column: "StatusWPId");

            migrationBuilder.CreateIndex(
                name: "IX_Description_DescriptionId",
                table: "Description",
                column: "DescriptionId");

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
                name: "IX_Priority_PriorityId",
                table: "Priority",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseUser_UsersContainerId",
                table: "ResponseUser",
                column: "UsersContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseWP_WorkPackagesContainerId",
                table: "ResponseWP",
                column: "WorkPackagesContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeWP_TypeWPId",
                table: "TypeWP",
                column: "TypeWPId");

            migrationBuilder.CreateIndex(
                name: "IX_User_EmbeddedUserId",
                table: "User",
                column: "EmbeddedUserId");

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
                name: "IX_WorkPackage_EmbeddedWPId",
                table: "WorkPackage",
                column: "EmbeddedWPId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackage__LinksId",
                table: "WorkPackage",
                column: "_LinksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResponseUser");

            migrationBuilder.DropTable(
                name: "ResponseWP");

            migrationBuilder.DropTable(
                name: "UserWorkPackage");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "WorkPackage");

            migrationBuilder.DropTable(
                name: "EmbeddedUser");

            migrationBuilder.DropTable(
                name: "EmbeddedWP");

            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.DropTable(
                name: "_Links");

            migrationBuilder.DropTable(
                name: "AssigneeWP");

            migrationBuilder.DropTable(
                name: "Priority");

            migrationBuilder.DropTable(
                name: "TypeWP");

            migrationBuilder.DropTable(
                name: "StatusWP");
        }
    }
}
