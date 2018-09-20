using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class TestAddUniqueIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                "IX_languages_Iso6391",
                "languages",
                "Iso6391",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                "IX_languages_Iso6391",
                "languages");
        }
    }
}