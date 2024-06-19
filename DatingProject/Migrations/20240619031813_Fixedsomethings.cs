using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingProject.Migrations
{
    /// <inheritdoc />
    public partial class Fixedsomethings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Cities_ZipCode",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Accounts_ProfileId",
                table: "Profiles");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_ZipCode",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Accounts");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileId",
                table: "Profiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProfileId",
                table: "Profiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ZipCode);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ReceiverId = table.Column<int>(type: "int", nullable: false),
                    LikeId = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.SenderId, x.ReceiverId });
                    table.ForeignKey(
                        name: "FK_Likes_Accounts_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Accounts",
                        principalColumn: "AccountsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Likes_Profiles_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ZipCode",
                table: "Accounts",
                column: "ZipCode");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_ReceiverId",
                table: "Likes",
                column: "ReceiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Cities_ZipCode",
                table: "Accounts",
                column: "ZipCode",
                principalTable: "Cities",
                principalColumn: "ZipCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Accounts_ProfileId",
                table: "Profiles",
                column: "ProfileId",
                principalTable: "Accounts",
                principalColumn: "AccountsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
