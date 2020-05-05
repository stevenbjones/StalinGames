using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class normalizednamesForRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "122b3ea7-ee55-4a66-8800-a8d0514e1cca", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "46bb5be3-af5e-4083-b91b-463bd6d025ec", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5af9d5b0-81b2-47ee-b58d-9022e0846741", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122b3ea7-ee55-4a66-8800-a8d0514e1cca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46bb5be3-af5e-4083-b91b-463bd6d025ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5af9d5b0-81b2-47ee-b58d-9022e0846741");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "c441e4a3-30f7-49bb-9ce1-f151b16f6c1a", "SUPERADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "6a9465e5-2c95-4fd3-998e-754dc2ad980f", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "57a1ed20-559f-4b9a-8c63-bcd0c6c74004", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BackGroundPath", "Blyats", "City", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "3c9a4d3d-35cf-4b1f-8ebb-78d333d98946", 0, "33ce243a-dfba-4277-a6b4-fc50ef234685", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEOk/XMtLtdgtQcHgJDJeD2h6bBrvaRV+5hCz9hpPE6ep+y+b27hF50s1di25+SifWA==", null, false, "2bdd74e3-f2db-47d3-b0de-e66f892f1b6e", false, "Jens", null, 2000, null, null, null, 0, 0, 0 },
                    { "838e8960-26ab-4949-b908-b606fb61d894", 0, "c351e4f2-3698-4512-9ced-5a5c34962120", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEE8kAElvXt7DV1dVKJ+Uy9Ze01bDOO5+4eAhag43p3lE2KKNmJWk8zcW7s1LYoj7OQ==", null, false, "ca3da98a-beb9-408a-a98c-23b2b561c24f", false, "frederik", null, 2000, null, null, null, 0, 0, 0 },
                    { "98c4cfaf-22e9-492e-9b86-11ca67d0cd65", 0, "c94eff93-d1e9-4315-a16c-82e409273a11", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEFxoh+OmBtSWQp6bvhXikP1ERW1du7PSsJHhA3QCEsbkuZS5Gyo4fsVw6s++kDq33w==", null, false, "fababc36-03f8-49cb-838a-72d127f8d004", false, "peter", null, 2000, null, null, null, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "3c9a4d3d-35cf-4b1f-8ebb-78d333d98946", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "838e8960-26ab-4949-b908-b606fb61d894", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "98c4cfaf-22e9-492e-9b86-11ca67d0cd65", "3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3c9a4d3d-35cf-4b1f-8ebb-78d333d98946", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "838e8960-26ab-4949-b908-b606fb61d894", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "98c4cfaf-22e9-492e-9b86-11ca67d0cd65", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c9a4d3d-35cf-4b1f-8ebb-78d333d98946");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "838e8960-26ab-4949-b908-b606fb61d894");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98c4cfaf-22e9-492e-9b86-11ca67d0cd65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "99d272a2-92af-44f7-9bc5-84daac6d8f12", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "4289e765-16f4-46ab-86e2-961b9bd68834", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "b79c1851-d220-4b9a-bdb0-18cb05b66070", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BackGroundPath", "Blyats", "City", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "5af9d5b0-81b2-47ee-b58d-9022e0846741", 0, "52819bd1-dca8-4322-a165-b7857ba3f994", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEMJpmztKvndAngXlM7kdEDoID2Q4Ibncs7nCaEtmWyjgXw4iTSS9XJuctSx+0GikNg==", null, false, "7c3184bb-aaff-44b5-aa5d-010f4efe5540", false, "Jens", null, 0, null, null, null, 0, 0, 0 },
                    { "122b3ea7-ee55-4a66-8800-a8d0514e1cca", 0, "418b6eee-1aa0-4b2a-9227-2415075b08b5", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEMmljYqza2YkBNCohC3cn+UVaEITv4SgQL9P2Ut4tX3QtpaG2/nrrWgaIfqA+e4vsQ==", null, false, "c95bca83-b28a-4812-8dbe-e1cb10a7324a", false, "frederik", null, 0, null, null, null, 0, 0, 0 },
                    { "46bb5be3-af5e-4083-b91b-463bd6d025ec", 0, "9d7e9e70-45ee-4691-a985-2ac45142f68b", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEMc5uxQzu6WZL2127TLKFQ2MdV8Yd71pyZD+2H7LHnuAxFgr6n4oi5mN3Op0TfsXhg==", null, false, "2c93a4e8-06de-4317-ab91-ea6ba6b3c38e", false, "peter", null, 0, null, null, null, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "5af9d5b0-81b2-47ee-b58d-9022e0846741", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "122b3ea7-ee55-4a66-8800-a8d0514e1cca", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "46bb5be3-af5e-4083-b91b-463bd6d025ec", "3" });
        }
    }
}
