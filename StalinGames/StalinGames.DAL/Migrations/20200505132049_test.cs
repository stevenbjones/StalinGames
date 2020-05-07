using Microsoft.EntityFrameworkCore.Migrations;

namespace StalinGames.DAL.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ProfileTitle",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a9695416-d7cc-4d6d-a5dc-46af7dab58cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f972e4f7-4988-43ca-ba2b-070ec7ff4e81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "af462172-51b8-4eba-8fca-11dc6dea12cd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BackGroundPath", "Blyats", "LastGamePlayed", "ProfilePicturePath", "ProfileTitle", "TotalBlyatsLost", "TotalGamesPlayed" },
                values: new object[,]
                {
                    { "c3d922f7-d201-41ae-9976-dd42325b0bba", 0, "a2d9260a-ffee-47d5-94f5-c9a9949184b6", "ApplicationUser", "Jens@StalinGames.com", false, false, null, null, "JENS", "AQAAAAEAACcQAAAAEPWycyVd2REdVtZX6qktDqajgJOO3rJwzayhwLmj1fz07Pfas+cOU5HSkb9I/MgMSQ==", null, false, "c087e126-061e-412d-934b-36c320bd8258", false, "Jens", null, 2000, 0L, null, null, 0, 0 },
                    { "1cf417c3-56af-4399-999b-c4eca95e7c49", 0, "9ef11c5f-cec2-4c27-bfff-b6c03649760b", "ApplicationUser", "frederik@StalinGames.com", false, false, null, null, "FREDERIK", "AQAAAAEAACcQAAAAEI8kMqyqgc3LW0EOl2tecnZC6XYjbEWyDTGdJLb9yZHMRNSG0ipNKs4uopc7uroQIA==", null, false, "367fd4d3-c183-4e40-a7c9-947fb47ff39f", false, "frederik", null, 2000, 0L, null, null, 0, 0 },
                    { "05ea642d-5452-4d78-ad96-e2936f184501", 0, "04c1fcb0-791f-417b-a485-031fea5d03f0", "ApplicationUser", "peter@Gmail.com", false, false, null, null, "PETER", "AQAAAAEAACcQAAAAEIa1EV7JfnkQRaWdsSmNRAWd158wQl4ddl5fTEXx303BzaaKRkhdLkeLfTOqjVvTIg==", null, false, "2e6c0539-369f-42e6-9daf-a1511e848ede", false, "peter", null, 2000, 0L, null, null, 0, 0 },
                    { "a383c00a-acd0-46c6-a280-e50d5a9909ba", 0, "5196c806-01dc-4235-98bb-347008ad849d", "ApplicationUser", "steven@StalinGames.com", false, false, null, null, "steven", "AQAAAAEAACcQAAAAELSOg+DFkwSIjUTPu9J5LHL6E5RjfFxrEIguE+SupQqUZpIPEF/3eYt5QiJTRXjDzw==", null, false, "c437355f-73e2-4060-b8e9-f718f4198515", false, "steven", null, 2000, 0L, null, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "c3d922f7-d201-41ae-9976-dd42325b0bba", "1" },
                    { "1cf417c3-56af-4399-999b-c4eca95e7c49", "2" },
                    { "05ea642d-5452-4d78-ad96-e2936f184501", "3" },
                    { "a383c00a-acd0-46c6-a280-e50d5a9909ba", "1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "05ea642d-5452-4d78-ad96-e2936f184501", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1cf417c3-56af-4399-999b-c4eca95e7c49", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a383c00a-acd0-46c6-a280-e50d5a9909ba", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c3d922f7-d201-41ae-9976-dd42325b0bba", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05ea642d-5452-4d78-ad96-e2936f184501");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cf417c3-56af-4399-999b-c4eca95e7c49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a383c00a-acd0-46c6-a280-e50d5a9909ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d922f7-d201-41ae-9976-dd42325b0bba");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileTitle",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
