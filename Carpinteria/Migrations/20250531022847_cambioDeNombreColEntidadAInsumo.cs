using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpinteria.Migrations
{
    /// <inheritdoc />
    public partial class cambioDeNombreColEntidadAInsumo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EntidadId",
                table: "MovimientosStock",
                newName: "InsumoId");

            migrationBuilder.RenameColumn(
                name: "Entidad",
                table: "MovimientosStock",
                newName: "Insumo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InsumoId",
                table: "MovimientosStock",
                newName: "EntidadId");

            migrationBuilder.RenameColumn(
                name: "Insumo",
                table: "MovimientosStock",
                newName: "Entidad");
        }
    }
}
