using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWithIdentity.Migrations
{
    public partial class Todo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "tsk");

            migrationBuilder.CreateTable(
                name: "Task",
                schema: "tsk",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TaskDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskTimeFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskTimeTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Task",
                schema: "tsk");
        }
    }
}
