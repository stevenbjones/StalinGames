using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class adddefaultbackgroundtousers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5cbe2019-de2e-46ac-97a0-cf20b01b9626", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9bf697a9-144d-4967-a8cc-28af82c39c35", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "acd885ef-b705-4e8f-89d3-fa52eb1ccc3f", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "af29d398-5ae0-414c-b5de-07c2e8364a1c", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "dae85a09-79fe-47e2-b733-afd35727520e", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "de2409da-5322-44da-85ce-ef5af9c81080", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e2e86a6a-fd39-4ebd-b00f-5f39ce9700b8", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e5e1216b-6aa4-49b5-9f05-452e704c377b", "1" });

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "0064462d-f17f-46a3-a26b-e065090ece2b");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "4c4e5f14-3499-4372-8403-914c43326570");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "56e38f48-2e86-428d-90a9-56f6f2c4b2be");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "57ff676e-f674-4af4-9b2d-2819aaf83765");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "58a08eda-7ab2-4f68-ad55-b4ac0a1b93d7");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "5d89333d-00b4-4ef5-b402-67c5367ca978");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "66f21c6c-ec39-48a5-ad19-3de0b7ffe0f0");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "71d0bb5c-e303-43cc-9a87-48bc80f3bde6");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "8f560516-670a-4346-800c-d8849972bcb6");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "8fd88427-1a99-4c07-92bc-e39db894da9d");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "983c1dc6-8dd1-4447-b999-7df7158884a6");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "c187ba4f-4127-4dc3-a2e3-d647ea9266dd");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "e20e6ef5-e9d4-4a79-979f-59f22d0374fd");

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumn: "ItemID",
                keyValue: "fd7e6639-3025-4cc6-bc6f-5d2768dd7957");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "092ddc63-7c43-4129-843b-a48313a74fe9");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "268f0b06-4e86-4c46-960a-e14ade9c67a0");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "beb5fddc-a9af-4402-8d1a-94a1f26f2745");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "ca3016e3-401b-430d-a62b-a041721efea1");

            migrationBuilder.DeleteData(
                table: "PlayerPurchases",
                keyColumn: "OrderID",
                keyValue: "fcf5c83f-970f-47a0-9a43-1d2651ea9bc5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cbe2019-de2e-46ac-97a0-cf20b01b9626");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bf697a9-144d-4967-a8cc-28af82c39c35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acd885ef-b705-4e8f-89d3-fa52eb1ccc3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af29d398-5ae0-414c-b5de-07c2e8364a1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dae85a09-79fe-47e2-b733-afd35727520e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de2409da-5322-44da-85ce-ef5af9c81080");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2e86a6a-fd39-4ebd-b00f-5f39ce9700b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5e1216b-6aa4-49b5-9f05-452e704c377b");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "55c56c99-bcad-4098-b611-96e294070568");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "329ee51d-9554-49d3-ba3a-5bafc97cd870");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c367796e-296b-4a78-b1e0-af0440fd564e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "9bf697a9-144d-4967-a8cc-28af82c39c35", 0, "057444d5-ee69-479e-9e42-2e03895dba22", "ApplicationUser", "karel@Gmail.com", false, false, null, null, "karel", "AQAAAAEAACcQAAAAEBTyt73+WyaPCrZ470AzuNwWoEFUZWeXUcdGqhfAzk+cSzfx6mwCaP8Wk7bgCLkmRw==", null, false, "7437ada2-f86e-4026-8667-20d683b79e87", false, "karel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "5cbe2019-de2e-46ac-97a0-cf20b01b9626", 0, "5326cba1-5f18-4ad4-ad0b-e8bcb3075d44", "ApplicationUser", "eddy@Gmail.com", false, false, null, null, "eddy", "AQAAAAEAACcQAAAAEJta4I9zTn2dHpC6PO8ULZGqGWj5qpfCtp2p99CPb4+o0o1BbV7kHNTVSPltuxgMVw==", null, false, "5148c92f-a348-4ce4-8da9-96be338c32b3", false, "eddy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "e5e1216b-6aa4-49b5-9f05-452e704c377b", 0, "a9f9febc-573d-461a-bf2e-044322003efe", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEBpKO9kB4DSai7pNMDYg0CDRZcwNBDNbjKonBuG7LFDUZIQxZ7p4/oYUzPrFkptFfw==", null, false, "09a0e607-6438-4241-b454-5d87440386d5", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, 0L, null, "KingPin", 0, 0 },
                    { "de2409da-5322-44da-85ce-ef5af9c81080", 0, "17ca9f60-2374-4102-8cf9-2f4c8eac6b09", "ApplicationUser", "frank@Gmail.com", false, false, null, null, "frank", "AQAAAAEAACcQAAAAEB2o1vPM3N8NCy1+SK9WGyIrkhZja99l822HvQ7tugLtomE0IF8uc7ju5gFYqI2lSg==", null, false, "6553482c-5f3d-4186-80a1-8dce4667ef5b", false, "frank", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "acd885ef-b705-4e8f-89d3-fa52eb1ccc3f", 0, "e32f5eee-dacd-4d8b-a13c-0a51eedd411b", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEEdG82+EfC2ZnDpL+G/MJQeTPZg9Pn+6xRuH4R3qqTiHst3ghCJN/DWnVZLRKLPuyg==", null, false, "e8ad211a-8a89-417f-9e83-6ef957ae848f", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "e2e86a6a-fd39-4ebd-b00f-5f39ce9700b8", 0, "7eb882ac-d9af-41dd-b9ae-c13ce35e6b57", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEJs+cs9MwYA3OCX5lIY0rQqEe2IGcsedEHaXMfFopaW4rVvUFXFeZc9PW9bx9R3rSg==", null, false, "86647a69-c5f6-4b0b-8459-30fbcb69e5a4", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "af29d398-5ae0-414c-b5de-07c2e8364a1c", 0, "748ec81b-cac3-4bbe-b7e7-648d289a7ad1", "ApplicationUser", "jan@Gmail.com", false, false, null, null, "jan", "AQAAAAEAACcQAAAAEIvkL711a+bDagutmH0V1mteuWl/TA0ITKpabqc98ivPs+tSR4mwZ1dVi/Xc1R88QQ==", null, false, "cc88d6ac-5463-4d32-9bc6-91ebbefa0864", false, "jan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "dae85a09-79fe-47e2-b733-afd35727520e", 0, "5068c560-9971-4716-8f79-e7e679c88592", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAECXpbl1ya79Vl1hqU9OuZI1vQJ7oOGDjchrl1vqqyxT8Ox0czpXFw9lx9Q/zp/ZlMQ==", null, false, "83e70c8f-fc6e-4e7b-9fb9-9cb576193803", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Value", "itemType" },
                values: new object[,]
                {
                    { "8f560516-670a-4346-800c-d8849972bcb6", "Ultimate true StalinGames casino master", 1000000, "TrueStalinGamesMaster.jpg", 1 },
                    { "8fd88427-1a99-4c07-92bc-e39db894da9d", "Default background", 0, "DefaultBackground.jpg", 1 },
                    { "57ff676e-f674-4af4-9b2d-2819aaf83765", "KingPin", 1000000, null, 0 },
                    { "fd7e6639-3025-4cc6-bc6f-5d2768dd7957", "Wolf of Wall Street", 500000, null, 0 },
                    { "c187ba4f-4127-4dc3-a2e3-d647ea9266dd", "Roulette master", 200000, "RouletteMaster.jpg", 1 },
                    { "58a08eda-7ab2-4f68-ad55-b4ac0a1b93d7", "Slot machine master", 200000, "SlotMachineMaster.jpg", 1 },
                    { "5d89333d-00b4-4ef5-b402-67c5367ca978", "Simple card pattern", 5000, "CardPattern.jpg", 1 },
                    { "0064462d-f17f-46a3-a26b-e065090ece2b", "Black jack master", 200000, "BlackJackMaster.jpg", 1 },
                    { "e20e6ef5-e9d4-4a79-979f-59f22d0374fd", "Absolute Legend", 100000, null, 0 },
                    { "56e38f48-2e86-428d-90a9-56f6f2c4b2be", "Local Champion", 10000, null, 0 },
                    { "66f21c6c-ec39-48a5-ad19-3de0b7ffe0f0", "Simp", 2000, null, 0 },
                    { "983c1dc6-8dd1-4447-b999-7df7158884a6", "Gambler", 0, null, 0 },
                    { "71d0bb5c-e303-43cc-9a87-48bc80f3bde6", "Ace on fire", 50000, "FireAce.jpg", 1 },
                    { "4c4e5f14-3499-4372-8403-914c43326570", "Casino master", 500000, "CasinoMaster.jpg", 1 }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "092ddc63-7c43-4129-843b-a48313a74fe9", "fd7e6639-3025-4cc6-bc6f-5d2768dd7957", "e5e1216b-6aa4-49b5-9f05-452e704c377b" },
                    { "beb5fddc-a9af-4402-8d1a-94a1f26f2745", "57ff676e-f674-4af4-9b2d-2819aaf83765", "e5e1216b-6aa4-49b5-9f05-452e704c377b" },
                    { "fcf5c83f-970f-47a0-9a43-1d2651ea9bc5", "8fd88427-1a99-4c07-92bc-e39db894da9d", "e5e1216b-6aa4-49b5-9f05-452e704c377b" },
                    { "ca3016e3-401b-430d-a62b-a041721efea1", "8f560516-670a-4346-800c-d8849972bcb6", "e5e1216b-6aa4-49b5-9f05-452e704c377b" },
                    { "268f0b06-4e86-4c46-960a-e14ade9c67a0", "fd7e6639-3025-4cc6-bc6f-5d2768dd7957", "5cbe2019-de2e-46ac-97a0-cf20b01b9626" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "e5e1216b-6aa4-49b5-9f05-452e704c377b", "1" },
                    { "e2e86a6a-fd39-4ebd-b00f-5f39ce9700b8", "2" },
                    { "dae85a09-79fe-47e2-b733-afd35727520e", "3" },
                    { "acd885ef-b705-4e8f-89d3-fa52eb1ccc3f", "1" },
                    { "de2409da-5322-44da-85ce-ef5af9c81080", "3" },
                    { "af29d398-5ae0-414c-b5de-07c2e8364a1c", "3" },
                    { "5cbe2019-de2e-46ac-97a0-cf20b01b9626", "3" },
                    { "9bf697a9-144d-4967-a8cc-28af82c39c35", "3" }
                });
        }
    }
}
