using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dash.PL.Data.Migrations
{
    public partial class UpdateUserRolesAndPasswords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f6f8d43-e241-46e9-9efb-4a429de1fee8", "07427fc2-3d84-4435-8030-95f253415910" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fdd48e0a-4089-4aa2-8086-3344e8d3e1a0", "e9d10429-64c3-4276-bc83-7769b1ed0f44" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc75c970-6b8e-4711-b8c9-b12010f1bc3d", "ec1f1bfe-fe4f-4614-b362-aa41c750e561" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f6f8d43-e241-46e9-9efb-4a429de1fee8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc75c970-6b8e-4711-b8c9-b12010f1bc3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdd48e0a-4089-4aa2-8086-3344e8d3e1a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07427fc2-3d84-4435-8030-95f253415910");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9d10429-64c3-4276-bc83-7769b1ed0f44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec1f1bfe-fe4f-4614-b362-aa41c750e561");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "3f6f8d43-e241-46e9-9efb-4a429de1fee8", "92bcbee0-cbe5-4c7b-9a65-e4828f5c0936", "User", "USER" },
                    { "cc75c970-6b8e-4711-b8c9-b12010f1bc3d", "68863035-b868-43af-be35-5b6d760fcc00", "SuperAdmin", "SUPERADMIN" },
                    { "fdd48e0a-4089-4aa2-8086-3344e8d3e1a0", "43ac104e-aa0d-4fb8-86f2-c97a7a2fef71", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07427fc2-3d84-4435-8030-95f253415910", 0, null, "85ed048e-e926-4b4a-85ba-6c139faaab32", "user@cmp.com", true, null, false, null, "USER@CMP.COM", "USER@CMP.COM", "AQAAAAEAACcQAAAAEO0Gjr1b2UGZ71HlyEX79wWJTXTX/zD9iTYWWo/94rP0CgrGZHwGjH28zIhkNS3h0A==", null, false, "5d3ffdf2-09b4-43a4-ac54-1809a9cf8bd3", false, "user@cmp.com" },
                    { "e9d10429-64c3-4276-bc83-7769b1ed0f44", 0, null, "1e766ed4-8625-49e9-8b08-c668e39a2668", "adminUser@cmp.com", true, null, false, null, "ADMINUSER@CMP.COM", "ADMINUSER@CMP.COM", null, null, false, "32cc2736-58c7-4790-87f6-01f7774c0327", false, "adminUser@cmp.com" },
                    { "ec1f1bfe-fe4f-4614-b362-aa41c750e561", 0, null, "08985d95-a2df-48ee-b772-34fbdfaebcbe", "superAdmin@cmp.com", true, null, false, null, "SUPERADMIN@CMP.COM", "SUPERADMIN@CMP.COM", null, null, false, "410bfa72-48a8-44fe-b326-adb94aa6da76", false, "superAdmin@cmp.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3f6f8d43-e241-46e9-9efb-4a429de1fee8", "07427fc2-3d84-4435-8030-95f253415910" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fdd48e0a-4089-4aa2-8086-3344e8d3e1a0", "e9d10429-64c3-4276-bc83-7769b1ed0f44" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc75c970-6b8e-4711-b8c9-b12010f1bc3d", "ec1f1bfe-fe4f-4614-b362-aa41c750e561" });
        }
    }
}
