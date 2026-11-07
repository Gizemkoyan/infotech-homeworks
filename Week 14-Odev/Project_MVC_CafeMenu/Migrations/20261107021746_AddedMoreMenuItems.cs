using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_MVC_CafeMenu.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreMenuItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Description", "ImageUrl", "IsAvailable", "MenuCategoryId", "Name", "PreparationTimeMinutes", "Price" },
                values: new object[,]
                {
                    { 16, "Bal ve mevsim meyveleriyle servis edilen pankek.", "https://placehold.co/600x400/FFE4B5/000000?text=Pankek", true, 1, "Pankek", 15, 220m },
                    { 17, "Çıtır tavuk, patates püresi ve salata.", "https://placehold.co/600x400/DEB887/000000?text=Schnitzel", true, 2, "Tavuk Schnitzel", 25, 360m },
                    { 18, "Kahve aromalı, mascarpone kremalı İtalyan tatlısı.", "https://placehold.co/600x400/D2B48C/000000?text=Tiramisu", true, 3, "Tiramisu", 5, 230m },
                    { 19, "Buzla servis edilen soğuk espresso kahvesi.", "https://placehold.co/600x400/6F4E37/FFFFFF?text=Iced+Americano", true, 4, "Iced Americano", 5, 145m },
                    { 20, "Çıtır kaplamalı mozzarella peynir çubukları.", "https://placehold.co/600x400/FFD700/000000?text=Mozzarella+Sticks", false, 5, "Mozzarella Sticks", 12, 195m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
