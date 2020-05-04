using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class extendidentity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "148bd93a-b699-4805-a2cf-54a6fff32dd5", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4242773c-f6fb-49b2-a7a4-4ec46da1fccd", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b2e5b362-a5c7-4a06-9919-adac4c1b7cac", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "148bd93a-b699-4805-a2cf-54a6fff32dd5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4242773c-f6fb-49b2-a7a4-4ec46da1fccd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2e5b362-a5c7-4a06-9919-adac4c1b7cac");

            migrationBuilder.AddColumn<string>(
                name: "BackGroundPath",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Blyats",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastGamePlayed",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicturePath",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfileTitle",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalBlyatsLost",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalGamesPlayed",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "99d272a2-92af-44f7-9bc5-84daac6d8f12");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4289e765-16f4-46ab-86e2-961b9bd68834");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "b79c1851-d220-4b9a-bdb0-18cb05b66070");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BackGroundPath",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Blyats",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastGamePlayed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePicturePath",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileTitle",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalBlyatsLost",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalGamesPlayed",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "75a00874-a534-4cd4-b1bb-e114d1d2387f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "81131ce2-9848-4102-83db-6697784d3ac2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "e230476a-d772-476d-8ebe-472547aea95b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "City" },
                values: new object[,]
                {
                    { "4242773c-f6fb-49b2-a7a4-4ec46da1fccd", 0, "5e8b0352-04c5-497b-884d-9ace4a8694d4", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEJa1GentQ7bVex4LqzqVz3YYndHqp+8KmwLmosmKTnFBzLGaO10GPudkCOmZFzSWHQ==", null, false, "1b36a79c-ac8e-4dd3-97a8-9e7b75cca5f5", false, "Jens", null },
                    { "148bd93a-b699-4805-a2cf-54a6fff32dd5", 0, "5fd21548-d59b-4033-964d-fc387dd6cfbd", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEHEGxR6xT2966Dik0fRvf9DnynYq9+BAgotmT6xBHxPa6COw2g5HBc5q9u3MmV+yLQ==", null, false, "b3195826-e1bd-48aa-a4ae-ac0cf1d5d03e", false, "frederik", null },
                    { "b2e5b362-a5c7-4a06-9919-adac4c1b7cac", 0, "0228be1a-7022-4f36-a73c-f50ba4e7660c", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAECgZlWVa8IiBd52fcFChTrKuuXedpHtfw9fIyP7v4zLVDfPAwr64S9Ayw5dXDbXIFQ==", null, false, "0c21962c-5f36-424e-b249-17c9ece4ce54", false, "peter", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "4242773c-f6fb-49b2-a7a4-4ec46da1fccd", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "148bd93a-b699-4805-a2cf-54a6fff32dd5", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "b2e5b362-a5c7-4a06-9919-adac4c1b7cac", "3" });
        }
    }
}
