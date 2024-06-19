using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingProject.Migrations
{
    /// <inheritdoc />
    public partial class CrudInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountsId", "CreatedDate", "Email", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { 1, new DateTime(2024, 6, 11, 8, 19, 34, 833, DateTimeKind.Utc).AddTicks(681), "jaco@gmail.com", "Jacob", "Hbo", "bob123", "bob" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountsId",
                keyValue: 1);
        }
    }
}
