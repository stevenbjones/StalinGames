using Microsoft.EntityFrameworkCore.Migrations;
using System;

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
                    { "1", "b70e0fe1-6ffa-46c1-b7a9-394cabd3ae1e", "SuperAdmin", "SUPERADMIN" },
                    { "2", "d724ee23-44c2-4cc5-a5a2-142a4531abe4", "Admin", "ADMIN" },
                    { "3", "2adca980-c86b-446b-9f61-183c6eb5a13a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "043a0cd9-9f01-4921-bb7e-cd46cd852e32", 0, "0964c179-ee1e-42cd-a952-57e6261e1446", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEIF69UM6W7Gbn2U8SgzvA32Sp5xQTfuHb7f+8h6pGF9D5V5Ghy7JUc4eQr3xCLIuCQ==", null, false, "3804006e-11e8-40bb-ac43-c5117df402f4", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, 0L, null, "KingPin", 0, 0 },
                    { "b9620fce-cab5-4006-9827-e946f736fbb3", 0, "1380a6d9-df8a-4763-8135-b67a6c496fe3", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEHRj2mCSqiteQcPDlosRdbEEYASdzdkBlWIXWqQkAePIK4yXEr+cVvpg2wapoYHQWA==", null, false, "7c24ec87-a994-4963-a2ac-cb9bc0b4446f", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "a47b16bd-bd1e-45ce-8fb3-dbff1c40c87f", 0, "9259e67e-2d82-4f86-bf34-d0f6a57191f7", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEFUL6tc4/whLWGaoqrG9yg1dvYSaBJY/ZpoKFKst+6CDh5PDY3obZ+ZvM5kiQGtu2A==", null, false, "3de0c5ff-c416-4b0a-b889-a00886b99caf", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 },
                    { "59e2ecb0-5584-4845-9fb6-0c83ac8b0106", 0, "a21293b9-1c77-4cfd-86e5-adb8e6a7688e", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEJzdI82qebWqG/xgQTSqq9FkgY81oqFi+83XOoKhlJm6LDf4eefOdTzxOoFCiR8bAw==", null, false, "c8dfc01c-8788-4462-9bbb-e9badaa4d4ee", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 0L, null, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Value", "itemType" },
                values: new object[,]
                {
                    { "3986abac-0767-4db7-9417-14f4f4a0f979", "KingPin", 1000000, null, 0 },
                    { "afbef5e9-1991-49a6-bc2d-c401d69d48e0", "Wolf of Wall Street", 1000000, null, 0 },
                    { "91eb8406-e5ea-42f6-a118-443575571ffe", "Ultimate true StalinGames casino master", 1000000, "TrueStalinGamesMaster.jpg", 1 },
                    { "12f488d1-efcb-4be3-a674-7b26ed2fcb41", "Slot machine master", 200000, "SlotMachineMaster.jpg", 1 },
                    { "534146c6-cdb8-4c03-a025-32cd5c111e0f", "Roulette master", 200000, "RouletteMaster.jpg", 1 },
                    { "077faa2c-67c4-4a29-8ca0-e9bcf6524a0e", "Ace on fire", 50000, "FireAce.jpg", 1 },
                    { "4b205760-94dd-4be2-883b-36670ff78db6", "Black jack master", 200000, "BlackJackMaster.jpg", 1 },
                    { "e7e4ce71-2d18-403f-9dc8-91c990ea0ef5", "Simple card pattern", 5000, "CardPattern.jpg", 1 },
                    { "a0ba85cb-4c06-4b79-9ffb-fb6a87dbdf66", "Absolute Legend", 100000, null, 0 },
                    { "b3dc130b-7b12-4254-b367-02c7574d5a84", "Local Champion", 10000, null, 0 },
                    { "73f31485-0aea-4fb9-b629-a41f6b1c5cdd", "Simp", 2000, null, 0 },
                    { "ccce3e54-74b8-4fba-bbac-288b07f5a314", "Gambler", 0, null, 0 },
                    { "c0d66d31-b92e-437b-b752-9495749ecb37", "Casino master", 500000, "CasinoMaster.jpg", 1 }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "657256fa-f242-47a9-bfa9-53668416aabd", "3986abac-0767-4db7-9417-14f4f4a0f979", "043a0cd9-9f01-4921-bb7e-cd46cd852e32" },
                    { "126fe372-08c8-4125-be19-0194d372be0a", "afbef5e9-1991-49a6-bc2d-c401d69d48e0", "043a0cd9-9f01-4921-bb7e-cd46cd852e32" },
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