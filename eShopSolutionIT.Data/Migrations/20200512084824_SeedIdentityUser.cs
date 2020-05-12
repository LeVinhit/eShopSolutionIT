using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolutionIT.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Decription",
                table: "AppRoles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 12, 15, 48, 23, 217, DateTimeKind.Local).AddTicks(2106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 12, 15, 38, 32, 240, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AppRoles",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "203d8c15-f6f2-49ce-bab1-6abcb8303013", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "8f8df454-992d-4014-b00c-50e368ac965d", new DateTime(1996, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "levinhit.tdm@gmail.com", true, "Le", "Vinh", false, null, "levinhit.tdm@gmail.com", "admin", "AQAAAAEAACcQAAAAEBp3aTEyHWEUA6L2jRBoC0K7za/0OgDId/rXHeaGenyDCiPm4uXsswdKqQv5ST4rNg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 5, 12, 15, 48, 23, 262, DateTimeKind.Local).AddTicks(4578));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AppRoles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 12, 15, 38, 32, 240, DateTimeKind.Local).AddTicks(8781),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 12, 15, 48, 23, 217, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.AddColumn<string>(
                name: "Decription",
                table: "AppRoles",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 5, 12, 15, 38, 32, 283, DateTimeKind.Local).AddTicks(4519));
        }
    }
}
