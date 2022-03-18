using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InheritanceTest_final.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Comment",
                newName: "Type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Comment",
                newName: "Discriminator");
        }
    }
}
