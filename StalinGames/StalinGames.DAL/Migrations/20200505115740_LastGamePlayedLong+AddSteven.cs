using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class LastGamePlayedLongAddSteven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<long>(
                name: "LastGamePlayed",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2658d452-37b8-4896-a9d7-b43d157c93e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "17cd0aa2-4a8d-457a-bde8-560c116569e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "e3dac020-1811-4854-9d77-2158f51fdb2e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BackGroundPath", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "c159e8bd-3548-42b0-8526-e0e9ed0bbf6f", 0, "efabe413-1e80-4ba6-b860-080b3930db82", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEF7RvsGz+TxEXwMg+14cO5s7LNVU3DdDKaCZ391KWVPnB6dXmU1y/wje+58gzloPKg==", null, false, "e92291a3-554c-41d5-b639-8921f4aa5053", false, "Jens", null, 2000, 0L, null, 0, 0, 0 },
                    { "b0c60255-e9e6-4e65-9a61-2dbd6c866459", 0, "568b1081-0eb0-4677-a8bb-d4943fae3e77", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEHc5FMSs1aA95p0gjC4slJ/fq21AAngOH2y/F48bJxVADfkuODHHOfY9xuJie0Vgng==", null, false, "6ea1b8ac-7fda-4159-a6d9-c650295f7ffc", false, "frederik", null, 2000, 0L, null, 0, 0, 0 },
                    { "53cf2244-e7c7-4885-808c-b216dddff26f", 0, "7ea1d21a-fe43-4741-8ac4-b742dacd98aa", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEMa2LZFBW2Ot7mR75jebqrBfmmIZkeIeJAjnCnbKTFNtev6P7DXsp6XV5IfGCJW43A==", null, false, "7b0da682-30dd-4d9b-9c90-866dee4f806d", false, "peter", null, 2000, 0L, null, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "c159e8bd-3548-42b0-8526-e0e9ed0bbf6f", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "b0c60255-e9e6-4e65-9a61-2dbd6c866459", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "53cf2244-e7c7-4885-808c-b216dddff26f", "3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "53cf2244-e7c7-4885-808c-b216dddff26f", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b0c60255-e9e6-4e65-9a61-2dbd6c866459", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c159e8bd-3548-42b0-8526-e0e9ed0bbf6f", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53cf2244-e7c7-4885-808c-b216dddff26f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0c60255-e9e6-4e65-9a61-2dbd6c866459");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c159e8bd-3548-42b0-8526-e0e9ed0bbf6f");

            migrationBuilder.AlterColumn<string>(
                name: "LastGamePlayed",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c441e4a3-30f7-49bb-9ce1-f151b16f6c1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6a9465e5-2c95-4fd3-998e-754dc2ad980f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "57a1ed20-559f-4b9a-8c63-bcd0c6c74004");

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
    }
}
