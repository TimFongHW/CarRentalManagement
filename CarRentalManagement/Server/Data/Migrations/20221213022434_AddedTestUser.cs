using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddedTestUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "fb13de97-29bb-444f-ba68-337a2093e390");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "2e88e461-064b-4d20-bc99-6ea35c962017");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5841587-1635-419f-a245-5e703a2bc1f2", "AQAAAAEAACcQAAAAENlJLs/HjZgwFUXtU0sX4cOzQJvG0SHvCjwLkPJz4BwDObabkzb18RLA1b64MLLWVA==", "2d463d86-68b0-4761-ab60-90a89d4644b7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a5d4f34e-b52f-45cb-b981-6e383a381c11", 0, "0938d12a-b6ad-45a6-a684-bcce275a91b3", "test@localhost.com", false, "Test", "User", false, null, "TEST@LOCALHOST.COM", "TEST", "AQAAAAEAACcQAAAAEOqm9b5moQBtVjHXbU0Omn+NaBN5CqC8hVzShz62ZpMdPf8CNpG5o0FZfsIjgx/sLw==", null, false, "283ca38b-14cc-452c-9d6d-a947fb72206e", false, "Test" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 13, 10, 24, 34, 401, DateTimeKind.Local).AddTicks(8314), new DateTime(2022, 12, 13, 10, 24, 34, 403, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 13, 10, 24, 34, 403, DateTimeKind.Local).AddTicks(7457), new DateTime(2022, 12, 13, 10, 24, 34, 403, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 13, 10, 24, 34, 404, DateTimeKind.Local).AddTicks(8102), new DateTime(2022, 12, 13, 10, 24, 34, 404, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 13, 10, 24, 34, 404, DateTimeKind.Local).AddTicks(8112), new DateTime(2022, 12, 13, 10, 24, 34, 404, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 13, 10, 24, 34, 405, DateTimeKind.Local).AddTicks(2685), new DateTime(2022, 12, 13, 10, 24, 34, 405, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 13, 10, 24, 34, 405, DateTimeKind.Local).AddTicks(2695), new DateTime(2022, 12, 13, 10, 24, 34, 405, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 13, 10, 24, 34, 405, DateTimeKind.Local).AddTicks(2698), new DateTime(2022, 12, 13, 10, 24, 34, 405, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 13, 10, 24, 34, 405, DateTimeKind.Local).AddTicks(2700), new DateTime(2022, 12, 13, 10, 24, 34, 405, DateTimeKind.Local).AddTicks(2700) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5d4f34e-b52f-45cb-b981-6e383a381c11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "beb851dd-ebc6-4a5e-8cfc-e3d7f0f4e554");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "0d7f81a8-ee18-4bc6-8406-398484236719");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1db982bc-1df2-4e6d-a867-d62691cbdd5a", "AQAAAAEAACcQAAAAEKuZXZX2/SKHrtQzNftMeV3OidJaNJ+MIOHpc42JEPr7fXKMrDluBNBE4wxmYkzFmg==", "44b08bc8-8741-411f-a01a-c2a27104c882" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 12, 17, 20, 54, 148, DateTimeKind.Local).AddTicks(7567), new DateTime(2022, 12, 12, 17, 20, 54, 150, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 12, 17, 20, 54, 150, DateTimeKind.Local).AddTicks(3527), new DateTime(2022, 12, 12, 17, 20, 54, 150, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(4389), new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(4400), new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7683), new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7692), new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7694), new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7697), new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7698) });
        }
    }
}
