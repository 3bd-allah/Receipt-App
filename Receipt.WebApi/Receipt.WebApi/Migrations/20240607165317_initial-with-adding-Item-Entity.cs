using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Receipt.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class initialwithaddingItemEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: false),
                    InStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "InStock", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 100, "Apple", 1.00m },
                    { 2, 150, "Banana", 0.50m },
                    { 3, 200, "Orange", 0.75m },
                    { 4, 50, "Milk", 1.50m },
                    { 5, 80, "Bread", 2.00m },
                    { 6, 60, "Butter", 1.75m },
                    { 7, 40, "Cheese", 3.00m },
                    { 8, 30, "Chicken Breast", 5.00m },
                    { 9, 25, "Ground Beef", 4.00m },
                    { 10, 90, "Eggs", 2.50m },
                    { 11, 120, "Rice", 1.25m },
                    { 12, 100, "Pasta", 1.10m },
                    { 13, 200, "Tomato", 0.90m },
                    { 14, 75, "Lettuce", 1.20m },
                    { 15, 180, "Carrot", 0.80m },
                    { 16, 150, "Potato", 0.70m },
                    { 17, 160, "Onion", 0.60m },
                    { 18, 200, "Garlic", 0.40m },
                    { 19, 110, "Cucumber", 1.00m },
                    { 20, 90, "Bell Pepper", 1.50m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
