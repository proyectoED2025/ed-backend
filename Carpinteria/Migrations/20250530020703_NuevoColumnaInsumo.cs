using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpinteria.Migrations
{
    /// <inheritdoc />
    public partial class NuevoColumnaInsumo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TipoVidrio",
                table: "Insumos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeriePerfil",
                table: "Insumos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeriePerfil",
                table: "Insumos");

            migrationBuilder.AlterColumn<int>(
                name: "TipoVidrio",
                table: "Insumos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
