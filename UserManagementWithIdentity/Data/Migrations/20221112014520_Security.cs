using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class Security : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Security");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "IDI",
                newName: "UserTokens",
                newSchema: "Security");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "IDI",
                newName: "Users",
                newSchema: "Security");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "IDI",
                newName: "UserRoles",
                newSchema: "Security");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "IDI",
                newName: "UserLogins",
                newSchema: "Security");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "IDI",
                newName: "UserClaims",
                newSchema: "Security");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "IDI",
                newName: "Roles",
                newSchema: "Security");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "IDI",
                newName: "RoleClaims",
                newSchema: "Security");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "IDI");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "Security",
                newName: "UserTokens",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "Security",
                newName: "Users",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "Security",
                newName: "UserRoles",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "Security",
                newName: "UserLogins",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "Security",
                newName: "UserClaims",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "Security",
                newName: "Roles",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "Security",
                newName: "RoleClaims",
                newSchema: "IDI");
        }
    }
}
