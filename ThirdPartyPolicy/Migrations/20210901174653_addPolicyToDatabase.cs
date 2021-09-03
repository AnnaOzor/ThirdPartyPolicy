using Microsoft.EntityFrameworkCore.Migrations;

namespace ThirdPartyPolicy.Migrations
{
    public partial class addPolicyToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyType_Policies_PolicyId",
                table: "BodyType");

            migrationBuilder.DropForeignKey(
                name: "FK_Premium_Policies_PolicyId",
                table: "Premium");

            migrationBuilder.DropIndex(
                name: "IX_Premium_PolicyId",
                table: "Premium");

            migrationBuilder.DropIndex(
                name: "IX_BodyType_PolicyId",
                table: "BodyType");

            migrationBuilder.DropColumn(
                name: "PolicyId",
                table: "Premium");

            migrationBuilder.DropColumn(
                name: "PolicyId",
                table: "BodyType");

            migrationBuilder.AddColumn<string>(
                name: "BodyType",
                table: "Policies",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Premium",
                table: "Policies",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyType",
                table: "Policies");

            migrationBuilder.DropColumn(
                name: "Premium",
                table: "Policies");

            migrationBuilder.AddColumn<int>(
                name: "PolicyId",
                table: "Premium",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PolicyId",
                table: "BodyType",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Premium_PolicyId",
                table: "Premium",
                column: "PolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyType_PolicyId",
                table: "BodyType",
                column: "PolicyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BodyType_Policies_PolicyId",
                table: "BodyType",
                column: "PolicyId",
                principalTable: "Policies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Premium_Policies_PolicyId",
                table: "Premium",
                column: "PolicyId",
                principalTable: "Policies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
