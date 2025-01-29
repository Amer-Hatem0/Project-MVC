using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dash.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class a1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "17d119b3-ce6b-43d1-a220-a605ba0c8f79", "107b8984-02cc-42cc-84e0-f5a241b7cc1e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84ea4926-b10c-4bc3-acdf-7e3d8c546cca", "68b04063-fb15-4c77-8ff8-720a55038620" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d39147a4-c120-4751-9bf3-2fc35a8ca2a2", "e67585ce-3549-4fad-ad83-679c87433999" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17d119b3-ce6b-43d1-a220-a605ba0c8f79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84ea4926-b10c-4bc3-acdf-7e3d8c546cca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d39147a4-c120-4751-9bf3-2fc35a8ca2a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107b8984-02cc-42cc-84e0-f5a241b7cc1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68b04063-fb15-4c77-8ff8-720a55038620");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e67585ce-3549-4fad-ad83-679c87433999");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9487d16d-823b-4bd6-8534-eae9d048fa5a", null, "User", "USER" },
                    { "a0e88203-dd3f-4a72-a227-842651cc5888", null, "Admin", "ADMIN" },
                    { "bfff75c4-2b23-41fe-8204-bb80c4c03f73", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09c8337c-9c1c-4a61-ad15-aa00ec04266f", 0, null, "7eb29804-b9b6-4352-b059-6fee4da1870e", "user@cmp.com", true, null, false, null, "USER@CMP.COM", "USER@CMP.COM", "AQAAAAIAAYagAAAAEHXq5bx2NaE5Ap+r0TTdMLuFfYS/dAOZ0FM2HNz9SeRH4hSSbD399kTEFXhxbb7dSw==", null, false, "ff9ecbb1-5d6a-4a8b-816a-befee42f9b8f", false, "user@cmp.com" },
                    { "10f17c40-6de0-4dc4-bd1d-3604ec7f9202", 0, null, "209d4d36-19b0-40cb-b4b5-8373cb204015", "adminUser@cmp.com", true, null, false, null, "ADMINUSER@CMP.COM", "ADMINUSER@CMP.COM", null, null, false, "b3098c5f-5d89-4941-9025-67bdfa30450d", false, "adminUser@cmp.com" },
                    { "ba9f9a9b-9c0a-4071-a0c2-9b439ecdb7d6", 0, null, "0a2de7e4-a027-48b0-a2e7-eba368c92dcc", "superAdmin@cmp.com", true, null, false, null, "SUPERADMIN@CMP.COM", "SUPERADMIN@CMP.COM", null, null, false, "9abc6ca2-4be6-4f4d-a1f9-534bd341d9dd", false, "superAdmin@cmp.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9487d16d-823b-4bd6-8534-eae9d048fa5a", "09c8337c-9c1c-4a61-ad15-aa00ec04266f" },
                    { "a0e88203-dd3f-4a72-a227-842651cc5888", "10f17c40-6de0-4dc4-bd1d-3604ec7f9202" },
                    { "bfff75c4-2b23-41fe-8204-bb80c4c03f73", "ba9f9a9b-9c0a-4071-a0c2-9b439ecdb7d6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9487d16d-823b-4bd6-8534-eae9d048fa5a", "09c8337c-9c1c-4a61-ad15-aa00ec04266f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a0e88203-dd3f-4a72-a227-842651cc5888", "10f17c40-6de0-4dc4-bd1d-3604ec7f9202" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bfff75c4-2b23-41fe-8204-bb80c4c03f73", "ba9f9a9b-9c0a-4071-a0c2-9b439ecdb7d6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9487d16d-823b-4bd6-8534-eae9d048fa5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0e88203-dd3f-4a72-a227-842651cc5888");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfff75c4-2b23-41fe-8204-bb80c4c03f73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09c8337c-9c1c-4a61-ad15-aa00ec04266f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10f17c40-6de0-4dc4-bd1d-3604ec7f9202");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba9f9a9b-9c0a-4071-a0c2-9b439ecdb7d6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17d119b3-ce6b-43d1-a220-a605ba0c8f79", "35f329ba-32d8-4152-a5d0-be4ba1f706d6", "SuperAdmin", "SUPERADMIN" },
                    { "84ea4926-b10c-4bc3-acdf-7e3d8c546cca", "b9485744-afdf-4d49-9945-75019afd3b97", "User", "USER" },
                    { "d39147a4-c120-4751-9bf3-2fc35a8ca2a2", "9b46181a-b010-4074-bbc6-54d56ab9b073", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "107b8984-02cc-42cc-84e0-f5a241b7cc1e", 0, null, "00c95aae-ff27-4ea5-9fd6-2000e801e681", "superAdmin@cmp.com", true, null, false, null, "SUPERADMIN@CMP.COM", "SUPERADMIN@CMP.COM", null, null, false, "a508cb2b-6e3f-4571-8a2d-ee5b41a4c703", false, "superAdmin@cmp.com" },
                    { "68b04063-fb15-4c77-8ff8-720a55038620", 0, null, "95da4e0b-df70-4312-9014-91b21a437e39", "user@cmp.com", true, null, false, null, "USER@CMP.COM", "USER@CMP.COM", "AQAAAAEAACcQAAAAEP9m2pa/damu5vc1Lo+WlVfq2UkOzrpKgs2xgPRh88WQey4lGpc16WH7zzjwZPnR+g==", null, false, "08e21059-4b4e-457d-8ca0-daffb26f4fe2", false, "user@cmp.com" },
                    { "e67585ce-3549-4fad-ad83-679c87433999", 0, null, "8e0aab36-44d7-4401-b491-2c99913980fa", "adminUser@cmp.com", true, null, false, null, "ADMINUSER@CMP.COM", "ADMINUSER@CMP.COM", null, null, false, "4d133177-3d2c-4c72-8572-01c314262eb3", false, "adminUser@cmp.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "17d119b3-ce6b-43d1-a220-a605ba0c8f79", "107b8984-02cc-42cc-84e0-f5a241b7cc1e" },
                    { "84ea4926-b10c-4bc3-acdf-7e3d8c546cca", "68b04063-fb15-4c77-8ff8-720a55038620" },
                    { "d39147a4-c120-4751-9bf3-2fc35a8ca2a2", "e67585ce-3549-4fad-ad83-679c87433999" }
                });
        }
    }
}
