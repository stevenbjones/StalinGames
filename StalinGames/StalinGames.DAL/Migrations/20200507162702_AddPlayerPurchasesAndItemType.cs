using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class AddPlayerPurchasesAndItemType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "05ea642d-5452-4d78-ad96-e2936f184501", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1cf417c3-56af-4399-999b-c4eca95e7c49", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a383c00a-acd0-46c6-a280-e50d5a9909ba", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c3d922f7-d201-41ae-9976-dd42325b0bba", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05ea642d-5452-4d78-ad96-e2936f184501");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cf417c3-56af-4399-999b-c4eca95e7c49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a383c00a-acd0-46c6-a280-e50d5a9909ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d922f7-d201-41ae-9976-dd42325b0bba");

            migrationBuilder.DropColumn(
                name: "ProfileTitle",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "BackGroundPath",
                table: "AspNetUsers",
                newName: "BackgroundPath");

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundPath",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AccountCreatedDate",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileTitleName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BackgroundPicture",
                columns: table => new
                {
                    BackgroundPath = table.Column<string>(nullable: false),
                    BackgroundPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundPicture", x => x.BackgroundPath);
                });

            migrationBuilder.CreateTable(
                name: "PlayerPurchases",
                columns: table => new
                {
                    OrderID = table.Column<string>(nullable: false),
                    UserID = table.Column<string>(nullable: false),
                    Item = table.Column<string>(nullable: false),
                    ItemType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerPurchases", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "ProfileTitle",
                columns: table => new
                {
                    ProfileTitleName = table.Column<string>(nullable: false),
                    ProfileTitlePrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileTitle", x => x.ProfileTitleName);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "e648e3ba-aa22-4217-ae78-86ca918050c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6a72f0c7-b808-4134-b62b-07fc21f3d7a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2028719c-46ad-4dc1-beb8-8b86a98f14e7");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackgroundPath", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitleName", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "735113a5-6a3b-435f-8e1e-77bc2451ae90", 0, "41ea0276-6949-473d-821d-af2a81d89f9b", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEKs+f9VZzsMbZdppBLvPNnDr3ZkkhxOOgyjI18mugG2S+CqcSNLLbHzM41pY01cOSA==", null, false, "a0318001-49ed-4487-bcda-5ec3f350de6e", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "896b468b-13c9-4ac9-b470-86948fed8297", 0, "490db074-0246-42f6-bfbb-635c269a7584", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEBeNL3IfUlGcz0vWtGHQxhFh5e50G/pwwZK/8wRT0G2Ixc4HBvBLzkA/Gx/QFqocQg==", null, false, "a9d8eef2-8de4-43f4-9934-4570122d6189", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "bf8c1951-c6a7-49e7-b216-7bd3ef5c561c", 0, "3caf496e-252a-4e5c-b6d5-4fdab1b19e5e", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEPnKaiWr1vSU4y/UTEIJO/bTfQYbJo/2UIMftukSECJSbK9ye+JLUfppDXKgk88xig==", null, false, "86f95de3-1aac-4eac-a33c-8fde6defc5c0", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "8d4e4805-5b57-4ebe-92e0-ab82da192d8c", 0, "0f1f0b8c-b43e-471a-b4d9-6d0bdd758398", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEO4MwskbTtlikX0xvBDqur4Qz0e6PuQ3Cv25AOeeQp/1LGBTXRMwfvADguQsVzaf0Q==", null, false, "80445652-7e69-415c-953f-1b68e4bcfc22", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "Item", "ItemType", "UserID" },
                values: new object[,]
                {
                    { "1dd22ff8-f7d9-40dc-a74d-18b368df3af1", "Gambler", 0, "735113a5-6a3b-435f-8e1e-77bc2451ae90" },
                    { "677ddac5-f745-4d68-8234-2005ace134a3", "KingPin", 0, "735113a5-6a3b-435f-8e1e-77bc2451ae90" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "735113a5-6a3b-435f-8e1e-77bc2451ae90", "1" },
                    { "896b468b-13c9-4ac9-b470-86948fed8297", "2" },
                    { "bf8c1951-c6a7-49e7-b216-7bd3ef5c561c", "3" },
                    { "8d4e4805-5b57-4ebe-92e0-ab82da192d8c", "1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BackgroundPath",
                table: "AspNetUsers",
                column: "BackgroundPath");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProfileTitleName",
                table: "AspNetUsers",
                column: "ProfileTitleName");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BackgroundPicture_BackgroundPath",
                table: "AspNetUsers",
                column: "BackgroundPath",
                principalTable: "BackgroundPicture",
                principalColumn: "BackgroundPath",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ProfileTitle_ProfileTitleName",
                table: "AspNetUsers",
                column: "ProfileTitleName",
                principalTable: "ProfileTitle",
                principalColumn: "ProfileTitleName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BackgroundPicture_BackgroundPath",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ProfileTitle_ProfileTitleName",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BackgroundPicture");

            migrationBuilder.DropTable(
                name: "PlayerPurchases");

            migrationBuilder.DropTable(
                name: "ProfileTitle");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BackgroundPath",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProfileTitleName",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "735113a5-6a3b-435f-8e1e-77bc2451ae90", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "896b468b-13c9-4ac9-b470-86948fed8297", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8d4e4805-5b57-4ebe-92e0-ab82da192d8c", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bf8c1951-c6a7-49e7-b216-7bd3ef5c561c", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "735113a5-6a3b-435f-8e1e-77bc2451ae90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "896b468b-13c9-4ac9-b470-86948fed8297");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d4e4805-5b57-4ebe-92e0-ab82da192d8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf8c1951-c6a7-49e7-b216-7bd3ef5c561c");

            migrationBuilder.DropColumn(
                name: "AccountCreatedDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileTitleName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "BackgroundPath",
                table: "AspNetUsers",
                newName: "BackGroundPath");

            migrationBuilder.AlterColumn<string>(
                name: "BackGroundPath",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileTitle",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

           

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a9695416-d7cc-4d6d-a5dc-46af7dab58cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f972e4f7-4988-43ca-ba2b-070ec7ff4e81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "af462172-51b8-4eba-8fca-11dc6dea12cd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BackGroundPath", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "c3d922f7-d201-41ae-9976-dd42325b0bba", 0, "a2d9260a-ffee-47d5-94f5-c9a9949184b6", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEPWycyVd2REdVtZX6qktDqajgJOO3rJwzayhwLmj1fz07Pfas+cOU5HSkb9I/MgMSQ==", null, false, "c087e126-061e-412d-934b-36c320bd8258", false, "Jens", null, 2000, 0L, null, null, 0, 0 },
                    { "1cf417c3-56af-4399-999b-c4eca95e7c49", 0, "9ef11c5f-cec2-4c27-bfff-b6c03649760b", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEI8kMqyqgc3LW0EOl2tecnZC6XYjbEWyDTGdJLb9yZHMRNSG0ipNKs4uopc7uroQIA==", null, false, "367fd4d3-c183-4e40-a7c9-947fb47ff39f", false, "frederik", null, 2000, 0L, null, null, 0, 0 },
                    { "05ea642d-5452-4d78-ad96-e2936f184501", 0, "04c1fcb0-791f-417b-a485-031fea5d03f0", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEIa1EV7JfnkQRaWdsSmNRAWd158wQl4ddl5fTEXx303BzaaKRkhdLkeLfTOqjVvTIg==", null, false, "2e6c0539-369f-42e6-9daf-a1511e848ede", false, "peter", null, 2000, 0L, null, null, 0, 0 },
                    { "a383c00a-acd0-46c6-a280-e50d5a9909ba", 0, "5196c806-01dc-4235-98bb-347008ad849d", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAELSOg+DFkwSIjUTPu9J5LHL6E5RjfFxrEIguE+SupQqUZpIPEF/3eYt5QiJTRXjDzw==", null, false, "c437355f-73e2-4060-b8e9-f718f4198515", false, "steven", null, 2000, 0L, null, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "c3d922f7-d201-41ae-9976-dd42325b0bba", "1" },
                    { "1cf417c3-56af-4399-999b-c4eca95e7c49", "2" },
                    { "05ea642d-5452-4d78-ad96-e2936f184501", "3" },
                    { "a383c00a-acd0-46c6-a280-e50d5a9909ba", "1" }
                });
        }
    }
}
