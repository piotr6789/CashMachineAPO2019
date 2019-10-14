using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CashMachine.Migrations
{
    public partial class GenerateOwners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "IsAbleToTransfer", "LastName", "Name" },
                values: new object[,]
                {
                    { new Guid("3686f45d-5e74-4666-ae76-6cf898d36f90"), true, "Kowalski", "Piotr" },
                    { new Guid("98d50544-b91e-4491-9bf9-a4d601e5f873"), true, "Nowak", "Maciej" },
                    { new Guid("9710bb72-956f-4aca-ad4e-9fa133e385d4"), true, "Janicki", "Wojciech" },
                    { new Guid("8f18e657-4611-4ce1-9854-279fa327144c"), true, "Olejniczak", "Adam" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("3686f45d-5e74-4666-ae76-6cf898d36f90"));

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("8f18e657-4611-4ce1-9854-279fa327144c"));

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("9710bb72-956f-4aca-ad4e-9fa133e385d4"));

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("98d50544-b91e-4491-9bf9-a4d601e5f873"));
        }
    }
}
