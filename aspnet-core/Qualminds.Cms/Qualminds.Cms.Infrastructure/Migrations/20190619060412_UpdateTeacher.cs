using Microsoft.EntityFrameworkCore.Migrations;

namespace Qualminds.Cms.Infrastructure.Migrations
{
    public partial class UpdateTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teachers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teachers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
