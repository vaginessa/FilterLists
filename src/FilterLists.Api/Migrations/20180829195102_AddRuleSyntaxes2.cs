using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddRuleSyntaxes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "rule_syntaxes",
                keyColumn: "Id",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "rule_syntaxes",
                keyColumn: "Id",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "rule_syntaxes",
                keyColumn: "Id",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "rule_syntaxes",
                keyColumn: "Id",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "rule_syntaxes",
                keyColumn: "Id",
                keyValue: (byte)5);

            migrationBuilder.InsertData(
                table: "rule_syntaxes",
                columns: new[] { "Id", "CreatedDateUtc", "ModifiedDateUtc", "Name" },
                values: new object[,]
                {
                    { (byte)1, null, null, "Comment" },
                    { (byte)2, null, null, "Title" },
                    { (byte)3, null, null, "Expires" },
                    { (byte)4, null, null, "Platform Hint" },
                    { (byte)5, null, null, "Pre-processor Directive" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "rule_syntaxes",
                keyColumn: "Id",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "rule_syntaxes",
                keyColumn: "Id",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "rule_syntaxes",
                keyColumn: "Id",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "rule_syntaxes",
                keyColumn: "Id",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "rule_syntaxes",
                keyColumn: "Id",
                keyValue: (byte)5);

            migrationBuilder.InsertData(
                table: "rule_syntaxes",
                columns: new[] { "Id", "CreatedDateUtc", "ModifiedDateUtc", "Name" },
                values: new object[,]
                {
                    { (byte)1, null, null, "Comment" },
                    { (byte)2, null, null, "Title" },
                    { (byte)3, null, null, "Expires" },
                    { (byte)4, null, null, "Platform Hint" },
                    { (byte)5, null, null, "Pre-processor Directive" }
                });
        }
    }
}
