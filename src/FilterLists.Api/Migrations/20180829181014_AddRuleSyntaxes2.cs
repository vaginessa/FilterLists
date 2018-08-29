using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddRuleSyntaxes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                "rule_syntaxes",
                "Id",
                (byte)1);

            migrationBuilder.DeleteData(
                "rule_syntaxes",
                "Id",
                (byte)2);

            migrationBuilder.DeleteData(
                "rule_syntaxes",
                "Id",
                (byte)3);

            migrationBuilder.DeleteData(
                "rule_syntaxes",
                "Id",
                (byte)4);

            migrationBuilder.DeleteData(
                "rule_syntaxes",
                "Id",
                (byte)5);

            migrationBuilder.InsertData(
                "rule_syntaxes",
                new[] {"Id", "CreatedDateUtc", "ModifiedDateUtc", "Name"},
                new object[,]
                {
                    {
                        (byte)1, new DateTime(2018, 8, 29, 13, 10, 13, 771, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 10, 13, 775, DateTimeKind.Local), "Comment"
                    },
                    {
                        (byte)2, new DateTime(2018, 8, 29, 13, 10, 13, 775, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 10, 13, 775, DateTimeKind.Local), "Title"
                    },
                    {
                        (byte)3, new DateTime(2018, 8, 29, 13, 10, 13, 775, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 10, 13, 775, DateTimeKind.Local), "Expires"
                    },
                    {
                        (byte)4, new DateTime(2018, 8, 29, 13, 10, 13, 775, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 10, 13, 775, DateTimeKind.Local), "Platform Hint"
                    },
                    {
                        (byte)5, new DateTime(2018, 8, 29, 13, 10, 13, 775, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 10, 13, 775, DateTimeKind.Local), "Pre-processor Directive"
                    }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                "rule_syntaxes",
                "Id",
                (byte)1);

            migrationBuilder.DeleteData(
                "rule_syntaxes",
                "Id",
                (byte)2);

            migrationBuilder.DeleteData(
                "rule_syntaxes",
                "Id",
                (byte)3);

            migrationBuilder.DeleteData(
                "rule_syntaxes",
                "Id",
                (byte)4);

            migrationBuilder.DeleteData(
                "rule_syntaxes",
                "Id",
                (byte)5);

            migrationBuilder.InsertData(
                "rule_syntaxes",
                new[] {"Id", "CreatedDateUtc", "ModifiedDateUtc", "Name"},
                new object[,]
                {
                    {
                        (byte)1, new DateTime(2018, 8, 29, 13, 8, 51, 832, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 8, 51, 836, DateTimeKind.Local), "Comment"
                    },
                    {
                        (byte)2, new DateTime(2018, 8, 29, 13, 8, 51, 836, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 8, 51, 836, DateTimeKind.Local), "Title"
                    },
                    {
                        (byte)3, new DateTime(2018, 8, 29, 13, 8, 51, 836, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 8, 51, 836, DateTimeKind.Local), "Expires"
                    },
                    {
                        (byte)4, new DateTime(2018, 8, 29, 13, 8, 51, 836, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 8, 51, 836, DateTimeKind.Local), "Platform Hint"
                    },
                    {
                        (byte)5, new DateTime(2018, 8, 29, 13, 8, 51, 836, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 8, 51, 836, DateTimeKind.Local), "Pre-processor Directive"
                    }
                });
        }
    }
}