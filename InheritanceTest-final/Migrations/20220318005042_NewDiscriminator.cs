using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InheritanceTest_final.Migrations
{
    public partial class NewDiscriminator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Comment",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Comment");
        }
    }
}
