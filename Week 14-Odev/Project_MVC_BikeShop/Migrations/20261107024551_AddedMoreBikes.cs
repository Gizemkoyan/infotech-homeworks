using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_MVC_BikeShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreBikes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bikes",
                columns: new[] { "Id", "BikeCategoryId", "Description", "FrameSize", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 16, 1, "Konforlu şehir içi sürüşler için ideal bisiklet.", "M", "https://placehold.co/600x400/5F9EA0/FFFFFF?text=Bianchi+Spillo", "Bianchi Spillo", 24500m, 6 },
                    { 17, 2, "Dağ yolları ve zorlu parkurlar için güçlü model.", "L", "https://placehold.co/600x400/2E8B57/FFFFFF?text=Carraro+Big+929", "Carraro Big 929", 34500m, 4 },
                    { 18, 3, "Uzun mesafelerde hızlı ve dengeli yol bisikleti.", "M", "https://placehold.co/600x400/CD5C5C/FFFFFF?text=Giant+Contend", "Giant Contend 3", 46500m, 5 },
                    { 19, 4, "Çocuklar için eğlenceli ve güvenli bisiklet.", "S", "https://placehold.co/600x400/FFB6C1/FFFFFF?text=Bisan+Happy", "Bisan Happy 20", 7800m, 11 },
                    { 20, 5, "Güçlü motor desteğine sahip elektrikli bisiklet.", "L", "https://placehold.co/600x400/6495ED/FFFFFF?text=RKS+MX25", "RKS MX25", 59500m, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bikes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Bikes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Bikes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Bikes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Bikes",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
