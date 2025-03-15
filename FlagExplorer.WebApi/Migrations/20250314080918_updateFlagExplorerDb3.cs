using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlagExplorer.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateFlagExplorerDb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Capital",
                schema: "dbo",
                table: "tbProvince",
                newName: "ShortName");

            migrationBuilder.AlterColumn<int>(
                name: "Population",
                schema: "dbo",
                table: "tbProvince",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "GDP",
                schema: "dbo",
                table: "tbProvince",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CityCtx",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    PopulationDensity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCtx", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityCtx",
                schema: "dbo");

            migrationBuilder.DropColumn(
                name: "GDP",
                schema: "dbo",
                table: "tbProvince");

            migrationBuilder.RenameColumn(
                name: "ShortName",
                schema: "dbo",
                table: "tbProvince",
                newName: "Capital");

            migrationBuilder.AlterColumn<int>(
                name: "Population",
                schema: "dbo",
                table: "tbProvince",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
