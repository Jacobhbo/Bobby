using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingProject.Migrations
{
    /// <inheritdoc />
    public partial class ChangeGenderToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 12, 8, 27, 16, 319, DateTimeKind.Utc).AddTicks(2008));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 8, 19, 34, 833, DateTimeKind.Utc).AddTicks(681));
        }
    }
}
