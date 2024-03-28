using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("81abbca8-664d-4b20-b5de-024705497d4a"),
                column: "PublicationDate",
                value: new DateTime(2024, 3, 28, 23, 48, 12, 274, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("83abbca8-664d-4b20-b5de-024705497d4a"),
                column: "PublicationDate",
                value: new DateTime(2024, 3, 28, 23, 48, 12, 274, DateTimeKind.Local).AddTicks(404));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("81abbca8-664d-4b20-b5de-024705497d4a"),
                column: "PublicationDate",
                value: new DateTime(2024, 3, 28, 23, 40, 47, 652, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("83abbca8-664d-4b20-b5de-024705497d4a"),
                column: "PublicationDate",
                value: new DateTime(2024, 3, 28, 23, 40, 47, 652, DateTimeKind.Local).AddTicks(325));
        }
    }
}
