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
                    ProfileTitle = table.Column<string>(nullable: true),
                    TotalGamesPlayed = table.Column<int>(nullable: true),
                    TotalBlyatsLost = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    AccountCreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: true)
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "18479d82-f5cf-4ebc-b4f5-e37f46b373ae", "SuperAdmin", "SUPERADMIN" },
                    { "2", "a1c96621-d1ea-47f6-8122-e863d1df33be", "Admin", "ADMIN" },
                    { "3", "1b12e147-1352-4e9c-800e-4419750ba2e4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "CreatedBy", "LastGamePlayed", "LastUpdateDate", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed", "UpdatedBy" },
                values: new object[,]
                {
                    { "852d3c02-291f-46ca-9d4c-e7d1100ab90c", 0, "149ef18b-adce-4589-a6e8-813f66671393", "ApplicationUser", "karel@Gmail.com", false, false, null, null, "karel", "AQAAAAEAACcQAAAAEOasVN/y4+fRMZKwoYK3KzA0dIaTARDCAlQ6fKWCbYH75tePTPeWKiiG93uzOCjxdQ==", null, false, "aaef01c3-1412-4589-a8d9-4c64a052012a", false, "karel", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, null, 1590662944L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, null },
                    { "cce0391c-84ae-4532-890b-1468b7c8e534", 0, "1435725e-c929-4976-a0d0-e0a5707eff97", "ApplicationUser", "eddy@Gmail.com", false, false, null, null, "eddy", "AQAAAAEAACcQAAAAEMzktHzzyRzogxfjFhe+e4DEQg7ZVsWkh7LK7pea3wSKynL7rXnZJeyBwQH/Pi+0sg==", null, false, "18a6ae24-0339-48cb-a963-a83d9852d588", false, "eddy", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, null, 1590662944L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, null },
                    { "ec1224f8-ee59-448e-b3f6-bb3391cf3e25", 0, "9643b2eb-64d3-4818-ba39-c9cd6d4415c6", "ApplicationUser", "frank@Gmail.com", false, false, null, null, "frank", "AQAAAAEAACcQAAAAEG7Aht9v4UYNt+mWSw2W8OEcMPHIMlD09pcELLZPAVyz0Al6I/xB1R2Jv0PrBvGSeA==", null, false, "7a383470-7520-4eae-8cc3-eaa50850ab91", false, "frank", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, null, 1590662944L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, null },
                    { "daee6e46-bbfd-44b8-92e0-438d1c5b156b", 0, "27801794-c5d5-4a6b-927b-bc12235dd365", "ApplicationUser", "jan@Gmail.com", false, false, null, null, "jan", "AQAAAAEAACcQAAAAEDGkhjXm9byRaF/m5jR7Ro6unaAkTKq0C3rVlJ0UF3+8/gPDfT4Qb1pbNGZBk9xaag==", null, false, "0258caaa-c6dc-4a4e-a636-3b4e22e6567f", false, "jan", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, null, 1590662944L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, null },
                    { "38f3e347-ba31-47e5-9869-8f72ae9fc912", 0, "61c8ee2c-91b9-4f2d-abe2-e7f0e22a9d86", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEEF9Ya5tDueM1BD7Ryv5OsHWriu1Zpw3i4PfhW862jHX+DhW59Q4eHccILSoWuxMcQ==", null, false, "402172f3-1a4a-459b-97fd-67a854ae87bc", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, null, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, 0, null },
                    { "4fa470e7-f490-491a-9f16-1c21d0619dbf", 0, "745836ce-d9bc-4f66-8234-862dbec81ae7", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEJAvMpGfWaANkTnNxfCJTObtRYoNYGwy59sRlzrnXAN7mrXIngnylw4fqXOcPppI/g==", null, false, "c81f194c-d743-4169-95a6-25bed8115987", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, null, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, 0, null },
                    { "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7", 0, "1b94d19e-0b13-451e-8652-59b74fb8007f", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEDMGqZTQnAraJfhNi9buLebj4cm1elSjKxSM0vShpRTBm8ElIVZs1arhccdxqfyr9A==", null, false, "74805d6e-3fb8-49b2-91b4-f909473f80cf", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, null, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "KingPin", 0, 0, null },
                    { "db55fa4b-c96f-4a3c-a633-1c9abb5dae33", 0, "5498e3e5-8cb6-4cfd-be2c-d0da9dd0a134", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEDXNf6eVDMjA+i1P/6BKBRykDkK3zbc6B3X0fCGqVAnnhdPSe6lFnjeKqMHK8nPJ7A==", null, false, "d0ac6cf5-2e92-4140-aaad-9936be33476d", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, null, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, 0, null }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Value", "itemType" },
                values: new object[,]
                {
                    { "bfd29c2a-5f3b-40b6-bc8e-f6b32eb7d468", "Slot machine master", 200000, "SlotMachineMaster.jpg", 1 },
                    { "19b3db47-222a-4a07-b2cc-ef6c5d8e51e9", "Ultimate true StalinGames casino master", 1000000, "TrueStalinGamesMaster.jpg", 1 },
                    { "4d792d6a-6152-4ad0-bf9f-076baa1d996d", "Default background", 0, "DefaultBackground.jpg", 1 },
                    { "e8c9978b-af1a-48c8-9290-af254257b28b", "KingPin", 1000000, null, 0 },
                    { "d78e768a-ccb0-4425-b0b2-aca042d04825", "Wolf of Wall Street", 500000, null, 0 },
                    { "b172e441-6785-41d9-89c1-6d4303fbc5db", "Gambler", 0, null, 0 },
                    { "7d079c31-2e0b-4015-9355-3852ed408a67", "Roulette master", 200000, "RouletteMaster.jpg", 1 },
                    { "bb9d86f9-1850-4f8c-8782-f611d3d0673c", "Casino master", 500000, "CasinoMaster.jpg", 1 },
                    { "251f92dc-3888-4a47-b4a0-a9f1999667e1", "Simple card pattern", 5000, "CardPattern.jpg", 1 },
                    { "e42758af-61f2-497e-b872-a3a15d9a186e", "Black jack master", 200000, "BlackJackMaster.jpg", 1 },
                    { "7de5d55b-0ac3-4ddd-abe6-f8bc93253cc9", "Absolute Legend", 100000, null, 0 },
                    { "7e4b3e1d-c511-47d9-a004-526a7bb6dc85", "Local Champion", 10000, null, 0 },
                    { "a9d6fdef-3755-42af-b18b-ba7a592def3f", "Simp", 2000, null, 0 },
                    { "887c1b7c-0aa0-4720-a323-7c20f6a483b9", "Ace on fire", 50000, "FireAce.jpg", 1 }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "eec625ed-0eef-4236-b4df-ba0b1d56c558", "4d792d6a-6152-4ad0-bf9f-076baa1d996d", "daee6e46-bbfd-44b8-92e0-438d1c5b156b" },
                    { "5ed5f55a-3da5-4936-a4e7-5ea560258afa", "d78e768a-ccb0-4425-b0b2-aca042d04825", "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7" },
                    { "e187a936-0761-4913-ad73-09f856debab1", "e8c9978b-af1a-48c8-9290-af254257b28b", "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7" },
                    { "628737c9-e376-48e3-8f81-5975304e20e4", "4d792d6a-6152-4ad0-bf9f-076baa1d996d", "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7" },
                    { "55711d46-9167-4fe6-91fe-5c02d700a9c6", "19b3db47-222a-4a07-b2cc-ef6c5d8e51e9", "36ce32f1-83a3-4eb3-a0a1-6f69e4df21e7" },
                    { "a833277c-0a10-4b5a-b202-4e358402c1b9", "d78e768a-ccb0-4425-b0b2-aca042d04825", "cce0391c-84ae-4532-890b-1468b7c8e534" },
                    { "a1d570ab-6341-4d02-a1e3-b07732a9f43e", "4d792d6a-6152-4ad0-bf9f-076baa1d996d", "cce0391c-84ae-4532-890b-1468b7c8e534" },
                    { "98488108-e07b-4363-beb0-1cfd3ed7576b", "4d792d6a-6152-4ad0-bf9f-076baa1d996d", "ec1224f8-ee59-448e-b3f6-bb3391cf3e25" },
                    { "9251f5ad-4f00-4717-af06-6d544c72967a", "4d792d6a-6152-4ad0-bf9f-076baa1d996d", "852d3c02-291f-46ca-9d4c-e7d1100ab90c" }
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
