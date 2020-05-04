using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class addusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "Discriminator",
            //    table: "AspNetUsers",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "City",
            //    table: "AspNetUsers",
            //    nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "75a00874-a534-4cd4-b1bb-e114d1d2387f", "SuperAdmin", null },
                    { "2", "81131ce2-9848-4102-83db-6697784d3ac2", "Admin", null },
                    { "3", "e230476a-d772-476d-8ebe-472547aea95b", "User", null }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

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

            //migrationBuilder.DropColumn(
            //    name: "Discriminator",
            //    table: "AspNetUsers");

            //migrationBuilder.DropColumn(
            //    name: "City",
            //    table: "AspNetUsers");
        }
    }
}
