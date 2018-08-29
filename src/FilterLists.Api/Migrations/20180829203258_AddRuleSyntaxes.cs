using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddRuleSyntaxes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "tags",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "tags",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "syntaxes",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "syntaxes",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "software",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "software",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "snapshots",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "snapshots",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "rules",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AddColumn<byte>(
                name: "RuleSyntaxId",
                table: "rules",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "maintainers",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "maintainers",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "licenses",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "licenses",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "languages",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "languages",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "filterlists",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "filterlists",
                type: "TIMESTAMP",
                nullable: true,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.CreateTable(
                name: "rule_syntaxes",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "TINYINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValueSql: "current_timestamp()"),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()"),
                    Name = table.Column<string>(type: "VARCHAR(126)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rule_syntaxes", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_rules_RuleSyntaxId",
                table: "rules",
                column: "RuleSyntaxId");

            migrationBuilder.AddForeignKey(
                name: "FK_rules_rule_syntaxes_RuleSyntaxId",
                table: "rules",
                column: "RuleSyntaxId",
                principalTable: "rule_syntaxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rules_rule_syntaxes_RuleSyntaxId",
                table: "rules");

            migrationBuilder.DropTable(
                name: "rule_syntaxes");

            migrationBuilder.DropIndex(
                name: "IX_rules_RuleSyntaxId",
                table: "rules");

            migrationBuilder.DropColumn(
                name: "RuleSyntaxId",
                table: "rules");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "tags",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "tags",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "syntaxes",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "syntaxes",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "software",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "software",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "snapshots",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "snapshots",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "rules",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "maintainers",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "maintainers",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "licenses",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "licenses",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "languages",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "languages",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "filterlists",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "filterlists",
                type: "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValueSql: "current_timestamp()");
        }
    }
}
