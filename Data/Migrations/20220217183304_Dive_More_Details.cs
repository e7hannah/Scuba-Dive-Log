using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scuba_Dive_Log.Data.Migrations
{
    public partial class Dive_More_Details : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BodyOfWater",
                table: "DiveLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Current",
                table: "DiveLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CylinderType",
                table: "DiveLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SuitType",
                table: "DiveLog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Surge",
                table: "DiveLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Visibility",
                table: "DiveLog",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "WaterTemperature",
                table: "DiveLog",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "WaterType",
                table: "DiveLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Waves",
                table: "DiveLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weather",
                table: "DiveLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "DiveLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weighting",
                table: "DiveLog",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyOfWater",
                table: "DiveLog");

            migrationBuilder.DropColumn(
                name: "Current",
                table: "DiveLog");

            migrationBuilder.DropColumn(
                name: "CylinderType",
                table: "DiveLog");

            migrationBuilder.DropColumn(
                name: "SuitType",
                table: "DiveLog");

            migrationBuilder.DropColumn(
                name: "Surge",
                table: "DiveLog");

            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "DiveLog");

            migrationBuilder.DropColumn(
                name: "WaterTemperature",
                table: "DiveLog");

            migrationBuilder.DropColumn(
                name: "WaterType",
                table: "DiveLog");

            migrationBuilder.DropColumn(
                name: "Waves",
                table: "DiveLog");

            migrationBuilder.DropColumn(
                name: "Weather",
                table: "DiveLog");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "DiveLog");

            migrationBuilder.DropColumn(
                name: "Weighting",
                table: "DiveLog");
        }
    }
}
