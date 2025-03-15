using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlagExplorer.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateFlagExplorerDb4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "provinceKey_pkey",
                schema: "dbo",
                table: "tbProvince");

            migrationBuilder.RenameTable(
                name: "tbProvince",
                schema: "dbo",
                newName: "ProvinceCtx",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProvinceCtx",
                schema: "dbo",
                table: "ProvinceCtx",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "VehicleCtx",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCtx", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleCtx",
                schema: "dbo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProvinceCtx",
                schema: "dbo",
                table: "ProvinceCtx");

            migrationBuilder.RenameTable(
                name: "ProvinceCtx",
                schema: "dbo",
                newName: "tbProvince",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "provinceKey_pkey",
                schema: "dbo",
                table: "tbProvince",
                column: "Id");
        }
    }
}
