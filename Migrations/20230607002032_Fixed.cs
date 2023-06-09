using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class Fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "ContactForms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "187664d6-1cbe-484d-a9e6-184a44c63323",
                column: "ConcurrencyStamp",
                value: "c26a66ba-fce8-4610-af0d-6eeab1ba1fbd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8489980-6fd1-40d9-b059-b8593debae14",
                column: "ConcurrencyStamp",
                value: "9cdd64a2-ada6-4902-b821-f22180ce9089");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f900fcab-87e3-4d4f-a751-3e7bcc0f3755",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2a53cc8-ac53-436c-a3a9-5ebb966bf95d", "AQAAAAIAAYagAAAAELcLikW3lHGFWquPZqpo1dDAfWWWaXJsAYzo4FnMW8jVvessw9HBB2kwrAT+nTYj3A==", "f0dbd81d-6717-4b37-8646-3725151eeff9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "ContactForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                column: "ConcurrencyStamp",
                value: "16dd31a1-3c4b-45eb-a3e5-d2129eccfca2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f900fcab-87e3-4d4f-a751-3e7bcc0f3755",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1398bfb-0265-4acf-bfa0-0a2651458f5c", "AQAAAAIAAYagAAAAEAbnO/cTQ1nuZfi/Qw3ItrXOVXm+OFhTbqBLbK/vTi7hmXvYssZIeSkgf6vrJy03TQ==", "49c4368f-4e3a-4c3b-a76a-3ce8be0c7fa4" });
        }
    }
}
