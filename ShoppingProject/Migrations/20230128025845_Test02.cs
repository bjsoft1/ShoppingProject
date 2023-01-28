using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingProject.Migrations
{
    public partial class Test02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete2",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "IsDelete2",
                table: "CategoriesModels");

            migrationBuilder.RenameColumn(
                name: "CategoryName1",
                table: "CategoriesModels",
                newName: "CategoryName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "CategoriesModels",
                newName: "CategoryName1");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete2",
                table: "UserAccounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete2",
                table: "CategoriesModels",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
