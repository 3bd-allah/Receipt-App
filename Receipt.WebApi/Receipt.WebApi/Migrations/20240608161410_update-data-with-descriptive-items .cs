using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Receipt.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updatedatawithdescriptiveitems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 50, "Phone", 699.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 30, "Laptop", 999.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 40, "Tablet", 399.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 20, "Camera", 299.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 70, "Headset", 59.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 100, "Mouse", 29.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 80, "Keyboard", 49.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 25, "Monitor", 199.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 15, "Printer", 89.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 50, "Router", 79.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 60, "Speaker", 45.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 150, "Charger", 19.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 10, "Drone", 499.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 20, "VR Headset", 299.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 120, "SSD", 89.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 90, "HDD", 49.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 130, "RAM", 79.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Price" },
                values: new object[] { "USB Drive", 15.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 40, "Smartwatch", 199.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 60, "Fitness Tracker", 99.99m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 100, "Apple", 1.00m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 150, "Banana", 0.50m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 200, "Orange", 0.75m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 50, "Milk", 1.50m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 80, "Bread", 2.00m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 60, "Butter", 1.75m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 40, "Cheese", 3.00m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 30, "Chicken Breast", 5.00m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 25, "Ground Beef", 4.00m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 90, "Eggs", 2.50m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 120, "Rice", 1.25m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 100, "Pasta", 1.10m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 200, "Tomato", 0.90m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 75, "Lettuce", 1.20m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 180, "Carrot", 0.80m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 150, "Potato", 0.70m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 160, "Onion", 0.60m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Garlic", 0.40m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 110, "Cucumber", 1.00m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 90, "Bell Pepper", 1.50m });
        }
    }
}
