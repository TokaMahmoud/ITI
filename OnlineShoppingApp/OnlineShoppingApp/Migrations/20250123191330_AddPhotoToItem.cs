using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShoppingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddPhotoToItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Items",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Items");
        }
    }
}
