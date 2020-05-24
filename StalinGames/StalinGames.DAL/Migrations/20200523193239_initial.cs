using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Blyats = table.Column<int>(nullable: true),
                    ProfilePicturePath = table.Column<string>(nullable: true),
                    LastGamePlayed = table.Column<long>(nullable: true),
                    BackGround = table.Column<string>(nullable: true),
                    AccountCreatedDate = table.Column<DateTime>(nullable: true),
                    ProfileTitle = table.Column<string>(nullable: true),
                    TotalGamesPlayed = table.Column<int>(nullable: true),
                    TotalBlyatsLost = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerItems",
                columns: table => new
                {
                    ItemID = table.Column<string>(nullable: false),
                    itemType = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerItems", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "PlayerPurchases",
                columns: table => new
                {
                    OrderID = table.Column<string>(nullable: false),
                    UserID = table.Column<string>(nullable: false),
                    ItemID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerPurchases", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "55c56c99-bcad-4098-b611-96e294070568", "SuperAdmin", "SUPERADMIN" },
                    { "2", "329ee51d-9554-49d3-ba3a-5bafc97cd870", "Admin", "ADMIN" },
                    { "3", "c367796e-296b-4a78-b1e0-af0440fd564e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "9bf697a9-144d-4967-a8cc-28af82c39c35", 0, "057444d5-ee69-479e-9e42-2e03895dba22", "ApplicationUser", "karel@Gmail.com", false, false, null, null, "karel", "AQAAAAEAACcQAAAAEBTyt73+WyaPCrZ470AzuNwWoEFUZWeXUcdGqhfAzk+cSzfx6mwCaP8Wk7bgCLkmRw==", null, false, "7437ada2-f86e-4026-8667-20d683b79e87", false, "karel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "5cbe2019-de2e-46ac-97a0-cf20b01b9626", 0, "5326cba1-5f18-4ad4-ad0b-e8bcb3075d44", "ApplicationUser", "eddy@Gmail.com", false, false, null, null, "eddy", "AQAAAAEAACcQAAAAEJta4I9zTn2dHpC6PO8ULZGqGWj5qpfCtp2p99CPb4+o0o1BbV7kHNTVSPltuxgMVw==", null, false, "5148c92f-a348-4ce4-8da9-96be338c32b3", false, "eddy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "de2409da-5322-44da-85ce-ef5af9c81080", 0, "17ca9f60-2374-4102-8cf9-2f4c8eac6b09", "ApplicationUser", "frank@Gmail.com", false, false, null, null, "frank", "AQAAAAEAACcQAAAAEB2o1vPM3N8NCy1+SK9WGyIrkhZja99l822HvQ7tugLtomE0IF8uc7ju5gFYqI2lSg==", null, false, "6553482c-5f3d-4186-80a1-8dce4667ef5b", false, "frank", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "af29d398-5ae0-414c-b5de-07c2e8364a1c", 0, "748ec81b-cac3-4bbe-b7e7-648d289a7ad1", "ApplicationUser", "jan@Gmail.com", false, false, null, null, "jan", "AQAAAAEAACcQAAAAEIvkL711a+bDagutmH0V1mteuWl/TA0ITKpabqc98ivPs+tSR4mwZ1dVi/Xc1R88QQ==", null, false, "cc88d6ac-5463-4d32-9bc6-91ebbefa0864", false, "jan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "dae85a09-79fe-47e2-b733-afd35727520e", 0, "5068c560-9971-4716-8f79-e7e679c88592", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAECXpbl1ya79Vl1hqU9OuZI1vQJ7oOGDjchrl1vqqyxT8Ox0czpXFw9lx9Q/zp/ZlMQ==", null, false, "83e70c8f-fc6e-4e7b-9fb9-9cb576193803", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "e2e86a6a-fd39-4ebd-b00f-5f39ce9700b8", 0, "7eb882ac-d9af-41dd-b9ae-c13ce35e6b57", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEJs+cs9MwYA3OCX5lIY0rQqEe2IGcsedEHaXMfFopaW4rVvUFXFeZc9PW9bx9R3rSg==", null, false, "86647a69-c5f6-4b0b-8459-30fbcb69e5a4", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "e5e1216b-6aa4-49b5-9f05-452e704c377b", 0, "a9f9febc-573d-461a-bf2e-044322003efe", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEBpKO9kB4DSai7pNMDYg0CDRZcwNBDNbjKonBuG7LFDUZIQxZ7p4/oYUzPrFkptFfw==", null, false, "09a0e607-6438-4241-b454-5d87440386d5", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, 0L, null, "KingPin", 0, 0 },
                    { "acd885ef-b705-4e8f-89d3-fa52eb1ccc3f", 0, "e32f5eee-dacd-4d8b-a13c-0a51eedd411b", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEEdG82+EfC2ZnDpL+G/MJQeTPZg9Pn+6xRuH4R3qqTiHst3ghCJN/DWnVZLRKLPuyg==", null, false, "e8ad211a-8a89-417f-9e83-6ef957ae848f", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Value", "itemType" },
                values: new object[,]
                {
                    { "c187ba4f-4127-4dc3-a2e3-d647ea9266dd", "Roulette master", 200000, "RouletteMaster.jpg", 1 },
                    { "8f560516-670a-4346-800c-d8849972bcb6", "Ultimate true StalinGames casino master", 1000000, "TrueStalinGamesMaster.jpg", 1 },
                    { "8fd88427-1a99-4c07-92bc-e39db894da9d", "Default background", 0, "DefaultBackground.jpg", 1 },
                    { "57ff676e-f674-4af4-9b2d-2819aaf83765", "KingPin", 1000000, null, 0 },
                    { "fd7e6639-3025-4cc6-bc6f-5d2768dd7957", "Wolf of Wall Street", 500000, null, 0 },
                    { "58a08eda-7ab2-4f68-ad55-b4ac0a1b93d7", "Slot machine master", 200000, "SlotMachineMaster.jpg", 1 },
                    { "71d0bb5c-e303-43cc-9a87-48bc80f3bde6", "Ace on fire", 50000, "FireAce.jpg", 1 },
                    { "e20e6ef5-e9d4-4a79-979f-59f22d0374fd", "Absolute Legend", 100000, null, 0 },
                    { "5d89333d-00b4-4ef5-b402-67c5367ca978", "Simple card pattern", 5000, "CardPattern.jpg", 1 },
                    { "0064462d-f17f-46a3-a26b-e065090ece2b", "Black jack master", 200000, "BlackJackMaster.jpg", 1 },
                    { "56e38f48-2e86-428d-90a9-56f6f2c4b2be", "Local Champion", 10000, null, 0 },
                    { "66f21c6c-ec39-48a5-ad19-3de0b7ffe0f0", "Simp", 2000, null, 0 },
                    { "983c1dc6-8dd1-4447-b999-7df7158884a6", "Gambler", 0, null, 0 },
                    { "4c4e5f14-3499-4372-8403-914c43326570", "Casino master", 500000, "CasinoMaster.jpg", 1 }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "ca3016e3-401b-430d-a62b-a041721efea1", "8f560516-670a-4346-800c-d8849972bcb6", "e5e1216b-6aa4-49b5-9f05-452e704c377b" },
                    { "092ddc63-7c43-4129-843b-a48313a74fe9", "fd7e6639-3025-4cc6-bc6f-5d2768dd7957", "e5e1216b-6aa4-49b5-9f05-452e704c377b" },
                    { "beb5fddc-a9af-4402-8d1a-94a1f26f2745", "57ff676e-f674-4af4-9b2d-2819aaf83765", "e5e1216b-6aa4-49b5-9f05-452e704c377b" },
                    { "fcf5c83f-970f-47a0-9a43-1d2651ea9bc5", "8fd88427-1a99-4c07-92bc-e39db894da9d", "e5e1216b-6aa4-49b5-9f05-452e704c377b" },
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PlayerItems");

            migrationBuilder.DropTable(
                name: "PlayerPurchases");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
