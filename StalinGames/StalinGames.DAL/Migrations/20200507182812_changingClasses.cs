using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class changingClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BackgroundPicture_BackgroundPath",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ProfileTitle_ProfileTitleName",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfileTitle",
                table: "ProfileTitle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BackgroundPicture",
                table: "BackgroundPicture");

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
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "1dd22ff8-f7d9-40dc-a74d-18b368df3af1");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "677ddac5-f745-4d68-8234-2005ace134a3");

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
                name: "ProfileTitlePrice",
                table: "ProfileTitle");

            migrationBuilder.DropColumn(
                name: "Item",
                table: "PlayerPurchases");

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "PlayerPurchases");

            migrationBuilder.DropColumn(
                name: "BackgroundPrice",
                table: "BackgroundPicture");

            migrationBuilder.DropColumn(
                name: "BackgroundPath",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileTitleName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileTitleName",
                table: "ProfileTitle",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ItemID",
                table: "ProfileTitle",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "ProfileTitle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "itemType",
                table: "ProfileTitle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ItemID",
                table: "PlayerPurchases",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundPath",
                table: "BackgroundPicture",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ItemID",
                table: "BackgroundPicture",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "BackgroundPicture",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "itemType",
                table: "BackgroundPicture",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BackGroundItemID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileTitleItemID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfileTitle",
                table: "ProfileTitle",
                column: "ItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BackgroundPicture",
                table: "BackgroundPicture",
                column: "ItemID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d5558286-d9cd-4621-8173-588573315a1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8755c973-2581-4a64-9f03-2895d0634c6f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "a464e3ff-e891-4a10-a238-ad55d0145dea");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGroundItemID", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitleItemID", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "5abde424-c88b-49ff-ace2-9e5b7124e572", 0, "ae2fd285-13c8-42d6-8349-55614b9ca064", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEF7+icv7FZfqLu/e0nH3ahAhbE8sw9lsysTDxMqWjLMNxln2nDPsEsQqjjFzsqMpkw==", null, false, "1d3135c7-5109-4c92-9920-4c3770f824fa", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "23152f98-5317-478a-a1d7-3b54ccfd9c57", 0, "1dc0c253-f098-47d8-a237-d0a1fd54da9f", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAED0vyfcWh7nPzPTQ/TZUjgmvKf9EP+mQHkh8jlTHs85lBjwtrAJi6qZZmN/1UjX5nw==", null, false, "cd5c23d3-d57b-4281-a605-21e324fc8693", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "6b59c1e0-bd8b-49d4-ace8-ec80de9afbe8", 0, "d9ea61c5-6cf6-4500-b014-ae2f73ff0128", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEPFjXcHe185XaHI1l33j5nmk8GHPWGHkAA5M8pzBKFW35QQX29mVAn/O3wn3gfh6tw==", null, false, "05033f69-79cb-49be-9ede-96a3ef22b237", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "6530f76a-6714-456f-85db-53dd29b40371", 0, "d9dbec2c-a9f2-4274-a0a9-d91fdc48bf07", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEEyU1GuEi+8DtuwH33TX65gzC6beq+CQ5f2s40vfonjfvTz2ILVnCZY/h51vY/uRXg==", null, false, "d15de8bc-f2de-4be1-8071-ed74eaba0293", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "81324328-d4a7-4001-9e73-a893a8f22c2a", "e1cae4a0-911e-47f4-8980-305dbfb1581b", "5abde424-c88b-49ff-ace2-9e5b7124e572" },
                    { "7c151428-8fc2-46a1-b830-6995694443fd", "c5b3c034-93d9-40c7-ac21-fc15ac752e01", "5abde424-c88b-49ff-ace2-9e5b7124e572" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "5abde424-c88b-49ff-ace2-9e5b7124e572", "1" },
                    { "23152f98-5317-478a-a1d7-3b54ccfd9c57", "2" },
                    { "6b59c1e0-bd8b-49d4-ace8-ec80de9afbe8", "3" },
                    { "6530f76a-6714-456f-85db-53dd29b40371", "1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BackGroundItemID",
                table: "AspNetUsers",
                column: "BackGroundItemID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProfileTitleItemID",
                table: "AspNetUsers",
                column: "ProfileTitleItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BackgroundPicture_BackGroundItemID",
                table: "AspNetUsers",
                column: "BackGroundItemID",
                principalTable: "BackgroundPicture",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ProfileTitle_ProfileTitleItemID",
                table: "AspNetUsers",
                column: "ProfileTitleItemID",
                principalTable: "ProfileTitle",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BackgroundPicture_BackGroundItemID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ProfileTitle_ProfileTitleItemID",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfileTitle",
                table: "ProfileTitle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BackgroundPicture",
                table: "BackgroundPicture");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BackGroundItemID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProfileTitleItemID",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "23152f98-5317-478a-a1d7-3b54ccfd9c57", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5abde424-c88b-49ff-ace2-9e5b7124e572", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6530f76a-6714-456f-85db-53dd29b40371", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6b59c1e0-bd8b-49d4-ace8-ec80de9afbe8", "3" });

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "7c151428-8fc2-46a1-b830-6995694443fd");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "81324328-d4a7-4001-9e73-a893a8f22c2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23152f98-5317-478a-a1d7-3b54ccfd9c57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5abde424-c88b-49ff-ace2-9e5b7124e572");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6530f76a-6714-456f-85db-53dd29b40371");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b59c1e0-bd8b-49d4-ace8-ec80de9afbe8");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "ProfileTitle");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ProfileTitle");

            migrationBuilder.DropColumn(
                name: "itemType",
                table: "ProfileTitle");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "PlayerPurchases");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "BackgroundPicture");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "BackgroundPicture");

            migrationBuilder.DropColumn(
                name: "itemType",
                table: "BackgroundPicture");

            migrationBuilder.DropColumn(
                name: "BackGroundItemID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileTitleItemID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileTitleName",
                table: "ProfileTitle",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfileTitlePrice",
                table: "ProfileTitle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Item",
                table: "PlayerPurchases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ItemType",
                table: "PlayerPurchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundPath",
                table: "BackgroundPicture",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BackgroundPrice",
                table: "BackgroundPicture",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BackgroundPath",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileTitleName",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfileTitle",
                table: "ProfileTitle",
                column: "ProfileTitleName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BackgroundPicture",
                table: "BackgroundPicture",
                column: "BackgroundPath");

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
    }
}
