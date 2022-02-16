using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scuba_Dive_Log.Data.Migrations
{
    public partial class DiveLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiveLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiveSite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiveBuddy = table.Column<int>(type: "int", nullable: false),
                    DiveType = table.Column<int>(type: "int", nullable: false),
                    MaxDepth = table.Column<float>(type: "real", nullable: false),
                    DiveTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiveLog", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiveLog");
        }
    }
}
