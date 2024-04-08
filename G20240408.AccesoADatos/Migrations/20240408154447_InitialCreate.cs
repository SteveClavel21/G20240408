using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G20240408.AccesoADatos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonasG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreG = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ApellidoG = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FechaNacimientoG = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SueldoG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstatusG = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonasG", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonasG");
        }
    }
}
