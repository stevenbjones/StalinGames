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
                    { "1", "4e1a5903-457c-47b5-afac-5fef012d7126", "SuperAdmin", "SUPERADMIN" },
                    { "2", "cf932e92-4a0a-452b-b01c-4a6df13bc287", "Admin", "ADMIN" },
                    { "3", "bb08310d-14d6-4f1e-a0c1-39830fc61edf", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreatedDate", "BackGround", "Blyats", "CreatedBy", "LastGamePlayed", "LastUpdateDate", "ProfilePicturePath", "ProfileTitle", "Status", "TotalBlyatsLost", "TotalGamesPlayed", "UpdatedBy" },
                values: new object[,]
                {
                    { "2cf2d837-0f65-43b0-8085-9fa576c485e2", 0, "88827873-9de8-4167-b83f-695e195ef5e9", "ApplicationUser", "karel@Gmail.com", false, false, null, null, "karel", "AQAAAAEAACcQAAAAEAsoEjY85Re2JpCngXxmtT1Iyrdi5SSLbLVW9GAwuHPSVZqy1qA10SBjFtfX4gp58A==", null, false, "46e6e506-9959-4c14-b1fe-e7e8698500e7", false, "karel", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "2cf2d837-0f65-43b0-8085-9fa576c485e2", 1590673335L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "a63688f1-3bf4-425e-8d01-a82036fa9ed7", 0, "3a9fc742-58da-489a-9958-79731a4e631a", "ApplicationUser", "eddy@Gmail.com", false, false, null, null, "eddy", "AQAAAAEAACcQAAAAEJLzRqzfeHHBx1YX49uL37LghmqOrGioc36eX14WM/fF8iZXJGdm6ej+avHtnMgDCA==", null, false, "f717d20c-4b05-4163-81da-c6ab15633687", false, "eddy", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "a63688f1-3bf4-425e-8d01-a82036fa9ed7", 1590673335L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "cf895424-4a41-4ffd-bbb6-bea989caa874", 0, "b2d16a2c-cc98-405f-9ffd-8a8496d070a1", "ApplicationUser", "frank@Gmail.com", false, false, null, null, "frank", "AQAAAAEAACcQAAAAELCGXk2GO/XSBCEB1nApSsYn4TCRuWNPGn0WYiD0O9dMbx6s6AI3XCRWlrjC4xTS3w==", null, false, "108deef5-14db-4516-8fc6-953bb4d0b4dd", false, "frank", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "cf895424-4a41-4ffd-bbb6-bea989caa874", 1590673335L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "85423698-f6d8-4e96-a832-b2606b08fe7a", 0, "f0f86459-57d3-48e6-9474-6166b897f44e", "ApplicationUser", "jan@Gmail.com", false, false, null, null, "jan", "AQAAAAEAACcQAAAAEE1Cz9VBJ3V4pEswQhqBeelrc5ArNV9FhnCROIjUHscyOyaKC3Owp9DgiO44xqh26Q==", null, false, "77cb2496-afdf-4878-98ca-62c2cecf7741", false, "jan", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "Default background", 2000, "85423698-f6d8-4e96-a832-b2606b08fe7a", 1590673335L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "cf55a117-bfd3-42be-a332-606dd54aa320", 0, "57b8f2d5-ecc5-4799-aa5b-402450db980d", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEIyv4qJ1/gaMsOk1SogLuJAUGiGg27SAnrKxrlZEEfzHVspEs7jv3QHk8No8mrsjHQ==", null, false, "ddb957af-718d-45c5-ab53-8f3195f7f952", false, "peter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, "cf55a117-bfd3-42be-a332-606dd54aa320", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "c816484c-94f8-4af5-83fc-dcea7fd00bf1", 0, "71553c34-6573-4978-9634-4b596eac942f", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAENLAqaEvQDJq0h3xYS19H8lrR+HOky3ZDnDK+61Ag/MhfrMcOC8Hb9tBTiW9IY+8sw==", null, false, "569ecf17-2c97-4800-b43e-25e5e0e45b7c", false, "frederik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, "c816484c-94f8-4af5-83fc-dcea7fd00bf1", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null },
                    { "bf4eb055-33b5-4419-a85e-031bcd617aef", 0, "bb75ca58-0b08-4889-bd2c-cd0fe560ef04", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEBD/6L4wXcAHNa1rxqiPg3kRvBOIAujS2nHe8YR15F4ubAKsqEylXt6LYzh1aUB5/g==", null, false, "86670858-9f0c-433b-848e-2858bfadb695", false, "Jens", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, "bf4eb055-33b5-4419-a85e-031bcd617aef", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "KingPin", 0, 0, 0, null },
                    { "b2e25bb9-497c-4ab0-8a69-f532e36bcf9c", 0, "60a3b23a-8f8d-4292-bdc1-d2f10a7dbcd5", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEJ2cRB+fJVQcwCfOgv2SXWrI0ZC3nNak6MEgEUOpHNm2bMLHcFhHU90BlLnsLXK8og==", null, false, "a03447d6-f243-4d49-8cdd-ee910929a8a9", false, "steven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default background", 2000, "b2e25bb9-497c-4ab0-8a69-f532e36bcf9c", 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gambler", 0, 0, 0, null }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemID", "Name", "Price", "Type", "Value" },
                values: new object[,]
                {
                    { "c5e041b3-7517-4127-87a2-3f69fbd60957", "Slot machine master", 200000, 1, "SlotMachineMaster.jpg" },
                    { "2c4c5b95-7fe1-4692-811f-627008072097", "Ultimate true StalinGames casino master", 1000000, 1, "TrueStalinGamesMaster.jpg" },
                    { "0324ab62-f514-4a8b-bddd-39cad3f7f006", "Default background", 0, 1, "DefaultBackground.jpg" },
                    { "edfab11a-6341-4aaa-af8e-e1613cc93b40", "KingPin", 1000000, 0, null },
                    { "c6e73f10-d06e-49d8-99e4-11eaf012a6e0", "Gambler", 0, 0, null },
                    { "56c353d8-5bf4-48e5-ac79-28982a1daa57", "Roulette master", 200000, 1, "RouletteMaster.jpg" },
                    { "b1667254-c2e8-4736-81d8-a5f9006ae5e1", "Wolf of Wall Street", 500000, 0, null },
                    { "47202c9d-de11-49e8-a70e-e6772542ebe7", "Casino master", 500000, 1, "CasinoMaster.jpg" },
                    { "e5c1f8c8-9cba-4f53-b346-230a70a139b7", "Simple card pattern", 5000, 1, "CardPattern.jpg" },
                    { "1ec081d6-a310-4e8a-aca8-4e5a255fdbd2", "Black jack master", 200000, 1, "BlackJackMaster.jpg" },
                    { "48ca6577-c9eb-49b1-bc6f-02f648e5521f", "Absolute Legend", 100000, 0, null },
                    { "b77c0e0d-045c-4a2f-8c5b-78aeadbc3bd8", "Local Champion", 10000, 0, null },
                    { "e4542553-52f4-45f4-9456-a1b8860cc6b0", "Simp", 2000, 0, null },
                    { "c3caace3-b25b-4c3e-8008-b04dc0428a03", "Ace on fire", 50000, 1, "FireAce.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PlayerPurchases",
                columns: new[] { "OrderID", "ItemID", "UserID" },
                values: new object[,]
                {
                    { "55423ed8-5830-47f7-aa52-23b7bfea4004", "0324ab62-f514-4a8b-bddd-39cad3f7f006", "cf55a117-bfd3-42be-a332-606dd54aa320" },
                    { "349778d5-34df-442b-9b2a-142f9e63b017", "c6e73f10-d06e-49d8-99e4-11eaf012a6e0", "b2e25bb9-497c-4ab0-8a69-f532e36bcf9c" },
                    { "e27807a7-48c5-4de5-9e4a-fafee02f50b4", "c6e73f10-d06e-49d8-99e4-11eaf012a6e0", "c816484c-94f8-4af5-83fc-dcea7fd00bf1" },
                    { "b6ca8ddc-bcf6-43d1-8d75-181f1d8e546d", "c6e73f10-d06e-49d8-99e4-11eaf012a6e0", "cf55a117-bfd3-42be-a332-606dd54aa320" },
                    { "ebf67922-41bd-45a7-8a11-6c75b094b95d", "c6e73f10-d06e-49d8-99e4-11eaf012a6e0", "2cf2d837-0f65-43b0-8085-9fa576c485e2" },
                    { "7e5e6436-6f09-4be5-97e1-fd0b475d22fc", "c6e73f10-d06e-49d8-99e4-11eaf012a6e0", "85423698-f6d8-4e96-a832-b2606b08fe7a" },
                    { "ee42d1cb-2753-4298-b97f-9d712800a71d", "c6e73f10-d06e-49d8-99e4-11eaf012a6e0", "cf895424-4a41-4ffd-bbb6-bea989caa874" },
                    { "1378f5fd-509c-40d5-a367-ef10d1e2ee70", "c6e73f10-d06e-49d8-99e4-11eaf012a6e0", "a63688f1-3bf4-425e-8d01-a82036fa9ed7" },
                    { "4b5ab78c-68ee-4f83-88a9-08325379c683", "0324ab62-f514-4a8b-bddd-39cad3f7f006", "a63688f1-3bf4-425e-8d01-a82036fa9ed7" },
                    { "9145c792-4320-45e8-a180-4133c139bea4", "0324ab62-f514-4a8b-bddd-39cad3f7f006", "85423698-f6d8-4e96-a832-b2606b08fe7a" },
                    { "609fd33c-281d-4312-b030-bda79b1d15a8", "0324ab62-f514-4a8b-bddd-39cad3f7f006", "cf895424-4a41-4ffd-bbb6-bea989caa874" },
                    { "71b88d57-3ad1-4a9d-871a-96fa1a6387ab", "b1667254-c2e8-4736-81d8-a5f9006ae5e1", "a63688f1-3bf4-425e-8d01-a82036fa9ed7" },
                    { "b3f6483d-084c-42e2-87f5-c2eab193a951", "2c4c5b95-7fe1-4692-811f-627008072097", "bf4eb055-33b5-4419-a85e-031bcd617aef" },
                    { "30f79c9f-2c7a-40ca-b8aa-e103f5e6d0fe", "0324ab62-f514-4a8b-bddd-39cad3f7f006", "bf4eb055-33b5-4419-a85e-031bcd617aef" },
                    { "a7cfb39d-4699-4ea2-a2e9-e25e5946bd6e", "edfab11a-6341-4aaa-af8e-e1613cc93b40", "bf4eb055-33b5-4419-a85e-031bcd617aef" },
                    { "6af571a4-5296-4547-a3fb-58c637de73b0", "b1667254-c2e8-4736-81d8-a5f9006ae5e1", "bf4eb055-33b5-4419-a85e-031bcd617aef" },
                    { "e75386e0-0ef9-4017-a3f2-a23a82e53fc6", "0324ab62-f514-4a8b-bddd-39cad3f7f006", "c816484c-94f8-4af5-83fc-dcea7fd00bf1" },
                    { "b6113494-58b9-4534-ae9c-e321f3fc75f3", "0324ab62-f514-4a8b-bddd-39cad3f7f006", "2cf2d837-0f65-43b0-8085-9fa576c485e2" },
                    { "1ba4edfe-d4c4-41a9-8307-1bc800cc0f11", "0324ab62-f514-4a8b-bddd-39cad3f7f006", "b2e25bb9-497c-4ab0-8a69-f532e36bcf9c" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "bf4eb055-33b5-4419-a85e-031bcd617aef", "1" },
                    { "c816484c-94f8-4af5-83fc-dcea7fd00bf1", "2" },
                    { "cf55a117-bfd3-42be-a332-606dd54aa320", "3" },
                    { "b2e25bb9-497c-4ab0-8a69-f532e36bcf9c", "1" },
                    { "cf895424-4a41-4ffd-bbb6-bea989caa874", "3" },
                    { "85423698-f6d8-4e96-a832-b2606b08fe7a", "3" },
                    { "a63688f1-3bf4-425e-8d01-a82036fa9ed7", "3" },
                    { "2cf2d837-0f65-43b0-8085-9fa576c485e2", "3" }
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
