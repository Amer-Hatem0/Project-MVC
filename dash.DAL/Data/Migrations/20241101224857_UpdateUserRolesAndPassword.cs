using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dash.PL.Data.Migrations
{
    public partial class UpdateUserRolesAndPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "171c88da-b03f-4037-a6d5-b528574cee83", "1aa44d49-6079-4f36-aa31-7740292a02d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0af84d84-c868-4d61-813b-bdfaa930c09e", "9cfe50c6-1614-47e1-ad82-5631bb02d089" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b43409e3-0e5a-4f2d-9763-033077a850b8", "a9abd45a-ee7c-4c5d-9f91-cde69008fc13" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0af84d84-c868-4d61-813b-bdfaa930c09e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "171c88da-b03f-4037-a6d5-b528574cee83");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b43409e3-0e5a-4f2d-9763-033077a850b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1aa44d49-6079-4f36-aa31-7740292a02d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cfe50c6-1614-47e1-ad82-5631bb02d089");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9abd45a-ee7c-4c5d-9f91-cde69008fc13");

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
                values: new object[] { "17d119b3-ce6b-43d1-a220-a605ba0c8f79", "107b8984-02cc-42cc-84e0-f5a241b7cc1e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "84ea4926-b10c-4bc3-acdf-7e3d8c546cca", "68b04063-fb15-4c77-8ff8-720a55038620" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d39147a4-c120-4751-9bf3-2fc35a8ca2a2", "e67585ce-3549-4fad-ad83-679c87433999" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "0af84d84-c868-4d61-813b-bdfaa930c09e", "18e54721-40fc-4ebf-89d2-e260d06587d1", "Admin", "ADMIN" },
                    { "171c88da-b03f-4037-a6d5-b528574cee83", "18ba08f3-bfac-469f-8000-7e91210b8a85", "SuperAdmin", "SUPERADMIN" },
                    { "b43409e3-0e5a-4f2d-9763-033077a850b8", "d168b440-1387-4586-a265-c0ba25b0336b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1aa44d49-6079-4f36-aa31-7740292a02d2", 0, null, "6fb9c19e-21fc-4c35-8aeb-2e533c469efa", "superAdmin@cmp.com", true, null, false, null, "SUPERADMIN@CMP.COM", "SUPERADMIN@CMP.COM", "AQAAAAEAACcQAAAAEL0vguumqKbfbe5FzJYnmFjMJhu/Z06dsHRB97aQBJcWf+t7KV8d5BnpXtiC+Hfdug==", null, false, "d86acd0f-3dbb-4f9a-9cda-eb78339bb1a2", false, "superAdmin@cmp.com" },
                    { "9cfe50c6-1614-47e1-ad82-5631bb02d089", 0, null, "7829bf0b-170f-4f38-b5a3-ba575555048e", "adminUser@cmp.com", true, null, false, null, "ADMINUSER@CMP.COM", "ADMINUSER@CMP.COM", "AQAAAAEAACcQAAAAEHwsTIMS2iXZz7g4VYm2X/QFgAGFPrw9Cwv0OH4S9ymQV0k18v63RQpSZ7VNEe52oQ==", null, false, "95d9e5e3-aa3d-4a07-8398-bb2327f86889", false, "adminUser@cmp.com" },
                    { "a9abd45a-ee7c-4c5d-9f91-cde69008fc13", 0, null, "be1910b9-09ca-493b-b47a-0e5c7452bf6e", "user@cmp.com", true, null, false, null, "USER@CMP.COM", "USER@CMP.COM", "AQAAAAEAACcQAAAAELCsvFpuvEcewUKi/53PUskPF3ihSunFFHwzG2BbBJZksYUHwjOKkL9ZhgSJfNfFdw==", null, false, "28e40e43-ae09-41a2-9c6c-76f08cd0ffad", false, "user@cmp.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "171c88da-b03f-4037-a6d5-b528574cee83", "1aa44d49-6079-4f36-aa31-7740292a02d2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0af84d84-c868-4d61-813b-bdfaa930c09e", "9cfe50c6-1614-47e1-ad82-5631bb02d089" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b43409e3-0e5a-4f2d-9763-033077a850b8", "a9abd45a-ee7c-4c5d-9f91-cde69008fc13" });
        }
    }
}
