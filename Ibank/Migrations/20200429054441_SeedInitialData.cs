using Ibank.Models;
using Microsoft.AspNetCore.Identity.UI.Pages.Internal.Account;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Ibank.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Account", "Password" },
                values: new object[] { "Antonio Santos", 464520, 123456 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Name", "Account", "Password" },
                values: new object[] { 2, "Maria Silva", 656890, 789456 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Name", "Account", "Password" },
                values: new object[] { 3, "Antonia Lourenço", 969430, 654132 });

           /* migrationBuilder.UpdateData(
                table: "Extract",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Id", "UserId", "Date", "Amount" },
                values: new object[] { 1, 1 ,0001-01-01, 50.00 });

            migrationBuilder.InsertData(
                table: "Extract",
                columns: new[] { "Id", "UserId", "Date", "Amount" },
                values: new object[] { 2, 3, 0001-01-01, 100.00 });
            */
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Account", "Password" },
                values: new object[] { "Antonia Lourenço", 969430, 654132 });

            /*
            migrationBuilder.DeleteData(
                table: "Extract",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Extract",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserId", "Date", "Amount" },
                values: new object[] { 3, "0001-01-01T00:00:00", 100.00 });
            */    
        }
    }
}
