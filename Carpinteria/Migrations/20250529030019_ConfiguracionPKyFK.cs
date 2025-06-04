using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpinteria.Migrations
{
    /// <inheritdoc />
    public partial class ConfiguracionPKyFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Insumos",
                newName: "InsumoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InsumoId",
                table: "Insumos",
                newName: "Id");
        }
    }
}
