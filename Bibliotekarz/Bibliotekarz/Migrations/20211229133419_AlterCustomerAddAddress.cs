using Microsoft.EntityFrameworkCore.Migrations;

namespace Bibliotekarz.Migrations
{
    public partial class AlterCustomerAddAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Borrowers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Borrowers");
        }
    }
}
