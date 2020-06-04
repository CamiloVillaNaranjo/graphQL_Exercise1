using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzeria.Data.Migrations
{
    public partial class InitializeDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalleOrdenes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion1 = table.Column<string>(maxLength: 40, nullable: false),
                    Direccion2 = table.Column<string>(nullable: true),
                    MovilNo = table.Column<string>(maxLength: 12, nullable: false),
                    Monto = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    EstadoOrden = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleOrdenes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetallePizzas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    Ingredientes = table.Column<int>(maxLength: 200, nullable: false),
                    Precio = table.Column<double>(nullable: false),
                    Tamano = table.Column<int>(nullable: false),
                    IdDetalleOrdenes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePizzas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallePizzas_DetalleOrdenes_IdDetalleOrdenes",
                        column: x => x.IdDetalleOrdenes,
                        principalTable: "DetalleOrdenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallePizzas_IdDetalleOrdenes",
                table: "DetallePizzas",
                column: "IdDetalleOrdenes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallePizzas");

            migrationBuilder.DropTable(
                name: "DetalleOrdenes");
        }
    }
}
