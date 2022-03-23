using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCereals.Migrations
{
    public partial class ex01compatibilitymickaelapi_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tata",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AddColumn<byte>(
                name: "Calories",
                table: "tata",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<short>(
                name: "Carbo",
                table: "tata",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<byte>(
                name: "Fiber",
                table: "tata",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<short>(
                name: "Potass",
                table: "tata",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<byte>(
                name: "Protein",
                table: "tata",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<float>(
                name: "Rating",
                table: "tata",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Sodium",
                table: "tata",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<short>(
                name: "Sugars",
                table: "tata",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<int>(
                name: "Vitamins",
                table: "tata",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Carbo",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Fiber",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Potass",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Protein",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Sodium",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Sugars",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Vitamins",
                table: "tata");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tata",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);
        }
    }
}
