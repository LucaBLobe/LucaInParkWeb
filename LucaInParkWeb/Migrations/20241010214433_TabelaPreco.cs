using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LucaInParkWeb.Migrations
{
    /// <inheritdoc />
    public partial class TabelaPreco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "TabelaPrecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FimVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrecoVigencia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaPrecos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaPrecos");
        }
    }
}
