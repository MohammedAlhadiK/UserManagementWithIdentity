using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class ff00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tokens_Users_UserId",
                schema: "IDI",
                table: "Tokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tokens",
                schema: "IDI",
                table: "Tokens");

            migrationBuilder.RenameTable(
                name: "Tokens",
                schema: "IDI",
                newName: "UserTokens",
                newSchema: "IDI");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                schema: "IDI",
                table: "UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_Users_UserId",
                schema: "IDI",
                table: "UserTokens",
                column: "UserId",
                principalSchema: "IDI",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_Users_UserId",
                schema: "IDI",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                schema: "IDI",
                table: "UserTokens");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "IDI",
                newName: "Tokens",
                newSchema: "IDI");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tokens",
                schema: "IDI",
                table: "Tokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tokens_Users_UserId",
                schema: "IDI",
                table: "Tokens",
                column: "UserId",
                principalSchema: "IDI",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
