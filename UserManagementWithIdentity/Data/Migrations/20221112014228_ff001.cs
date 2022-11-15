using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class ff001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_Users_UserId",
                schema: "IDI",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                schema: "IDI",
                table: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "IDI",
                newName: "UserClaims",
                newSchema: "IDI");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "IDI",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                schema: "IDI",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_UserId",
                schema: "IDI",
                table: "UserClaims",
                column: "UserId",
                principalSchema: "IDI",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_UserId",
                schema: "IDI",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                schema: "IDI",
                table: "UserClaims");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "IDI",
                newName: "AspNetUserClaims",
                newSchema: "IDI");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                schema: "IDI",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                schema: "IDI",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_Users_UserId",
                schema: "IDI",
                table: "AspNetUserClaims",
                column: "UserId",
                principalSchema: "IDI",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
