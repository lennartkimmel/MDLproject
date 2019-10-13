using Microsoft.EntityFrameworkCore.Migrations;

namespace MDLproject.Data.Migrations
{
    public partial class WorkingAndWell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Standard",
                table: "Format");

            migrationBuilder.AddColumn<int>(
                name: "StandardID",
                table: "Format",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StandardID",
                table: "Format");

            migrationBuilder.AddColumn<string>(
                name: "Standard",
                table: "Format",
                nullable: true);
        }
    }
}
