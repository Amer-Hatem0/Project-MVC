using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dash.PL.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
