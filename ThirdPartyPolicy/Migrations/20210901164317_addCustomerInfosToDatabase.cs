using Microsoft.EntityFrameworkCore.Migrations;

namespace ThirdPartyPolicy.Migrations
{
    public partial class addCustomerInfosToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChangeUserPasswords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OldPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmNewPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeUserPasswords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchasePolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasePolicies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleMake = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    RegNo = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    VehicleModel = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    BodyType = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Premium",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PremiumAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyId = table.Column<int>(type: "int", nullable: true),
                    PurchasePolicyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Premium", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Premium_Policies_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "Policies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Premium_PurchasePolicies_PurchasePolicyId",
                        column: x => x.PurchasePolicyId,
                        principalTable: "PurchasePolicies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BodyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyId = table.Column<int>(type: "int", nullable: true),
                    PremiumId = table.Column<int>(type: "int", nullable: true),
                    PurchasePolicyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyType_Policies_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "Policies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BodyType_Premium_PremiumId",
                        column: x => x.PremiumId,
                        principalTable: "Premium",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BodyType_PurchasePolicies_PurchasePolicyId",
                        column: x => x.PurchasePolicyId,
                        principalTable: "PurchasePolicies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BodyType_PolicyId",
                table: "BodyType",
                column: "PolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyType_PremiumId",
                table: "BodyType",
                column: "PremiumId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyType_PurchasePolicyId",
                table: "BodyType",
                column: "PurchasePolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_Premium_PolicyId",
                table: "Premium",
                column: "PolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_Premium_PurchasePolicyId",
                table: "Premium",
                column: "PurchasePolicyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyType");

            migrationBuilder.DropTable(
                name: "ChangeUserPasswords");

            migrationBuilder.DropTable(
                name: "CustomerInfos");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "VehicleInfos");

            migrationBuilder.DropTable(
                name: "Premium");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "PurchasePolicies");
        }
    }
}
