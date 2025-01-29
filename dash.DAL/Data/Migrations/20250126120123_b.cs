using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dash.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Links",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "347187ff-7990-4f9b-a30e-19f9e9e1b900", null, "User", "USER" },
                    { "925d8993-5769-456c-b2a7-5ccf1ee688d4", null, "SuperAdmin", "SUPERADMIN" },
                    { "b23ac8c0-b574-4a74-b80b-34fb0ff7be62", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "24f45960-effd-4dee-a35c-1cd11eb066d7", 0, null, "bcf9140d-dc95-47cc-ac2e-6acc2dd8dde7", "user@cmp.com", true, null, false, null, "USER@CMP.COM", "USER@CMP.COM", "AQAAAAIAAYagAAAAEBMlKb2MBlNXeFMPwG461ggYFxk5Nstwk6Q9cYMM5l4Opuf4Ogr4uILLKB9oS0ChaA==", null, false, "8da0c43a-f7c2-42fa-ad4c-2c00637b6453", false, "user@cmp.com" },
                    { "40c8e847-f7b7-459e-8300-0966fdf64a08", 0, null, "019580c6-53d2-4237-8f73-6e59e0d08fc1", "adminUser@comp.com", true, null, false, null, "ADMINUSER@COMP.COM", "ADMINUSER@COMP.COM", null, null, false, "b681938c-7ca9-4bda-85fe-c7b509343f8c", false, "adminUser@comp.com" },
                    { "f8b673ca-9197-46ca-808e-54e7de59e044", 0, null, "3570ba18-8ab3-4691-8e75-c73bb02f1ca5", "superAdmin@cmp.com", true, null, false, null, "SUPERADMIN@CMP.COM", "SUPERADMIN@CMP.COM", null, null, false, "a4aaae5a-b39b-42bc-b986-04bcbe8062a9", false, "superAdmin@cmp.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "347187ff-7990-4f9b-a30e-19f9e9e1b900", "24f45960-effd-4dee-a35c-1cd11eb066d7" },
                    { "b23ac8c0-b574-4a74-b80b-34fb0ff7be62", "40c8e847-f7b7-459e-8300-0966fdf64a08" },
                    { "925d8993-5769-456c-b2a7-5ccf1ee688d4", "f8b673ca-9197-46ca-808e-54e7de59e044" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "347187ff-7990-4f9b-a30e-19f9e9e1b900", "24f45960-effd-4dee-a35c-1cd11eb066d7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b23ac8c0-b574-4a74-b80b-34fb0ff7be62", "40c8e847-f7b7-459e-8300-0966fdf64a08" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "925d8993-5769-456c-b2a7-5ccf1ee688d4", "f8b673ca-9197-46ca-808e-54e7de59e044" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "347187ff-7990-4f9b-a30e-19f9e9e1b900");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "925d8993-5769-456c-b2a7-5ccf1ee688d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b23ac8c0-b574-4a74-b80b-34fb0ff7be62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24f45960-effd-4dee-a35c-1cd11eb066d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40c8e847-f7b7-459e-8300-0966fdf64a08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b673ca-9197-46ca-808e-54e7de59e044");

            migrationBuilder.AlterColumn<int>(
                name: "Mobile",
                table: "Links",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
