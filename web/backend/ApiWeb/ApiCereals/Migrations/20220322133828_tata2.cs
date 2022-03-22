using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCereals.Migrations
{
    public partial class tata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cereals",
                table: "Cereals");

            migrationBuilder.RenameTable(
                name: "Cereals",
                newName: "tata");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tata",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tata",
                table: "tata",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tata",
                table: "tata");

            migrationBuilder.RenameTable(
                name: "tata",
                newName: "Cereals");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cereals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cereals",
                table: "Cereals",
                column: "Id");
        }
    }
}
