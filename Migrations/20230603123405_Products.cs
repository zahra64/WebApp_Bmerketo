using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => new { x.ProductId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ProductTags_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Voxicon GR900 har snabb responstid. Skärmen svarar direkt när du klickar på eller flyttar musen vilket ökar precisionen i ditt spelande", "https://www.dustinhome.se/product/5011133361/gaming-rgb-gr900", 200m, "Gaming RGB GR900 " });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName" },
                values: new object[,]
                {
                    { 1, "new" },
                    { 2, "featured" },
                    { 3, "popular" }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "ProductId", "TagId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTags",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "187664d6-1cbe-484d-a9e6-184a44c63323",
                column: "ConcurrencyStamp",
                value: "911e1e6a-7da4-40df-abf3-24511b4d41d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8489980-6fd1-40d9-b059-b8593debae14",
                column: "ConcurrencyStamp",
                value: "333803f6-7b11-4268-a7b7-880b40930be0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f900fcab-87e3-4d4f-a751-3e7bcc0f3755",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b95463c8-20c2-4cd3-a6b6-cf49ea1dd07c", "AQAAAAIAAYagAAAAEPle76w43lpfgV3LW2cEo9Dh/7bampyduqbRxVcJ4HV5UsqUIk24AF3namS89tcH+A==", "e473584b-bebb-44b8-9b57-64ce0b37b636" });
        }
    }
}
