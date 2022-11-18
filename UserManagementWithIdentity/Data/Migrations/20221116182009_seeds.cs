﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(),"User", "User".ToUpper(), Guid.NewGuid().ToString() },
                schema: "Security"

                );
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(),"Admin", "Admin".ToUpper(), Guid.NewGuid().ToString() },
                schema: "Security"

                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}