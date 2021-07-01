using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_rpg.Migrations
{
    public partial class UserCharacterRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserID",
                table: "Characters",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Users_UserID",
                table: "Characters",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Users_UserID",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_UserID",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Characters");
        }
    }
}
