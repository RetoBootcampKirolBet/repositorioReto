using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSProject.Data.Migrations
{
    public partial class controllers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUserOpenProject = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    UserRole = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
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
                    PriorityId = table.Column<int>(nullable: true),
                    CustomField1Id = table.Column<int>(nullable: true),
                    CustomField2Id = table.Column<int>(nullable: true)
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
                        name: "FK__Links_CustomField1_CustomField1Id",
                        column: x => x.CustomField1Id,
                        principalTable: "CustomField1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Links_CustomField2_CustomField2Id",
                        column: x => x.CustomField2Id,
                        principalTable: "CustomField2",
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
                name: "WorkPackage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdOP = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    EstimatedTime = table.Column<string>(nullable: true),
                    SpentTime = table.Column<string>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    DueDate = table.Column<string>(nullable: true),
                    Activation = table.Column<string>(nullable: true),
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
                name: "IX__Links_CustomField1Id",
                table: "_Links",
                column: "CustomField1Id");

            migrationBuilder.CreateIndex(
                name: "IX__Links_CustomField2Id",
                table: "_Links",
                column: "CustomField2Id");

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
                name: "IX_CustomField1_CustomField1Id",
                table: "CustomField1",
                column: "CustomField1Id");

            migrationBuilder.CreateIndex(
                name: "IX_CustomField2_CustomField2Id",
                table: "CustomField2",
                column: "CustomField2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Description_DescriptionId",
                table: "Description",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Priority_PriorityId",
                table: "Priority",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeWP_TypeWPId",
                table: "TypeWP",
                column: "TypeWPId");

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
                name: "AssigneeWP");

            migrationBuilder.DropTable(
                name: "CustomField1");

            migrationBuilder.DropTable(
                name: "CustomField2");

            migrationBuilder.DropTable(
                name: "Priority");

            migrationBuilder.DropTable(
                name: "TypeWP");

            migrationBuilder.DropTable(
                name: "StatusWP");
        }
    }
}
