using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restoranas5.Migrations
{
    /// <inheritdoc />
    public partial class AddShopingCartItem5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPreferred",
                table: "MenuItem",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPreferred",
                table: "MenuItem");
        }
    }
}
