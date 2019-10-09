using Microsoft.EntityFrameworkCore.Migrations;

namespace CashMachine.Migrations
{
    public partial class ChangesInEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Card",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Card");
        }
    }
}
