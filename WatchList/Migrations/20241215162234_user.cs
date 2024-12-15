using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchList.Migrations
{
    /// <inheritdoc />
    public partial class user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "FilmUser",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_FilmUser_UserId",
                table: "FilmUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmUser_AspNetUsers_UserId",
                table: "FilmUser",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmUser_AspNetUsers_UserId",
                table: "FilmUser");

            migrationBuilder.DropIndex(
                name: "IX_FilmUser_UserId",
                table: "FilmUser");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FilmUser");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
