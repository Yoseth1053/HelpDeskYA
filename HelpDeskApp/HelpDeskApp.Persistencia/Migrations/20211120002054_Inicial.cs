using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpDeskApp.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ambientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmbNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmbUbicacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpNombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpApellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpCelular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpCorreo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoEmpleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncFechaReporte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IncFechaAtencion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InCantidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoElemento = table.Column<int>(type: "int", nullable: false),
                    AmbienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventarios_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MantenimientoPreventivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmbienteId = table.Column<int>(type: "int", nullable: true),
                    ManPFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManPDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MantenimientoPreventivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MantenimientoPreventivos_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpleadosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lo_Empleados_EmpleadosId",
                        column: x => x.EmpleadosId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MantenimientoCorrectivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentesId = table.Column<int>(type: "int", nullable: true),
                    AmbienteId = table.Column<int>(type: "int", nullable: true),
                    ManFechaSolucion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MantenimientoCorrectivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MantenimientoCorrectivos_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MantenimientoCorrectivos_Incidentes_IncidentesId",
                        column: x => x.IncidentesId,
                        principalTable: "Incidentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_AmbienteId",
                table: "Inventarios",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Lo_EmpleadosId",
                table: "Lo",
                column: "EmpleadosId");

            migrationBuilder.CreateIndex(
                name: "IX_MantenimientoCorrectivos_AmbienteId",
                table: "MantenimientoCorrectivos",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_MantenimientoCorrectivos_IncidentesId",
                table: "MantenimientoCorrectivos",
                column: "IncidentesId");

            migrationBuilder.CreateIndex(
                name: "IX_MantenimientoPreventivos_AmbienteId",
                table: "MantenimientoPreventivos",
                column: "AmbienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "Lo");

            migrationBuilder.DropTable(
                name: "MantenimientoCorrectivos");

            migrationBuilder.DropTable(
                name: "MantenimientoPreventivos");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Incidentes");

            migrationBuilder.DropTable(
                name: "Ambientes");
        }
    }
}
