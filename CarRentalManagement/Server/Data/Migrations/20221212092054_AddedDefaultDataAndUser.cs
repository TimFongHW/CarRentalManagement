using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "beb851dd-ebc6-4a5e-8cfc-e3d7f0f4e554", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "0d7f81a8-ee18-4bc6-8406-398484236719", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "1db982bc-1df2-4e6d-a867-d62691cbdd5a", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEKuZXZX2/SKHrtQzNftMeV3OidJaNJ+MIOHpc42JEPr7fXKMrDluBNBE4wxmYkzFmg==", null, false, "44b08bc8-8741-411f-a01a-c2a27104c882", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 12, 17, 20, 54, 148, DateTimeKind.Local).AddTicks(7567), new DateTime(2022, 12, 12, 17, 20, 54, 150, DateTimeKind.Local).AddTicks(2666), "Black", "System" },
                    { 2, "System", new DateTime(2022, 12, 12, 17, 20, 54, 150, DateTimeKind.Local).AddTicks(3527), new DateTime(2022, 12, 12, 17, 20, 54, 150, DateTimeKind.Local).AddTicks(3532), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(4389), new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(4397), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(4400), new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(4401), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7683), new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7689), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7692), new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7693), "X5", "System" },
                    { 3, "System", new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7694), new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7695), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7697), new DateTime(2022, 12, 12, 17, 20, 54, 151, DateTimeKind.Local).AddTicks(7698), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
