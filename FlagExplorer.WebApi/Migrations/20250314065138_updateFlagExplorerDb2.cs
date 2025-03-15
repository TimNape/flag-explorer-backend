using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlagExplorer.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateFlagExplorerDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Capital",
                schema: "dbo",
                table: "tbProvince",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Population",
                schema: "dbo",
                table: "tbProvince",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capital",
                schema: "dbo",
                table: "tbProvince");

            migrationBuilder.DropColumn(
                name: "Population",
                schema: "dbo",
                table: "tbProvince");
        }
    }
}
