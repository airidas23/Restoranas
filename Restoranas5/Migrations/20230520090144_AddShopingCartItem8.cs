using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restoranas5.Migrations
{
    /// <inheritdoc />
    public partial class AddShopingCartItem8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InStock",
                table: "MenuItem",
                newName: "IsPreferred");

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "Description", "ImageThumbnailUrl", "ImageUrl", "IsPreferred", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Our famous apple pies!", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, "Apple Pie", 12.95m },
                    { 2, "You'll love it!", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", true, "Blueberry Cheese Cake", 18.95m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "IsPreferred",
                table: "MenuItem",
                newName: "InStock");
        }
    }
}
