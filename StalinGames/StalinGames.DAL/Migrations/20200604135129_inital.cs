using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class inital : Migration
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
                    Status = table.Column<int>(nullable: true),
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
                    Type = table.Column<int>(nullable: false),
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
                    { "1", "2e36daff-c92b-4e68-bb0b-e35a279a68b4", "SuperAdmin", "SUPERADMIN" },
                    { "2", "c1f4951b-f6a1-4ba4-ab71-3ad57784d0b4", "Admin", "ADMIN" },
                    { "3", "5868d45d-ebf1-48ae-b2c4-29d84f1a2d6f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "CreatedBy", "LastGamePlayed", "LastUpdateDate", "ProfilePicturePath", "ProfileTitle", "Status", "TotalBlyatsLost", "TotalGamesPlayed", "UpdatedBy" },
                values: new object[,]
                {
                    { "0f36484f-2040-4483-88e7-9544b258fc74", 0, "2caecd79-ea89-4cca-ab75-1facaac49c54", "ApplicationUser", "karel@Gmail.com", false, false, null, null, "karel", "AQAAAAEAACcQAAAAEE7GGe89S6l1v9SRTO4aJiYXuUDtG4TYhC4X5dLpiZUELdEEXD/SyCjAsawgAw+IXg==", null, false, "a2d9444e-abca-4a23-9b90-eea5e36bbe6e", false, "karel", new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "0f36484f-2040-4483-88e7-9544b258fc74", 1591278688L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "ad0869ce-64ad-459c-9fde-e0522fd4c0c4", 0, "4120ce5e-300c-4b4b-89a9-683aa2350a45", "ApplicationUser", "eddy@Gmail.com", false, false, null, null, "eddy", "AQAAAAEAACcQAAAAEMt6jXzKhn9vdqDsrwyEkJWR0exwoydlEm7USmaPhBDFc97M1TRwR+Xfwb7L7phFXg==", null, false, "3387d469-05eb-428f-8aad-1ac205b0aab9", false, "eddy", new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "ad0869ce-64ad-459c-9fde-e0522fd4c0c4", 1591278688L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "068e7ce5-eda6-4961-89e8-3b29284a0fa3", 0, "4a2c6364-4774-4cda-8e62-ce2574ba3d48", "ApplicationUser", "frank@Gmail.com", false, false, null, null, "frank", "AQAAAAEAACcQAAAAEHGxGIz/O0dGb6J2LFLNGTDYim8oMJGmJ5/BlGW8piMlFoy9bKXG5nMA8OSN4CWgVg==", null, false, "4f7fd574-59f3-4bb6-85d7-75fc6e51d5d8", false, "frank", new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "068e7ce5-eda6-4961-89e8-3b29284a0fa3", 1591278688L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "434fb57b-3d64-4352-9c91-7b7862c622dc", 0, "1908a597-42f8-4bac-b1ea-76ebd33e3c6a", "ApplicationUser", "jan@Gmail.com", false, false, null, null, "jan", "AQAAAAEAACcQAAAAEITmUAd6HqgqLPrPRWzPIxm6K8851euTLmhYAKICdU4Fw02RCHAImYcxtz1OYvsfJQ==", null, false, "59370f79-a251-4235-9133-373815e4a714", false, "jan", new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "434fb57b-3d64-4352-9c91-7b7862c622dc", 1591278688L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "fbbc4a4b-4f35-4cd9-a34d-2b2060598678", 0, "45c79bde-0f96-491f-8367-430a2c907e65", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEJvX4duougGE9oJbBBq118vIHatLdZudWOPKWVOJblBbLm2cEXIfGK/QObnsAylZXw==", null, false, "49c96358-3adc-45a0-a966-42d6a01b3af3", false, "peter", new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "fbbc4a4b-4f35-4cd9-a34d-2b2060598678", 1591278688L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "474cefd2-42cd-4a24-abba-a5dd3a61afe1", 0, "d03f1432-81a9-46e1-b432-5c4159ed6e46", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEJcBOwtoZfLAPqtTfkA23xAfIfRS+Jh37kBZRqGduzV1PKml3bDEgOgr12gbxm/tHQ==", null, false, "070811c7-4a53-44fe-b5af-ceef8a16fc43", false, "frederik", new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "474cefd2-42cd-4a24-abba-a5dd3a61afe1", 1591278688L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "e0d48632-5a2b-40d9-babd-6585a478ab09", 0, "799e83bd-9aba-4084-8533-46d2c0182042", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEO9ohucz/rdShQsIcUK6233Kqg4AwmF50qFNQvRqMbctp5B9rcP3FK4a+lECjhFsGw==", null, false, "a75d737f-a00b-4a5c-be68-c52d8f65cf39", false, "Jens", new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "e0d48632-5a2b-40d9-babd-6585a478ab09", 1591278688L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "KingPin", 0, 0, 0, null },
                    { "2bfdf9fc-9fba-424c-bdc9-db3e8c7bc4af", 0, "b4e5b0fd-5ad9-466a-81fa-0d79fa18463d", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEKoyVsyy/wpVaRXAxnPADVoy7YbdaxltV2wvteUsIm4mWnYCItbh5X5Gw+XyzazetA==", null, false, "0074f8ca-e5ad-49a8-a02f-fe02a2a338ce", false, "steven", new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "2bfdf9fc-9fba-424c-bdc9-db3e8c7bc4af", 1591278688L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Type", "Value" },
                values: new object[,]
                {
                    { "a21eb22d-0aaa-46f3-a23e-8974f98aab0f", "Slot machine master", 200000, 1, "SlotMachineMaster.jpg" },
                    { "dee9e2b6-e006-416b-8fb1-fa6efa06e877", "Ultimate true StalinGames casino master", 1000000, 1, "TrueStalinGamesMaster.jpg" },
                    { "67b16a25-ed00-4f73-b0c8-b750a9caca12", "Default background", 0, 1, "DefaultBackground.jpg" },
                    { "ea887ee4-13a8-409c-83ed-041923eb38c1", "KingPin", 1000000, 0, null },
                    { "88f584b8-d837-4d43-953f-bd48a58697a3", "Gambler", 0, 0, null },
                    { "ee498721-6ecb-4343-986a-760a528983bd", "Roulette master", 200000, 1, "RouletteMaster.jpg" },
                    { "b4d7f0a6-0c99-4f7c-900e-00ea7811c708", "Wolf of Wall Street", 500000, 0, null },
                    { "98b8971f-1907-4356-a597-5c683e5e52cd", "Casino master", 500000, 1, "CasinoMaster.jpg" },
                    { "0acc88dd-f253-4335-9451-12e3ec0d912c", "Simple card pattern", 5000, 1, "CardPattern.jpg" },
                    { "4e0cca5c-aa25-4c41-abf7-cbba810eec38", "Black jack master", 200000, 1, "BlackJackMaster.jpg" },
                    { "17305c55-4d03-4162-bcf0-4dcf1b49563c", "Absolute Legend", 100000, 0, null },
                    { "fc45844c-a729-4de0-9d76-bf6845b54792", "Local Champion", 10000, 0, null },
                    { "daa8e021-5637-4d98-ba6c-315d67a22488", "Simp", 2000, 0, null },
                    { "d123e239-392a-466c-8a47-e8b927794e3d", "Ace on fire", 50000, 1, "FireAce.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "97137e0d-c42c-4855-a153-14bb0907856c", "67b16a25-ed00-4f73-b0c8-b750a9caca12", "fbbc4a4b-4f35-4cd9-a34d-2b2060598678" },
                    { "615617b3-1487-43a4-af3b-8afd3e168b95", "88f584b8-d837-4d43-953f-bd48a58697a3", "2bfdf9fc-9fba-424c-bdc9-db3e8c7bc4af" },
                    { "ef2159ba-6d59-4afa-b6ce-fccea46dba17", "88f584b8-d837-4d43-953f-bd48a58697a3", "474cefd2-42cd-4a24-abba-a5dd3a61afe1" },
                    { "43f053fb-0a9d-4ce4-b0ca-393023b00b44", "88f584b8-d837-4d43-953f-bd48a58697a3", "fbbc4a4b-4f35-4cd9-a34d-2b2060598678" },
                    { "beaaa60d-9d04-47cc-9596-4a17a93d6270", "88f584b8-d837-4d43-953f-bd48a58697a3", "0f36484f-2040-4483-88e7-9544b258fc74" },
                    { "dce8f9e4-3aab-43f6-946e-8b22f056a410", "88f584b8-d837-4d43-953f-bd48a58697a3", "434fb57b-3d64-4352-9c91-7b7862c622dc" },
                    { "79417ce6-4667-41b5-a017-3834f1aeeced", "88f584b8-d837-4d43-953f-bd48a58697a3", "068e7ce5-eda6-4961-89e8-3b29284a0fa3" },
                    { "bd6f0c78-eaa4-4c2d-beca-8465a7f74e8e", "88f584b8-d837-4d43-953f-bd48a58697a3", "ad0869ce-64ad-459c-9fde-e0522fd4c0c4" },
                    { "9b1d4525-3589-4c1b-8a3c-ca256d483ea2", "67b16a25-ed00-4f73-b0c8-b750a9caca12", "ad0869ce-64ad-459c-9fde-e0522fd4c0c4" },
                    { "1ed7d38a-b2f7-43ed-bccb-36a19c639719", "67b16a25-ed00-4f73-b0c8-b750a9caca12", "434fb57b-3d64-4352-9c91-7b7862c622dc" },
                    { "3f217ac7-c9d4-443f-9fa1-1acfcfdd6a26", "67b16a25-ed00-4f73-b0c8-b750a9caca12", "068e7ce5-eda6-4961-89e8-3b29284a0fa3" },
                    { "b5bc73e7-71b9-46b8-8acd-ffd0c68f297f", "b4d7f0a6-0c99-4f7c-900e-00ea7811c708", "ad0869ce-64ad-459c-9fde-e0522fd4c0c4" },
                    { "fe8b891a-ccbb-414c-a3d1-c8ff420694b0", "dee9e2b6-e006-416b-8fb1-fa6efa06e877", "e0d48632-5a2b-40d9-babd-6585a478ab09" },
                    { "eb7a068b-2c1e-460d-b317-127ad6a9d0ae", "67b16a25-ed00-4f73-b0c8-b750a9caca12", "e0d48632-5a2b-40d9-babd-6585a478ab09" },
                    { "e7a21260-9e42-46fc-8547-9d369a10fc69", "ea887ee4-13a8-409c-83ed-041923eb38c1", "e0d48632-5a2b-40d9-babd-6585a478ab09" },
                    { "eff27f0f-fbdd-4364-bddb-eb4579399fb8", "b4d7f0a6-0c99-4f7c-900e-00ea7811c708", "e0d48632-5a2b-40d9-babd-6585a478ab09" },
                    { "0b1dcff7-6694-4a2b-a16c-850a590799cf", "67b16a25-ed00-4f73-b0c8-b750a9caca12", "474cefd2-42cd-4a24-abba-a5dd3a61afe1" },
                    { "7104a070-565e-4e44-bed1-86ebd13c89b7", "67b16a25-ed00-4f73-b0c8-b750a9caca12", "0f36484f-2040-4483-88e7-9544b258fc74" },
                    { "82237991-cca0-41b3-b964-fad2a77fe377", "67b16a25-ed00-4f73-b0c8-b750a9caca12", "2bfdf9fc-9fba-424c-bdc9-db3e8c7bc4af" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "e0d48632-5a2b-40d9-babd-6585a478ab09", "1" },
                    { "474cefd2-42cd-4a24-abba-a5dd3a61afe1", "2" },
                    { "fbbc4a4b-4f35-4cd9-a34d-2b2060598678", "3" },
                    { "2bfdf9fc-9fba-424c-bdc9-db3e8c7bc4af", "1" },
                    { "068e7ce5-eda6-4961-89e8-3b29284a0fa3", "3" },
                    { "434fb57b-3d64-4352-9c91-7b7862c622dc", "3" },
                    { "ad0869ce-64ad-459c-9fde-e0522fd4c0c4", "3" },
                    { "0f36484f-2040-4483-88e7-9544b258fc74", "3" }
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
