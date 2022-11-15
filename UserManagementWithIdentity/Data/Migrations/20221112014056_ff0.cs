using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class ff0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                schema: "IDI",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                schema: "IDI",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                schema: "IDI",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                schema: "IDI",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                schema: "IDI",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                schema: "IDI",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                schema: "IDI",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                schema: "IDI",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                schema: "IDI",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                schema: "IDI",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                schema: "IDI",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                schema: "IDI",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "IDI",
                newName: "Tokens",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "IDI",
                newName: "Users",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "IDI",
                newName: "UserRoles",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "IDI",
                newName: "UserLogins",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "IDI",
                newName: "Roles",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "IDI",
                newName: "RoleClaims",
                newSchema: "IDI");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "IDI",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "IDI",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "IDI",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tokens",
                schema: "IDI",
                table: "Tokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "IDI",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                schema: "IDI",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                schema: "IDI",
                table: "UserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                schema: "IDI",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                schema: "IDI",
                table: "RoleClaims",
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

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "IDI",
                table: "RoleClaims",
                column: "RoleId",
                principalSchema: "IDI",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tokens_Users_UserId",
                schema: "IDI",
                table: "Tokens",
                column: "UserId",
                principalSchema: "IDI",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Users_UserId",
                schema: "IDI",
                table: "UserLogins",
                column: "UserId",
                principalSchema: "IDI",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                schema: "IDI",
                table: "UserRoles",
                column: "RoleId",
                principalSchema: "IDI",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "IDI",
                table: "UserRoles",
                column: "UserId",
                principalSchema: "IDI",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_Users_UserId",
                schema: "IDI",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "IDI",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Tokens_Users_UserId",
                schema: "IDI",
                table: "Tokens");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Users_UserId",
                schema: "IDI",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                schema: "IDI",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "IDI",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "IDI",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                schema: "IDI",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                schema: "IDI",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tokens",
                schema: "IDI",
                table: "Tokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                schema: "IDI",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                schema: "IDI",
                table: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "IDI",
                newName: "AspNetUsers",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "IDI",
                newName: "AspNetUserRoles",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "IDI",
                newName: "AspNetUserLogins",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "Tokens",
                schema: "IDI",
                newName: "AspNetUserTokens",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "IDI",
                newName: "AspNetRoles",
                newSchema: "IDI");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "IDI",
                newName: "AspNetRoleClaims",
                newSchema: "IDI");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                schema: "IDI",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                schema: "IDI",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "IDI",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                schema: "IDI",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                schema: "IDI",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                schema: "IDI",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                schema: "IDI",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                schema: "IDI",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                schema: "IDI",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                schema: "IDI",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalSchema: "IDI",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                schema: "IDI",
                table: "AspNetUserClaims",
                column: "UserId",
                principalSchema: "IDI",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                schema: "IDI",
                table: "AspNetUserLogins",
                column: "UserId",
                principalSchema: "IDI",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                schema: "IDI",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalSchema: "IDI",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                schema: "IDI",
                table: "AspNetUserRoles",
                column: "UserId",
                principalSchema: "IDI",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                schema: "IDI",
                table: "AspNetUserTokens",
                column: "UserId",
                principalSchema: "IDI",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
