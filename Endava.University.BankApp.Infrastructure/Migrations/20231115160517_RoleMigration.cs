using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Endava.University.BankApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RoleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2e59c92b-6386-4d94-bd94-f07cd60783e2"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a326c7de-c6d7-4098-aac1-a41a34359d32"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("91bffcd6-778b-484d-9b4d-555b87aeec78"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("291b696a-4f65-42bc-91b8-44c3bf166b29"), null, "Admin", "Admin" },
                    { new Guid("311d2bfd-a79a-4bf8-b6e9-f0d113b5f86c"), null, "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CanBeRemoved", "ChangeRate", "CurrencyCode", "Name" },
                values: new object[] { new Guid("05e9b35c-892a-459e-9fcb-6c9bf1e336f3"), false, 1m, "MDL", "Leu Moldovenesc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("291b696a-4f65-42bc-91b8-44c3bf166b29"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("311d2bfd-a79a-4bf8-b6e9-f0d113b5f86c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("05e9b35c-892a-459e-9fcb-6c9bf1e336f3"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2e59c92b-6386-4d94-bd94-f07cd60783e2"), null, "Admin", null },
                    { new Guid("a326c7de-c6d7-4098-aac1-a41a34359d32"), null, "User", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CanBeRemoved", "ChangeRate", "CurrencyCode", "Name" },
                values: new object[] { new Guid("91bffcd6-778b-484d-9b4d-555b87aeec78"), false, 1m, "MDL", "Leu Moldovenesc" });
        }
    }
}
