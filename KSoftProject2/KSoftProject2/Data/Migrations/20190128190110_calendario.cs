using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSoftProject2.Data.Migrations
{
    public partial class calendario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calendario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    Lunes = table.Column<double>(nullable: false),
                    Martes = table.Column<double>(nullable: false),
                    Miercoles = table.Column<double>(nullable: false),
                    Jueves = table.Column<double>(nullable: false),
                    Viernes = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdOP = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    TotalHorasEstimadas = table.Column<double>(nullable: false),
                    TotalHorasTrabajadas = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalendarioPersona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonaId = table.Column<int>(nullable: false),
                    WorkPackageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarioPersona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalendarioPersona_Calendario_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Calendario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalendarioPersona_Persona_WorkPackageId",
                        column: x => x.WorkPackageId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dedication",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Desarrollo = table.Column<double>(nullable: false),
                    Gestion = table.Column<double>(nullable: false),
                    Formacion = table.Column<double>(nullable: false),
                    Soporte = table.Column<double>(nullable: false),
                    Investigacion = table.Column<double>(nullable: false),
                    NoDedicadas = table.Column<double>(nullable: false),
                    PersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dedication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dedication_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Oporrak",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    DiasDeVacaciones = table.Column<DateTime>(nullable: false),
                    HorasDeVacaciones = table.Column<double>(nullable: false),
                    PersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oporrak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oporrak_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalendarioPersona_PersonaId",
                table: "CalendarioPersona",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarioPersona_WorkPackageId",
                table: "CalendarioPersona",
                column: "WorkPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Dedication_PersonaId",
                table: "Dedication",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Oporrak_PersonaId",
                table: "Oporrak",
                column: "PersonaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalendarioPersona");

            migrationBuilder.DropTable(
                name: "Dedication");

            migrationBuilder.DropTable(
                name: "Oporrak");

            migrationBuilder.DropTable(
                name: "Calendario");

            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
