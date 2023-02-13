using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjectPraktikum.Context.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Children");

            migrationBuilder.AlterColumn<string>(
                name: "HMO",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "User",
                table: "Children",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Users_User",
                table: "Children");

            migrationBuilder.DropIndex(
                name: "IX_Children_User",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "User",
                table: "Children");

            migrationBuilder.AlterColumn<int>(
                name: "HMO",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "ParentId",
                table: "Children",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
