using Microsoft.EntityFrameworkCore.Migrations;

namespace KSProject.Data.Migrations
{
    public partial class customfields2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Links_CustomField3_CustomField3Id",
                table: "_Links");

            migrationBuilder.DropForeignKey(
                name: "FK__Links_CustomField4_CustomField4Id",
                table: "_Links");

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

            migrationBuilder.AddForeignKey(
                name: "FK__Links_CustomField3_CustomField1Id",
                table: "_Links",
                column: "CustomField1Id",
                principalTable: "CustomField3",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Links_CustomField4_CustomField2Id",
                table: "_Links",
                column: "CustomField2Id",
                principalTable: "CustomField4",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Links_CustomField3_CustomField1Id",
                table: "_Links");

            migrationBuilder.DropForeignKey(
                name: "FK__Links_CustomField4_CustomField2Id",
                table: "_Links");

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
