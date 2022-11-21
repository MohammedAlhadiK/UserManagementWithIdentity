using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWithIdentity.Migrations
{
    public partial class Todo3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatorID",
                schema: "tsk",
                table: "Task",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorID",
                schema: "tsk",
                table: "Task");
        }
    }
}
