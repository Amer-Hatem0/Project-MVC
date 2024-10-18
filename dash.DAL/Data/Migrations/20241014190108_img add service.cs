using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dash.PL.Data.Migrations
{
    public partial class imgaddservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Services");
        }
    }
}
