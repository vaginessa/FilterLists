using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddRuleSyntaxes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                "RuleSyntaxId",
                "rules",
                nullable: true);

            migrationBuilder.CreateTable(
                "rule_syntaxes",
                table => new
                {
                    Id = table.Column<byte>("TINYINT UNSIGNED", nullable: false)
                              .Annotation("MySql:ValueGenerationStrategy",
                                  MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false,
                        defaultValueSql: "current_timestamp()"),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false,
                        defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()"),
                    Name = table.Column<string>("VARCHAR(126)", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_rule_syntaxes", x => x.Id); });

            migrationBuilder.InsertData(
                "rule_syntaxes",
                new[] {"Id", "CreatedDateUtc", "ModifiedDateUtc", "Name"},
                new object[,]
                {
                    {
                        (byte)1, new DateTime(2018, 8, 29, 13, 20, 19, 247, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 20, 19, 251, DateTimeKind.Local), "Comment"
                    },
                    {
                        (byte)2, new DateTime(2018, 8, 29, 13, 20, 19, 252, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 20, 19, 252, DateTimeKind.Local), "Title"
                    },
                    {
                        (byte)3, new DateTime(2018, 8, 29, 13, 20, 19, 252, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 20, 19, 252, DateTimeKind.Local), "Expires"
                    },
                    {
                        (byte)4, new DateTime(2018, 8, 29, 13, 20, 19, 252, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 20, 19, 252, DateTimeKind.Local), "Platform Hint"
                    },
                    {
                        (byte)5, new DateTime(2018, 8, 29, 13, 20, 19, 252, DateTimeKind.Local),
                        new DateTime(2018, 8, 29, 13, 20, 19, 252, DateTimeKind.Local), "Pre-processor Directive"
                    }
                });

            migrationBuilder.CreateIndex(
                "IX_rules_RuleSyntaxId",
                "rules",
                "RuleSyntaxId");

            migrationBuilder.AddForeignKey(
                "FK_rules_rule_syntaxes_RuleSyntaxId",
                "rules",
                "RuleSyntaxId",
                "rule_syntaxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_rules_rule_syntaxes_RuleSyntaxId",
                "rules");

            migrationBuilder.DropTable(
                "rule_syntaxes");

            migrationBuilder.DropIndex(
                "IX_rules_RuleSyntaxId",
                "rules");

            migrationBuilder.DropColumn(
                "RuleSyntaxId",
                "rules");
        }
    }
}