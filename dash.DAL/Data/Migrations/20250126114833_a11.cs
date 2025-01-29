using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dash.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class a11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "38564c9a-1ea7-4716-aa83-213e8a33e38e", null, "User", "USER" },
                    { "864eec2e-445a-4005-a8f1-3c0d261ba552", null, "SuperAdmin", "SUPERADMIN" },
                    { "88c5f375-fb76-405c-9732-26dda170531d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2ee1fa19-1e3a-4a10-97b9-66aea9a8f253", 0, null, "c9d9ab21-9657-4d1f-8361-f8c093f1a1e1", "superAdmin@cmp.com", true, null, false, null, "SUPERADMIN@CMP.COM", "SUPERADMIN@CMP.COM", null, null, false, "e0f3c63a-10bc-4946-bf5b-3fa573da8c86", false, "superAdmin@cmp.com" },
                    { "96bb1dfa-e501-49af-90c0-abbfffa3817c", 0, null, "b32be2f3-48b7-4202-82b2-92ca3b3cd57d", "adminUser@cmp.com", true, null, false, null, "ADMINUSER@CMP.COM", "ADMINUSER@CMP.COM", null, null, false, "d2b12d36-f5b9-4bff-902d-0f521af865b7", false, "adminUser@cmp.com" },
                    { "d7951be9-26b7-4446-8de6-938ce1a05759", 0, null, "8338d895-dc5a-43aa-81b0-992d89ec53dd", "user@cmp.com", true, null, false, null, "USER@CMP.COM", "USER@CMP.COM", "AQAAAAIAAYagAAAAEIt0SkhfLVcr1Qhzx/UVO9dV7Nildgki/xxw2Ff3phhE76J9oFZWnHvJLEgsYfDiVA==", null, false, "60e5bdb5-2920-48d3-b7df-90bd6107a627", false, "user@cmp.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "864eec2e-445a-4005-a8f1-3c0d261ba552", "2ee1fa19-1e3a-4a10-97b9-66aea9a8f253" },
                    { "88c5f375-fb76-405c-9732-26dda170531d", "96bb1dfa-e501-49af-90c0-abbfffa3817c" },
                    { "38564c9a-1ea7-4716-aa83-213e8a33e38e", "d7951be9-26b7-4446-8de6-938ce1a05759" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "864eec2e-445a-4005-a8f1-3c0d261ba552", "2ee1fa19-1e3a-4a10-97b9-66aea9a8f253" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88c5f375-fb76-405c-9732-26dda170531d", "96bb1dfa-e501-49af-90c0-abbfffa3817c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38564c9a-1ea7-4716-aa83-213e8a33e38e", "d7951be9-26b7-4446-8de6-938ce1a05759" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38564c9a-1ea7-4716-aa83-213e8a33e38e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "864eec2e-445a-4005-a8f1-3c0d261ba552");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88c5f375-fb76-405c-9732-26dda170531d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ee1fa19-1e3a-4a10-97b9-66aea9a8f253");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96bb1dfa-e501-49af-90c0-abbfffa3817c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7951be9-26b7-4446-8de6-938ce1a05759");

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
    }
}
