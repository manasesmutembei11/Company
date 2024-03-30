using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ArticleImageUrl",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("81abbca8-664d-4b20-b5de-024705497d4a"),
                column: "PublicationDate",
                value: new DateTime(2024, 3, 30, 20, 53, 45, 519, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("83abbca8-664d-4b20-b5de-024705497d4a"),
                column: "PublicationDate",
                value: new DateTime(2024, 3, 30, 20, 53, 45, 519, DateTimeKind.Local).AddTicks(6950));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ArticleImageUrl",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
