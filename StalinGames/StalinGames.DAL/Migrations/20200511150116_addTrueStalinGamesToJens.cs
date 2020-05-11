using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace StalinGames.DAL.Migrations
{
    public partial class addTrueStalinGamesToJens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "1844c21a-fe5e-43a3-93ad-651b207121fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1f64226f-5295-4a0f-814a-5f92fe890bed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "57b520c2-c751-4b9b-afd0-e9673cd86bde");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "1de9ba08-dcfc-4d01-91e9-54c8a3053ef8", 0, "13272b55-6afb-41b0-8a23-5b7b3b4b2fb6", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEHXhiOXZgms9oITroRO8YjtEoh/+vPjmlUIdWTqEf+Z7pk5xpYoIN0r9DEBA6Gtx9Q==", null, false, "71187ede-eeb5-4976-970e-e90efe94ce6d", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, 0L, null, "KingPin", 0, 0 },
                    { "953ad44d-a151-4d86-b733-6940417498f7", 0, "f857d739-cd02-4dae-bfb1-169a1be7e36a", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEGn1XyO2Esx7RnnndTNm9tdsLklkz0woBqgI+Imhp1GQZwtmK/YPlGJ4a8NfcFnc/A==", null, false, "edc82996-de46-42f9-85c1-96e0b23b09f2", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "48f9e0cd-e39b-4d78-a81f-1054c5da68f5", 0, "d93006a6-c4bb-4281-a6e7-0bc29cf82307", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEBgJ58WFRvrWYU4v46Z6RyJty5lGLJf1gRxpTbt+eK/BqW3wr7FYj5wAWhEBGKmZ/Q==", null, false, "d272281b-e32f-408c-92a6-7d3f418b3d5e", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "34a76cf9-8a60-45e1-9814-a633195b28de", 0, "d555df70-687b-459b-b0ec-ded1bfc63ed0", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEMPptMbTSkYycKknI+3nJxjRohrD3UTRD2xT423Bf07kNyIBz2ycbrSj395wQt3F2g==", null, false, "7796b77d-0a07-4acb-9a3b-54a16c7f68d5", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Value", "itemType" },
                values: new object[,]
                {
                    { "c2652ebb-5066-4f69-b150-015d1d8b35b9", "Gambler", 0, null, 0 },
                    { "02cb26b6-8170-411a-941a-7d75a6f0fbaf", "Ultimate true StalinGames casino master", 1000000, "TrueStalinGamesMaster.jpg", 1 },
                    { "b7bd13f6-f867-46d3-9f9c-d980f13b8f1b", "Default background", 0, "DefaultBackground.jpg", 1 },
                    { "4e489ded-2f03-4636-b05d-365ab2d1288a", "KingPin", 1000000, null, 0 },
                    { "0234a0e8-687d-48c2-b974-f5760d7e267b", "Slot machine master", 200000, "SlotMachineMaster.jpg", 1 },
                    { "3eb9067e-22e4-4ddf-859e-883930f52b2a", "Wolf of Wall Street", 1000000, null, 0 },
                    { "bcefae9f-a830-426b-ae3b-b268953142c6", "Casino master", 500000, "CasinoMaster.jpg", 1 },
                    { "00b87bbf-9d2b-4fcb-aaad-b42895eabe24", "Simple card pattern", 5000, "CardPattern.jpg", 1 },
                    { "c055126e-2e94-4a75-aa06-1ef7659db01d", "Black jack master", 200000, "BlackJackMaster.jpg", 1 },
                    { "fbe1da49-8fe5-4286-99ce-cccaaa0ed1c4", "Absolute Legend", 100000, null, 0 },
                    { "9875cbfd-0f27-40aa-a4e1-9c2d1e257093", "Local Champion", 10000, null, 0 },
                    { "98cc084f-a905-44dc-9c3a-ae47fce8f3bf", "Simp", 2000, null, 0 },
                    { "ff211ba1-3327-4d83-9259-2f53389550cc", "Ace on fire", 50000, "FireAce.jpg", 1 },
                    { "8734dfa1-1af3-4527-925d-824f7e329a59", "Roulette master", 200000, "RouletteMaster.jpg", 1 }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "9d1de275-0c8d-4600-8e9b-328f61747127", "3eb9067e-22e4-4ddf-859e-883930f52b2a", "1de9ba08-dcfc-4d01-91e9-54c8a3053ef8" },
                    { "22b50a0b-4d42-4c02-b019-c2502de8b2ea", "4e489ded-2f03-4636-b05d-365ab2d1288a", "1de9ba08-dcfc-4d01-91e9-54c8a3053ef8" },
                    { "2ab2372c-a8c7-4b70-80cc-1051739cff24", "b7bd13f6-f867-46d3-9f9c-d980f13b8f1b", "1de9ba08-dcfc-4d01-91e9-54c8a3053ef8" },
                    { "60f65d3d-6a81-47ea-b552-420dfa73500a", "02cb26b6-8170-411a-941a-7d75a6f0fbaf", "1de9ba08-dcfc-4d01-91e9-54c8a3053ef8" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "1de9ba08-dcfc-4d01-91e9-54c8a3053ef8", "1" },
                    { "953ad44d-a151-4d86-b733-6940417498f7", "2" },
                    { "34a76cf9-8a60-45e1-9814-a633195b28de", "3" },
                    { "48f9e0cd-e39b-4d78-a81f-1054c5da68f5", "1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1de9ba08-dcfc-4d01-91e9-54c8a3053ef8", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "34a76cf9-8a60-45e1-9814-a633195b28de", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "48f9e0cd-e39b-4d78-a81f-1054c5da68f5", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "953ad44d-a151-4d86-b733-6940417498f7", "2" });

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "00b87bbf-9d2b-4fcb-aaad-b42895eabe24");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "0234a0e8-687d-48c2-b974-f5760d7e267b");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "02cb26b6-8170-411a-941a-7d75a6f0fbaf");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "3eb9067e-22e4-4ddf-859e-883930f52b2a");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "4e489ded-2f03-4636-b05d-365ab2d1288a");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "8734dfa1-1af3-4527-925d-824f7e329a59");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "9875cbfd-0f27-40aa-a4e1-9c2d1e257093");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "98cc084f-a905-44dc-9c3a-ae47fce8f3bf");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "b7bd13f6-f867-46d3-9f9c-d980f13b8f1b");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "bcefae9f-a830-426b-ae3b-b268953142c6");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "c055126e-2e94-4a75-aa06-1ef7659db01d");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "c2652ebb-5066-4f69-b150-015d1d8b35b9");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "fbe1da49-8fe5-4286-99ce-cccaaa0ed1c4");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "ff211ba1-3327-4d83-9259-2f53389550cc");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "22b50a0b-4d42-4c02-b019-c2502de8b2ea");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "2ab2372c-a8c7-4b70-80cc-1051739cff24");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "60f65d3d-6a81-47ea-b552-420dfa73500a");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "9d1de275-0c8d-4600-8e9b-328f61747127");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1de9ba08-dcfc-4d01-91e9-54c8a3053ef8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34a76cf9-8a60-45e1-9814-a633195b28de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48f9e0cd-e39b-4d78-a81f-1054c5da68f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "953ad44d-a151-4d86-b733-6940417498f7");

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
    }
}