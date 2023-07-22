using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoProjectMVC.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTabler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Students",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "name");
        }
    }
}
