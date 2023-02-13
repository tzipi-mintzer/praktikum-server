using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjectPraktikum.Context.Migrations
{
    public partial class myMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Children",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Children",
                newName: "Name");
        }
    }
}
