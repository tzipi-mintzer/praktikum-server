using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjectPraktikum.Context.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Users_User",
                table: "Children");

            migrationBuilder.DropIndex(
                name: "IX_Children_User",
                table: "Children");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "Children",
                newName: "Parent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Parent",
                table: "Children",
                newName: "User");

            migrationBuilder.CreateIndex(
                name: "IX_Children_User",
                table: "Children",
                column: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Users_User",
                table: "Children",
                column: "User",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
