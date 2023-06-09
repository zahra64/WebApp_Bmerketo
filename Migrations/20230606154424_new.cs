using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "187664d6-1cbe-484d-a9e6-184a44c63323",
                column: "ConcurrencyStamp",
                value: "3bfbca49-f772-48a0-b42c-5bfadd58b545");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8489980-6fd1-40d9-b059-b8593debae14",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "16dd31a1-3c4b-45eb-a3e5-d2129eccfca2", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f900fcab-87e3-4d4f-a751-3e7bcc0f3755",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1398bfb-0265-4acf-bfa0-0a2651458f5c", "AQAAAAIAAYagAAAAEAbnO/cTQ1nuZfi/Qw3ItrXOVXm+OFhTbqBLbK/vTi7hmXvYssZIeSkgf6vrJy03TQ==", "49c4368f-4e3a-4c3b-a76a-3ce8be0c7fa4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "5c69ca95-9515-4bea-a85e-6e41b58c8d2a", "admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f900fcab-87e3-4d4f-a751-3e7bcc0f3755",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb2c213e-3daa-430c-942f-9d4d68d942dc", "AQAAAAIAAYagAAAAEA2gH5Dz3EWqkgwMrfKzfKv1x25UPbCOXuwrnjQaJqDyZZVcvjFHU2xmZ1g+/YCcdw==", "4c26d8e6-c253-4945-983b-693b43d23234" });
        }
    }
}
