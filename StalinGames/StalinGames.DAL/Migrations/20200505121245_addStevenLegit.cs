using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class addStevenLegit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1d7dc769-646b-4e8a-893c-e492f4109cda", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6a8740de-9bdb-4276-82cb-3f57ea175fa4", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a5d441e6-b2d4-48b1-8765-660f182a6a6a", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b827295-69ff-4340-8f1b-f895ae82f5db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d7dc769-646b-4e8a-893c-e492f4109cda");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a8740de-9bdb-4276-82cb-3f57ea175fa4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5d441e6-b2d4-48b1-8765-660f182a6a6a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "11d71152-277b-4680-8a0a-ec9c501cfaf7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9bb1c982-f2e1-40c2-a18e-30eb01f383d0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "e242f3cb-d804-4222-a95a-4276e83f2fa9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BackGroundPath", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "aa5046d0-2071-44af-b096-b6f9b097e063", 0, "b9b25202-2f0b-47a0-a863-0593990a0b6b", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEIxET+Dj1r5BywqMqpRrNSRAKv7sXr2poQGtZW/qnRsM8jvdtXbSVabzuzmgl6ugQA==", null, false, "27948a95-dac3-4ab7-8b82-788e5bc63f98", false, "Jens", null, 2000, 0L, null, 0, 0, 0 },
                    { "08ac88c8-ea76-4a98-a319-7e2dd6eda971", 0, "1af4beb7-1d85-48d2-865e-2986071983b2", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEIsb9y0AzHuaTFDCNQnUKllQ/CtbVN0nyI5iaLFKymsEHS4jNeXA1Xnwwyb2HH3SCg==", null, false, "cbc55081-f60b-4911-b317-3399a504b395", false, "frederik", null, 2000, 0L, null, 0, 0, 0 },
                    { "ce4145cb-6bf5-457a-8bdf-70d541220dad", 0, "33f1600c-763a-4bfd-9887-2c98a3e787a9", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEP9U4qqv7fVdB3d1rh2ncj02E+dpKxj6rLm6dmxaNmLLDVJ7hlcewoQNkRhJ2FbsHw==", null, false, "fcafa8ea-effb-4bbc-b5b6-4b1f1bceb023", false, "peter", null, 2000, 0L, null, 0, 0, 0 },
                    { "fc314465-a81e-4eff-9e87-570a6fe3c8e1", 0, "2fd30bf2-b63f-4b1d-aec7-04e5995b9828", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAEFVUAv/8H/EP2f5FW96BSv1+9iqupY6GDwAhdzw+ERIOA9H4t16xencrewtxEYD1qw==", null, false, "e55c4e4f-7d35-47bc-a581-f31689538cef", false, "steven", null, 2000, 0L, null, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "aa5046d0-2071-44af-b096-b6f9b097e063", "1" },
                    { "08ac88c8-ea76-4a98-a319-7e2dd6eda971", "2" },
                    { "ce4145cb-6bf5-457a-8bdf-70d541220dad", "3" },
                    { "fc314465-a81e-4eff-9e87-570a6fe3c8e1", "1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "08ac88c8-ea76-4a98-a319-7e2dd6eda971", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "aa5046d0-2071-44af-b096-b6f9b097e063", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ce4145cb-6bf5-457a-8bdf-70d541220dad", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fc314465-a81e-4eff-9e87-570a6fe3c8e1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08ac88c8-ea76-4a98-a319-7e2dd6eda971");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5046d0-2071-44af-b096-b6f9b097e063");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4145cb-6bf5-457a-8bdf-70d541220dad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc314465-a81e-4eff-9e87-570a6fe3c8e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a18841f6-d429-4770-84db-aaea96c456ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "49610822-8ada-4cc8-8fe5-a21c3c697030");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7139e1f1-131f-48c0-bd36-759dbcf55539");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BackGroundPath", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "6a8740de-9bdb-4276-82cb-3f57ea175fa4", 0, "3a22ac25-a8fb-422a-a935-7d825ad6a352", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEPr/Ujxpbe5pPqPDqdhTH6xWEUslZA7jXqIqX6tjCX2MGP7fPC950M2Se/g/I31woQ==", null, false, "743469a7-975e-41f2-983b-6da1fbf035c0", false, "Jens", null, 2000, 0L, null, 0, 0, 0 },
                    { "a5d441e6-b2d4-48b1-8765-660f182a6a6a", 0, "4cc29191-d0ed-4347-a620-aa0ddaf4c8f6", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAELdtdjyckgaHwhbgqd5MPtxxXTYCvUnQ8Uzj/jgB8n9Kiq+Yppac5r6/WsVT4FvqEw==", null, false, "96e68fc6-84cd-4c60-8b85-9ca939091664", false, "frederik", null, 2000, 0L, null, 0, 0, 0 },
                    { "1d7dc769-646b-4e8a-893c-e492f4109cda", 0, "00f3d612-6010-460e-92c9-e069b3b761f7", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEF1aBdglBDVx7V6d/v9oyR0owZjuQ4LtI+Y7ocdnXD1VuBP94/AdV1/lrskPIB7NgA==", null, false, "4e675828-c5cc-4f74-8e02-94e2e175c299", false, "peter", null, 2000, 0L, null, 0, 0, 0 },
                    { "0b827295-69ff-4340-8f1b-f895ae82f5db", 0, "4f19c41b-8bcb-4e10-af8f-c803ead92df0", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAECBYVie5gvXn2y24owZa7b3tmIj7/ylxVSiRDdSYVs3XkQgWN3UuUTE8EseRk4ftqg==", null, false, "21bc743b-5735-4894-8e2e-17c54173477c", false, "steven", null, 2000, 0L, null, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "6a8740de-9bdb-4276-82cb-3f57ea175fa4", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a5d441e6-b2d4-48b1-8765-660f182a6a6a", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "1d7dc769-646b-4e8a-893c-e492f4109cda", "3" });
        }
    }
}
