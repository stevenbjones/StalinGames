using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class adddefaultbackgroundtousers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "03470246-a39c-4f62-9074-01ccceb4c393", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2476ef9e-6c79-4eb3-b20b-cfd817910843", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "30c2d10d-0aac-4095-b796-3d3a63a23216", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "30f6be09-dae8-4366-9889-8ef233b671da", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "468dac6f-55a6-42d1-824d-e7e4c8224e7f", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "560bf694-fb85-42af-889a-20f8c1c92613", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bf204a27-bceb-4ba4-b254-d51c117160f7", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d450060a-fe94-4126-b487-0cf8dbb66f1c", "3" });

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "01402636-9a0c-48c8-a922-264d118f67c1");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "11e5551d-7ea9-4108-9ad2-448dadae0c65");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "30c87182-b4ea-4b80-8988-24806633823e");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "4a2f9da9-e2df-4363-ba74-8977d84d9e03");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "51ea3e43-e7ed-4b11-a795-fc39729fdf4a");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "5cdb6c94-64a2-49cd-a395-27188e0fa7d8");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "70a296b4-d952-49a8-8952-e95332c1574d");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "81d91f37-5841-4a6c-87c9-796969eb69d2");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "b6c42c46-46db-4e79-bf36-b8ebaa61c167");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "b7c74320-7258-47e0-bafb-f0a163bd174c");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "cdf24de5-2b7d-4457-bd1b-cad9e31bb6d2");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "f0a89e2a-3a35-49ad-83b7-14b5be72b058");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "f3e4d1f9-f3e9-43b1-8111-254da8b412ad");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "f994ab7a-f25d-4a0a-9bd3-2a56e9cb75d3");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "28578c96-061b-4c4a-a2e4-5a6271e66965");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "32325323-15cc-4b43-88b3-b8269fb86293");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "48552e69-0665-4aa5-8691-ce4b82f3e4e7");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "89776a87-9e86-4174-985e-79ce839ae773");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "a2e97819-add7-4211-a7f8-4ac4739896c2");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "a301194d-52cd-4e06-9a85-0c68fcac8b59");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "aca855ba-7245-4d2d-9d19-2aa4fbe027ed");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "b8e834d5-5c82-4b82-8eb8-57c84a5bfd0d");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "ebcbd5ae-24ce-417a-a64c-032178fcfa41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03470246-a39c-4f62-9074-01ccceb4c393");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2476ef9e-6c79-4eb3-b20b-cfd817910843");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30c2d10d-0aac-4095-b796-3d3a63a23216");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30f6be09-dae8-4366-9889-8ef233b671da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "468dac6f-55a6-42d1-824d-e7e4c8224e7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "560bf694-fb85-42af-889a-20f8c1c92613");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf204a27-bceb-4ba4-b254-d51c117160f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d450060a-fe94-4126-b487-0cf8dbb66f1c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d62a8af1-c92e-44ea-bf3c-d58ea90388ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3c995ae0-e065-4bd2-aa72-9e48e1eb3f64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "597a700b-fc44-44b4-a4fb-b81c993ff084");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "109a4cba-8431-417c-902b-33f721e205b6", 0, "52102ca0-ebf3-417b-9180-5fd0833af443", "ApplicationUser", "karel@Gmail.com", false, false, null, null, "karel", "AQAAAAEAACcQAAAAEI+HWBRtvscT1SRiRtLpCR7zEVx9PXVWB4T2VIE33qc5J0z2dKkvsy+Jonmu/zgcMA==", null, false, "615cf3ce-83bd-45ab-bb60-fd6aecfbeebe", false, "karel", new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, 1590263312L, null, "Gambler", 0, 0 },
                    { "6df73de9-aa33-4d7c-9e1e-75ddd9db1998", 0, "dcbcc000-14b5-48ed-87c8-2c06803818ab", "ApplicationUser", "eddy@Gmail.com", false, false, null, null, "eddy", "AQAAAAEAACcQAAAAEBGhKp/bg+qc7Tu1Fx5Nua75x2jKu8FJAFKuYinfxXmqPm0kjSM2SNb3AyNvHm9PKQ==", null, false, "0392722e-30a8-4de2-b9ad-f79156df6ed8", false, "eddy", new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, 1590263312L, null, "Gambler", 0, 0 },
                    { "4e2e3570-8cf7-49d8-a443-ffad065e2c38", 0, "b658b5a9-e081-468e-862b-86aca13908fd", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEJ6IepSsjJ8wM5pDsKuLfpurR8Ad8kMXPGd2muA53I2cUlQskL1oZfkDXHJ2z06Cuw==", null, false, "7a2ce44c-4e87-440b-a9c9-d7cf46da3c21", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, 0L, null, "KingPin", 0, 0 },
                    { "8e73da08-e483-41d6-a790-7e8c27963811", 0, "1dd8bd3e-a1e2-43d2-b347-19c98a814b4a", "ApplicationUser", "frank@Gmail.com", false, false, null, null, "frank", "AQAAAAEAACcQAAAAEPiaIOAU6cTCBBfE5f463gueliknakrrxMimCFZprmXMDvbQ8Gqocs7rxshhOVkD7Q==", null, false, "af07fe86-8830-47d8-959a-078324ffa6fd", false, "frank", new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, 1590263312L, null, "Gambler", 0, 0 },
                    { "64e9d43c-dc3b-416a-a4c1-e887f3b8b6b5", 0, "f955de68-78c6-45c9-9f2f-ca6804fe6859", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEBPMMfJFp/hrxHP7P6sEKAooSG73lr9BmA5puyavMfDXoXbjJt6bsQS3QUESzgEySw==", null, false, "f1f4e765-96e6-4edd-8e2b-49f5a38cb9d0", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "201894e1-898e-4e91-bdee-137454fdf84a", 0, "da2d583a-8bfb-4e62-ad5b-1d1249a7a96e", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEDX0xdv8n871umueBr/rej7iR18eci/4yBw0WQBwdN/24lv2AmIXJ3F/4enlGejhKQ==", null, false, "9fbeadba-3279-4972-8fda-b471c82847dd", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "b7b0a235-036d-4822-8468-2e15743e4cc2", 0, "74d5e3a1-370a-46f1-be79-c7b4a21a97d4", "ApplicationUser", "jan@Gmail.com", false, false, null, null, "jan", "AQAAAAEAACcQAAAAEDhyconuECH6uyBHr8B8+VGiok8OnApsEK9j3ZXAK9lN7Ihus1lY+mUoXOOWFKWtxg==", null, false, "81941f71-e071-4658-b7be-5c4b5a7080ba", false, "jan", new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, 1590263312L, null, "Gambler", 0, 0 },
                    { "84a807fc-f3a9-4095-9b95-b95a759ac5e8", 0, "fdd15c97-e88f-4917-9606-6cee037708e4", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEFiVL70Dbxlu9YgSH9C0TdYKVTCZozigvCwNIz79QJbkx6aJOBSUp8sCiGjyXCNFxw==", null, false, "3fd30526-4265-4fc9-a616-bbc2ff2f58fd", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Value", "itemType" },
                values: new object[,]
                {
                    { "8aea1830-afb4-43b8-95f4-569eefb31d41", "Ultimate true StalinGames casino master", 1000000, "TrueStalinGamesMaster.jpg", 1 },
                    { "d260d87e-95c6-4b48-941c-0f2880a20967", "Default background", 0, "DefaultBackground.jpg", 1 },
                    { "a0259e50-4d9f-4839-b4ad-e8e5dbe211ff", "Wolf of Wall Street", 500000, null, 0 },
                    { "791d63b8-e870-4a51-8f5c-bed5398493a7", "Gambler", 0, null, 0 },
                    { "287088c3-4acd-41ae-88d1-5d90a44ba7db", "KingPin", 1000000, null, 0 },
                    { "e076ede6-2f6d-4f1c-9384-6f76d1a4dba6", "Ace on fire", 50000, "FireAce.jpg", 1 },
                    { "b28ae19b-e00e-400d-8fce-ac5668ca8fb6", "Simp", 2000, null, 0 },
                    { "45484008-9951-4b66-a7b6-efeb76997911", "Roulette master", 200000, "RouletteMaster.jpg", 1 },
                    { "3e174df4-209c-43b4-82c3-8960c0a7f589", "Local Champion", 10000, null, 0 },
                    { "08df8158-1ad2-407c-8a82-8b9138279bbe", "Slot machine master", 200000, "SlotMachineMaster.jpg", 1 },
                    { "07728ff2-0e3f-4a50-8de7-e261def7b1dd", "Black jack master", 200000, "BlackJackMaster.jpg", 1 },
                    { "42987eb6-2f49-4e22-bc4a-405208eb5d00", "Simple card pattern", 5000, "CardPattern.jpg", 1 },
                    { "def890dd-3e34-4702-a4c0-d81971c5bddd", "Casino master", 500000, "CasinoMaster.jpg", 1 },
                    { "5cfd704c-c4a6-4dd8-88e5-47200fed4a15", "Absolute Legend", 100000, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "c95e3e41-eb7a-4bb7-87b5-1440f2ad8109", "a0259e50-4d9f-4839-b4ad-e8e5dbe211ff", "4e2e3570-8cf7-49d8-a443-ffad065e2c38" },
                    { "a7b09896-3ec6-4c1d-b5d3-b6f04002340d", "287088c3-4acd-41ae-88d1-5d90a44ba7db", "4e2e3570-8cf7-49d8-a443-ffad065e2c38" },
                    { "123814f9-22c3-449b-b0b4-d550d188e9c2", "8aea1830-afb4-43b8-95f4-569eefb31d41", "4e2e3570-8cf7-49d8-a443-ffad065e2c38" },
                    { "de47e6a1-c3cc-479c-88df-819a8d5fc1b1", "a0259e50-4d9f-4839-b4ad-e8e5dbe211ff", "6df73de9-aa33-4d7c-9e1e-75ddd9db1998" },
                    { "0bec0849-72fb-4888-bcce-9cd7b2b5fb95", "d260d87e-95c6-4b48-941c-0f2880a20967", "6df73de9-aa33-4d7c-9e1e-75ddd9db1998" },
                    { "777dced8-46c5-45e8-9c47-2667b64e9e45", "d260d87e-95c6-4b48-941c-0f2880a20967", "8e73da08-e483-41d6-a790-7e8c27963811" },
                    { "987f281f-5f93-44d7-a5a2-8cf89cba3d2f", "d260d87e-95c6-4b48-941c-0f2880a20967", "b7b0a235-036d-4822-8468-2e15743e4cc2" },
                    { "750b41e6-eb27-4f93-a0c6-ed41cd433e53", "d260d87e-95c6-4b48-941c-0f2880a20967", "109a4cba-8431-417c-902b-33f721e205b6" },
                    { "eac88137-de59-47ce-a720-022ad5671177", "d260d87e-95c6-4b48-941c-0f2880a20967", "4e2e3570-8cf7-49d8-a443-ffad065e2c38" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "4e2e3570-8cf7-49d8-a443-ffad065e2c38", "1" },
                    { "201894e1-898e-4e91-bdee-137454fdf84a", "2" },
                    { "84a807fc-f3a9-4095-9b95-b95a759ac5e8", "3" },
                    { "64e9d43c-dc3b-416a-a4c1-e887f3b8b6b5", "1" },
                    { "8e73da08-e483-41d6-a790-7e8c27963811", "3" },
                    { "b7b0a235-036d-4822-8468-2e15743e4cc2", "3" },
                    { "6df73de9-aa33-4d7c-9e1e-75ddd9db1998", "3" },
                    { "109a4cba-8431-417c-902b-33f721e205b6", "3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "109a4cba-8431-417c-902b-33f721e205b6", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "201894e1-898e-4e91-bdee-137454fdf84a", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4e2e3570-8cf7-49d8-a443-ffad065e2c38", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "64e9d43c-dc3b-416a-a4c1-e887f3b8b6b5", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6df73de9-aa33-4d7c-9e1e-75ddd9db1998", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "84a807fc-f3a9-4095-9b95-b95a759ac5e8", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e73da08-e483-41d6-a790-7e8c27963811", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b7b0a235-036d-4822-8468-2e15743e4cc2", "3" });

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "07728ff2-0e3f-4a50-8de7-e261def7b1dd");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "08df8158-1ad2-407c-8a82-8b9138279bbe");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "287088c3-4acd-41ae-88d1-5d90a44ba7db");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "3e174df4-209c-43b4-82c3-8960c0a7f589");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "42987eb6-2f49-4e22-bc4a-405208eb5d00");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "45484008-9951-4b66-a7b6-efeb76997911");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "5cfd704c-c4a6-4dd8-88e5-47200fed4a15");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "791d63b8-e870-4a51-8f5c-bed5398493a7");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "8aea1830-afb4-43b8-95f4-569eefb31d41");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "a0259e50-4d9f-4839-b4ad-e8e5dbe211ff");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "b28ae19b-e00e-400d-8fce-ac5668ca8fb6");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "d260d87e-95c6-4b48-941c-0f2880a20967");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "def890dd-3e34-4702-a4c0-d81971c5bddd");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "e076ede6-2f6d-4f1c-9384-6f76d1a4dba6");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "0bec0849-72fb-4888-bcce-9cd7b2b5fb95");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "123814f9-22c3-449b-b0b4-d550d188e9c2");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "750b41e6-eb27-4f93-a0c6-ed41cd433e53");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "777dced8-46c5-45e8-9c47-2667b64e9e45");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "987f281f-5f93-44d7-a5a2-8cf89cba3d2f");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "a7b09896-3ec6-4c1d-b5d3-b6f04002340d");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "c95e3e41-eb7a-4bb7-87b5-1440f2ad8109");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "de47e6a1-c3cc-479c-88df-819a8d5fc1b1");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "eac88137-de59-47ce-a720-022ad5671177");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109a4cba-8431-417c-902b-33f721e205b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "201894e1-898e-4e91-bdee-137454fdf84a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e2e3570-8cf7-49d8-a443-ffad065e2c38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64e9d43c-dc3b-416a-a4c1-e887f3b8b6b5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6df73de9-aa33-4d7c-9e1e-75ddd9db1998");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84a807fc-f3a9-4095-9b95-b95a759ac5e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e73da08-e483-41d6-a790-7e8c27963811");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7b0a235-036d-4822-8468-2e15743e4cc2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1ffd62da-1cb8-46ee-95d9-ed8c05b282bf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "172986b2-802d-41a7-b573-a3a349b31bd9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "34ab4a34-4f33-41ac-acc0-cabb47a043eb");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "d450060a-fe94-4126-b487-0cf8dbb66f1c", 0, "f5185b40-1eb0-4abd-bfcb-67fa471b18f4", "ApplicationUser", "karel@Gmail.com", false, false, null, null, "karel", "AQAAAAEAACcQAAAAEDPz1pza0XUaJSr81R327KL51a4FBlQwKIQ5EQ6sSgcyc+dtvXQ5ekoLe9l+ceXP/w==", null, false, "c33c63ca-ba3e-4730-b528-f5bcfb5a5e6a", false, "karel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "2476ef9e-6c79-4eb3-b20b-cfd817910843", 0, "cdb40d0a-e294-4627-8fd3-26a03869e0bb", "ApplicationUser", "eddy@Gmail.com", false, false, null, null, "eddy", "AQAAAAEAACcQAAAAEMTSYkERjqul3vNXNTKbNOU4ufcxMvK71FYTM+RQnSRLw41adyDRH/GiWiW4hsWIaA==", null, false, "b194ce4f-4534-4526-b0d6-39e561b5ac59", false, "eddy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "bf204a27-bceb-4ba4-b254-d51c117160f7", 0, "2f748198-44e5-439c-9a11-10a8b2efe8b5", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEMI3QzkccFQo7Po5OxCUPUaxpnfPR9RWq7kC7CUODZl5es6E17os8ACCZ3rTYwq4/w==", null, false, "0f48ca5b-0769-4167-a46c-5295c718bcd2", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, 0L, null, "KingPin", 0, 0 },
                    { "560bf694-fb85-42af-889a-20f8c1c92613", 0, "aef9258b-0d26-47c5-a121-cebc68e776ad", "ApplicationUser", "frank@Gmail.com", false, false, null, null, "frank", "AQAAAAEAACcQAAAAEH5/VpsvarcMgsEMoVQqmUnQDDNIit6Dr5ScgWuPr5d+0jLdGJIKFG1JWQ+LWgKX5Q==", null, false, "222c1537-6ba2-4816-b780-894ead8b0947", false, "frank", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "30f6be09-dae8-4366-9889-8ef233b671da", 0, "d1e4109d-98ad-4122-b578-b075a2cdd013", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEFTDeZRgXHzlko6MrAxX3Wndp3ymkFZG+GOc17GJso7tbHZBNiYXmtul5Ag/nbV8/Q==", null, false, "65e82e1a-5ab9-4913-b0f3-0aa7760acebc", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "468dac6f-55a6-42d1-824d-e7e4c8224e7f", 0, "c673cf27-ebee-4ae4-b035-a9209d824f7d", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEChF6S7BCice9ozsn4PrU7xGVbmOoJ/lx3Y3DsZOhrcDmmlOKj4eax7IjZiY+7VwrQ==", null, false, "dd13cfed-c062-4c1c-b70f-e3fe8aa28104", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "30c2d10d-0aac-4095-b796-3d3a63a23216", 0, "c502366d-84ef-4913-8c9e-08661d0d9dcb", "ApplicationUser", "jan@Gmail.com", false, false, null, null, "jan", "AQAAAAEAACcQAAAAEHhVEhhy1aWOwa/THDUstxrtdD4Xep/L5M8EXLjvtj2csI8IySbSL06V0nThEH/h1A==", null, false, "897e62ae-425d-446b-bde0-6047319cbdeb", false, "jan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "03470246-a39c-4f62-9074-01ccceb4c393", 0, "38703a77-14a2-4d7e-a5e2-474d1d811855", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEEVbRKmFODlCJ8GvT6LoYY/k5Bm3r26plZXbzdP4PcqcH8NpBIMf5CzcSTC0xapJJg==", null, false, "7a8d46bb-d005-4288-b17c-47a3c68d12b8", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Value", "itemType" },
                values: new object[,]
                {
                    { "51ea3e43-e7ed-4b11-a795-fc39729fdf4a", "Ultimate true StalinGames casino master", 1000000, "TrueStalinGamesMaster.jpg", 1 },
                    { "70a296b4-d952-49a8-8952-e95332c1574d", "Default background", 0, "DefaultBackground.jpg", 1 },
                    { "30c87182-b4ea-4b80-8988-24806633823e", "Wolf of Wall Street", 500000, null, 0 },
                    { "f994ab7a-f25d-4a0a-9bd3-2a56e9cb75d3", "Slot machine master", 200000, "SlotMachineMaster.jpg", 1 },
                    { "01402636-9a0c-48c8-a922-264d118f67c1", "KingPin", 1000000, null, 0 },
                    { "81d91f37-5841-4a6c-87c9-796969eb69d2", "Casino master", 500000, "CasinoMaster.jpg", 1 },
                    { "cdf24de5-2b7d-4457-bd1b-cad9e31bb6d2", "Gambler", 0, null, 0 },
                    { "b6c42c46-46db-4e79-bf36-b8ebaa61c167", "Ace on fire", 50000, "FireAce.jpg", 1 },
                    { "4a2f9da9-e2df-4363-ba74-8977d84d9e03", "Simp", 2000, null, 0 },
                    { "f0a89e2a-3a35-49ad-83b7-14b5be72b058", "Roulette master", 200000, "RouletteMaster.jpg", 1 },
                    { "b7c74320-7258-47e0-bafb-f0a163bd174c", "Absolute Legend", 100000, null, 0 },
                    { "11e5551d-7ea9-4108-9ad2-448dadae0c65", "Black jack master", 200000, "BlackJackMaster.jpg", 1 },
                    { "5cdb6c94-64a2-49cd-a395-27188e0fa7d8", "Simple card pattern", 5000, "CardPattern.jpg", 1 },
                    { "f3e4d1f9-f3e9-43b1-8111-254da8b412ad", "Local Champion", 10000, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "48552e69-0665-4aa5-8691-ce4b82f3e4e7", "30c87182-b4ea-4b80-8988-24806633823e", "bf204a27-bceb-4ba4-b254-d51c117160f7" },
                    { "89776a87-9e86-4174-985e-79ce839ae773", "01402636-9a0c-48c8-a922-264d118f67c1", "bf204a27-bceb-4ba4-b254-d51c117160f7" },
                    { "a2e97819-add7-4211-a7f8-4ac4739896c2", "51ea3e43-e7ed-4b11-a795-fc39729fdf4a", "bf204a27-bceb-4ba4-b254-d51c117160f7" },
                    { "a301194d-52cd-4e06-9a85-0c68fcac8b59", "30c87182-b4ea-4b80-8988-24806633823e", "2476ef9e-6c79-4eb3-b20b-cfd817910843" },
                    { "32325323-15cc-4b43-88b3-b8269fb86293", "70a296b4-d952-49a8-8952-e95332c1574d", "2476ef9e-6c79-4eb3-b20b-cfd817910843" },
                    { "aca855ba-7245-4d2d-9d19-2aa4fbe027ed", "70a296b4-d952-49a8-8952-e95332c1574d", "560bf694-fb85-42af-889a-20f8c1c92613" },
                    { "28578c96-061b-4c4a-a2e4-5a6271e66965", "70a296b4-d952-49a8-8952-e95332c1574d", "30c2d10d-0aac-4095-b796-3d3a63a23216" },
                    { "b8e834d5-5c82-4b82-8eb8-57c84a5bfd0d", "70a296b4-d952-49a8-8952-e95332c1574d", "d450060a-fe94-4126-b487-0cf8dbb66f1c" },
                    { "ebcbd5ae-24ce-417a-a64c-032178fcfa41", "70a296b4-d952-49a8-8952-e95332c1574d", "bf204a27-bceb-4ba4-b254-d51c117160f7" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "bf204a27-bceb-4ba4-b254-d51c117160f7", "1" },
                    { "468dac6f-55a6-42d1-824d-e7e4c8224e7f", "2" },
                    { "03470246-a39c-4f62-9074-01ccceb4c393", "3" },
                    { "30f6be09-dae8-4366-9889-8ef233b671da", "1" },
                    { "560bf694-fb85-42af-889a-20f8c1c92613", "3" },
                    { "30c2d10d-0aac-4095-b796-3d3a63a23216", "3" },
                    { "2476ef9e-6c79-4eb3-b20b-cfd817910843", "3" },
                    { "d450060a-fe94-4126-b487-0cf8dbb66f1c", "3" }
                });
        }
    }
}
