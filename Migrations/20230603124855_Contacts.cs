using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class Contacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactForms", x => x.Id);
                });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f63e61e-fe89-47dc-a259-e8777f44eb66", "AQAAAAIAAYagAAAAECBvQBZWF63ZNs9glMMjVGp/yvaZQ/94NjwmBymvBzVub1sqjXneBvhxmm62ecVLVQ==", "536cf23e-13f5-4919-b5ad-69e8f4b531ae" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactForms");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "187664d6-1cbe-484d-a9e6-184a44c63323",
                column: "ConcurrencyStamp",
                value: "f9afdbc8-39a4-4e99-90c1-877f43e433aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8489980-6fd1-40d9-b059-b8593debae14",
                column: "ConcurrencyStamp",
                value: "e6e33ed9-a0f6-43bc-823b-e63394a6d14a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f900fcab-87e3-4d4f-a751-3e7bcc0f3755",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30633586-990c-48c5-afad-d24e2cfa9f61", "AQAAAAIAAYagAAAAEIcvecj/iO8YL8gMXxE8oV4OLvLOUUtG4UilGijd9yUq6+I2QwvureC+aE58+9N7gQ==", "6c1d9990-8f41-472e-b9b2-15696366e439" });
        }
    }
}
