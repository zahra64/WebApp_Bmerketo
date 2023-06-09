using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class Fixsomething : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "187664d6-1cbe-484d-a9e6-184a44c63323",
                column: "ConcurrencyStamp",
                value: "7b7f0716-fff1-41a9-9528-9131ccbdfa45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8489980-6fd1-40d9-b059-b8593debae14",
                column: "ConcurrencyStamp",
                value: "5c69ca95-9515-4bea-a85e-6e41b58c8d2a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f900fcab-87e3-4d4f-a751-3e7bcc0f3755",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb2c213e-3daa-430c-942f-9d4d68d942dc", "AQAAAAIAAYagAAAAEA2gH5Dz3EWqkgwMrfKzfKv1x25UPbCOXuwrnjQaJqDyZZVcvjFHU2xmZ1g+/YCcdw==", "4c26d8e6-c253-4945-983b-693b43d23234" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "187664d6-1cbe-484d-a9e6-184a44c63323",
                column: "ConcurrencyStamp",
                value: "282ba529-015e-4898-b154-8046afd3e4d6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8489980-6fd1-40d9-b059-b8593debae14",
                column: "ConcurrencyStamp",
                value: "e77d76bb-c969-4acf-9a93-433b8acb97c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f900fcab-87e3-4d4f-a751-3e7bcc0f3755",
                columns: new[] { "AddressId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "8f63e61e-fe89-47dc-a259-e8777f44eb66", "AQAAAAIAAYagAAAAECBvQBZWF63ZNs9glMMjVGp/yvaZQ/94NjwmBymvBzVub1sqjXneBvhxmm62ecVLVQ==", "536cf23e-13f5-4919-b5ad-69e8f4b531ae" });
        }
    }
}
