using Microsoft.EntityFrameworkCore.Migrations;

namespace ThirdPartyPolicy.Migrations
{
    public partial class addUserLoginToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "UserLogins");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserLogins",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "RememberMe",
                table: "UserLogins",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "RememberMe",
                table: "UserLogins");

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "UserLogins",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
