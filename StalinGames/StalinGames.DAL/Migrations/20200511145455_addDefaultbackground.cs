using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace StalinGames.DAL.Migrations
{
    public partial class addDefaultbackground : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "043a0cd9-9f01-4921-bb7e-cd46cd852e32", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "59e2ecb0-5584-4845-9fb6-0c83ac8b0106", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a47b16bd-bd1e-45ce-8fb3-dbff1c40c87f", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b9620fce-cab5-4006-9827-e946f736fbb3", "2" });

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "077faa2c-67c4-4a29-8ca0-e9bcf6524a0e");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "12f488d1-efcb-4be3-a674-7b26ed2fcb41");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "3986abac-0767-4db7-9417-14f4f4a0f979");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "4b205760-94dd-4be2-883b-36670ff78db6");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "534146c6-cdb8-4c03-a025-32cd5c111e0f");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "73f31485-0aea-4fb9-b629-a41f6b1c5cdd");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "91eb8406-e5ea-42f6-a118-443575571ffe");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "a0ba85cb-4c06-4b79-9ffb-fb6a87dbdf66");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "afbef5e9-1991-49a6-bc2d-c401d69d48e0");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "b3dc130b-7b12-4254-b367-02c7574d5a84");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "c0d66d31-b92e-437b-b752-9495749ecb37");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "ccce3e54-74b8-4fba-bbac-288b07f5a314");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "e7e4ce71-2d18-403f-9dc8-91c990ea0ef5");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "126fe372-08c8-4125-be19-0194d372be0a");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "21a6992d-68c8-4d25-ac89-8461e878798f");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "657256fa-f242-47a9-bfa9-53668416aabd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "043a0cd9-9f01-4921-bb7e-cd46cd852e32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59e2ecb0-5584-4845-9fb6-0c83ac8b0106");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a47b16bd-bd1e-45ce-8fb3-dbff1c40c87f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9620fce-cab5-4006-9827-e946f736fbb3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ea1ad8f5-5746-46be-88bd-043fdbcbec6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ef036c76-8765-44bd-bf78-062f9a394bfc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "8f7e9c37-769d-4d8e-95aa-7676060e88dd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "96062e7d-7d6e-47ed-897f-447b22e97305", 0, "8e4de258-cf89-40bb-9c5f-627f1e90dd4e", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEPNQgFwLovuFubgx09jnxPaHUzktQlHTApGCdOiTfmEFjPeVEHVpih672AYmigs8Tg==", null, false, "159a9553-b2a2-4850-8d1f-5463ef8029cb", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, 0L, null, "KingPin", 0, 0 },
                    { "07539380-8a1c-4464-82c9-6cab4d3e76d4", 0, "3948b3e2-5912-4c58-9bf0-b9cea2c0807e", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEA1Ov6TY2wjgSnl+zqn8W/UKdy6FBNUDv17QsmrKjDuVldgNhhhgNd0SteQ4ufb/Kw==", null, false, "3d2065f7-1f5e-40d7-87e9-9ff044afe48a", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "9f016273-c56f-4de5-b46f-24d96c43a5d1", 0, "13c008e1-3a01-4c66-beff-8e9eae7a9042", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEEh5klYrZYwqPkxEwoEkQl2vN0ap85vVdlQLZmUmTlv3vbEBJS0dHONVo9E9AwYR4Q==", null, false, "7f4d50db-3a69-4466-bf22-ba684f3efd84", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "c37270c9-ba51-4540-a44d-c5a29afb16e0", 0, "7b5bb1aa-b0b3-4e91-afd6-1694499ecfb4", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEA38cMF2F56PD1G42G8uyOpOTjFolGFQcAn/7fPQvLwzEkWqX0H0Cixzn4PSGssWRg==", null, false, "c02c20ee-086b-40cd-839f-d90b75fb1db0", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Value", "itemType" },
                values: new object[,]
                {
                    { "97753b01-cbd2-49b8-ba4d-3ed3f3c5e511", "Gambler", 0, null, 0 },
                    { "f1e6b317-7713-45ee-a427-8f1fdac72fd9", "Default background", 0, "DefaultBackground.jpg", 1 },
                    { "27ba45a5-ff3c-4fcc-b4c7-8199715cdff9", "KingPin", 1000000, null, 0 },
                    { "48ca10f1-6a8d-49f2-b117-77d2078b1b05", "Wolf of Wall Street", 1000000, null, 0 },
                    { "ae8d90f6-9166-4cb3-ac8e-205cf7c6c78b", "Ultimate true StalinGames casino master", 1000000, "TrueStalinGamesMaster.jpg", 1 },
                    { "b6f35bdb-5160-4eb0-9193-5d56a665a261", "Slot machine master", 200000, "SlotMachineMaster.jpg", 1 },
                    { "6d3880cd-6357-4025-af6c-eabcd576e79c", "Casino master", 500000, "CasinoMaster.jpg", 1 },
                    { "01d61fc7-07a9-464a-b647-fcaff11c2f72", "Simple card pattern", 5000, "CardPattern.jpg", 1 },
                    { "651ede18-fe00-43a2-9421-3fbdf3d9b1b1", "Black jack master", 200000, "BlackJackMaster.jpg", 1 },
                    { "7978257c-fa74-48db-b6f7-3e898ea07a9e", "Absolute Legend", 100000, null, 0 },
                    { "c9dea5db-3f27-4556-9740-628824e040a6", "Local Champion", 10000, null, 0 },
                    { "f2db0479-6a50-4881-9202-9c1efb67b7f4", "Simp", 2000, null, 0 },
                    { "cdb57f8d-822a-4aab-83c5-5a9be1004853", "Roulette master", 200000, "RouletteMaster.jpg", 1 },
                    { "0e26388e-a9eb-4e71-bfdb-e8552bcedf31", "Ace on fire", 50000, "FireAce.jpg", 1 }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "a2cd9a23-fcda-4cf2-80f9-c4bf7800c463", "48ca10f1-6a8d-49f2-b117-77d2078b1b05", "96062e7d-7d6e-47ed-897f-447b22e97305" },
                    { "252c4aed-504c-4a6c-af3a-7fab0de2f5af", "27ba45a5-ff3c-4fcc-b4c7-8199715cdff9", "96062e7d-7d6e-47ed-897f-447b22e97305" },
                    { "c8090f6b-5cb3-40ec-9e20-20f06a6c765f", "f1e6b317-7713-45ee-a427-8f1fdac72fd9", "96062e7d-7d6e-47ed-897f-447b22e97305" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "96062e7d-7d6e-47ed-897f-447b22e97305", "1" },
                    { "07539380-8a1c-4464-82c9-6cab4d3e76d4", "2" },
                    { "c37270c9-ba51-4540-a44d-c5a29afb16e0", "3" },
                    { "9f016273-c56f-4de5-b46f-24d96c43a5d1", "1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "07539380-8a1c-4464-82c9-6cab4d3e76d4", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "96062e7d-7d6e-47ed-897f-447b22e97305", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9f016273-c56f-4de5-b46f-24d96c43a5d1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c37270c9-ba51-4540-a44d-c5a29afb16e0", "3" });

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "01d61fc7-07a9-464a-b647-fcaff11c2f72");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "0e26388e-a9eb-4e71-bfdb-e8552bcedf31");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "27ba45a5-ff3c-4fcc-b4c7-8199715cdff9");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "48ca10f1-6a8d-49f2-b117-77d2078b1b05");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "651ede18-fe00-43a2-9421-3fbdf3d9b1b1");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "6d3880cd-6357-4025-af6c-eabcd576e79c");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "7978257c-fa74-48db-b6f7-3e898ea07a9e");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "97753b01-cbd2-49b8-ba4d-3ed3f3c5e511");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "ae8d90f6-9166-4cb3-ac8e-205cf7c6c78b");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "b6f35bdb-5160-4eb0-9193-5d56a665a261");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "c9dea5db-3f27-4556-9740-628824e040a6");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "cdb57f8d-822a-4aab-83c5-5a9be1004853");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "f1e6b317-7713-45ee-a427-8f1fdac72fd9");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "f2db0479-6a50-4881-9202-9c1efb67b7f4");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "252c4aed-504c-4a6c-af3a-7fab0de2f5af");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "a2cd9a23-fcda-4cf2-80f9-c4bf7800c463");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "c8090f6b-5cb3-40ec-9e20-20f06a6c765f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07539380-8a1c-4464-82c9-6cab4d3e76d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96062e7d-7d6e-47ed-897f-447b22e97305");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f016273-c56f-4de5-b46f-24d96c43a5d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c37270c9-ba51-4540-a44d-c5a29afb16e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b70e0fe1-6ffa-46c1-b7a9-394cabd3ae1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d724ee23-44c2-4cc5-a5a2-142a4531abe4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2adca980-c86b-446b-9f61-183c6eb5a13a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "043a0cd9-9f01-4921-bb7e-cd46cd852e32", 0, "0964c179-ee1e-42cd-a952-57e6261e1446", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEIF69UM6W7Gbn2U8SgzvA32Sp5xQTfuHb7f+8h6pGF9D5V5Ghy7JUc4eQr3xCLIuCQ==", null, false, "3804006e-11e8-40bb-ac43-c5117df402f4", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, 0L, null, "KingPin", 0, 0 },
                    { "b9620fce-cab5-4006-9827-e946f736fbb3", 0, "1380a6d9-df8a-4763-8135-b67a6c496fe3", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEHRj2mCSqiteQcPDlosRdbEEYASdzdkBlWIXWqQkAePIK4yXEr+cVvpg2wapoYHQWA==", null, false, "7c24ec87-a994-4963-a2ac-cb9bc0b4446f", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "59e2ecb0-5584-4845-9fb6-0c83ac8b0106", 0, "a21293b9-1c77-4cfd-86e5-adb8e6a7688e", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEJzdI82qebWqG/xgQTSqq9FkgY81oqFi+83XOoKhlJm6LDf4eefOdTzxOoFCiR8bAw==", null, false, "c8dfc01c-8788-4462-9bbb-e9badaa4d4ee", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "a47b16bd-bd1e-45ce-8fb3-dbff1c40c87f", 0, "9259e67e-2d82-4f86-bf34-d0f6a57191f7", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEFUL6tc4/whLWGaoqrG9yg1dvYSaBJY/ZpoKFKst+6CDh5PDY3obZ+ZvM5kiQGtu2A==", null, false, "3de0c5ff-c416-4b0a-b889-a00886b99caf", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Value", "itemType" },
                values: new object[,]
                {
                    { "ccce3e54-74b8-4fba-bbac-288b07f5a314", "Gambler", 0, null, 0 },
                    { "3986abac-0767-4db7-9417-14f4f4a0f979", "KingPin", 1000000, null, 0 },
                    { "afbef5e9-1991-49a6-bc2d-c401d69d48e0", "Wolf of Wall Street", 1000000, null, 0 },
                    { "91eb8406-e5ea-42f6-a118-443575571ffe", "Ultimate true StalinGames casino master", 1000000, "TrueStalinGamesMaster.jpg", 1 },
                    { "534146c6-cdb8-4c03-a025-32cd5c111e0f", "Roulette master", 200000, "RouletteMaster.jpg", 1 },
                    { "12f488d1-efcb-4be3-a674-7b26ed2fcb41", "Slot machine master", 200000, "SlotMachineMaster.jpg", 1 },
                    { "e7e4ce71-2d18-403f-9dc8-91c990ea0ef5", "Simple card pattern", 5000, "CardPattern.jpg", 1 },
                    { "4b205760-94dd-4be2-883b-36670ff78db6", "Black jack master", 200000, "BlackJackMaster.jpg", 1 },
                    { "a0ba85cb-4c06-4b79-9ffb-fb6a87dbdf66", "Absolute Legend", 100000, null, 0 },
                    { "b3dc130b-7b12-4254-b367-02c7574d5a84", "Local Champion", 10000, null, 0 },
                    { "73f31485-0aea-4fb9-b629-a41f6b1c5cdd", "Simp", 2000, null, 0 },
                    { "c0d66d31-b92e-437b-b752-9495749ecb37", "Casino master", 500000, "CasinoMaster.jpg", 1 },
                    { "077faa2c-67c4-4a29-8ca0-e9bcf6524a0e", "Ace on fire", 50000, "FireAce.jpg", 1 }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "126fe372-08c8-4125-be19-0194d372be0a", "afbef5e9-1991-49a6-bc2d-c401d69d48e0", "043a0cd9-9f01-4921-bb7e-cd46cd852e32" },
                    { "657256fa-f242-47a9-bfa9-53668416aabd", "3986abac-0767-4db7-9417-14f4f4a0f979", "043a0cd9-9f01-4921-bb7e-cd46cd852e32" },
                    { "21a6992d-68c8-4d25-ac89-8461e878798f", "cfcac2df-92e0-4862-9f2b-fa648eb62c90", "043a0cd9-9f01-4921-bb7e-cd46cd852e32" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "043a0cd9-9f01-4921-bb7e-cd46cd852e32", "1" },
                    { "b9620fce-cab5-4006-9827-e946f736fbb3", "2" },
                    { "a47b16bd-bd1e-45ce-8fb3-dbff1c40c87f", "3" },
                    { "59e2ecb0-5584-4845-9fb6-0c83ac8b0106", "1" }
                });
        }
    }
}