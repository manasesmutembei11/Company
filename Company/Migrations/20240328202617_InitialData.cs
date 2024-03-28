using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Company.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleImageUrl", "AuthorId", "CategoryId", "Content", "PublicationDate", "Title" },
                values: new object[,]
                {
                    { new Guid("81abbca8-664d-4b20-b5de-024705497d4a"), "583 Wall Dr. Gwynn Oak, MD 21207", new Guid("82abbca8-664d-4b20-b5de-024705497d4a"), null, "", new DateTime(2024, 3, 28, 23, 26, 17, 154, DateTimeKind.Local).AddTicks(8833), "Recipe 1" },
                    { new Guid("83abbca8-664d-4b20-b5de-024705497d4a"), "583 Wall Dr. Gwynn Oak, MD 21207", new Guid("84abbca8-664d-4b20-b5de-024705497d4a"), null, "", new DateTime(2024, 3, 28, 23, 26, 17, 154, DateTimeKind.Local).AddTicks(8848), "Recipe 2" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Name", "Price", "ProductCategoryId", "ProductImageUrl", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("90abbca8-664d-4b20-b5de-024705497d4a"), null, "Re", "583 Wall Dr. Gwynn Oak, MD 21207", 100m, null, "IMAGE URL", 50 },
                    { new Guid("91abbca8-664d-4b20-b5de-024705497d4a"), null, "Product 2 description", "583 Wall Dr. Gwynn Oak, MD 21207", 1000m, null, "IMAGE URL", 50 },
                    { new Guid("92abbca8-664d-4b20-b5de-024705497d4a"), null, "product 3 description", "product 3", 100m, null, "IMAGE URL", 500 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("81abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("83abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("90abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("91abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("92abbca8-664d-4b20-b5de-024705497d4a"));
        }
    }
}
