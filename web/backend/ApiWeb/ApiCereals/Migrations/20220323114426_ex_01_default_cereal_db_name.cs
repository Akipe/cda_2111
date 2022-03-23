using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCereals.Migrations
{
    public partial class ex_01_default_cereal_db_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tata",
                table: "tata");

            migrationBuilder.RenameTable(
                name: "tata",
                newName: "Cereals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cereals",
                table: "Cereals",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cereals",
                table: "Cereals");

            migrationBuilder.RenameTable(
                name: "Cereals",
                newName: "tata");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tata",
                table: "tata",
                column: "Id");
        }
    }
}
