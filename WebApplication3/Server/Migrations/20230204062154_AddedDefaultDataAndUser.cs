using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Server.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LasttName",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "14ee06ad-0cab-49a2-9fec-c19f2c5e4d17", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "1235fbc7-1ef4-46ec-af43-f39562c5168c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "11f6c321-2df5-4130-97cc-3318c66236f4", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEMXWI5nbCvOD/qph2EwTpqndKG8FH8H8OWEZnhGaDf6NbOKwpdwuGX8dEyx5KS4Yaw==", null, false, "50f0e8f0-af68-461c-aeb5-f7018e438eda", false, "Admin" });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Price", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 2, 4, 14, 21, 52, 779, DateTimeKind.Local).AddTicks(7708), new DateTime(2023, 2, 4, 14, 21, 52, 781, DateTimeKind.Local).AddTicks(9649), "ChickenRice", 5f, "System" },
                    { 2, "System", new DateTime(2023, 2, 4, 14, 21, 52, 782, DateTimeKind.Local).AddTicks(1238), new DateTime(2023, 2, 4, 14, 21, 52, 782, DateTimeKind.Local).AddTicks(1246), "Laksa", 8f, "System" }
                });

            migrationBuilder.InsertData(
                table: "Riders",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeliveryFee", "Name", "UpdatedBy", "Vehicle" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 2, 4, 14, 21, 52, 785, DateTimeKind.Local).AddTicks(3331), new DateTime(2023, 2, 4, 14, 21, 52, 785, DateTimeKind.Local).AddTicks(3374), 3f, "Jack", "System", "Bicycle" },
                    { 2, "System", new DateTime(2023, 2, 4, 14, 21, 52, 785, DateTimeKind.Local).AddTicks(3384), new DateTime(2023, 2, 4, 14, 21, 52, 785, DateTimeKind.Local).AddTicks(3387), 4f, "John", "System", "Car" }
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
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "LasttName");
        }
    }
}
