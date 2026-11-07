using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_MVC_PlantShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedMorePlants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "plants",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "PlantCategoryId", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 16, "Etli yapraklı, bakımı kolay bir sukulent.", "https://placehold.co/600x400/4CAF50/white?text=Crassula+Ovata", "Crassula Ovata", 1, 140.00m, 22 },
                    { 17, "Az bakım isteyen dayanıklı bir iç mekân bitkisi.", "https://placehold.co/600x400/2E7D32/white?text=Pasa+Kilici", "Paşa Kılıcı", 2, 275.00m, 16 },
                    { 18, "Renkli çiçekleriyle balkon ve bahçeler için uygundur.", "https://placehold.co/600x400/E57373/white?text=Begonya", "Begonya", 3, 160.00m, 19 },
                    { 19, "Dekoratif görünüm sağlayan hafif saksı.", "https://placehold.co/600x400/A1887F/white?text=Hasir+Saksi", "Hasır Saksı", 4, 190.00m, 25 },
                    { 20, "Saksı ve bahçe ekimine uygun tohum.", "https://placehold.co/600x400/558B2F/white?text=Maydanoz+Tohumu", "Maydanoz Tohumu", 5, 25.00m, 70 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "plants",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "plants",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "plants",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "plants",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "plants",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
