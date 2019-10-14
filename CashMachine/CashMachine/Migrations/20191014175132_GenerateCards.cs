using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CashMachine.Migrations
{
    public partial class GenerateCards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "Id", "Money", "OwnerId", "Pin", "Type" },
                values: new object[,]
                {
                    { new Guid("139f252b-b17b-43e3-af1b-f65a0a76e4db"), 100, new Guid("3686f45d-5e74-4666-ae76-6cf898d36f90"), 2345, "Credid card" },
                    { new Guid("73cd64ae-d13c-4be1-b4a0-4f055abd76f0"), 200, new Guid("98d50544-b91e-4491-9bf9-a4d601e5f873"), 3456, "Debit card" },
                    { new Guid("b50cbd75-9df7-4c3c-8296-68d12832b65f"), 300, new Guid("9710bb72-956f-4aca-ad4e-9fa133e385d4"), 4567, "Credid card" },
                    { new Guid("c66d5c50-1d97-469b-82c8-15e11ee0faf2"), 400, new Guid("8f18e657-4611-4ce1-9854-279fa327144c"), 5678, "Payment card" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("139f252b-b17b-43e3-af1b-f65a0a76e4db"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("73cd64ae-d13c-4be1-b4a0-4f055abd76f0"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("b50cbd75-9df7-4c3c-8296-68d12832b65f"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("c66d5c50-1d97-469b-82c8-15e11ee0faf2"));
        }
    }
}
