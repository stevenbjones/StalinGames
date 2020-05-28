using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "38f3e347-ba31-47e5-9869-8f72ae9fc912", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4fa470e7-f490-491a-9f16-1c21d0619dbf", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "852d3c02-291f-46ca-9d4c-e7d1100ab90c", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cce0391c-84ae-4532-890b-1468b7c8e534", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "daee6e46-bbfd-44b8-92e0-438d1c5b156b", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "db55fa4b-c96f-4a3c-a633-1c9abb5dae33", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ec1224f8-ee59-448e-b3f6-bb3391cf3e25", "3" });

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "19b3db47-222a-4a07-b2cc-ef6c5d8e51e9");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "251f92dc-3888-4a47-b4a0-a9f1999667e1");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "4d792d6a-6152-4ad0-bf9f-076baa1d996d");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "7d079c31-2e0b-4015-9355-3852ed408a67");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "7de5d55b-0ac3-4ddd-abe6-f8bc93253cc9");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "7e4b3e1d-c511-47d9-a004-526a7bb6dc85");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "887c1b7c-0aa0-4720-a323-7c20f6a483b9");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "a9d6fdef-3755-42af-b18b-ba7a592def3f");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "b172e441-6785-41d9-89c1-6d4303fbc5db");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "bb9d86f9-1850-4f8c-8782-f611d3d0673c");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "bfd29c2a-5f3b-40b6-bc8e-f6b32eb7d468");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "d78e768a-ccb0-4425-b0b2-aca042d04825");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "e42758af-61f2-497e-b872-a3a15d9a186e");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "e8c9978b-af1a-48c8-9290-af254257b28b");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "55711d46-9167-4fe6-91fe-5c02d700a9c6");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "5ed5f55a-3da5-4936-a4e7-5ea560258afa");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "628737c9-e376-48e3-8f81-5975304e20e4");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "9251f5ad-4f00-4717-af06-6d544c72967a");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "98488108-e07b-4363-beb0-1cfd3ed7576b");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "a1d570ab-6341-4d02-a1e3-b07732a9f43e");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "a833277c-0a10-4b5a-b202-4e358402c1b9");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "e187a936-0761-4913-ad73-09f856debab1");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "eec625ed-0eef-4236-b4df-ba0b1d56c558");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38f3e347-ba31-47e5-9869-8f72ae9fc912");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fa470e7-f490-491a-9f16-1c21d0619dbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "852d3c02-291f-46ca-9d4c-e7d1100ab90c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cce0391c-84ae-4532-890b-1468b7c8e534");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "daee6e46-bbfd-44b8-92e0-438d1c5b156b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db55fa4b-c96f-4a3c-a633-1c9abb5dae33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec1224f8-ee59-448e-b3f6-bb3391cf3e25");

            migrationBuilder.DropColumn(
                name: "itemType",
                table: "PlayerItems");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "PlayerItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "63454598-c8c6-434b-a067-1bf346a5cfc1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "63cadd00-d5ea-41ca-8763-e5df51159f0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "911c789b-9f3b-4def-93b6-636733e7a0e4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "CreatedBy", "LastGamePlayed", "LastUpdateDate", "ProfilePicturePath", "ProfileTitle", "Status", "TotalBlyatsLost", "TotalGamesPlayed", "UpdatedBy" },
                values: new object[,]
                {
                    { "710b35e5-af8f-4931-a4d6-95fa05655173", 0, "e2411ac6-dec0-456f-8b60-2f6543be65dd", "ApplicationUser", "karel@Gmail.com", false, false, null, null, "karel", "AQAAAAEAACcQAAAAECqP0g663x8qFeTwk0msq9h1G6ZlZOI07x2ZaSTUdjuKjzIk8H1iX71jliGu3mA0RQ==", null, false, "69f27fa5-4621-4f90-8a98-fcb6fee6f166", false, "karel", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "710b35e5-af8f-4931-a4d6-95fa05655173", 1590666829L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "ee7c1584-fffa-465b-86a5-43f10c62040e", 0, "b4e69bc4-9a72-4616-aeea-8cf666f18141", "ApplicationUser", "eddy@Gmail.com", false, false, null, null, "eddy", "AQAAAAEAACcQAAAAEMTrQGSnbLvWov5Fpmab2dNiL3WnbhKo177ANTWPYUdpud/Evtet7ByBv/oz6T1QBA==", null, false, "2cf86062-476a-4a2b-9f45-a7bde678ce4a", false, "eddy", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "ee7c1584-fffa-465b-86a5-43f10c62040e", 1590666829L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "a494ba54-9af3-4d2e-9bb5-44310c517ae1", 0, "9bd73486-1600-4254-99be-33e61a06f4ff", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEAEbhm9AcpxmE8dd96CoakviSaeb+ZF4+bNd5Dm901YXoQRMV35ZiDBmA8ZwxdnUrg==", null, false, "c6f93b2d-8cd8-436d-8e29-8ee50c12ca1b", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, "a494ba54-9af3-4d2e-9bb5-44310c517ae1", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "KingPin", 0, 0, 0, null },
                    { "f80aecde-919f-4600-a98f-457aefbdc071", 0, "aac01f3c-7d0c-4118-93b0-e1a196c2c8b7", "ApplicationUser", "frank@Gmail.com", false, false, null, null, "frank", "AQAAAAEAACcQAAAAENJpMqqBjgNjc378QbvUMQbJN6jwodNRNg6q7oBe8R6794lB6WAYeBYxGhABSXoGsw==", null, false, "d904a86d-8e2f-4b80-b9e9-6694808421d8", false, "frank", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "f80aecde-919f-4600-a98f-457aefbdc071", 1590666829L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "a3e3b09d-ae23-44f1-82c0-ea0bca0e56c8", 0, "b0fc0ebb-619d-4d18-b5c4-41592c202373", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEFYt8uXxR+uj/P4Hcmu9UW8J5logsrsB+SEicBP1MJ/6N+gYjBvgGDpaDo7ja88hVw==", null, false, "1f2ace47-9cf6-4c24-a117-9e6ccff0b92e", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, "a3e3b09d-ae23-44f1-82c0-ea0bca0e56c8", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "377e88ca-7356-48be-a2f9-fc32fe94c700", 0, "a7c4dc96-0ef5-44c5-aa5d-9b5c30ce2ee7", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEI/IGVTMSyTwo5d6/1ODr/1TibplFq2gMjCo8+z2pvscUgex26Em9GmLuHfN8VB3PQ==", null, false, "7827107d-ba53-406e-842c-f2bc9f6da123", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, "377e88ca-7356-48be-a2f9-fc32fe94c700", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "a865fec4-3757-4330-bc89-90d9cddf8904", 0, "43f405e3-092c-492a-8b4d-32a63ad1a7cc", "ApplicationUser", "jan@Gmail.com", false, false, null, null, "jan", "AQAAAAEAACcQAAAAEJHZM/VhlPC7m9JFo8Z/YUesrocUP/iari5+B5aqURWy/y90YXwUtmroSUBhJowZoQ==", null, false, "da008b0a-e001-4910-9c44-f3bac6e09831", false, "jan", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "a865fec4-3757-4330-bc89-90d9cddf8904", 1590666829L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "ffeaef44-072c-4756-891a-ae37c6b00eba", 0, "59ddd289-041b-4726-ad70-a3f6dfca36a2", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEJ+3fKo70qUr1sWzqeP5E177HpZnhpKn10f5SxOpVJHnnnWxMh+56Quuz/eEhArebw==", null, false, "89d2df96-1b3d-4c0f-8dc5-4b0679932ca8", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, "ffeaef44-072c-4756-891a-ae37c6b00eba", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Type", "Value" },
                values: new object[,]
                {
                    { "c01cdc9a-29eb-4994-911c-10968260006a", "Default background", 0, 1, "DefaultBackground.jpg" },
                    { "1ee8a279-d8e2-4832-b1e3-d837561ae437", "KingPin", 1000000, 0, null },
                    { "06deddce-0bcb-4fc0-b888-e5b4d84c08f0", "Wolf of Wall Street", 500000, 0, null },
                    { "df76f660-6140-4c31-a0a5-5372e9b03239", "Gambler", 0, 0, null },
                    { "0fa8689d-3d5d-4f57-97e3-6e1670b64695", "Slot machine master", 200000, 1, "SlotMachineMaster.jpg" },
                    { "47cab2af-c945-4eab-b6a7-a91444d7def8", "Ultimate true StalinGames casino master", 1000000, 1, "TrueStalinGamesMaster.jpg" },
                    { "2ae8d01a-cbd8-45e7-9277-0614abba5a8e", "Ace on fire", 50000, 1, "FireAce.jpg" },
                    { "19606388-dea2-4ad5-ab06-8441309b8216", "Casino master", 500000, 1, "CasinoMaster.jpg" },
                    { "0db18983-b588-4c7f-9444-bcb3df5761ac", "Simple card pattern", 5000, 1, "CardPattern.jpg" },
                    { "2683610e-1f1e-4076-bae7-6f92dde0dad3", "Black jack master", 200000, 1, "BlackJackMaster.jpg" },
                    { "963e1bed-1db6-499b-b861-d76b95271124", "Absolute Legend", 100000, 0, null },
                    { "a8e3a7a9-ee97-4a60-94b6-f38025b673c0", "Simp", 2000, 0, null },
                    { "600aa645-1106-4d4b-95ba-b47067152778", "Local Champion", 10000, 0, null },
                    { "4c1b53ed-ad57-4001-a086-dbb0c5d9c22c", "Roulette master", 200000, 1, "RouletteMaster.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "6f64068d-9055-43d4-9a0e-c5052709716a", "c01cdc9a-29eb-4994-911c-10968260006a", "a3e3b09d-ae23-44f1-82c0-ea0bca0e56c8" },
                    { "9d54b50c-8d75-4c01-be0b-1e36b91a8980", "c01cdc9a-29eb-4994-911c-10968260006a", "377e88ca-7356-48be-a2f9-fc32fe94c700" },
                    { "e4c23b5d-2595-48f2-b8c6-f2679886820b", "c01cdc9a-29eb-4994-911c-10968260006a", "ffeaef44-072c-4756-891a-ae37c6b00eba" },
                    { "78efbb1b-441c-471c-a271-2fbe03d4a745", "df76f660-6140-4c31-a0a5-5372e9b03239", "a3e3b09d-ae23-44f1-82c0-ea0bca0e56c8" },
                    { "c7a1ac04-6bb2-45ae-b1dd-40813c2cc493", "df76f660-6140-4c31-a0a5-5372e9b03239", "377e88ca-7356-48be-a2f9-fc32fe94c700" },
                    { "ac0e7aa7-0232-4df0-aa3d-ed32f96bd336", "df76f660-6140-4c31-a0a5-5372e9b03239", "ffeaef44-072c-4756-891a-ae37c6b00eba" },
                    { "68b943c7-2a01-4206-a5ff-3f90873b8d5d", "df76f660-6140-4c31-a0a5-5372e9b03239", "710b35e5-af8f-4931-a4d6-95fa05655173" },
                    { "b39f708c-4ecf-4a76-8a70-c4557123c803", "df76f660-6140-4c31-a0a5-5372e9b03239", "a865fec4-3757-4330-bc89-90d9cddf8904" },
                    { "19517288-f484-4251-b806-a409d1b66342", "c01cdc9a-29eb-4994-911c-10968260006a", "710b35e5-af8f-4931-a4d6-95fa05655173" },
                    { "1317ea73-2cd6-4c5f-8000-ce7a7f490f55", "df76f660-6140-4c31-a0a5-5372e9b03239", "ee7c1584-fffa-465b-86a5-43f10c62040e" },
                    { "300d2bf2-7348-49c7-959b-1b4482d02e3a", "c01cdc9a-29eb-4994-911c-10968260006a", "a865fec4-3757-4330-bc89-90d9cddf8904" },
                    { "20ce8c07-3989-40c3-8434-c55b92668664", "c01cdc9a-29eb-4994-911c-10968260006a", "f80aecde-919f-4600-a98f-457aefbdc071" },
                    { "6b0c872e-db34-4d8b-b904-72d8d681599d", "c01cdc9a-29eb-4994-911c-10968260006a", "ee7c1584-fffa-465b-86a5-43f10c62040e" },
                    { "5d098ac9-60c1-4e64-b7bb-c111bc65e820", "06deddce-0bcb-4fc0-b888-e5b4d84c08f0", "ee7c1584-fffa-465b-86a5-43f10c62040e" },
                    { "8f5602a6-3419-442a-8a8d-79afadaf3dc9", "47cab2af-c945-4eab-b6a7-a91444d7def8", "a494ba54-9af3-4d2e-9bb5-44310c517ae1" },
                    { "35c3aa00-d212-478f-ba1b-79fce996bc51", "1ee8a279-d8e2-4832-b1e3-d837561ae437", "a494ba54-9af3-4d2e-9bb5-44310c517ae1" },
                    { "1f9962a4-5cd0-4ab2-bbe0-bc705fd721b7", "06deddce-0bcb-4fc0-b888-e5b4d84c08f0", "a494ba54-9af3-4d2e-9bb5-44310c517ae1" },
                    { "faf6051b-be32-4127-be03-39667d2b70a4", "df76f660-6140-4c31-a0a5-5372e9b03239", "f80aecde-919f-4600-a98f-457aefbdc071" },
                    { "9c8d497b-d9d1-44e1-b47f-fc5a7712358f", "c01cdc9a-29eb-4994-911c-10968260006a", "a494ba54-9af3-4d2e-9bb5-44310c517ae1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "a494ba54-9af3-4d2e-9bb5-44310c517ae1", "1" },
                    { "377e88ca-7356-48be-a2f9-fc32fe94c700", "2" },
                    { "ffeaef44-072c-4756-891a-ae37c6b00eba", "3" },
                    { "a3e3b09d-ae23-44f1-82c0-ea0bca0e56c8", "1" },
                    { "f80aecde-919f-4600-a98f-457aefbdc071", "3" },
                    { "a865fec4-3757-4330-bc89-90d9cddf8904", "3" },
                    { "ee7c1584-fffa-465b-86a5-43f10c62040e", "3" },
                    { "710b35e5-af8f-4931-a4d6-95fa05655173", "3" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "377e88ca-7356-48be-a2f9-fc32fe94c700", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "710b35e5-af8f-4931-a4d6-95fa05655173", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a3e3b09d-ae23-44f1-82c0-ea0bca0e56c8", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a494ba54-9af3-4d2e-9bb5-44310c517ae1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a865fec4-3757-4330-bc89-90d9cddf8904", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ee7c1584-fffa-465b-86a5-43f10c62040e", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f80aecde-919f-4600-a98f-457aefbdc071", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ffeaef44-072c-4756-891a-ae37c6b00eba", "3" });

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "06deddce-0bcb-4fc0-b888-e5b4d84c08f0");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "0db18983-b588-4c7f-9444-bcb3df5761ac");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "0fa8689d-3d5d-4f57-97e3-6e1670b64695");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "19606388-dea2-4ad5-ab06-8441309b8216");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "1ee8a279-d8e2-4832-b1e3-d837561ae437");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "2683610e-1f1e-4076-bae7-6f92dde0dad3");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "2ae8d01a-cbd8-45e7-9277-0614abba5a8e");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "47cab2af-c945-4eab-b6a7-a91444d7def8");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "4c1b53ed-ad57-4001-a086-dbb0c5d9c22c");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "600aa645-1106-4d4b-95ba-b47067152778");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "963e1bed-1db6-499b-b861-d76b95271124");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "a8e3a7a9-ee97-4a60-94b6-f38025b673c0");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "c01cdc9a-29eb-4994-911c-10968260006a");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "df76f660-6140-4c31-a0a5-5372e9b03239");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "1317ea73-2cd6-4c5f-8000-ce7a7f490f55");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "19517288-f484-4251-b806-a409d1b66342");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "1f9962a4-5cd0-4ab2-bbe0-bc705fd721b7");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "20ce8c07-3989-40c3-8434-c55b92668664");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "300d2bf2-7348-49c7-959b-1b4482d02e3a");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "35c3aa00-d212-478f-ba1b-79fce996bc51");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "5d098ac9-60c1-4e64-b7bb-c111bc65e820");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "68b943c7-2a01-4206-a5ff-3f90873b8d5d");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "6b0c872e-db34-4d8b-b904-72d8d681599d");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "6f64068d-9055-43d4-9a0e-c5052709716a");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "78efbb1b-441c-471c-a271-2fbe03d4a745");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "8f5602a6-3419-442a-8a8d-79afadaf3dc9");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "9c8d497b-d9d1-44e1-b47f-fc5a7712358f");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "9d54b50c-8d75-4c01-be0b-1e36b91a8980");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "ac0e7aa7-0232-4df0-aa3d-ed32f96bd336");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "b39f708c-4ecf-4a76-8a70-c4557123c803");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "c7a1ac04-6bb2-45ae-b1dd-40813c2cc493");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "e4c23b5d-2595-48f2-b8c6-f2679886820b");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "faf6051b-be32-4127-be03-39667d2b70a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "377e88ca-7356-48be-a2f9-fc32fe94c700");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "710b35e5-af8f-4931-a4d6-95fa05655173");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3e3b09d-ae23-44f1-82c0-ea0bca0e56c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a494ba54-9af3-4d2e-9bb5-44310c517ae1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a865fec4-3757-4330-bc89-90d9cddf8904");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee7c1584-fffa-465b-86a5-43f10c62040e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f80aecde-919f-4600-a98f-457aefbdc071");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffeaef44-072c-4756-891a-ae37c6b00eba");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "PlayerItems");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "itemType",
                table: "PlayerItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "18479d82-f5cf-4ebc-b4f5-e37f46b373ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a1c96621-d1ea-47f6-8122-e863d1df33be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "1b12e147-1352-4e9c-800e-4419750ba2e4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "CreatedBy", "LastGamePlayed", "LastUpdateDate", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed", "UpdatedBy" },
                values: new object[,]
                {
                    { "852d3c02-291f-46ca-9d4c-e7d1100ab90c", 0, "149ef18b-adce-4589-a6e8-813f66671393", "ApplicationUser", "karel@Gmail.com", false, false, null, null, "karel", "AQAAAAEAACcQAAAAEOasVN/y4+fRMZKwoYK3KzA0dIaTARDCAlQ6fKWCbYH75tePTPeWKiiG93uzOCjxdQ==", null, false, "aaef01c3-1412-4589-a8d9-4c64a052012a", false, "karel", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, null, 1590662944L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, null },
                    { "cce0391c-84ae-4532-890b-1468b7c8e534", 0, "1435725e-c929-4976-a0d0-e0a5707eff97", "ApplicationUser", "eddy@Gmail.com", false, false, null, null, "eddy", "AQAAAAEAACcQAAAAEMzktHzzyRzogxfjFhe+e4DEQg7ZVsWkh7LK7pea3wSKynL7rXnZJeyBwQH/Pi+0sg==", null, false, "18a6ae24-0339-48cb-a963-a83d9852d588", false, "eddy", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, null, 1590662944L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, null },
                    { "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7", 0, "1b94d19e-0b13-451e-8652-59b74fb8007f", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEDMGqZTQnAraJfhNi9buLebj4cm1elSjKxSM0vShpRTBm8ElIVZs1arhccdxqfyr9A==", null, false, "74805d6e-3fb8-49b2-91b4-f909473f80cf", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, null, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "KingPin", 0, 0, null },
                    { "ec1224f8-ee59-448e-b3f6-bb3391cf3e25", 0, "9643b2eb-64d3-4818-ba39-c9cd6d4415c6", "ApplicationUser", "frank@Gmail.com", false, false, null, null, "frank", "AQAAAAEAACcQAAAAEG7Aht9v4UYNt+mWSw2W8OEcMPHIMlD09pcELLZPAVyz0Al6I/xB1R2Jv0PrBvGSeA==", null, false, "7a383470-7520-4eae-8cc3-eaa50850ab91", false, "frank", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, null, 1590662944L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, null },
                    { "db55fa4b-c96f-4a3c-a633-1c9abb5dae33", 0, "5498e3e5-8cb6-4cfd-be2c-d0da9dd0a134", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEDXNf6eVDMjA+i1P/6BKBRykDkK3zbc6B3X0fCGqVAnnhdPSe6lFnjeKqMHK8nPJ7A==", null, false, "d0ac6cf5-2e92-4140-aaad-9936be33476d", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, null, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, 0, null },
                    { "4fa470e7-f490-491a-9f16-1c21d0619dbf", 0, "745836ce-d9bc-4f66-8234-862dbec81ae7", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEJAvMpGfWaANkTnNxfCJTObtRYoNYGwy59sRlzrnXAN7mrXIngnylw4fqXOcPppI/g==", null, false, "c81f194c-d743-4169-95a6-25bed8115987", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, null, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, 0, null },
                    { "daee6e46-bbfd-44b8-92e0-438d1c5b156b", 0, "27801794-c5d5-4a6b-927b-bc12235dd365", "ApplicationUser", "jan@Gmail.com", false, false, null, null, "jan", "AQAAAAEAACcQAAAAEDGkhjXm9byRaF/m5jR7Ro6unaAkTKq0C3rVlJ0UF3+8/gPDfT4Qb1pbNGZBk9xaag==", null, false, "0258caaa-c6dc-4a4e-a636-3b4e22e6567f", false, "jan", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, null, 1590662944L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, null },
                    { "38f3e347-ba31-47e5-9869-8f72ae9fc912", 0, "61c8ee2c-91b9-4f2d-abe2-e7f0e22a9d86", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEEF9Ya5tDueM1BD7Ryv5OsHWriu1Zpw3i4PfhW862jHX+DhW59Q4eHccILSoWuxMcQ==", null, false, "402172f3-1a4a-459b-97fd-67a854ae87bc", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, null, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, 0, null }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Value", "itemType" },
                values: new object[,]
                {
                    { "19b3db47-222a-4a07-b2cc-ef6c5d8e51e9", "Ultimate true StalinGames casino master", 1000000, "TrueStalinGamesMaster.jpg", 1 },
                    { "4d792d6a-6152-4ad0-bf9f-076baa1d996d", "Default background", 0, "DefaultBackground.jpg", 1 },
                    { "d78e768a-ccb0-4425-b0b2-aca042d04825", "Wolf of Wall Street", 500000, null, 0 },
                    { "b172e441-6785-41d9-89c1-6d4303fbc5db", "Gambler", 0, null, 0 },
                    { "e8c9978b-af1a-48c8-9290-af254257b28b", "KingPin", 1000000, null, 0 },
                    { "887c1b7c-0aa0-4720-a323-7c20f6a483b9", "Ace on fire", 50000, "FireAce.jpg", 1 },
                    { "a9d6fdef-3755-42af-b18b-ba7a592def3f", "Simp", 2000, null, 0 },
                    { "7d079c31-2e0b-4015-9355-3852ed408a67", "Roulette master", 200000, "RouletteMaster.jpg", 1 },
                    { "7e4b3e1d-c511-47d9-a004-526a7bb6dc85", "Local Champion", 10000, null, 0 },
                    { "bfd29c2a-5f3b-40b6-bc8e-f6b32eb7d468", "Slot machine master", 200000, "SlotMachineMaster.jpg", 1 },
                    { "e42758af-61f2-497e-b872-a3a15d9a186e", "Black jack master", 200000, "BlackJackMaster.jpg", 1 },
                    { "251f92dc-3888-4a47-b4a0-a9f1999667e1", "Simple card pattern", 5000, "CardPattern.jpg", 1 },
                    { "bb9d86f9-1850-4f8c-8782-f611d3d0673c", "Casino master", 500000, "CasinoMaster.jpg", 1 },
                    { "7de5d55b-0ac3-4ddd-abe6-f8bc93253cc9", "Absolute Legend", 100000, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "5ed5f55a-3da5-4936-a4e7-5ea560258afa", "d78e768a-ccb0-4425-b0b2-aca042d04825", "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7" },
                    { "e187a936-0761-4913-ad73-09f856debab1", "e8c9978b-af1a-48c8-9290-af254257b28b", "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7" },
                    { "55711d46-9167-4fe6-91fe-5c02d700a9c6", "19b3db47-222a-4a07-b2cc-ef6c5d8e51e9", "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7" },
                    { "a833277c-0a10-4b5a-b202-4e358402c1b9", "d78e768a-ccb0-4425-b0b2-aca042d04825", "cce0391c-84ae-4532-890b-1468b7c8e534" },
                    { "a1d570ab-6341-4d02-a1e3-b07732a9f43e", "4d792d6a-6152-4ad0-bf9f-076baa1d996d", "cce0391c-84ae-4532-890b-1468b7c8e534" },
                    { "98488108-e07b-4363-beb0-1cfd3ed7576b", "4d792d6a-6152-4ad0-bf9f-076baa1d996d", "ec1224f8-ee59-448e-b3f6-bb3391cf3e25" },
                    { "eec625ed-0eef-4236-b4df-ba0b1d56c558", "4d792d6a-6152-4ad0-bf9f-076baa1d996d", "daee6e46-bbfd-44b8-92e0-438d1c5b156b" },
                    { "9251f5ad-4f00-4717-af06-6d544c72967a", "4d792d6a-6152-4ad0-bf9f-076baa1d996d", "852d3c02-291f-46ca-9d4c-e7d1100ab90c" },
                    { "628737c9-e376-48e3-8f81-5975304e20e4", "4d792d6a-6152-4ad0-bf9f-076baa1d996d", "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7", "1" },
                    { "4fa470e7-f490-491a-9f16-1c21d0619dbf", "2" },
                    { "38f3e347-ba31-47e5-9869-8f72ae9fc912", "3" },
                    { "db55fa4b-c96f-4a3c-a633-1c9abb5dae33", "1" },
                    { "ec1224f8-ee59-448e-b3f6-bb3391cf3e25", "3" },
                    { "daee6e46-bbfd-44b8-92e0-438d1c5b156b", "3" },
                    { "cce0391c-84ae-4532-890b-1468b7c8e534", "3" },
                    { "852d3c02-291f-46ca-9d4c-e7d1100ab90c", "3" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
