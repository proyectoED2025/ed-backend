using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpinteria.Migrations
{
    /// <inheritdoc />
    public partial class cambiosExtras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Proovedor",
                table: "Insumos",
                newName: "Proveedor");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Stocks",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Proveedor",
                table: "Insumos",
                newName: "Proovedor");

            migrationBuilder.AlterColumn<string>(
                name: "FechaCreacion",
                table: "Stocks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
