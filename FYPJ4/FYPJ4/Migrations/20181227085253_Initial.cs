using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FYPJ4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountCode = table.Column<string>(nullable: true),
                    AccountDesc = table.Column<string>(nullable: true),
                    Actual = table.Column<string>(nullable: false),
                    Encumbrance = table.Column<string>(nullable: false),
                    FYBalance = table.Column<string>(nullable: false),
                    FYBudget = table.Column<string>(nullable: false),
                    FYSpent = table.Column<string>(nullable: false),
                    FYSpentPercent = table.Column<string>(nullable: false),
                    ReportAsAt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
