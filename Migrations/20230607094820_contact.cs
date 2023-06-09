using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class contact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "ContactForms");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "ContactForms");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "187664d6-1cbe-484d-a9e6-184a44c63323",
                column: "ConcurrencyStamp",
                value: "970c4baa-01b4-49fa-a537-9913dd7c9e7e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8489980-6fd1-40d9-b059-b8593debae14",
                column: "ConcurrencyStamp",
                value: "32005164-229a-4a6d-8cef-33d107979566");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f900fcab-87e3-4d4f-a751-3e7bcc0f3755",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ec2ac75-f2ef-43db-a4a3-08ea11b79b88", "AQAAAAIAAYagAAAAEMgW1qlAOc0lV2yGl/1M1rrcyTjk51eNr2rMD5sj36BVcbF4XmITVZ4Zga90y0esFg==", "81d75f49-a7ee-4343-82f5-88fecc770155" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "ContactForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "ContactForms",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
