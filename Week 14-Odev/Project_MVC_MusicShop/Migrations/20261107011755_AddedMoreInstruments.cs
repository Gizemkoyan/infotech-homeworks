using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_MVC_MusicShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreInstruments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "Id", "Brand", "Description", "ImageUrl", "InstrumentCategoryId", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 16, "Yamaha", "Başlangıç ve orta seviye elektro gitar", "https://placehold.co/600x400/2563eb/ffffff?text=Pacific+112V", 1, "Pacific 112V", 17500m, 7 },
                    { 17, "Roland", "Taşınabilir ve çok sesli dijital klavye", "https://placehold.co/600x400/7c3aed/ffffff?text=Roland+GO+KEYS", 2, "GO:KEYS 3", 24000m, 6 },
                    { 18, "Alesis", "Başlangıç ve orta seviye elektronik davul seti", "https://placehold.co/600x400/dc2626/ffffff?text=Alesis+Nitro", 3, "Nitro Max Kit", 29500m, 4 },
                    { 19, "Stentor", "Yeni başlayanlar için tam boy keman", "https://placehold.co/600x400/9333ea/ffffff?text=Stentor+Violin", 4, "Student II Violin", 13500m, 9 },
                    { 20, "Yamaha", "Öğrenciler için Si bemol trompet", "https://placehold.co/600x400/059669/ffffff?text=Yamaha+Trumpet", 5, "YTR-2330", 38500m, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
